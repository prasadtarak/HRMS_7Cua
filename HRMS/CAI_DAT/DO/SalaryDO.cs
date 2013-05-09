using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
    /// <summary>
    /// 
    /// </summary>
    public class SalaryDO
    {
        /// <summary>
        /// Lấy thông tin lương của các nhân viên trong bộ phận
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public DataSet GetDepartmentSalary(int Month, int Year, int DepartmentID)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetDepartmentSalary", conn);
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
                dataAdapter.Fill(dataSet, "GetDepartmentSalary");
                return dataSet;
            }
            catch (Exception oException)
            {
                Console.WriteLine(oException);
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
        /// Sinh bảng lương tháng
        /// </summary>
        /// <param name="Month">Tháng</param>
        /// <param name="Year">Năm</param>
        /// <param name="EmployeeID">Mã nhân viên</param>
        /// <returns></returns>
        public int GenerateSalary(int Month, int Year, int EmployeeID, string ProcedureName)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command

            SqlCommand sqlCommand = new SqlCommand(ProcedureName, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
            sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));

            try
            {
                conn.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception oException)
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
        /// Sinh bảng lương tháng
        /// </summary>
        /// <param name="Month">Tháng</param>
        /// <param name="Year">Năm</param>
        /// <param name="EmployeeID">Mã nhân viên</param>
        /// <returns></returns>
        public int GenerateSalary_HP(int Month, int Year, int EmployeeID, float workingDayInMonth)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("GenerateSalary_HP_New", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
            sqlCommand.Parameters.Add(new SqlParameter("@Month", Month));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", Year));
            sqlCommand.Parameters.Add(new SqlParameter("@WorkingDayInMonth", workingDayInMonth));

            try
            {
                conn.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception oException)
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
        /// Cập nhật bảng lương nhân viên
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdateSalary(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateSalary", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Month", SqlDbType.Int, "Month"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Year", SqlDbType.Int, "Year"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BasicSalary", SqlDbType.Money, "BasicSalary"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchAllowance", SqlDbType.Money, "LunchAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@HarmfulAllowance", SqlDbType.Money, "HarmfulAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ResponsibleAllowance", SqlDbType.Money, "ResponsibleAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IntimateAllowance", SqlDbType.Money, "IntimateAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DangerousAllowance", SqlDbType.Money, "DangerousAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@JapaneseAllowance", SqlDbType.Money, "JapaneseAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalTimeSheet", SqlDbType.Real, "TotalTimeSheet"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SumMoney", SqlDbType.Money, "SumMoney"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime1", SqlDbType.Float, "OverTime1"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime2", SqlDbType.Float, "OverTime2"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime3", SqlDbType.Float, "OverTime3"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTime4", SqlDbType.Float, "OverTime4"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OverTimeMoney", SqlDbType.Money, "OverTimeMoney"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OtherAddition", SqlDbType.Money, "OtherAddition"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalPaidLunch", SqlDbType.Money, "TotalPaidLunch"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Insurance", SqlDbType.Money, "Insurance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PersonalIncomeTax", SqlDbType.Money, "PersonalIncomeTax"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OtherDeduction", SqlDbType.Money, "OtherDeduction"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SalaryBLD", SqlDbType.Money, "SalaryBLD"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RealSalary", SqlDbType.Money, "RealSalary"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
            }
            catch (Exception oException)
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
        /// Xóa nhân viên khỏi bảng lương
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteEmployeeSalary(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeSalary", conn);
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
            catch (Exception oException)
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

        public DataSet GetAutoGenerateLunchSheet()
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetAutoGenerateLunchSheet", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAutoGenerateLunchSheet");
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

        public float GetWorkingDayInMonth(int month, int year)
        {
            float workingDay = 0;
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetWorkingDayInMonth", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("@Month", SqlDbType.Int)).Value = month;
            sqlCommand.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = year;
            
            DataSet dataSet = new DataSet();
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    workingDay = Convert.ToSingle(reader[0]);
                }
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
                return 0;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
            return workingDay;
        }
    }
}
