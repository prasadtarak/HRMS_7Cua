using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
using System.Xml.Serialization;
using EVSoft.HRMSLisence;

namespace EVSoft.HRMS.Common
{
		/// <summary>
		/// Lớp này chịu trách nhiệm duy trì tất cả các context của người sử dụng.
		/// </summary>
		public class WorkingContext
		{
            /// <summary>
            /// Trạng thái đăng ký của chương trình
            /// </summary>
		    private static RegistionType m_RegistionType;
			/// <summary>
			/// Thuộc tính duy trì ngôn ngữ được thiết lập khi sử dụng ngôn ngữ
			/// </summary>
			private static string language = "";// = "ja-JP";
			private static LangManager langManager;
           
			/// <summary>
			/// Người dùng đang đăng nhập trong hệ thống
			/// </summary>
			private static string username;

			/// <summary>
			/// Các thiết lập của hệ thống
			/// </summary>
//			private static Setting setting;
			private static ModuleSettings setting;
//			settings = ModuleConfig.GetSettings();
//			private static ModuleSettings setting;

			/// <summary>
			/// Khởi tạo ngôn ngữ mặc định là tiếng Việt
			/// </summary>
			/// <returns>Mã lỗi xuất hiện khi thực hiện kết nối đến CSDL</returns>
            /// 
			public static int InitWorkingContext()
			{
//				setting = new Setting(UserStorageOption.File);
				setting = ModuleConfig.GetSettings();
//				setting = new ModuleSettings();
//				RestoreSettings();
				language = "ja-JP";//ConfigurationSettings.AppSettings["CurrentLanguage"];
				language = setting.Language;
				langManager = new LangManager(language);

				return 0;
			}
           
            
			public static int DisposeWorkingContext()
			{
				if (langManager != null)
				{
					langManager.Dispose();
				}

				return 0;
			}
			/// <summary>
			/// 
			/// </summary>
//			private static void RestoreSettings()
//			{
//				Setting newSetting;
//				
//
//				try
//				{
//					newSetting = ((Setting) setting.Restore());
//					
//
//				}
////				catch (UserSettingsException ex)
//				catch
//				{
//					// in case of failure, keep current WorkingContext.Settings
//					//MessageBox.Show(ex.ToString());
//					MessageBox.Show("Không tìm thấy file cấu hình hệ thống.", "Lỗi nạp file cấu hình", MessageBoxButtons.OK, MessageBoxIcon.Error);
//					newSetting = setting;
//				}
//				setting = newSetting;
//
//			}

			public static ModuleSettings Setting
			{
				get { return setting; }
				set { setting = value; }
			}
			/// <summary>
			/// Thiết lập kết nối đến database
			/// </summary>
			/// <returns></returns>
			public static SqlConnection GetConnection()
			{
				string connectionString = "server=" + setting.Server;
				connectionString += ";database=" + setting.Database;
				connectionString += ";uid=" + setting.UserName;
				connectionString += ";pwd=" + setting.Password;
				SqlConnection conn = new  SqlConnection(connectionString);
				return conn;
			}

			/// <summary>
			/// kiểm tra kết nối CSDL
			/// </summary>
			/// <param name="servername"></param>
			/// <param name="dbname"></param>
			/// <param name="user"></param>
			/// <param name="password"></param>
			/// <returns></returns>
			public static bool CheckConnection(string servername,string dbname,string user,string password)
			{
				string connectionString = "server=" + servername;
				connectionString += ";database=" + dbname;
				connectionString += ";uid=" + user;
				connectionString += ";pwd=" + password;
				SqlConnection conn = new  SqlConnection(connectionString);
				try 
				{
					conn.Open();
//					string strSQL = "SELECT CompanyID FROM tblCompany ";
//					SqlCommand cmd = new SqlCommand(strSQL,conn);
//					cmd.ExecuteNonQuery();
					return true;
				}
				catch 
				{
					return false;
				}
				finally
				{
					conn.Close();
				}
			}
			/// <summary>
			/// Thiết lập hoặc lấy về ngôn ngữ đang được thiết lập cho ứng dụng
			/// </summary>
			public static string Language
			{
				get
				{
					return language;
				}
				set
				{
					language = value;
					langManager.ChangeLanguage(value);
				}
			}

			/// <summary>
			/// Lấy về đối tượng chứa text của các control
			/// </summary>
			public static LangManager LangManager
			{
				get
				{
					return langManager;
				}
			}
			/// <summary>
			/// Thiết lập hoặc lấy về người dùng đang truy nhập hệ thống
			/// </summary>
			public static string Username
			{
				get { return username; }
				set { username = value; }
			}

			/// <summary>
			/// Hàm tạo một parameter (sử dụng để truyền tham số vào stored procedure)
			/// </summary>
			/// <param name="paramName">Tên tham số</param>
			/// <param name="paramType">kiểu dữ liệu</param>
			/// <param name="columnName">tên cột</param>
			/// <returns>SQLParameter</returns>
			public static System.Data.SqlClient.SqlParameter CreateParam( 
				string paramName, SqlDbType paramType, string columnName) 
			{
				// Create a parameter and return it
				System.Data.SqlClient.SqlParameter p =
					new System.Data.SqlClient.SqlParameter(paramName, paramType);
				p.SourceVersion = DataRowVersion.Current;
				p.SourceColumn = columnName;

				return p;
			}

		    public static RegistionType RegistionType
		    {
                get { return m_RegistionType; }
                set { m_RegistionType = value; }
		    }
		}
}
