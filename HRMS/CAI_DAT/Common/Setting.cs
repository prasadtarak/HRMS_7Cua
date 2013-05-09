/// <summary>
/// Stores settings for WorkingContext.
/// </summary>
namespace EVSoft.HRMS.Common
{
	public class Setting : UserSettingsBase
	{
		/// <summary>
		/// Thông tin kết nối cơ sở dữ liệu
		/// </summary>
		private string server;

		private string database;
		private string uid;
		private string pwd;

		/// <summary>
		/// Đường dẫn ảnh
		/// </summary>
		private string picturePath;

		#region " Constructors "

		/// <summary>
		/// Creates a new, empty settings object which will be
		/// stored in isolated storage.
		/// </summary>
		public Setting()
		{
		}

		/// <summary>
		/// Creates a new, empty settings object.
		/// </summary>
		/// <param name="StorageOption">The location to store the settings.</param>
		public Setting(UserStorageOption StorageOption) : base(StorageOption)
		{
		}

		#endregion

		public string Server
		{
			get { return server; }
			set { server = value; }
		}

		public string Database
		{
			get { return database; }
			set { database = value; }
		}

		public string UserID
		{
			get { return uid; }
			set { uid = value; }
		}

		public string Password
		{
			get { return pwd; }
			set { pwd = value; }
		}

		public string PicturePath
		{
			get { return picturePath; }
			set { picturePath = value; }
		}
	}

}