using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for StatusDO.
	/// </summary>
	public class StatusDO
	{
		/// <summary>
		/// Lấy thông tin trạng thái nhân viên
		/// </summary>
		/// <param name="DepartmentID">Mã phòng ban</param>
		/// <param name="Date">Ngày kiểm tra</param>
		/// <returns></returns>
		public DataSet GetEmployeeStatus(int DepartmentID, DateTime Date, int Order, int PageIndex, int PageSize)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetEmployeeStatus", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", DepartmentID));
			sqlCommand.Parameters.Add(new SqlParameter("@Date", Date));
			sqlCommand.Parameters.Add(new SqlParameter("@Order", Order));
			sqlCommand.Parameters.Add(new SqlParameter("@PageIndex", PageIndex));
			sqlCommand.Parameters.Add(new SqlParameter("@PageSize", PageSize));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetEmployeeStatus");
				return dataSet;
			}
			catch(Exception oException)
			{
                MessageBox.Show("SqlException: Timeout expired.", "Message");
				return null;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}
		}
		/// <summary>
		/// Lấy thông tin giờ đầu ca đăng ký lịch làm việc của nhân viên theo ngày
		/// </summary>
		/// <param name="EmployeeID"></param>
		/// <param name="workingDay"></param>
		/// <returns></returns>
		public DataSet GetCheckInTime(int EmployeeID, DateTime workingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetCheckInTime", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@Date", workingDay));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetCheckInTime");
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
		/// Lấy thông tin tổng hợp trạng thái của nhân viên
		/// </summary>
		/// <param name="departmentID"></param>
		/// <param name="workingDay"></param>
		/// <returns></returns>
	
		public DataSet GetEmployeeStatusStatistics(int departmentID, DateTime workingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetEmployeeStatusStatistics", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
			sqlCommand.Parameters.Add(new SqlParameter("@Date", workingDay));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetEmployeeStatusStatistics");
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
		/// Lay tong trang  thai cua toan cong ty
		/// </summary>
		/// <returns></returns>
		public DataSet GetEmployeeStatusInDay(int departmentID,DateTime workingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetEmployeeStatusInDay", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			
			sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", departmentID));
			sqlCommand.Parameters.Add(new SqlParameter("@Date", workingDay));
			
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetEmployeeStatusInDay");
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
		/// Lấy tên viết tắt kiểu ngày nghỉ mà nhân viên đã đăng ký nghỉ theo ngày
		/// </summary>
		/// <param name="EmployeeID"></param>
		/// <param name="workingDay"></param>
		/// <returns></returns>
		public DataSet GetDayShortNameByEmployeeRest(int EmployeeID, DateTime workingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetDayShortNameByEmployeeRest", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@Date", workingDay));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetDayShortNameByEmployeeRest");
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
		/// Lấy thông tin đăng ký công tác của nhân viên trong ngày
		/// </summary>
		/// <param name="EmployeeID">Mã nhân viên</param>
		/// <param name="StartDate">Ngày kiểm tra</param>
		/// <param name="EndDate">Ngày kiểm tra</param>
		/// <returns></returns>
		public int GetEmployeeLeaveStatus(int EmployeeID, DateTime StartDate, DateTime EndDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			SqlCommand sqlCommand = new SqlCommand("GetEmployeeLeaveStatus", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@StartDate", StartDate));
			sqlCommand.Parameters.Add(new SqlParameter("@EndDate", EndDate));

			SqlParameter returnValue = sqlCommand.Parameters.Add("@ReturnValue", SqlDbType.Int);
			returnValue.Direction = ParameterDirection.ReturnValue;
			//sqlCommand.Parameters.Add(returnValue);

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetEmployeeLeaveStatus");
				return (Int32)returnValue.Value;
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
		/// Lấy thông tin đăng ký nghỉ của nhân viên trong ngày
		/// </summary>
		/// <param name="EmployeeID">Mã nhân viên</param>
		/// <param name="StartDate">Ngày kiểm tra</param>
		/// <param name="EndDate">Ngày kiểm tra</param>
		/// <returns></returns>
		public int GetEmployeeRestStatus(int EmployeeID, DateTime StartDate, DateTime EndDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			SqlCommand sqlCommand = new SqlCommand("GetEmployeeRestStatus", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@StartDate", StartDate));
			sqlCommand.Parameters.Add(new SqlParameter("@EndDate", EndDate));
			SqlParameter returnValue = sqlCommand.Parameters.Add("@ReturnValue", SqlDbType.Int);
			returnValue.Direction = ParameterDirection.ReturnValue;

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetEmployeeRestStatus");
				return (Int32)returnValue.Value;
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
	}
}
