using System;
using System.Xml;
using System.Xml.Serialization;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Summary of ModuleSettings Class
	/// </summary>
	public class ModuleSettings
	{
		private string connectionString;
		private string database;
		private string userName;
		private string password;
		private string server;
		private string picturePath;
        private string reportPath;
		private string language;

		public ModuleSettings()
		{ }

		[XmlElement]
		public string ConnectionStr
		{
			get 
			{
				return connectionString;
			}
			set 
			{
				connectionString = value;
			}
		}
		[XmlElement]
		public string Database
		{
			get 
			{
				return database;
			}
			set 
			{				
				database = value;
			}
		}
		[XmlElement]
		public string UserName
		{
			get 
			{
				return userName;
			}
			set 
			{				
				userName = value;
			}
		}
		[XmlElement]
		public string Password
		{
			get 
			{
				return password;
			}
			set 
			{				
				password = value;
			}
		}
		[XmlElement]
		public string Server
		{
			get 
			{
				return server;
			}
			set 
			{				
				server = value;
			}
		}
		[XmlElement]
		public string PicturePath
		{
			get 
			{
				return picturePath;
			}
			set 
			{				
				picturePath = value;
			}
		}
        [XmlElement]
        public string ReportPath
        {
            get
            {
                return reportPath;
            }
            set
            {
                reportPath = value;
            }
        }
		[XmlElement]
		public string Language
		{
			get 
			{
				return language;
			}
			set 
			{				
				language = value;
			}
		}
	
		//Other element goes here
	}
}
