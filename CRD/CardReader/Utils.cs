using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;

namespace CardReader
{
	/// <summary>
	/// Summary description for Utils.
	/// </summary>
	public class Utils
	{
		public Utils()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static myCompany.MyApp.Config.ModuleSettings settings;
		public static string connectionString;
	
		/// <summary>
		/// Lấy thông số hệ thống từ file cấu hình
		/// </summary>
		public static void LoadAppSettings()
		{
			// Access the application settings that were
			// loaded at start time.
			// Load ConnectionString from App Settings
			connectionString = "server=" + settings.Server;
			connectionString += ";database=" + settings.Database;
			connectionString += ";uid=" + settings.UserName;
			connectionString += ";pwd=" + settings.Password;
		}
		///  <summary>
		/// Gets a SqlConnection to the local sqlserver
		/// </summary>
		/// <returns>SqlConnection</returns>		
		public static SqlConnection getConnection()
		{
			LoadAppSettings();
			SqlConnection conn = new SqlConnection(connectionString);
			return conn;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string getSettings()
		{
			string cardType ="";
			settings = myCompany.MyApp.Config.ModuleConfig.GetSettings();
			switch (settings.CardType)
			{
                case "BarCode":
                    cardType = "BarCode";
                    break;
				case "PPSwipe":
					cardType = "PPSwipe";
					break;
				case "PP3750":
					cardType = "PP3750";
					break;
				case "PP6750":
					cardType = "PP6750";
                    break;
                case "X628C":
                    cardType = "X628C";
                    
					break;
			}
			return cardType;
		}
		/// <summary>
		/// initialize CardReader machine
		/// </summary>
		public static void initCardReader()
		{
//			System.Threading.Thread thisThread = System.Threading.Thread.CurrentThread;
//			CultureInfo originalCulture = thisThread.CurrentCulture;
//
//			thisThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//chuyển regional setting sang US do lỗi của Excel

			settings = myCompany.MyApp.Config.ModuleConfig.GetSettings();
			Process current =Process.GetCurrentProcess();
			Process[] processes = Process.GetProcessesByName(current.ProcessName);
			if (processes.Length>1)
				Application.Exit();
			else
			switch (settings.CardType)
			{
                case "BarCode":
                    Application.Run(new frmBarCodeReader());
                    break;
				
				case "PP3750":
					Application.Run(new frmPP3750());
					break;
				case "PP6750":
					Application.Run(new frmPP6750());
                    break;
                case "X628C":
                    Application.Run(new frmX628C());
                    break;
				
			}
			
//			thisThread.CurrentCulture = originalCulture;//chuyển lại regional mặc định của máy
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="strCardType"></param>
        public static void SaveSettings(String strCardType, String databaseName, String password, String username, String serverName, String picturePath, String barCodeType)
		{
			myCompany.MyApp.Config.ModuleSettings	newSettings=new myCompany.MyApp.Config.ModuleSettings();
			newSettings.CardType= strCardType;
            newSettings.BarCodeType = barCodeType;
			newSettings.Database=databaseName;
			newSettings.Password = password;
			newSettings.UserName = username;
			newSettings.Server = serverName;
			newSettings.PicturePath = picturePath;
			myCompany.MyApp.Config.ModuleConfig.SaveSettings(newSettings);
			
		}
	}
}
