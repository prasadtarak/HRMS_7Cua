using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AttLogs;
using EVSoft.CardReader;
using System.Threading;
using System.ServiceProcess;

namespace CardReader
{
    public partial class frmX628C : Form
    {
        public frmX628C()
        {
            InitializeComponent();
            //connectToDevice();
        }
        private bool bClose;
        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        PP6750DO pp6750 = null;
        X628CDO x628 = null;

        /********************************************************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.                                           *
        * This part is for demonstrating the communication with your device.There are 3 communication ways: "TCP/IP","Serial Port" and "USB Client".*
        * The communication way which you can use duing to the model of the device.                                                                 *
        * *******************************************************************************************************************************************/
        #region Communication
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.

        //If your device supports the TCP/IP communications, you can refer to this.
        //when you are using the tcp/ip communication,you can distinguish different devices by their IP address.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                lblState.ForeColor = Color.Crimson;
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                lblState.ForeColor = Color.Lime;
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //If your device supports the SerialPort communications, you can refer to this.
        private void btnRsConnect_Click(object sender, EventArgs e)
        {
            if (cbPort.Text.Trim() == "" || cbBaudRate.Text.Trim() == "" || txtMachineSN.Text.Trim() == "")
            {
                MessageBox.Show("Port,BaudRate and MachineSN cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;
            //accept serialport number from string like "COMi"
            int iPort;
            string sPort = cbPort.Text.Trim();
            for (iPort = 1; iPort < 10; iPort++)
            {
                if (sPort.IndexOf(iPort.ToString()) > -1)
                {
                    break;
                }
            }

            Cursor = Cursors.WaitCursor;
            if (btnRsConnect.Text == "Disconnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnRsConnect.Text = "Connect";
                btnRsConnect.Refresh();
                lblState.Text = "Current State:Disconnected";
                Cursor = Cursors.Default;
                return;
            }

            iMachineNumber = Convert.ToInt32(txtMachineSN.Text.Trim());//when you are using the serial port communication,you can distinguish different devices by their serial port number.
            bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, Convert.ToInt32(cbBaudRate.Text.Trim()));

            if (bIsConnected == true)
            {
                btnRsConnect.Text = "Disconnect";
                btnRsConnect.Refresh();
                lblState.Text = "Current State:Connected";

                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }

            Cursor = Cursors.Default;
        }

        //If your device supports the USBCLient, you can refer to this.
        //Not all series devices can support this kind of connection.Please make sure your device supports USBClient.
        //Connect the device via the virtual serial port created by USBClient
        private void btnUSBConnect_Click(object sender, EventArgs e)
        {
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;

            if (btnUSBConnect.Text == "Disconnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnUSBConnect.Text = "Connect";
                btnUSBConnect.Refresh();
                lblState.Text = "Current State:Disconnected";
                Cursor = Cursors.Default;
                return;
            }

            SearchforUSBCom usbcom = new SearchforUSBCom();
            string sCom = "";
            bool bSearch = usbcom.SearchforCom(ref sCom);//modify by Darcy on Nov.26 2009
            if (bSearch == false)//modify by Darcy on Nov.26 2009
            {
                MessageBox.Show("Can not find the virtual serial port that can be used", "Error");
                Cursor = Cursors.Default;
                return;
            }

            int iPort;
            for (iPort = 1; iPort < 10; iPort++)
            {
                if (sCom.IndexOf(iPort.ToString()) > -1)
                {
                    break;
                }
            }

            iMachineNumber = Convert.ToInt32(txtMachineSN2.Text.Trim());
            if (iMachineNumber == 0 || iMachineNumber > 255)
            {
                MessageBox.Show("The Machine Number is invalid!", "Error");
                Cursor = Cursors.Default;
                return;
            }

            int iBaudRate = 115200;//115200 is one possible baudrate value(its value cannot be 0)
            bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, iBaudRate);

            if (bIsConnected == true)
            {
                btnUSBConnect.Text = "Disconnect";
                btnUSBConnect.Refresh();
                lblState.Text = "Current State:Connected";
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
                disconnectToDevice();
            }

            Cursor = Cursors.Default;
        }

        #endregion

        /*************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.*
        * This part is for demonstrating operations with(read/get/clear) the attendance records.         *
        * ************************************************************************************************/

        private void btnGetGeneralLogData_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            else
            {
                ReceiveData();
            }
        }

        /// <summary>
        /// Nhận dữ liệu từ máy quẹt thẻ
        /// </summary>
        private void ReceiveData()
        {
            string sdwEnrollNumber = "";
            //int idwTMachineNumber = 0;
            //int idwEMachineNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;
            int idwSecond = 0;
            int idwWorkcode = 0;

            int idwErrorCode = 0;
            int iGLCount = 0;
            int iIndex = 0;

            string CardID = string.Empty;
            DateTime WorkingDay = DateTime.Now;
            string CheckIn = string.Empty;

            Cursor = Cursors.WaitCursor;
            lvLogs.Items.Clear();
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
            {
                while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
                           out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                {
                    iGLCount++;
                    lvLogs.Items.Add(iGLCount.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(sdwEnrollNumber);//modify by Darcy on Nov.26 2009
                    lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwWorkcode.ToString());
                    iIndex++;

                    CardID = sdwEnrollNumber;
                    //giờ vào
                    //				string CheckIn = str1.Substring(20,4);
                    //ngày làm việc
                    //				DateTime WorkingDay = ConvertString2Day("20"+str1.Substring(12,6));
                    WorkingDay = DateTime.Parse(idwYear.ToString() + "/" + idwMonth.ToString() + "/" + idwDay.ToString());
                    CheckIn = idwHour.ToString() + ":" + idwMinute.ToString();

                    try
                    {

                        WriteLog.WriteTimeLog(CardID, WorkingDay.ToString("yyyyMMdd"), CheckIn);
                    }
                    catch
                    {
                        // axCZKEM1.Disconnect();//disconnect device incase exception
                    }

                    int employeeID = 0;
                    DataSet dataSet = pp6750.GetEmployeeInfo(CardID);
                    DataTable dbtable = dataSet.Tables[0];

                    if (dbtable.Rows.Count == 0)
                    {
                        ///MessageBox.Show((" Thẻ "+CardID+ " không hợp lệ !!!"),"Thông báo");
                    }
                    else
                    {
                        foreach (DataRow dataRow in dbtable.Rows)
                        {
                            // Lấy mã thẻ của nhân viên vừa quẹt
                            employeeID = (int)dataRow["EmployeeID"];

                            DateTime gioQuetthe = ConvertString2Time(idwHour, idwMinute);

                        }
                        ///// Lấy giờ quẹt thẻ
                        //String TimeInOut = ConvertString2Time(idwHour, idwMinute).ToShortTimeString();
                        ///// Kiểm tra thời gian quẹt thẻ là giờ vào hay ra
                        //string TimeIn = pp6750.GetTimeIn(employeeID, WorkingDay);
                        ///// Lưu dữ liệu quẹt thẻ vào cơ sở dữ liệu                     
                        //pp6750.SaveCardData(WorkingDay.ToString(), employeeID, TimeInOut, TimeIn);

                        DateTime dtCheckCardTime = new DateTime(idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond);
                        x628.SaveCheckCardData(employeeID, dtCheckCardTime);

                    }
                }
                //xoa du lieu sau khi doc xong
                if (axCZKEM1.ClearGLog(iMachineNumber))
                {
                    axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                    //MessageBox.Show("All att Logs have been cleared from teiminal!", "Success");
                }
            }
            else
            {
                Cursor = Cursors.Default;
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                    disconnectToDevice();
                    aTimer.Interval = 120000;
                }
                else
                {
                    // MessageBox.Show("No data from terminal returns!", "Error");
                }
            }

            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            Cursor = Cursors.Default;
        }

        private void btnClearGLog_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            int idwErrorCode = 0;

            ///lvLogs.Items.Clear();
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device


            if (axCZKEM1.ClearGLog(iMachineNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("All att Logs have been cleared from teiminal!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                disconnectToDevice();
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
        }


        private void btnGetDeviceStatus_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            int idwErrorCode = 0;
            int iValue = 0;

            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            {
                MessageBox.Show("The count of the AttLogs in the device is " + iValue.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                disconnectToDevice();
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }


        /// <summary>
        /// Chuyển xâu sang kiểu ngày
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        private DateTime ConvertString2Day(string temp)
        {
            DateTime WorkingDay = new DateTime();
            string str = temp.Substring(0, 4) + "/" + temp.Substring(4, 2) + "/" + temp.Substring(6, 2);
            try
            {
                WorkingDay = DateTime.Parse(str);
            }
            catch (Exception)
            {

            }
            return WorkingDay;
        }
        /// <summary>
        /// chuyển một xâu sang kiểu ngày
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private DateTime ConvertString2Time(int Hour, int Minute)
        {
            return new DateTime(1900, 1, 1, Hour, Minute, 0);
        }

        private void frmX628C_Load(object sender, EventArgs e)
        {
            pp6750 = new PP6750DO();
            x628 = new X628CDO();
            //  Thread.Sleep(2000);

        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if (pp6750.CheckConnection())
            {
                if (bIsConnected == false) //if not connected, try to connect first
                {
                    //MessageBox.Show("Please connect the device first", "Error");
                    int idwErrorCode = 0;
                    Cursor = Cursors.WaitCursor;
                    bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
                    if (bIsConnected == true)
                    {
                        btnConnect.Text = "DisConnect";
                        btnConnect.Refresh();
                        lblState.Text = "Current State:Connected";
                        lblState.ForeColor = Color.Lime;
                        iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                        axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                        ReceiveData();//get the data from device
                    }
                    else
                    {
                        MessageBox.Show("Unable to connect the device. Please check the cable or device setting. ErrorCode=" + idwErrorCode.ToString(), "Error");
                        aTimer.Interval = 120000;
                    }
                }
                else //if already connected, get the data immediately
                {
                    ReceiveData();//get the data from device
                }

            }
            else
            {
                MessageBox.Show("Failed to connect to the database", "Error");
                aTimer.Interval = 120000;
            }
        }
        /// <summary>
        /// Try to connect to the device
        /// </summary>
        private void connectToDevice()
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                lblState.ForeColor = Color.Crimson;
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                lblState.ForeColor = Color.Lime;
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device. Please check the cable or device setting. ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }
        /// <summary>
        /// Disconnect to the device
        /// </summary>
        private void disconnectToDevice()
        {
            axCZKEM1.Disconnect();
            bIsConnected = false;
            btnConnect.Text = "Connect";
            lblState.Text = "Current State:DisConnected";
            lblState.ForeColor = Color.Crimson;
            Cursor = Cursors.Default;
            return;
        }
        ///////
        private void contextMenu1_Popup(object sender, System.EventArgs e)
        {
            mnuShow.Enabled = !(this.Visible);
            mnuHide.Enabled = this.Visible;
            Load_Service();
        }
        private void Load_Service()
        {
            ServiceController sc = new ServiceController("CardReaderService");
            if (sc.Status.ToString() == "Stopped")
            {
                mnuStart.Enabled = true;
                mnuStop.Enabled = false;
            }
            else
            {
                mnuStart.Enabled = false;
                mnuStop.Enabled = true;
            }
        }

        private void frmX628C_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (!bClose)
                e.Cancel = true;
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            bClose = true;
            this.Close();
        }

        private void frmX628C_Resize(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void mnuStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController sc = new ServiceController("CardReaderService");
                if (sc.Status.ToString() == "Stopped")
                {
                    sc.Start();
                    sc.Refresh();
                    mnuStart.Enabled = false;
                    mnuStop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void mnuStop_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController sc = new ServiceController("CardReaderService");
                if (sc.CanStop)
                {
                    if (sc.Status.ToString() != "Stopped")
                    {
                        sc.Stop();
                        sc.Refresh();
                        mnuStart.Enabled = true;
                        mnuStop.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void mnuShow_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void mnuHide_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Card Reader 20110519 4PM", "Last update by ChinhND", MessageBoxButtons.OK);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                try
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
                }
            }
            else
            {
                try
                {
                    this.Hide();
                    this.WindowState = FormWindowState.Minimized;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Service đọc thẻ không tồn tại", "Thông báo");
                }
            }

        }
    }
}
