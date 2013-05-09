using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Summary description for ModuleConfig.
	/// </summary>
	public class ModuleConfig
	{
		//No instance can be created for this Class, so make it private
		private ModuleConfig()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Get the Setting values from a config file
		/// </summary>
		/// <returns>Module Setting with all settings value</returns>
		public static ModuleSettings GetSettings()
		{
			XmlSerializer serializer=new XmlSerializer(typeof(ModuleSettings));
			ModuleSettings settings=null;
			string filePath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath , GetSettingsFile());
			
			try
			{
				FileStream fs=new FileStream(filePath,FileMode.Open,FileAccess.Read);	
				//Deserialize the data
				settings=(ModuleSettings)serializer.Deserialize(fs);
				fs.Close();				
			}
			catch(System.IO.FileNotFoundException ex)
			{
				//do something throw exception
				MessageBox.Show(ex.Message);
			}
			return settings;

		}

		public static void SaveSettings(ModuleSettings settings)
		{
			string fileName= System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath , GetSettingsFile());
			XmlSerializer seriallizer=new XmlSerializer(typeof(ModuleSettings));
			FileStream fs=new FileStream(fileName,FileMode.Create);
			seriallizer.Serialize(fs,settings);
			fs.Close();
		}
		private static string GetSettingsFile()
		{
			string filePath=System.Configuration.ConfigurationSettings.AppSettings["hrms_SettingFile"];
			return filePath;
		}		
	}
}
