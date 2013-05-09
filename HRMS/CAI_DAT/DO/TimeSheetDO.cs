using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for TimeSheetDO.
	/// </summary>
	public class TimeSheetDO
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ToDate"></param>
		/// <returns></returns>
		public DataSet GetTimeSheet(DateTime ToDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetTimeSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@ToDate", ToDate));

			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetTimeSheet");
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
		/// 
		/// </summary>
		/// <param name="DepartmentID"></param>
		/// <param name="Month"></param>
		/// <param name="Year"></param>
		/// <returns></returns>
		public DataSet GetDepartmentTimeSheet(int Month, int Year, int DepartmentID)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetDepartmentTimeSheet", conn);
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
				dataAdapter.Fill(dataSet, "GetDepartmentTimeSheet");
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
		/// Sinh bảng chấm công
		/// </summary>
		/// <param name="Month">Tháng</param>
		/// <param name="Year">Năm</param>
		/// <param name="EmployeeID">Mã nhân viên</param>
		/// <returns></returns>
		public int GenerateTimeSheet(int Month, int Year, int EmployeeID)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
            SqlCommand sqlCommand = new SqlCommand("GenerateTimeSheet_7Cua", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 600;

			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
			sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
			sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));
 
			try
			{
				conn.Open();
				sqlCommand.ExecuteNonQuery();
                return 1;
			}
			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return -1;
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
		/// <param name="Month"></param>
		/// <param name="Year"></param>
		/// <param name="EmployeeID"></param>
		/// <returns></returns>
		public int GenerateEmployeeSummaryInMonth(int Month, int Year, int EmployeeID)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GenerateEmployeeSummaryInMonth", conn);
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
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateTimeSheet(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateTimeSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Month", SqlDbType.Int, "Month"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Year", SqlDbType.Int, "Year"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime", SqlDbType.Int, "OverTime"));
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
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Total", SqlDbType.Float, "Total"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime1", SqlDbType.Float, "OverTime1"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime2", SqlDbType.Float, "OverTime2"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime3", SqlDbType.Float, "OverTime3"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime4", SqlDbType.Float, "OverTime4"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.VarChar, "Note"));
 
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

		public int DeleteTimeSheet(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteTimeSheet", conn);
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
        public void UpdateTimeSheetChange(int Year,int month,int type,int EmployeeID,string day,string OldValue,string Newvalue,string Description)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateTimeSheetChange", conn);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.Add("@Year", SqlDbType.Int).Value = Year;
            sqlCommand.Parameters.Add("@Month", SqlDbType.Int).Value = month;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeID;
            sqlCommand.Parameters.Add("@Type", SqlDbType.SmallInt).Value = type;
            sqlCommand.Parameters.Add("@OldValue", SqlDbType.NVarChar).Value = OldValue;
            sqlCommand.Parameters.Add("@NewValue", SqlDbType.NVarChar).Value = Newvalue;
            sqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = Description;
            sqlCommand.Parameters.Add("@Day", SqlDbType.NVarChar).Value = day.Trim();
           
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
              

            }
            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }
        public DataSet GetTimeSetChange(int Year,int Month,int EmployeeID,int Type)
        {
            DataSet Result = new DataSet();
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetTimeSheetChange", conn);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.Add("@Year", SqlDbType.Int).Value = Year;
            sqlCommand.Parameters.Add("@Month", SqlDbType.Int).Value = Month;
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeID;
            sqlCommand.Parameters.Add("@Type", SqlDbType.Int).Value = Type;
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                dataAdapter.Fill(Result);
                return Result;               
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
	}
}
			