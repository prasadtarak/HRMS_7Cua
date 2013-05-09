using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

/// <summary>
/// Possible locations to save user settings.
/// </summary>
namespace EVSoft.HRMS.Common
{
	public enum UserStorageOption
	{
		/// <summary>
		/// Settings will be stored in isolated storage.
		/// </summary>
		IsolatedStorage,
		/// <summary>
		/// Settings will be stored in the registry.
		/// </summary>
		Registry,
		/// <summary>
		/// Settings will be stored in text files in the
		/// application directory.
		/// </summary>
		File
	}

	/// <summary>
	/// Contains base functionality for user settings storage.
	/// </summary>
	/// <remarks>
	/// To store user settings, inherit from this class to create your own
	/// settings class. Within that class use standard XmlSerialization rules
	/// to declare your fields and properties.
	/// </remarks>
	public abstract class UserSettingsBase
	{
		private UserStorageOption mOption;
		private string mSection;

		/// <summary>
		/// Creates a UserSettings object that stores its settings
		/// in isolated storage in a section based on the class name.
		/// </summary>
		public UserSettingsBase()
		{
			mOption = UserStorageOption.IsolatedStorage;

			mSection = this.GetType().Name;
		}

		/// <summary>
		/// Creates a UserSettings object that stores its settings
		/// in the specified storage location in a section based
		/// on the class name.
		/// </summary>
		/// <param name="StorageOption">The storage location for the settings.</param>
		public UserSettingsBase(UserStorageOption StorageOption)
		{
			//mOption = UserStorageOption.IsolatedStorage;

			mOption = StorageOption;
			mSection = this.GetType().Name;

		}

		/// <summary>
		/// Creates a UserSettings object that stores its settings
		/// in the specified storage location in a section named
		/// per the parameter value.
		/// </summary>
		/// <param name="StorageOption">The storage location for the settings.</param>
		/// <param name="Section">The section name in which the settings should be stored.</param>
		public UserSettingsBase(UserStorageOption StorageOption, string Section)
		{
			//mOption = UserStorageOption.IsolatedStorage;

			mOption = StorageOption;
			mSection = Section;

		}

		/// <summary>
		/// The section name in which the settings are stored.
		/// </summary>
		/// <returns>The section name.</returns>
		public string Section
		{
			get { return mSection; }
		}

		/// <summary>
		/// The location where the settings are stored.
		/// </summary>
		/// <returns>The location where settings are stored.</returns>
		[XmlIgnore()]
		public UserStorageOption StorageOption
		{
			get { return mOption; }
			set { mOption = value; }
		}

		#region " Save "

		/// <summary>
		/// Saves the current settings based on the currently
		/// logged in user, the storage location and section name.
		/// </summary>
		public void Save()
		{
			switch (mOption)
			{
				case UserStorageOption.IsolatedStorage:

					SaveToIsolatedStorage();
					break;

				case UserStorageOption.Registry:

					SaveToRegistry();
					break;

				case UserStorageOption.File:

					SaveToFile();
					break;

			}

		}

		/// <summary>
		/// Stores the user settings to isolated storage.
		/// </summary>
		private void SaveToIsolatedStorage()
		{
			XmlSerializer formatter = new XmlSerializer(this.GetType());

			IsolatedStorageFileStream settingsFile = new IsolatedStorageFileStream(Section + ".xml", FileMode.Create, IsolatedStorageFile.GetUserStoreForDomain());

			try
			{
				formatter.Serialize(settingsFile, this);

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings could not be saved to isolated storage", ex));

			}
			finally
			{
				settingsFile.Close();
			}

		}

		/// <summary>
		/// Stores the user settings to the Windows registry.
		/// </summary>
		private void SaveToRegistry()
		{
			MemoryStream buffer = new MemoryStream();

			XmlSerializer formatter = new XmlSerializer(this.GetType());

			formatter.Serialize(buffer, this);

			string output;
			output = Encoding.ASCII.GetString(buffer.ToArray());

			//Interaction.SaveSetting(GetAppName(), Section, "Settings", output);

		}

		/// <summary>
		/// Stores the user settings to an XML file.
		/// </summary>
		private void SaveToFile()
		{
			string path = GetFilePath(Section);

			FileStream outFile = null;
			if (!File.Exists(path)) 
			{
				outFile = File.Create(path);
			}
			else
			{
				outFile = File.OpenWrite(path);
			}

			try
			{
				XmlSerializer formatter = new XmlSerializer(this.GetType());
				formatter.Serialize(outFile, this);

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings could not be written to file " + path, ex));

			}
			finally
			{
				outFile.Close();
			}
		}

		#endregion

		#region " Restore "

		/// <summary>
		/// Creates a new settings object with settings data based
		/// on the currently logged in user, the storage
		/// location and section name.
		/// </summary>
		/// <returns>The newly populated settings object.</returns>
		public UserSettingsBase Restore()
		{
			return Restore(this.GetType(), mSection, mOption);

		}

		/// <summary>
		/// Creates a new settings object of the specified type
		/// based on the currently logged in user, the specified
		/// section name and specified storage location.
		/// </summary>
		/// <param name="Type">The type of the settings object to return.</param>
		/// <param name="Section">The section name containing the settings.</param>
		/// <param name="StorageOption">The storage location of the settings.</param>
		/// <returns>The newly populated settings object.</returns>
		public static UserSettingsBase Restore(Type Type, string Section, UserStorageOption StorageOption)
		{
			switch (StorageOption)
			{
				case UserStorageOption.IsolatedStorage:

					return RestoreFromIsolatedStorage(Type, Section);

				case UserStorageOption.Registry:

					return RestoreFromRegistry(Type, Section);

				case UserStorageOption.File:

					return RestoreFromFile(Type, Section);

			}

			return null;
		}

		/// <summary>
		/// Restore the user settings from isolated storage.
		/// </summary>
		/// <param name="Type">The type of the settings object.</param>
		/// <param name="Section">The section in which the settings are stored.</param>
		/// <returns>A populated settings object.</returns>
		private static UserSettingsBase RestoreFromIsolatedStorage(Type Type, string Section)
		{
			XmlSerializer formatter = new XmlSerializer(Type);
			IsolatedStorageFileStream settingsFile;

			try
			{
				settingsFile = new IsolatedStorageFileStream(Section + ".Config", FileMode.Open, IsolatedStorageFile.GetUserStoreForDomain());

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings not found in isolated storage", ex));

			}

			try
			{
				byte[] buffer = new byte[Convert.ToInt32(settingsFile.Length) - 1 + 1];

				settingsFile.Read(buffer, 0, Convert.ToInt32(settingsFile.Length));

				MemoryStream stream = new MemoryStream(buffer);

				return ((UserSettingsBase) formatter.Deserialize(stream));

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings could not be loaded from isolated storage", ex));
			}
			finally
			{
				settingsFile.Close();
			}

		}

		/// <summary>
		/// Restore the user settings from the Windows registry.
		/// </summary>
		/// <param name="Type">The type of the settings object.</param>
		/// <param name="Section">The section in which the settings are stored.</param>
		/// <returns>A populated settings object.</returns>
		private static UserSettingsBase RestoreFromRegistry(Type Type, string Section)
		{
			string text;

			try
			{
				//text = Interaction.GetSetting(GetAppName(), Section, "Settings", "");
				text = "";
			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings not found in registry", ex));
			}

			try
			{
				MemoryStream buffer = new MemoryStream(Encoding.ASCII.GetBytes(text));

				XmlSerializer formatter = new XmlSerializer(Type);

				UserSettingsBase settings = ((UserSettingsBase) formatter.Deserialize(buffer));
				settings.mOption = UserStorageOption.Registry;

				return settings;

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings could not be loaded from registry", ex));
			}

		}

		/// <summary>
		/// Restore the user settings from an XML file.
		/// </summary>
		/// <param name="Type">The type of the settings object.</param>
		/// <param name="Section">The section in which the settings are stored.</param>
		/// <returns>A populated settings object.</returns>
		private static UserSettingsBase RestoreFromFile(Type Type, string Section)
		{
			string path = GetFilePath(Section);

			FileStream inFile;

			try
			{
				inFile = File.OpenRead(path);

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings file not found " + path, ex));
			}

			try
			{
				  XmlSerializer formatter = new XmlSerializer(Type);

				byte[] buffer = new byte[Convert.ToInt32(inFile.Length) + 1];

				inFile.Read(buffer, 0, Convert.ToInt32(inFile.Length));
				MemoryStream stream = new MemoryStream(buffer);

				stream.Position = 0;

				UserSettingsBase settings = ((UserSettingsBase) formatter.Deserialize(stream));
				settings.mOption = UserStorageOption.File;
				return settings;

			}
			catch (Exception ex)
			{
				throw (new UserSettingsException("User settings could not be read from file " + path, ex));

			}
			finally
			{
				inFile.Close();
			}

		}

		#endregion

		#region " Utility functions "

		/// <summary>
		/// Returns the name the the running application.
		/// </summary>
		/// <remarks>
		/// Since this relies on the AppDomain name having some
		/// reasonable meaning, this method may not work in some
		/// situations. Most notably, it will not work in ASP.NET
		/// where the AppDomain names are unpredicable and have
		/// little to no meaning. If you need to store and retrieve
		/// user setting values in ASP.NET you'll need to enhance
		/// the UserSettingsBase class to have some other way of
		/// identifying the name of your application.
		/// </remarks>
		/// <returns>The application name.</returns>
		private static string GetAppName()
		{
			string app = AppDomain.CurrentDomain.FriendlyName;

			// strip off the .exe if any
			if (app.Substring(app.Length - 4, 4) == ".exe")
			{
				app = app.Substring(0, app.Length - 4);
			}

			return app;

		}

		/// <summary>
		/// Returns the name of the current user.
		/// </summary>
		/// <remarks>
		/// <para>
		/// If there is no current user the .NET Framework supplies an
		/// empty GenericIdentity object, with an empty user name. If
		/// we get an empty user name we return 'default' instead.
		/// </para><para>
		/// If the user identity is a Windows identity the user name
		/// will include the domain name. Since we're using the user
		/// name to build a path, the '\' in the name will cause problems
		/// so we strip out the domain and '\' symbol.
		/// </para>
		/// </remarks>
		/// <returns>The name of the current user.</returns>
		private static string GetUser()
		{
			string user = Thread.CurrentPrincipal.Identity.Name;

			if (user.Length == 0)
			{
				// if there's no user, set it to default
				user = "default";

			}
			else
			{
				// if we got a full domain name, remove the domain
				int pos = user.IndexOf("\\", 0);
				if (pos > 0)
				{
					user = user.Substring(pos + 1 - 1);
				}
			}

			return user;

		}

		/// <summary>
		/// Returns a full file path to a user-settings file.
		/// </summary>
		/// <param name="Section">The section name for these settings.</param>
		/// <returns>A complete file path (path and name) for the settings file.</returns>
		private static string GetFilePath(string Section)
		{
			StringBuilder sb = new StringBuilder();

			//string path = ConfigurationSettings.AppSettings["SettingsPath"];
			string path = Application.StartupPath;
			if (path.Length > 0)
			{
				sb.Append(path);

				if (path.Substring(path.Length - 1, 1) != "\\")
				{
					sb.Append("\\");
				}
			}

			//sb.Append("Config.xml");
			sb.Append("hrms.Config");
//			sb.Append(GetAppName());
//			sb.Append(".");
//			sb.Append(Section);
//			sb.Append(".");
//			sb.Append(GetUser());
//			sb.Append(".xml");

			return sb.ToString();

		}

		#endregion
	}

	[Serializable()]
	public class UserSettingsException : Exception
	{
		/// <summary>
		/// Creates a new exception.
		/// </summary>
		public UserSettingsException(string message) : base(message)
		{
		}

		/// <summary>
		/// Creates a new exception with an inner exception.
		/// </summary>
		public UserSettingsException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		/// Required because System.Exception implements ISerializable.
		/// </summary>
		protected UserSettingsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

	}
}