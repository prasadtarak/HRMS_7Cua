using System;
using System.Xml;
using System.Xml.Serialization;

namespace myCompany.MyApp.Config
{
	/// <summary>
	/// Summary of ModuleSettings Class
	/// </summary>
	public class ModuleSettings
	{
		private string cardType;
        private string barCodeType;
		private string database;
		private string userName;
		private string password;
		private string server;
		private string active;
		private string picturePath;

		public ModuleSettings()
		{ }

		[XmlElement]
		public string CardType
		{
			get 
			{
				return cardType;
			}
			set 
			{				
				cardType = value;
			}
		}
        [XmlElement]
        public string BarCodeType
        {
            get
            {
                return barCodeType;
            }
            set
            {
                barCodeType = value;
            }
        }
		[XmlElement]
		public string Active
		{
			get 
			{
				return active;
			}
			set 
			{				
				active = value;
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
	
		//Other element goes here
	}
}
