//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 
//Note	    :		  
//Author	: vietht
//Modify	: Chinhnd sửa một số method sang store Procedure
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for LeaveScheduleDO.
	/// </summary>
	public class LeaveScheduleDO
	{
		SqlConnection conn = null;
		SqlCommand sqlCommand = null;
		//		SqlParameter param = null;
		SqlDataAdapter dadapter = null;
		DataSet dataSet = null;

		//----------------------------------------------------------------------------
		//Purpose	: 
		//Input		: 
		//Output	: 
		//----------------------------------------------------------------------------
//		private System.Data.SqlClient.SqlParameter param = null;

		/// <summary>
		/// Lấy về danh sách nhân viên đã đăng ký lịch công tác
		/// </summary>
		/// <returns></returns>
		public DataSet getLeaveSchedule()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "SELECT LeaveID,EmployeeID,LeaveLocation,WorkInfo,StartLeave,EndLeave FROM tblLeaveSchedule";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			SqlDataAdapter dataAdapter= new SqlDataAdapter();
			dataAdapter.SelectCommand=sqlCommand;
			DataSet dataSet = new DataSet();

			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet,"tblLeaveSchedule");
				return dataSet;   
			}

			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally      
			{
				conn.Close();
			}       

		}
		/// <summary>
		/// Thêm lịch công tác cho một nhân viên
		/// </summary>
		/// <param name="dsLeaveSchedule"></param>
		/// <returns></returns>
		public int AddLeaveSchedule(DataSet dsLeaveSchedule)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("AddLeaveSchedule",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID",SqlDbType.Int,"EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LeaveLocation",SqlDbType.NVarChar,"LeaveLocation"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkInfo",SqlDbType.NVarChar,"WorkInfo"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartLeave",SqlDbType.DateTime,"StartLeave"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EndLeave",SqlDbType.DateTime,"EndLeave"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);
			dadapter = new SqlDataAdapter();
			dadapter.InsertCommand = sqlCommand;
			
			try
			{
				conn.Open();
				dadapter.Update(dsLeaveSchedule.Tables[0]);			
				return (int)result.Value;
			}
			catch (Exception ex)
			{
				//				throw ex;
				MessageBox.Show(ex.ToString());
				return 0;
			}
			finally      
			{
				conn.Dispose();
				conn.Close();
			}  
			
		}
		/// <summary>
		/// Cập nhật thông về lịch công tác của một nhân viên
		/// </summary>
		/// <param name="dsLeaveSchedule"></param>
		/// <returns></returns>
		public int UpdateLeaveSchedule(DataSet dsLeaveSchedule)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("UpdateLeaveSchedule",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LeaveID",SqlDbType.Int,"LeaveID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID",SqlDbType.Int,"EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LeaveLocation",SqlDbType.NVarChar,"LeaveLocation"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkInfo",SqlDbType.NVarChar,"WorkInfo"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartLeave",SqlDbType.DateTime,"StartLeave"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EndLeave",SqlDbType.DateTime,"EndLeave"));
			SqlParameter result = new SqlParameter("ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);
			dadapter = new SqlDataAdapter();
			dadapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				dadapter.Update(dsLeaveSchedule.Tables[0]);
				return (int)result.Value;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0;
				
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}
		/// <summary>
		/// Lấy tất cả các nhân viên đi công tác trong khoảng  ngày cho trước
		/// </summary>
		/// <param name="dtpFrom">ngày đầu</param>
		/// <param name="dtpTo">ngày cuối</param>
		/// <param name="DepartmentID">mã phòng</param>
		/// <returns>Dataset</returns>

		public DataSet GetListLeaveSchedule(DateTime dtpFrom,DateTime dtpTo,int DepartmentID)
		{

			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("GetListLeaveSchedule",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			
			SqlParameter para1 = new SqlParameter("@dtpFrom",SqlDbType.DateTime);
			para1.Value = dtpFrom.Date;
			sqlCommand.Parameters.Add(para1);

			SqlParameter para2 = new SqlParameter("@dtpEnd",SqlDbType.DateTime);
			para2.Value = dtpTo.Date;
			sqlCommand.Parameters.Add(para2);

			SqlParameter para3 = new SqlParameter("@DepartmentID",SqlDbType.Int);
			para3.Value = DepartmentID;
			sqlCommand.Parameters.Add(para3);

			dadapter = new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			dataSet = new DataSet();
			try
			{
				conn.Open();
				dadapter.Fill(dataSet,"tblLeaveSchedule");
				return dataSet;   
			}

			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally      
			{
				conn.Close();
			}       

		}

		/// <summary>
		/// Xóa lịch công tác
		/// </summary>
		/// <param name="dsLeaveSchedule"></param>
		/// <returns></returns>
		public int DeleteLeaveSchedule(DataSet dsLeaveSchedule)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("DeleteLeaveSchedule",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LeaveID",SqlDbType.Int,"LeaveID"));

			dadapter = new SqlDataAdapter();
			dadapter.DeleteCommand = sqlCommand;
			try
			{
				conn.Open();
				return dadapter.Update(dsLeaveSchedule, "tblLeaveSchedule");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0;
			}

			finally
			{
				conn.Close();
			}
			
		}

	}
}
