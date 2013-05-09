//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for RegOverTime.
	/// </summary>
	public class RegOverTimeDO
	{
		SqlConnection conn = null;
		SqlCommand sqlCommand = null;
		//		SqlParameter param = null;
		SqlDataAdapter dadapter = null;
		DataSet ds = null;
//		private System.Data.SqlClient.SqlParameter param = null;
		public RegOverTimeDO()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// Danh sách nhân viên làm thêm giờ them phòng ban và ngày
		/// </summary>
		/// <param name="WorkingDay"></param>
		/// <param name="DepartmentID"></param>
		/// <returns></returns>
		public DataSet GetRegOverTime(DateTime WorkingDay, int DepartmentID)
		{
			conn = WorkingContext.GetConnection();
			// Build the command
			sqlCommand = new SqlCommand("GetRegOverTime", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter param1 = new SqlParameter("@WorkingDay",SqlDbType.DateTime);
			param1.Value = WorkingDay.ToShortDateString();
			sqlCommand.Parameters.Add(param1);

			SqlParameter param2 = new SqlParameter("@DepartmentID",SqlDbType.Int);
			param2.Value = DepartmentID;
			sqlCommand.Parameters.Add(param2);

			// Adapter and DataSet
			dadapter= new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;
			ds = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(ds,"tblRegOverTime");
				return ds;
			}

			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
			finally
			{
				conn.Close();
			}
		}
		
		/// <summary>
		/// Đăng ký làm thêm giờ cho nhân viên
		/// </summary>
		/// <param name="dsRegOverTime"></param>
		/// <returns></returns>
		public int AddRegOverTime(DataSet dsRegOverTime)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("AddRegOverTime",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID",SqlDbType.NVarChar,"EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartOverTime",SqlDbType.DateTime,"StartOverTime"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerAmount",SqlDbType.Int,"DinnerAmount"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay",SqlDbType.DateTime,"WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Length",SqlDbType.DateTime,"Length"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkOverTimeInfo",SqlDbType.NVarChar,"WorkOverTimeInfo"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			
			dadapter = new SqlDataAdapter();
			dadapter.InsertCommand = sqlCommand;
			
			try
			{
				conn.Open();
				dadapter.Update(dsRegOverTime.Tables[0]);
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
		/// Cập nhật đăng ký làm thêm giờ
		/// </summary>
		/// <param name="dsRegOverTime"></param>
		/// <returns></returns>
		public int UpdateRegOverTime(DataSet dsRegOverTime)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("UpdateRegOverTime",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RegOverTimeID",SqlDbType.Int,"RegOverTimeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID",SqlDbType.Int,"EmployeeID"));
			//@EmployeeID - bien' trong store procedure, EmployeeID- cot trong dataset
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartOverTime",SqlDbType.DateTime,"StartOverTime"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerAmount",SqlDbType.Int,"DinnerAmount"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay",SqlDbType.DateTime,"WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Length",SqlDbType.DateTime,"Length"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkOverTimeInfo",SqlDbType.NVarChar,"WorkOverTimeInfo"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dadapter = new SqlDataAdapter();
			dadapter.UpdateCommand = sqlCommand;
			try
			{
				conn.Open();
				dadapter.Update(dsRegOverTime.Tables[0]);
				return (int)result.Value;
			}
			catch (Exception ex)
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
		/// Xóa đăng ký làm thêm giờ
		/// </summary>
		/// <param name="dsRegOverTime"></param>
		/// <returns></returns>
		public int DeleteRegOverTime(DataSet dsRegOverTime)
		{
			
			SqlConnection conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("DeleteRegOverTime",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RegOverTimeID",SqlDbType.Int,"RegOverTimeID"));

			dadapter = new SqlDataAdapter();
			dadapter.DeleteCommand = sqlCommand;
			try
			{
				conn.Open();
				return dadapter.Update(dsRegOverTime, "tblRegOverTime");
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
