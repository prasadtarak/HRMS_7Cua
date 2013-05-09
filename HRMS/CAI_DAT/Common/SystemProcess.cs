using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
//using EVsoft.HRMS.Ketoan.Data_Object.He_thong;
using System.Data;

namespace EVsoft.HRMS.Common
{
	/// <summary>
	/// Summary description for SystemProcess.
	/// </summary>
	public class SystemProcess : System.ComponentModel.Component
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		// Mã của người dùng đang đăng nhập vào hệ thống
		//		public static int Userid=0;
		//		public static string Username="";
		
		
		#region SERVER&DB
		//Dành cho Server
		[DllImport("odbc32.dll")]
		private static extern short SQLAllocHandle(short hType, IntPtr inputHandle, out IntPtr outputHandle);
		[DllImport("odbc32.dll")]
		private static extern short SQLSetEnvAttr(IntPtr henv, int attribute, IntPtr valuePtr, int strLength);
		[DllImport("odbc32.dll")]
		private static extern short SQLFreeHandle(short hType, IntPtr handle); 
		[DllImport("odbc32.dll",CharSet=CharSet.Ansi)]
		private static extern short SQLBrowseConnect(IntPtr hconn, StringBuilder inString, 
			short inStringLength, StringBuilder outString, short outStringLength,
			out short outLengthNeeded);

		private const short SQL_HANDLE_ENV = 1;
		private const short SQL_HANDLE_DBC = 2;
		private const int SQL_ATTR_ODBC_VERSION = 200;
		private const int SQL_OV_ODBC3 = 3;
		private const short SQL_SUCCESS = 0;
		
		private const short SQL_NEED_DATA = 99;
		private const short DEFAULT_RESULT_SIZE = 1024;
		private const string SQL_DRIVER_STR = "DRIVER=SQL SERVER";
		//Dành cho database
        //SQLDMO.SQLServer srv = new SQLDMO.SQLServerClass();
        public static string UserId = "";
        public static string Email = "";
        public static string UserName = "";
		
		#endregion

		private System.ComponentModel.Container components1 = null;
     

		public SystemProcess(System.ComponentModel.IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public SystemProcess()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        public string Username
        {
            set { UserName = value; }
            get { return UserName; }
        }
        public string UserID
        {
            set { UserId = value; }
            get { return UserId; }
        }

        public string Mail
        {
            set { Email = value; }
            get { return Email; }
        }


		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region Dùng cho Thiết lập CSDL

		public string[] GetServers()
		{
			string[] retval = null;
			string txt = string.Empty;
			IntPtr henv = IntPtr.Zero;
			IntPtr hconn = IntPtr.Zero;
			StringBuilder inString = new StringBuilder(SQL_DRIVER_STR);
			StringBuilder outString = new StringBuilder(DEFAULT_RESULT_SIZE);
			short inStringLength = (short) inString.Length;
			short lenNeeded = 0;

			try
			{
				if (SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_ENV, henv, out henv))
				{
					if (SQL_SUCCESS == SQLSetEnvAttr(henv,SQL_ATTR_ODBC_VERSION,(IntPtr)SQL_OV_ODBC3,0))
					{
						if (SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_DBC, henv, out hconn))
						{
							if (SQL_NEED_DATA ==  SQLBrowseConnect(hconn, inString, inStringLength, outString, 
								DEFAULT_RESULT_SIZE, out lenNeeded))
							{
								if (DEFAULT_RESULT_SIZE < lenNeeded)
								{
									outString.Capacity = lenNeeded;
									if (SQL_NEED_DATA != SQLBrowseConnect(hconn, inString, inStringLength, outString, 
										lenNeeded,out lenNeeded))
									{
										throw new ApplicationException("Unabled to aquire SQL Servers from ODBC driver.");
									}	
								}
								txt = outString.ToString();
								int start = txt.IndexOf("{") + 1;
								int len = txt.IndexOf("}") - start;
								if ((start > 0) && (len > 0))
								{
									txt = txt.Substring(start,len);
								}
								else
								{
									txt = string.Empty;
								}
							}						
						}
					}
				}
			}
			catch (Exception ex)
			{
				//Throw away any error if we are not in debug mode
#if (DEBUG)
				MessageBox.Show(ex.Message,"Không lấy được thông tin server");
#endif 
				txt = string.Empty;
			}
			finally
			{
				if (hconn != IntPtr.Zero)
				{
					SQLFreeHandle(SQL_HANDLE_DBC,hconn);
				}
				if (henv != IntPtr.Zero)
				{
					SQLFreeHandle(SQL_HANDLE_ENV,hconn);
				}
			}
	
			if (txt.Length > 0)
			{
				retval = txt.Split(",".ToCharArray());
			}

			return retval;
		}
		//Đưa ra danh sách Database
		public string[] Listdb(string servername,string username,string password)
		{
			string[] list = new string[50];
			int count =0;
			try
			{
                //srv.Connect(servername,username,password);		
                //foreach(SQLDMO.Database db in srv.Databases) 
                //{ 
                //    if(db.Name!=null) 
                //    {
                //        list[count] = db.Name;
                //        count++;
                //    }
                //}
			}
			catch(Exception ex)
			{
				return null;
			}
			finally
			{
                //srv.DisConnect();
			}
			if(count==0)return null;
			string[] newlist = new string[count];
			for(int i=0;i<count;i++)
			{
				newlist[i] = list[i];
			}
			return newlist;
		}

		#endregion



		#region Tạo file Manifest
		public void CheckManifestFile()
		{
			FileInfo MF = new FileInfo(@"Implementation.exe.manifest");
			if(MF.Exists) return;
			StreamWriter newMF = new StreamWriter(@"Implementation.exe.manifest");
			string[] Line = new string[50];
			Line[0] = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>";
			Line[1] = "<assembly xmlns=\"urn:schemas-microsoft-com:asm.v1\" manifestVersion=\"1.0\">";
			Line[2] = "    <assemblyIdentity";
			Line[3] = "        version=\"1.0.0.0\"";
			Line[4] = "        processorArchitecture=\"X86\"";
			Line[5] = "        name=\"Company.Product.EXE\"";
			Line[6] = "        type=\"win32\"";
			Line[7] = "    />";
			Line[8] = "    <description></description>";
			Line[9] = "    <dependency>";
			Line[10] = "        <dependentAssembly>";
			Line[11] = "            <assemblyIdentity";
			Line[12] = "                type=\"win32\"";
			Line[13] = "                name=\"Microsoft.Windows.Common-Controls\"";
			Line[14] = "                version=\"6.0.0.0\"";
			Line[15] = "                processorArchitecture=\"X86\"";
			Line[16] = "                publicKeyToken=\"6595b64144ccf1df\"";
			Line[17] = "                language=\"*\"";
			Line[18] = "            />";
			Line[19] = "        </dependentAssembly>";
			Line[20] = "    </dependency>";
			Line[21] = "</assembly>";
			for(int i=0;i<22;i++)
			{
				newMF.WriteLine(Line[i]);
			}
			newMF.Close();
		}
		#endregion
	}
}
