//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
    /// <summary>
    /// Summary description for RegRestEmployeeDO.
    /// </summary>
    public class RegRestEmployeeDO
    {
        SqlConnection con = null;
        SqlCommand com = null;
        SqlDataAdapter adapter = null;
        DataSet dsRestEmployee = null;

        #region Các hàm lấy dữ liệu
        /// <summary>
        /// Lấy các kiểu ngày đưa vào dataset
        /// </summary>
        /// <returns></returns>
        public DataSet GetRegRestEmployee()
        {
            con = WorkingContext.GetConnection();
            string strSQL = "SELECT RegRestID,EmployeeID,DayID,RestReason,StartRest,EndRest FROM tblRegRestEmployee";
            SqlCommand sqlcmd = new SqlCommand(strSQL, con);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            dsRestEmployee = new DataSet();

            try
            {
                con.Open();
                adapter.Fill(dsRestEmployee, "tblRegRestEmployee");
                return dsRestEmployee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Thống kê nhân viên nghỉ trong một khoảng thời gian và theo phòng ban
        /// </summary>
        /// <param name="dtpFrom"></param>
        /// <param name="dtpTo"></param>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public DataSet GetRegRestEmployee(DateTime dtpFrom, DateTime dtpTo, int DepartmentID)
        {
            con = WorkingContext.GetConnection();
            // Build the command
            com = new SqlCommand("GetRegRestEmployee", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@dtpFrom", SqlDbType.DateTime);
            param1.Value = dtpFrom.ToShortDateString();
            com.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@dtpTo", SqlDbType.DateTime);
            param2.Value = dtpTo.ToShortDateString();
            com.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@DepartmentID", SqlDbType.Int);
            param3.Value = DepartmentID;
            com.Parameters.Add(param3);

            // Adapter and DataSet
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            dsRestEmployee = new DataSet();

            try
            {
                con.Open();
                adapter.Fill(dsRestEmployee, "tblRegRestEmployee");
                return dsRestEmployee;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Lấy thông tin dập thẻ của nhân viên theo từng ngày làm việc
        /// </summary>
        /// <param name="iEmployeeID">ID nhân viên</param>
        /// <param name="dtWorkingDay">Ngày làm việc</param>
        /// <returns></returns>
        public DataTable GetTimeInTimeOutInDay(int iEmployeeID, DateTime dtWorkingDay)
        {
            con = WorkingContext.GetConnection();
            SqlCommand cmd = new SqlCommand("GetTimeInOutInDay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeID;
            cmd.Parameters.Add(new SqlParameter("@WorkingDay", SqlDbType.DateTime)).Value = dtWorkingDay;

            adapter = new SqlDataAdapter(cmd);
            dsRestEmployee = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(dsRestEmployee, "tblTimeInTimeOut");
                return dsRestEmployee.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Tạo bảng lưu thông tin thời gian vào/ra được quy định
        /// </summary>
        /// <returns></returns>
        private DataTable CreatTableCheckInCheckOut()
        {
            DataTable tblCheckInCheckOutPri = new DataTable();

            tblCheckInCheckOutPri.Columns.Add("CheckIn", typeof(DateTime));
            tblCheckInCheckOutPri.Columns.Add("CheckOut", typeof(DateTime));
            tblCheckInCheckOutPri.Columns.Add("LunchTime", typeof(DateTime));
            tblCheckInCheckOutPri.Columns.Add("ShiftID", typeof(int));

            return tblCheckInCheckOutPri;
        }

        private DataTable CreatTableRest()
        {
            DataTable tblRestPri = new DataTable();

            tblRestPri.Columns.Add("TotalRestRemain", typeof(float));
            tblRestPri.Columns.Add("TotalRestAllow", typeof(float));
            tblRestPri.Columns.Add("TotalRest", typeof(float));

            return tblRestPri;
        }

        /// <summary>
        /// Lấy thời gian vào/ra được quy định theo lịch đăng ký làm việc
        /// </summary>
        /// <param name="iEmployeeIDPara">ID nhân viên</param>
        /// <param name="dtWorkingDayPara">Ngày làm việc</param>
        /// <returns></returns>
        public DataTable GetCheckInCheckOutInDay(int iEmployeeIDPara, DateTime dtWorkingDayPara)
        {
            con = WorkingContext.GetConnection();
            com = new SqlCommand("GetCheckInTime", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Clear();
            com.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeIDPara;
            com.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime)).Value = dtWorkingDayPara;

            adapter = new SqlDataAdapter(com);
            DataTable tblCheckInCheckOutPri = CreatTableCheckInCheckOut();
            try
            {
                con.Open();
                adapter.Fill(tblCheckInCheckOutPri);

                return tblCheckInCheckOutPri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Lấy số phép được hưởng còn lại của nhân viên trong năm
        /// </summary>
        /// <param name="iEmployeeIDPara">ID nhân viên</param>
        /// <param name="iYearPara">Năm tính phép</param>
        /// <param name="iMonthPara">Tháng hiện tại</param>
        /// <returns></returns>
        public DataTable GetRestAllow(int iEmployeeIDPara, int iYearPara, int iMonthPara)
        {
            //float fTotalRestPri = 0.0f;

            con = WorkingContext.GetConnection();
            com = new SqlCommand("GetRestAllowOfEmployee", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Clear();
            com.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeIDPara;
            com.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = iYearPara;
            com.Parameters.Add(new SqlParameter("@CurrentMonth", SqlDbType.Int)).Value = iMonthPara;

            adapter = new SqlDataAdapter(com);
            DataTable tblRestPri = CreatTableRest();
            try
            {
                con.Open();
                adapter.Fill(tblRestPri);

                return tblRestPri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();                
            }            
        }

        /// <summary>
        /// Tính số ngày nghỉ thực tế được đăng ký
        /// </summary>
        /// <param name="iEmployeeIDPara">ID nhân viên</param>
        /// <param name="dtStartRestPara">Ngày bắt đầu nghỉ</param>
        /// <param name="dtEndRestPara">Ngày kết thúc nghỉ</param>
        /// <param name="fNumDayPara">Thời gian nghỉ (sáng/chiều/cả ngày)</param>
        /// <returns></returns>
        public float GetCurrentRest(int iEmployeeIDPara, DateTime dtStartRestPara, DateTime dtEndRestPara, float fNumDayPara)
        {
            float fCurrentRestPri = -1;

            con = WorkingContext.GetConnection();
            com = new SqlCommand("GetCurrentRestOfEmployee", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Clear();
            com.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeIDPara;
            com.Parameters.Add(new SqlParameter("@StartRest", SqlDbType.DateTime)).Value = dtStartRestPara;
            com.Parameters.Add(new SqlParameter("@EndRest", SqlDbType.DateTime)).Value = dtEndRestPara;
            com.Parameters.Add(new SqlParameter("@NumDay", SqlDbType.Float)).Value = fNumDayPara;
            
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                { 
                    fCurrentRestPri = Convert.ToSingle(reader["TotalRest"]);
                }
                reader.Close();

                return fCurrentRestPri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
            finally
            {
                con.Close();
            }
        }


        /// <summary>
        /// Lay ten con cua nhan vien dang ky nghi trong con
        /// </summary>
        /// <param name="regRestID"></param>
        /// <returns></returns>
        public DataSet GetChildName(int regRestID)
        {
            con = WorkingContext.GetConnection();
            // Build the command
            com = new SqlCommand("GetChildName", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter param3 = new SqlParameter("@RegRestID", SqlDbType.Int);
            param3.Value = regRestID;
            com.Parameters.Add(param3);

            // Adapter and DataSet
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            dsRestEmployee = new DataSet();

            try
            {
                con.Open();
                adapter.Fill(dsRestEmployee, "tblChildName");
                return dsRestEmployee;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Các hàm insert/update/delete dữ liệu

        #region Các hàm lưu thông tin đăng ký nghỉ và số ngày đã nghỉ phép
        /// <summary>
        /// Ghi đăng ký nghỉ cho nhân viên vào cơ sở dữ liệu
        /// </summary>
        /// <param name="dsRegRestEmployee">Bảng lưu đăng ký nghỉ</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public int AddRegRestEmployee(DataSet dsRegRestEmployee, SqlTransaction trans)
        {
            com = new SqlCommand("AddRegRestEmployee");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.NVarChar, "EmployeeID"));
            com.Parameters.Add(WorkingContext.CreateParam("@DayID", SqlDbType.Int, "DayID"));
            com.Parameters.Add(WorkingContext.CreateParam("@RestReason", SqlDbType.NVarChar, "RestReason"));
            com.Parameters.Add(WorkingContext.CreateParam("@StartRest", SqlDbType.DateTime, "StartRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@EndRest", SqlDbType.DateTime, "EndRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@TypeRest", SqlDbType.Bit, "TypeRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@NumDay", SqlDbType.Float, "NumDay"));
            com.Parameters.Add(WorkingContext.CreateParam("@NameChild", SqlDbType.NVarChar, "NameChild"));
            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(result);

            com.Transaction = trans;
            com.Connection = trans.Connection;

            adapter = new SqlDataAdapter();
            adapter.InsertCommand = com;

            try
            {
                adapter.Update(dsRegRestEmployee, "tblRegRestEmployee");
                return (int)result.Value;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// Xóa thông tin đăng ký nghỉ của nhân viên
        /// </summary>
        /// <param name="dsRegRestEmployee">Bảng lưu thông tin ĐK nghỉ</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public int DeleteRegRestEmployee(DataSet dsRegRestEmployee, SqlTransaction trans)
        {
            com = new SqlCommand("DeleteRegRestEmployee");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));

            com.Transaction = trans;
            com.Connection = trans.Connection;

            adapter = new SqlDataAdapter();
            adapter.DeleteCommand = com;
            try
            {
                return adapter.Update(dsRegRestEmployee, "tblRegRestEmployee");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// Lưu lại thông tin đăng ký nghỉ phép của nhân viên 
        /// </summary>
        /// <param name="iEmployeeID">EmployeeID</param>
        /// <param name="dtStartRest">Ngày bắt đầu ĐK nghỉ</param>
        /// <param name="dtEndRest">Ngày kết thúc ĐK nghỉ</param>
        /// <param name="fNumDay">Số ngày ĐK nghỉ</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public bool AddRestSheetEmployee(int iEmployeeIDPara, DateTime dtStartRestPara, DateTime dtEndRestPara, DateTime dtCurrentDayPara, float fNumDayPara, float fRestAllowPara, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("AddRestEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeIDPara;
            cmd.Parameters.Add(new SqlParameter("@StartRest", SqlDbType.DateTime)).Value = dtStartRestPara;
            cmd.Parameters.Add(new SqlParameter("@EndRest", SqlDbType.DateTime)).Value = dtEndRestPara;
            cmd.Parameters.Add(new SqlParameter("@CurrentDay", SqlDbType.DateTime)).Value = dtCurrentDayPara;
            cmd.Parameters.Add(new SqlParameter("@NumDay", SqlDbType.Float)).Value = fNumDayPara;
            cmd.Parameters.Add(new SqlParameter("@RestAllow", SqlDbType.Float)).Value = fRestAllowPara;
            try
            {
                cmd.Transaction = trans;
                cmd.Connection = trans.Connection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cập nhật ngày nghỉ bảng thanh toán tiền  phép khi thay đổi thông tin ĐK nghỉ
        /// </summary>
        /// <param name="iEmployeeID">EmployeeID</param>
        /// <param name="bUpdateStartRest">Ngày bắt đầu ĐK nghỉ trước update</param>
        /// <param name="bUpdateEndRest">Ngày kết thúc ĐK nghỉ trước update</param>
        /// <param name="aUpdateStartRest">Ngày bắt đầu ĐK nghỉ sau update</param>
        /// <param name="aUpdateEndRest">Ngày kết thúc ĐK nghỉ sau update</param>
        /// <param name="bUpdateCurrentDay">Ngày bắt đầu tính nghỉ trước update</param>
        /// <param name="aUpdateCurrentDay">Ngày bắt đầu tính nghỉ sau update</param>
        /// <param name="bUpdateDayId">Kiểu ngày ĐK nghỉ trước update</param>
        /// <param name="aUpdateDayId">Kiểu ngày DDK nghỉ sau update</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public bool UpdateRestSheetEmployee(int iEmployeeID, DateTime bUpdateStartRest, DateTime bUpdateEndRest, DateTime aUpdateStartRest,
            DateTime aUpdateEndRest, DateTime bUpdateCurrentDay, DateTime aUpdateCurrentDay, int bUpdateDayId, int aUpdateDayId, float fRestAllowPara, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("UpdateRestSheetEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeID;
            cmd.Parameters.Add(new SqlParameter("@bUpdateStartRest", SqlDbType.DateTime)).Value = bUpdateStartRest;
            cmd.Parameters.Add(new SqlParameter("@bUpdateEndRest", SqlDbType.DateTime)).Value = bUpdateEndRest;
            cmd.Parameters.Add(new SqlParameter("@aUpdateStartRest", SqlDbType.DateTime)).Value = aUpdateStartRest;
            cmd.Parameters.Add(new SqlParameter("@aUpdateEndRest", SqlDbType.DateTime)).Value = aUpdateEndRest;
            cmd.Parameters.Add(new SqlParameter("@bUpdateCurrentDay", SqlDbType.DateTime)).Value = bUpdateCurrentDay;
            cmd.Parameters.Add(new SqlParameter("@aUpdateCurrentDay", SqlDbType.DateTime)).Value = aUpdateCurrentDay;
            cmd.Parameters.Add(new SqlParameter("@bUpdateDayId", SqlDbType.Int)).Value = bUpdateDayId;
            cmd.Parameters.Add(new SqlParameter("@aUpdateDayId", SqlDbType.Int)).Value = aUpdateDayId;
            cmd.Parameters.Add(new SqlParameter("@RestAllow", SqlDbType.Float)).Value = fRestAllowPara;
            try
            {
                cmd.Transaction = trans;
                cmd.Connection = trans.Connection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cập nhật lại số ngày nghỉ phép trong bảng thanh toán tiền phép khi xóa thông tin ĐK nghỉ phép
        /// </summary>
        /// <param name="iEmployeeID">EmployeeID</param>
        /// <param name="dtStartRest">Ngày bắt đầu ĐK</param>
        /// <param name="dtEndRest">Ngày kết thúc ĐK</param>
        /// <param name="dtCurrentDay">Ngày bắt đầu tính nghỉ</param>
        /// <param name="iDayId">Kiểu ngày nghỉ</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public bool UpdateRestSheetEmployee(int iEmployeeID, DateTime dtStartRest, DateTime dtEndRest, DateTime dtCurrentDay, int iDayId, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("DeleteRestSheetEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeID;
            cmd.Parameters.Add(new SqlParameter("@StartRest", SqlDbType.DateTime)).Value = dtStartRest;
            cmd.Parameters.Add(new SqlParameter("@EndRest", SqlDbType.DateTime)).Value = dtEndRest;
            cmd.Parameters.Add(new SqlParameter("@CurrentDay", SqlDbType.DateTime)).Value = dtCurrentDay;
            cmd.Parameters.Add(new SqlParameter("@DayId", SqlDbType.Int)).Value = iDayId;
            try
            {
                cmd.Transaction = trans;
                cmd.Connection = trans.Connection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// cập nhật đăng ký nghỉ
        /// </summary>
        /// <param name="RegRestEmployee">Bảng lưu ĐK nghỉ</param>
        /// <param name="trans">Transaction</param>
        /// <returns></returns>
        public int UpdateRegRestEmployee(DataSet RegRestEmployee, SqlTransaction trans)
        {
            com = new SqlCommand("UpdateRegRestEmployee");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));
            com.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            com.Parameters.Add(WorkingContext.CreateParam("@DayID", SqlDbType.Int, "DayID"));
            com.Parameters.Add(WorkingContext.CreateParam("@RestReason", SqlDbType.NVarChar, "RestReason"));
            com.Parameters.Add(WorkingContext.CreateParam("@StartRest", SqlDbType.DateTime, "StartRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@EndRest", SqlDbType.DateTime, "EndRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@TypeRest", SqlDbType.Bit, "TypeRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@NumDay", SqlDbType.Float, "NumDay"));
            com.Parameters.Add(WorkingContext.CreateParam("@NameChild", SqlDbType.NVarChar, "NameChild"));
            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(result);

            com.Transaction = trans;
            com.Connection = trans.Connection;

            adapter = new SqlDataAdapter();
            adapter.UpdateCommand = com;
            try
            {
                adapter.Update(RegRestEmployee, "tblRegRestEmployee");
                return (int)result.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }
        #endregion

        #region Cũ
        /// <summary>
        /// Ghi đăng ký nghỉ cho nhân viên vào cơ sở dữ liệu
        /// </summary>
        /// <param name="dsRegRestEmployee"></param>
        /// <returns></returns>
        public int AddRegRestEmployee(DataSet dsRegRestEmployee)
        {
            con = WorkingContext.GetConnection();
            com = new SqlCommand("AddRegRestEmployee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.NVarChar, "EmployeeID"));
            com.Parameters.Add(WorkingContext.CreateParam("@DayID", SqlDbType.Int, "DayID"));
            com.Parameters.Add(WorkingContext.CreateParam("@RestReason", SqlDbType.NVarChar, "RestReason"));
            com.Parameters.Add(WorkingContext.CreateParam("@StartRest", SqlDbType.DateTime, "StartRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@EndRest", SqlDbType.DateTime, "EndRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@TypeRest", SqlDbType.Bit, "TypeRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@NumDay", SqlDbType.Float, "NumDay"));
            com.Parameters.Add(WorkingContext.CreateParam("@NameChild", SqlDbType.NVarChar, "NameChild"));
            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(result);

            adapter = new SqlDataAdapter();
            adapter.InsertCommand = com;

            try
            {
                con.Open();
                adapter.Update(dsRegRestEmployee, "tblRegRestEmployee");
                return (int)result.Value;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

        }

        /// <summary>
        ///  xóa đăng ký nghỉ của nhân viên
        /// </summary>
        /// <param name="dsRegRestEmployee"></param>
        /// <returns></returns>
        public int DeleteRegRestEmployee(DataSet dsRegRestEmployee)
        {

            SqlConnection conn = WorkingContext.GetConnection();
            com = new SqlCommand("DeleteRegRestEmployee", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));

            adapter = new SqlDataAdapter();
            adapter.DeleteCommand = com;
            try
            {
                conn.Open();
                return adapter.Update(dsRegRestEmployee, "tblRegRestEmployee");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }

            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// cập nhật đăng ký nghỉ
        /// </summary>
        /// <param name="RegRestEmployee"></param>
        /// <returns></returns>
        public int UpdateRegRestEmployee(DataSet RegRestEmployee)
        {
            con = WorkingContext.GetConnection();
            com = new SqlCommand("UpdateRegRestEmployee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));
            com.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            com.Parameters.Add(WorkingContext.CreateParam("@DayID", SqlDbType.Int, "DayID"));
            com.Parameters.Add(WorkingContext.CreateParam("@RestReason", SqlDbType.NVarChar, "RestReason"));
            com.Parameters.Add(WorkingContext.CreateParam("@StartRest", SqlDbType.DateTime, "StartRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@EndRest", SqlDbType.DateTime, "EndRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@TypeRest", SqlDbType.Bit, "TypeRest"));
            com.Parameters.Add(WorkingContext.CreateParam("@NumDay", SqlDbType.Float, "NumDay"));
            com.Parameters.Add(WorkingContext.CreateParam("@NameChild", SqlDbType.NVarChar, "NameChild"));
            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(result);
            adapter = new SqlDataAdapter();
            adapter.UpdateCommand = com;
            try
            {
                con.Open();
                adapter.Update(RegRestEmployee, "tblRegRestEmployee");
                return (int)result.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

        }
        #endregion
        #endregion
    }
}