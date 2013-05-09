using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using XPTable.Models;

namespace EVsoft.HRMS.Common
{
	
	public class GeneralProcess : Component
	{
		#region  .NET
		
		private Container components = null;

		public GeneralProcess(IContainer container)
		{
			container.Add(this);
			InitializeComponent();
		}

		public GeneralProcess()
		{
			InitializeComponent();
		}

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

		private void InitializeComponent()
		{
			components = new Container();
		}
		
		#endregion
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//        #region Biến
//        SqlCommand command = new SqlCommand();
//        SqlDataAdapter adapter = new SqlDataAdapter();
//        #endregion
	
//        #region Xử lý chuỗi
//        public string PhanTichChuoi(string n)
//        {
//            string text="";
//            string phantruocdaucham="";
//            string phansaudaucham="";
//            bool flag = false;
//            int k = n.Length;
//            int i = 0;
//            for(i=0;i<k;i++)
//            {
//                if  (n.Substring(i,1)==".")
//                {
//                    flag = true;
//                    break;
//                }
//            }
			
//            if (flag)
//            {
//                phantruocdaucham = BoDauPhay(n.Substring(0,i));
//                phansaudaucham = n.Substring(i+1,k-i-1);
//                text = DocSo(phantruocdaucham) + " phẩy " + DocSo(phansaudaucham);
//            }
//            else
//            {
//                text = DocSo(n);
//            }
//            text = text.Substring(0,1).ToUpper() + text.Substring(1,text.Length-1);
			
//            return text;
//        }
//        private string BoDauPhay(string n)
//        {
//            string text = "";
//            int k = n.Length;
//            for(int i=0;i<k;i++)
//            {
//                if  (n.Substring(i,1)!=",")
//                {
//                    text = text + n.Substring(i, 1);
//                }
//            }
//            return text;
//        }
//        private string DocSo(string n)
//        {
//            string text;
//            int k = n.Length;
			
			
//            string cumthunhat;
//            string cumthuhai;
//            string cumthuba;
//            string cumthutu;
//            string cumthunam;
			
//            string doccumthunhat="";
//            string doccumthuhai="";
//            string doccumthuba="";
//            string doccumthutu="";
//            string doccumthunam="";
			
		
//            int i = 0;
			
//            if (k<=3)
//            {	
//                i = k;
//                cumthunhat = n.Substring(0,i);
//                if (i==3){doccumthunhat = DocChuoiBaSo(cumthunhat);}
//                if (i==2){doccumthunhat = DocChuoiHaiSo(cumthunhat);}
//                if (i==1){doccumthunhat = DocMotSo(cumthunhat);}
				
//                text = doccumthunhat;
//            }
			
//            else
//            {
//                if (k<=6)
//                {
//                    i = k-3;
//                    cumthunhat = n.Substring(0,i);
//                    if (i==3){doccumthunhat = DocChuoiBaSo(cumthunhat);}
//                    if (i==2){doccumthunhat = DocChuoiHaiSo(cumthunhat);}
//                    if (i==1){doccumthunhat = DocMotSo(cumthunhat);}
					
//                    cumthuhai = n.Substring(k-3,3);
//                    if (cumthuhai!="000")
//                    {
//                        doccumthuhai =  DocChuoiBaSo(cumthuhai);
//                    }
						
//                    text = doccumthunhat + "nghìn " + doccumthuhai;
//                }
//                else
//                {
//                    if (k<=9)
//                    {
//                        i = k-6;
//                        cumthunhat = n.Substring(0,i);
//                        if (i==3){doccumthunhat = DocChuoiBaSo(cumthunhat);}
//                        if (i==2){doccumthunhat = DocChuoiHaiSo(cumthunhat);}
//                        if (i==1){doccumthunhat = DocMotSo(cumthunhat);}

//                        cumthuhai = n.Substring(k-6,3);
//                        cumthuba = n.Substring(k-3,3);

//                        if (cumthuhai!="000")
//                        {
//                            doccumthuhai =  DocChuoiBaSo(cumthuhai) + "nghìn ";
//                        }
//                        if (cumthuba!="000")
//                        {
//                            doccumthuba =  DocChuoiBaSo(cumthuba);
//                        }
								
//                        text = doccumthunhat + "triệu " + doccumthuhai  + doccumthuba;
//                    }
//                    else
//                    {
//                        if (k<=12)
//                        {
//                            i = k-9;
//                            cumthunhat = n.Substring(0,i);
//                            if (i==3){doccumthunhat = DocChuoiBaSo(cumthunhat);}
//                            if (i==2){doccumthunhat = DocChuoiHaiSo(cumthunhat);}
//                            if (i==1){doccumthunhat = DocMotSo(cumthunhat);}

//                            cumthuhai = n.Substring(k-9,3);
//                            cumthuba = n.Substring(k-6,3);
//                            cumthutu = n.Substring(k-3,3);

//                            if (cumthuhai!="000")
//                            {
//                                doccumthuhai =  DocChuoiBaSo(cumthuhai) + "triệu " ;
//                            }
//                            if (cumthuba!="000")
//                            {
//                                doccumthuba =  DocChuoiBaSo(cumthuba) + "nghìn ";
//                            }
//                            if (cumthutu!="000")
//                            {
//                                doccumthutu =  DocChuoiBaSo(cumthutu);
//                            }
									
						
//                            text = doccumthunhat + "tỷ " + doccumthuhai + doccumthuba  + doccumthutu;
//                        }
//                        else
//                        {
//                            i =k-12;
//                            cumthunhat = n.Substring(0,i);
//                            if (i==3){doccumthunhat = DocChuoiBaSo(cumthunhat);}
//                            if (i==2){doccumthunhat = DocChuoiHaiSo(cumthunhat);}
//                            if (i==1){doccumthunhat = DocMotSo(cumthunhat);}
								
//                            cumthuhai = n.Substring(k-12,3);
//                            cumthuba = n.Substring(k-9,3);
//                            cumthutu = n.Substring(k-6,3);
//                            cumthunam = n.Substring(k-3,3);

//                            if (cumthuhai!="000")
//                            {
//                                doccumthuhai =  DocChuoiBaSo(cumthuhai) + "tỷ " ;
//                            }
//                            if (cumthuba!="000")
//                            {
//                                doccumthuba =  DocChuoiBaSo(cumthuba) + "triệu ";
//                            }
//                            if (cumthutu!="000")
//                            {
//                                doccumthutu =  DocChuoiBaSo(cumthutu)+ "nghìn ";
//                            }
//                            if (cumthunam!="000")
//                            {
//                                doccumthunam =  DocChuoiBaSo(cumthunam);
//                            }
								
//                            text = doccumthunhat + "nghìn " + doccumthuhai + doccumthuba  + doccumthutu + doccumthunam;
							
//                        }
//                    }
//                }

//            }
			
			
			
			
//            return text;
//        }

//        private string DocMotSo(string n)
//        {	
//            int m =-1;
			
//            if (n!="") {m = int.Parse(n);}
//            string text;
			

//            switch (m)
//            {
//                case -1 :
//                    text = "";
//                    break;
//                case 0 :
//                    text = "không ";
//                    break;
//                case 1 :
//                    text = "một ";
//                    break;
//                case 2 :
//                    text = "hai ";
//                    break;
//                case 3 :
//                    text = "ba ";
//                    break;
//                case 4 :
//                    text = "bốn ";
//                    break;
//                case 5 :
//                    text = "năm ";
//                    break;
//                case 6 :
//                    text = "sáu ";
//                    break;
//                case 7 :
//                    text = "bẩy ";
//                    break;
//                case 8 :
//                    text = "tám ";
//                    break;
//                case 9 :
//                    text = "chín ";
//                    break;
//                default :
//                    text = "";
//                    break;
//            }

//            return text;
//        }

//        private string DocChuoiHaiSo (string n)
//        {
//            string text ="";
//            string sothunhat;
//            string sothuhai;
//            string docsothuhai;
//            string docsothunhat;

//            sothunhat = n.Substring(0,1);
//            sothuhai = n.Substring(1,1);

//            if (int.Parse(sothuhai)==0)
//            {
//                docsothuhai="";
//            }
//            else
//            {	
//                docsothuhai = DocMotSo(sothuhai);	
//            }
			

//            if (int.Parse(sothunhat)==1)
//            {
//                docsothunhat= "mười ";
//            }
//            else
//            {	
//                docsothunhat = DocMotSo(sothunhat)+ "mươi ";
//                if (int.Parse(sothuhai)==1)
//                {
//                    docsothuhai = "mốt ";
//                }
//                if (int.Parse(sothuhai)==4)
//                {
//                    docsothuhai = "tư ";
//                }
//                if (int.Parse(sothuhai)==5)
//                {
//                    docsothuhai = "nhăm ";
//                }
//            }

			
//            text = docsothunhat + docsothuhai;
//            return text;
//        }

//        private string DocChuoiBaSo (string n)
//        {
//                string text = "";
//            string sothunhat;
//            string sothuhai;
//            string sothuba;
//            string doccumhaiso;
			

//            sothunhat = n.Substring(0,1);
//            sothuhai = n.Substring(1,1);
//            sothuba = n.Substring(2,1);
			
		
				
//            if (int.Parse(sothuhai)==0)
//            {
//                if (int.Parse(sothuba)==0)
//                {
//                    doccumhaiso = "";
//                }
//                else
//                {
//                    doccumhaiso = "linh " +  DocMotSo(sothuba);
//                }
//            }
//            else
//            {	
					
//                doccumhaiso = DocChuoiHaiSo(n.Substring(1,2));
//            }
				
			

//            text = DocMotSo(sothunhat) + "trăm " + doccumhaiso;

			
//            return text;
			
//        }
//        #endregion

//        #region Xử lý các thay đổi xảy ra ở các form liên quan đang active
//        public static void CheckAndRefreshNeibough(string NeiboughForm,Form MDIForm)
//        {
//            Form[] mdichld = MDIForm.MdiChildren;
//            if (MDIForm.MdiChildren.Length == 0)
//            {
//                return;
//            }
//            foreach (Form selfm in mdichld)
//            {
//                string str = selfm.Name;
//                str = str.IndexOf(NeiboughForm).ToString();
//                if (str != "-1")
//                {
//                    selfm.Activate();
//                    selfm.Close();
//                    return;
//                }
//            }
//        }
//        #endregion

//        #region  chuyển định dạng MM\DD\YY sang DD\MM\YY

//        public string CatNgay(int Year,int Month,int day)
//        {
//            DateTime getdate = new DateTime(Year,Month,day);
//            string str = getdate.ToShortDateString();
////			string ngay = str.Substring(0, 2);
////			string thang = str.Substring(3, 2);
////			string nam = str.Substring(6, 4);
////			string newstr = thang + "/" + ngay + "/" + nam;
////			return newstr;
//            return str;
//        }
//        #endregion
	
//        #region Tự động Fill dữ liệu vào DataSet từ Store ko truyền tham số
//        /// <summary>
//        /// DataSetName = DoiTuongDataSet.TenDataTable
//        /// </summary>
//        /// <param name="StoreName"></param>
//        /// <param name="DataSetName"></param>
//        public void AutoFillDataTable(string StoreName,DataTable DataTableName)
//        {			
//            DataTableName.Clear();
//            command.Parameters.Clear();
//            command.CommandText = "StoreName";
//            try
//            {
//                command.ExecuteNonQuery();
//                adapter.Fill(DataTableName);
//            }
//            catch(Exception ex)
//            {
//                MessageBox.Show(ex.ToString());
//            }

//        }
//        #endregion

//        #region Currency All Exchange
//        public static string GetCurrencyName(string CurrencyID)
//        {
//            ReferDataConnect ConnectToReferData = new ReferDataConnect();
//            ConnectToReferData.QueryCCYList();
//            foreach(DataRow row in ConnectToReferData.ds_refer.tbl_GE_List_CCY)
//            {
//                if(row[ConnectToReferData.ds_refer.tbl_GE_List_CCY.CurrencyIDColumn].ToString()==CurrencyID)
//                {
//                    return row[ConnectToReferData.ds_refer.tbl_GE_List_CCY.CurrencyNameColumn].ToString();
//                }
//            }
//            return "";
//        }
//        public static string GetCurrencyID(string CurrencyName)
//        {
//            ReferDataConnect ConnectToReferData = new ReferDataConnect();
//            ConnectToReferData.QueryCCYList();
//            foreach(DataRow row in ConnectToReferData.ds_refer.tbl_GE_List_CCY)
//            {
//                if(row[ConnectToReferData.ds_refer.tbl_GE_List_CCY.CurrencyNameColumn].ToString()==CurrencyName)
//                {
//                    return row[ConnectToReferData.ds_refer.tbl_GE_List_CCY.CurrencyIDColumn].ToString();
//                }
//            }
//            return "";
//        }
//        #endregion

		#region Standard Form Control
		public static void StandardFormControl(Form thisForm)
		{
			ControlCollectionModifier(thisForm);
		}
		private static void ControlCollectionModifier(Control ThisControl)
		{
			foreach(Control myctrl in ThisControl.Controls)
			{
				/*Đệ quy để xét toàn bộ các Control*/
				if(myctrl.Controls.Count!=0)
					ControlCollectionModifier(myctrl);
				
				/*Chuẩn hóa bảng XPTable*/
				if((myctrl.ToString() == "XPTable.Models.Table"))
					XPTableOnModifier(myctrl);

				/*Tạo phím Enter có khả năng sử dụng như phím Tab*/
				ControlEnterChangeTabIndex(myctrl);
				
				/*Chuẩn hóa DateTimePicker theo Culture được chọn*/
				if((myctrl.GetType().ToString() == "System.Windows.Forms.DateTimePicker"))
					DateTimePickerCustomFormatSet(myctrl);
			}
		}

		#region Xử lý co dãn bảng XPTable
		/// <summary>
		/// Kiểm tra và áp đặt thuộc tính chung cho Control XPTable
		/// </summary>
		/// <param name="ThisControl"></param>
		private static void XPTableOnModifier(Control ThisControl)
		{
			if((ThisControl.ToString() != "XPTable.Models.Table"))return;
			Table tbl = (XPTable.Models.Table)ThisControl;
			XPTableModifier(ref tbl);
		}
		/// <summary>
		///  Tự động size cột dữ liệu (Không sử dụng khi đã dùng even SizeChanged)
		///  void modify nên để sau cùng áu khi toàn bộ dữ liệu đã load đầy đủ
		/// </summary>
		/// <param name="mytbl"></param>
		public static void XPTableModifier(ref Table mytbl)
		{
			RowColor(ref mytbl);
			SizeModifier(ref mytbl);
			mytbl.BeginUpdate();
			mytbl.Resize += new EventHandler(SizeChanged);
			mytbl.EnableHeaderContextMenu=false;
			mytbl.EndUpdate();
		}
		//Kiểm tra và thay đổi
		private static void SizeModifier(ref Table mytbl)
		{
			//Lấy thông tin bảng hiển tại
			int TblWsize = mytbl.Size.Width;
			int TotalColnum = mytbl.ColumnModel.Columns.Count;
			int TotalColsize = mytbl.ColumnModel.VisibleColumnsWidth;
			if(mytbl.ColumnModel.VisibleColumnCount==0)return;
			//Kiểm tra khoảng trống
			if(TblWsize<=TotalColsize+30)return;
			//Nếu bảng chỉ có một cột thì hiển thị trực tiếp
			if(mytbl.ColumnModel.VisibleColumnCount==1)
			{
				mytbl.BeginUpdate();
				for (int i=0;i<TotalColnum;i++)
				{
					mytbl.ColumnModel.Columns[i].Width =TblWsize-30;
				}
				mytbl.EndUpdate();
			}
			else
			{
				int Remainning = (TblWsize-TotalColsize-30)/mytbl.ColumnModel.VisibleColumnCount;
				//Tăng kích thước
				mytbl.BeginUpdate();
				for (int i=0;i<TotalColnum;i++)
				{
					mytbl.ColumnModel.Columns[i].Width =mytbl.ColumnModel.Columns[i].Width+Remainning;
				}
				mytbl.EndUpdate();
			}
			Cheats(ref mytbl);
		}
		//Giúp refresh dữ liệu
		private static void Cheats(ref Table mytbl)
		{
			mytbl.BeginUpdate();
			mytbl.ColumnModel.Columns.Add(new TextColumn());
			mytbl.EndUpdate();
			mytbl.BeginUpdate();
			mytbl.ColumnModel.Columns.RemoveAt(mytbl.ColumnModel.Columns.Count-1);
			mytbl.EndUpdate();
		}

		//Thay đổi size
		private static void SizeChanged(object sender, EventArgs e)
		{
			//Lấy bảng XPTable
			Table mytbl = (Table)sender;
			SizeModifier(ref mytbl);
		}

		//Thay đổi màu sắc
		private static void RowColor(ref Table mytbl)
		{
			mytbl.BeginUpdate();
			mytbl.AlternatingRowColor = Color.FromArgb(((Byte)(235)), ((Byte)(243)), ((Byte)(255)));
			mytbl.BackColor = Color.FromArgb(((Byte)(241)), ((Byte)(244)), ((Byte)(255)));
			mytbl.SortedColumnBackColor = Color.Transparent;
			mytbl.EndUpdate();
		}
		#endregion
		
		#region Xử lý phím Enter có tác dụng như Tab_Key

		/// <summary>
		/// Thay đổi cách thức chuyển index khi enter với Controls và một số Control đặc biệt
		/// </summary>
		/// <param name="ThisControl"></param>
		private static void ControlEnterChangeTabIndex(Control ThisControl)
		{
			if((ThisControl.GetType().ToString() == "MTGCComboBox"))
				ThisControl.KeyDown +=new System.Windows.Forms.KeyEventHandler(OnEnterChangeTabIndexKeyDown);
			else
				ThisControl.KeyPress +=new KeyPressEventHandler(OnEnterChangeTabIndexKeyPress);
		}
		private static void OnEnterChangeTabIndexKeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar == 13)
			{
				/*Get current active control and his big parent*/
				Control ThisControl = (Control) sender;
				Control ThisBigParent = ThisControl.TopLevelControl;
								
//				SelectNoneToLeave(ThisControl);
				/*Next Control Select*/
				ThisBigParent.SelectNextControl(ThisControl,true,true,true,true);

				/*Select full text in the active control*/
				Control NowActiveControl = ThisBigParent.GetContainerControl().ActiveControl;
				SelectFullTextOnComeIn(NowActiveControl);
			}
		}
		private static void OnEnterChangeTabIndexKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if((e.KeyCode==Keys.Return)||(e.KeyCode==Keys.Enter))
			{
				/*Get current active control and his big parent*/
				Control ThisControl = (Control) sender;
				Control ThisBigParent = ThisControl.TopLevelControl;
				
//				SelectNoneToLeave(ThisControl);
				/*Next Control Active*/
				ThisBigParent.SelectNextControl(ThisControl,true,true,true,true);

				/*Select Full Text*/
				Control NowActiveControl = ThisBigParent.GetContainerControl().ActiveControl;
				SelectFullTextOnComeIn(NowActiveControl);
			}
		}
		private static void SelectNoneToLeave(Control myControl)
		{
			if((myControl.GetType().ToString() == "System.Windows.Forms.TextBox"))
				((TextBox) myControl).Select(0,0) ;
			else if((myControl.GetType().ToString() == "System.Windows.Forms.ComboBox"))
				((ComboBox) myControl).Select(0,0) ;
			else if((myControl.GetType().ToString() == "MTGCComboBox"))
				((MTGCComboBox) myControl).Select(0,0) ;
		}
		private static void SelectFullTextOnComeIn(Control myControl)
		{
			if((myControl.GetType().ToString() == "System.Windows.Forms.TextBox"))
				((TextBox) myControl).SelectAll() ;
			else if((myControl.GetType().ToString() == "System.Windows.Forms.ComboBox"))
				((ComboBox) myControl).SelectAll() ;
			else if((myControl.GetType().ToString() == "MTGCComboBox"))
				((MTGCComboBox) myControl).SelectAll() ;
		}
		#endregion

		#region Chuẩn hóa kiểu hiển thị của DateTimePicker theo Culture được chọn
		private static void DateTimePickerCustomFormatSet(Control ThisControl)
		{
			if((ThisControl.GetType().ToString() != "System.Windows.Forms.DateTimePicker"))return;
			DateTimePicker DateTimeControl = (DateTimePicker) ThisControl;
			DateTimeControl.CustomFormat = Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern;
			DateTimeControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		}
		#endregion

		#endregion

        //#region Change number in TextBox to stadard format in event Lost Focus
        ///// <summary>
        ///// Change number in TextBox to stadard format in event Lost Focus
        ///// </summary>
        ///// <param name="textbox">this TextBox</param>
        //public static void TextBoxAffectAsNumBerBox(TextBox textbox)
        //{
        //    textbox.LostFocus += new EventHandler(txt_LostFocus);
        //    textbox.TextChanged += new EventHandler(textbox_TextChanged);
        //}
        //private static void txt_LostFocus(object sender, EventArgs e)
        //{
        //    NumberFormatInfo numberInfo = CultureInfo.CurrentCulture.NumberFormat;
        //    decimal inputnumber = 0;
        //    TextBox txtbox = (TextBox) sender;
        //    try
        //    {
        //        inputnumber = decimal.Parse(txtbox.Text);
        //    }
        //    catch

        //    {
        //        return;
        //    }
        //    txtbox.Text = inputnumber.ToString("N",numberInfo);
        //}

        //private static void textbox_TextChanged(object sender, EventArgs e)
        //{
        //    TextBox txtbox = (TextBox) sender;
        //    if(txtbox.Focused)return;
        //    NumberFormatInfo numberInfo = CultureInfo.CurrentCulture.NumberFormat;
        //    decimal inputnumber = 0;
        //    try
        //    {
        //        inputnumber = decimal.Parse(txtbox.Text);
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //    txtbox.Text = inputnumber.ToString("N",numberInfo);
        //}
        //#endregion

        //#region Nạp thông tin MCTGComboBox
        ///// <summary>
        ///// Fill dữ liệu vào MTCGComboBox
        ///// </summary>
        ///// <param name="MyComboBox"></param>
        ///// <param name="SourceString"></param>
        ///// <param name="Tbl"></param>
        ///// <param name="SelectIndex"></param>
        ///// <param name="DropDown"></param>
        //public void FillMTCGBox(ref MTGCComboBox MyComboBox,string[] SourceString,DataTable Tbl,int SelectIndex,bool DropDown)
        //{
        //    if(Tbl.Rows.Count==0)return;
        //    MyComboBox.Items.Clear();
        //    MyComboBox.SourceDataString = SourceString;
        //    MyComboBox.SourceDataTable = Tbl;
        //    MyComboBox.SelectedIndex= SelectIndex;
        //    if(DropDown)
        //        MyComboBox.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
        //}
        //public void FillMTCGBox(ref MTGCComboBox MyComboBox,string[] SourceString,DataTable Tbl,bool DropDown)
        //{
        //    if(Tbl.Rows.Count==0)return;
        //    MyComboBox.Items.Clear();
        //    MyComboBox.SourceDataString = SourceString;
        //    MyComboBox.SourceDataTable = Tbl;
        //    if(DropDown)
        //        MyComboBox.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
        //}
        ///// <summary>
        ///// Fill dữ liệu vào MTCGComboBox
        ///// </summary>
        ///// <param name="MyComboBox">ComboBox cần Fill dữ liệu</param>
        ///// <param name="SourceString">Các cột cần hiển thị trong DataTable</param>
        ///// <param name="Tbl">DataTable</param>
        //public void FillMTCGBox(ref MTGCComboBox MyComboBox,string[] SourceString,DataTable Tbl)
        //{
        //    if(Tbl.Rows.Count==0)return;
        //    MyComboBox.Items.Clear();
        //    MyComboBox.SourceDataString = SourceString;
        //    MyComboBox.SourceDataTable = Tbl;
        //}
        //#endregion
	}
}
