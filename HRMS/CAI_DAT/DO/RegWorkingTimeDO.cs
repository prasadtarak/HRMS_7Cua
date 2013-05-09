using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for RegWorkingTimeDO.
	/// </summary>
	public class RegWorkingTimeDO
	{
		/// <summary>
		/// Lấy thông tin đăng ký lịch làm việc theo tháng của từng nhân viên
		/// </summary>
		/// <param name="EmployeeID"></param>
		/// <param name="Month"></param>
		/// <param name="Year"></param>
		/// <returns></returns>
		public DataSet GetWorkingTimeByMonth(int EmployeeID, int Month, int Year)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetWorkingTimeByMonth", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
			sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetWorkingTimeByMonth");
				return dataSet;
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}

        /// <summary>
        /// Lấy thông tin đăng ký lịch làm thêm theo tháng của từng nhân viên
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public DataSet GetOverTimeByMonth(int EmployeeID, int Month, int Year)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetOverTimeByMonth", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
            sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();
            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetOverTimeByMonth");
                return dataSet;
            }
            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
                return null;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }

		
		/// <summary>
		/// Lấy thông tin đăng ký lịch làm việc theo tháng của từng phòng ban
		/// </summary>
		/// <param name="departmentID"></param>
		/// <param name="Month"></param>
		/// <param name="Year"></param>
		/// <returns></returns>
		public DataSet GetDepartmentWorkingTimeByMonth(int departmentID, int Month, int Year)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetDepartmentWorkingTimeByMonth", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
			sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
			sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetDepartmentWorkingTimeByMonth");
				return dataSet;
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}
		/// <summary>
		/// Thêm thời gian làm việc theo nhan vien
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int AddWorkingTime(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("AddWorkingTime", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day", SqlDbType.DateTime, "Day"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeSheet", SqlDbType.Float, "TimeSheet"));
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;
 
			try
			{
				conn.Open();
				return dataAdapter.Update(dataSet.Tables[0]);
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return 0;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}
		/// <summary>
		/// Cập nhật thời gian làm việc theo nhan vien
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateWorkingTime(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateWorkingTime", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingTimeID", SqlDbType.Int, "WorkingTimeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day", SqlDbType.DateTime, "Day"));
           	sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeSheet", SqlDbType.Float, "TimeSheet"));
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;
 
			try
			{
				conn.Open();
				return dataAdapter.Update(dataSet.Tables[0]);
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return 0;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}

		/// <summary>
		/// Xóa đăng ký thời gian làm việc
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int DeleteWorkingTime(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteWorkingTime", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingTimeID", SqlDbType.Int, "WorkingTimeID"));
 
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.DeleteCommand = sqlCommand;
 
			try
			{
				conn.Open();
				return dataAdapter.Update(dataSet.Tables[0]);
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return 0;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}
	}
}
