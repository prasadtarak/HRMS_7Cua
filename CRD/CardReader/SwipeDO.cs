using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CardReader
{
	public class SwipeDO
	{
		public static string connectionString;

		private string strSQL = "";

		private SqlConnection conn = null;
		private SqlCommand sqlCommand = null;
		private SqlDataAdapter dataAdapter = null;
		
		private DataSet dataSet = null;

		/// <summary>
		/// Retreives all employee info.
		/// </summary>
		/// <param name="CardID"></param>
		/// <returns>DataSet containing the employee info.</returns>
		public DataSet GetEmployeeInfo(string CardID)
		{
			conn = Utils.getConnection();

			// Build the command
			strSQL = "SELECT tblEmployee.EmployeeID, tblEmployee.EmployeeName, tblEmployee.CardID, tblEmployee.Picture, tblDepartment.DepartmentName ";
			strSQL += " FROM tblEmployee INNER JOIN tblDepartment on tblEmployee.DepartmentID = tblDepartment.DepartmentID WHERE tblEmployee.CardID = '" + CardID + "'";

			sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			dataAdapter = new SqlDataAdapter(sqlCommand);
			dataAdapter.SelectCommand = sqlCommand;
			dataSet = new DataSet();

			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "tblEmployee");
				return dataSet;
			}
			catch (Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally
			{
				conn.Close();
			}
		}

        public DataSet GetEmployeeInfoByBarCode(string BarCodeID)
        {
            conn = Utils.getConnection();

            // Build the command
            strSQL = "SELECT tblEmployee.EmployeeID, tblEmployee.EmployeeName, tblEmployee.CardID, tblEmployee.Picture, tblDepartment.DepartmentName ";
            strSQL += " FROM tblEmployee INNER JOIN tblDepartment on tblEmployee.DepartmentID = tblDepartment.DepartmentID WHERE tblEmployee.BarCode = '" + BarCodeID + "'";

            sqlCommand = new SqlCommand(strSQL, conn);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "tblEmployee");
                return dataSet;
            }
            catch (SqlException oException)
            {
                Console.WriteLine(oException.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet GetAllUser()
        {
            conn = Utils.getConnection();

            // Build the command
            strSQL = "SELECT tblUser.UserID ";
            strSQL += " FROM tblUser";

            sqlCommand = new SqlCommand(strSQL, conn);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "tblUser");
                return dataSet;
            }
            catch (SqlException oException)
            {
                Console.WriteLine(oException.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

		/// <summary>
		/// Lưu dữ liệu về thời gian vào ra của nhân viên
		/// </summary>
		/// <param name="WorkingDay"></param>
		/// <param name="EmployeeID"></param>
		/// <param name="TimeInOut"></param>
		/// <param name="TimeIn"></param>
		/// <returns></returns>
		public int SaveCardData(DateTime WorkingDay, int EmployeeID, string TimeInOut, string TimeIn)
		{
			System.DateTime timeIn = new System.DateTime();
			System.DateTime timeOut = new System.DateTime();
			//			System.TimeSpan inOut = new TimeSpan();
			int Delay = 0;
			conn = Utils.getConnection();
			if (TimeIn.Equals(""))
			{
				strSQL = "INSERT INTO tblTimeInTimeOut(WorkingDay, EmployeeID, TimeIn) VALUES(@WorkingDay,@EmployeeID,@TimeInOut)";
				
			}
			else
			{
				timeIn = DateTime.Parse(TimeIn);
				timeOut =DateTime.Parse(TimeInOut);
				Delay = (timeOut.Hour- timeIn.Hour)*60+(timeOut.Minute-timeIn.Minute) ; 
				if(Delay >= 15)
				{
                    strSQL = "UPDATE tblTimeInTimeOut SET TimeOut = @TimeInOut WHERE EmployeeID = @EmployeeID AND WorkingDay = @WorkingDay AND (TimeOut IS NULL OR TimeOut < @TimeInOut)";	
				}
				else
				{
					//ko lam gi
				}
			}
			
			sqlCommand = new SqlCommand(strSQL, conn);
			sqlCommand.CommandType = CommandType.Text;

			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = EmployeeID;
			sqlCommand.Parameters.Add(new SqlParameter("@WorkingDay", SqlDbType.DateTime)).Value =WorkingDay;
			sqlCommand.Parameters.Add(new SqlParameter("@TimeInOut", SqlDbType.NVarChar)).Value =TimeInOut;

			try
			{
				conn.Open();
				return sqlCommand.ExecuteNonQuery();
			}

			catch (SqlException oException)
			{
				Console.WriteLine(oException.ToString());
				return 0;
			}
			finally
			{
				conn.Close();
			}

		}
		/// <summary>
		/// Lấy thời gian vào của nhân viên
		/// </summary>
		/// <param name="EmployeeID"></param>
		/// <param name="WorkingDay"></param>
		/// <returns></returns>
		public string GetTimeIn(int EmployeeID, DateTime WorkingDay)
		{
			conn = Utils.getConnection();

			strSQL = "SELECT TimeIn FROM tblTimeInTimeOut WHERE EmployeeID = @EmployeeID AND WorkingDay = @WorkingDay";
//			strSQL = "SELECT TimeIn FROM tblTimeInTimeOut WHERE EmployeeID = '308' AND WorkingDay = '19-08-2006 12:00:00 AM'";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			sqlCommand.CommandType = CommandType.Text;

			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = EmployeeID;
			sqlCommand.Parameters.Add(new SqlParameter("@WorkingDay", SqlDbType.DateTime)).Value = 
WorkingDay;
			// Adapter and DataSet
			SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
			DataSet dataSet = new DataSet();


			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "tblTimeInTimeOut");
			}

			catch (Exception oException)
			{
				MessageBox.Show(oException.ToString());
			}
			finally
			{
				conn.Close();
			}

			string TimeIn = "";
			DataTable dataTable = dataSet.Tables[0];
			if (dataTable.Rows.Count != 0)
			{
				foreach (DataRow dr in dataTable.Rows)
				{
					TimeIn = dr["TimeIn"].ToString();
				}
			}
			return TimeIn;
		}
	}
}