using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for LunchDO.
	/// </summary>
	public class LunchDO
	{

		public LunchDO()
		{
			
		}
        SqlConnection conn = null;

        SqlCommand sqlCommand = null;
        SqlDataAdapter dataAdapter = null;
        public int AddLunch(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("AddLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchMoney", SqlDbType.Money, "LunchMoney"));
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
			/// Them nhung nhan vien chua co trong bang tblLunch
			/// </summary>
			/// <param name="workingDay"></param>
			/// <returns></returns>
			public int ImportEmployeeToLunch(DateTime workingDay)
			{
				SqlConnection conn = WorkingContext.GetConnection();
				conn.Open();
				SqlCommand command = new SqlCommand("ImportEmployeeToLunch", conn);
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter param = new SqlParameter("@WorkingDay", SqlDbType.DateTime);
				param.Value = workingDay;
				command.Parameters.Add(param);
            
				SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
				result.Direction = ParameterDirection.ReturnValue;
				command.Parameters.Add(result);
				try
				{
					command.ExecuteNonQuery();
					return Convert.ToInt32(result.Value);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return -1;
				}
				finally
				{
					conn.Dispose();
					conn.Close();
				}
			}
	
		/// <summary>
		/// Lấy về danh sách nhân viên, số tiền đăng ký ăn trưa theo phòng ban
		/// </summary>
		/// <param name="DepartmentID"></param>
		/// <returns></returns>
		public DataSet GetLunch(int DepartmentID, DateTime WorkingDay)
		{
			SqlConnection conn  = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
		
			SqlParameter param1 = new SqlParameter("@DepartmentID",SqlDbType.Int);
			param1.Value = DepartmentID;
			sqlCommand.Parameters.Add(param1);

			SqlParameter param2 = new SqlParameter("@WorkingDay",SqlDbType.DateTime);
			param2.Value = WorkingDay;
			sqlCommand.Parameters.Add(param2);

			// Adapter and DataSet
			SqlDataAdapter dadapter= new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			DataSet ds = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(ds,"tblLunch");
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
		/// Cập nhật đăng ký ăn trưa
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateLunch(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpDateLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchID", SqlDbType.Int, "LunchID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchMoney", SqlDbType.Money, "LunchMoney"));
 
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;
 
			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
        public void AddLunchAuto(int EmployeeID,DateTime WorkingDay,Decimal LunchMoney)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("AddLunchAuto", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@WorkingDay", SqlDbType.DateTime).Value = WorkingDay;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeID;
            sqlCommand.Parameters.Add("@LunchMoney", SqlDbType.Money).Value = LunchMoney;
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


		//----------------------------------------------------------------------------
		//Purpose	: 
		//Input		: 
		//Output	: 
		//----------------------------------------------------------------------------
		public int DeleteLunch(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchID", SqlDbType.Int, "LunchID"));
 
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
		
		/// <summary>
		/// Chuyển dữ liệu từ một ngày đã đăng ký ăn trưa sang ngày hiện tại
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int CopyFromPreviousLunch(DataSet dataSet, DateTime PreviousWorkingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("CopyFromPreviousLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter param1 = new SqlParameter("@PreviousWorkingDay",SqlDbType.DateTime);
			param1.Value = PreviousWorkingDay.ToShortDateString();
			sqlCommand.Parameters.Add(param1);
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchID", SqlDbType.Int, "LunchID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;
 
			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		/// 
		/// </summary>
		/// <param name="dataSet"></param>
		/// <param name="PreviousWorkingDay"></param>
		/// <returns></returns>
		public int UpdateFromPreviousLunch(DataSet dataSet, DateTime PreviousWorkingDay)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateFromPreviousLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter param1 = new SqlParameter("@PreviousWorkingDay",SqlDbType.DateTime);
			param1.Value = PreviousWorkingDay.ToShortDateString();
			sqlCommand.Parameters.Add(param1);
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchID", SqlDbType.Int, "LunchID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;
 
			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		/// Sinh bảng chấm công
		/// </summary>
		/// <param name="Month">Tháng</param>
		/// <param name="Year">Năm</param>
		/// <param name="EmployeeID">Mã nhân viên</param>
		/// <returns></returns>
		public int GenerateLunchSheet(int Month, int Year, int EmployeeID)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GenerateLunchSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
			sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));
 
			try
			{
				conn.Open();
				return sqlCommand.ExecuteNonQuery();
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
		/// 
		/// </summary>
		/// <param name="DepartmentID"></param>
		/// <param name="Month"></param>
		/// <param name="Year"></param>
		/// <returns></returns>
		public DataSet GetDepartmentLunchSheet(int Month, int Year, int DepartmentID)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetDepartmentLunchSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
			sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));
			sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", DepartmentID));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetDepartmentLunchSheet");
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
		/// Cập nhật bảng ăn trưa tháng
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateLunchSheet(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateLunchSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Month", SqlDbType.Int, "Month"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Year", SqlDbType.Int, "Year"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day1", SqlDbType.VarChar, "Day1"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day2", SqlDbType.VarChar, "Day2"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day3", SqlDbType.VarChar, "Day3"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day4", SqlDbType.VarChar, "Day4"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day5", SqlDbType.VarChar, "Day5"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day6", SqlDbType.VarChar, "Day6"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day7", SqlDbType.VarChar, "Day7"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day8", SqlDbType.VarChar, "Day8"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day9", SqlDbType.VarChar, "Day9"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day10", SqlDbType.VarChar, "Day10"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day11", SqlDbType.VarChar, "Day11"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day12", SqlDbType.VarChar, "Day12"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day13", SqlDbType.VarChar, "Day13"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day14", SqlDbType.VarChar, "Day14"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day15", SqlDbType.VarChar, "Day15"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day16", SqlDbType.VarChar, "Day16"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day17", SqlDbType.VarChar, "Day17"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day18", SqlDbType.VarChar, "Day18"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day19", SqlDbType.VarChar, "Day19"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day20", SqlDbType.VarChar, "Day20"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day21", SqlDbType.VarChar, "Day21"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day22", SqlDbType.VarChar, "Day22"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day23", SqlDbType.VarChar, "Day23"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day24", SqlDbType.VarChar, "Day24"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day25", SqlDbType.VarChar, "Day25"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day26", SqlDbType.VarChar, "Day26"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day27", SqlDbType.VarChar, "Day27"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day28", SqlDbType.VarChar, "Day28"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day29", SqlDbType.VarChar, "Day29"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day30", SqlDbType.VarChar, "Day30"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Day31", SqlDbType.VarChar, "Day31"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalPaidLunch", SqlDbType.Float, "TotalPaidLunch"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalNormalLunch", SqlDbType.Float, "TotalNormalLunch"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalOverTimeLunch", SqlDbType.Float, "TotalOverTimeLunch"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalAllowance", SqlDbType.Float, "TotalAllowance"));
 
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

		public int DeleteEmployeeLunch(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeLunch", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Month", SqlDbType.Int, "Month"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Year", SqlDbType.Int, "Year"));
 
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
