using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CardReader;

namespace EVSoft.CardReader
{
    public class X628CDO
    {
        public static string connectionString;

        private string strSQL = "";

        private SqlConnection conn = null;
        private SqlCommand sqlCommand = null;
        private SqlDataAdapter dataAdapter = null;

        private DataSet dataSet = null;


        /// <summary>
        /// Kiem tra ket noi DataBase
        /// </summary>
        /// <returns></returns>
        public bool CheckConnection()
        {
            // Adapter and DataSet
            conn = Utils.getConnection();
            strSQL = "SELECT Count(EmployeeID) FROM tblEmployee";
            sqlCommand = new SqlCommand(strSQL, conn);
            try
            {
                if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

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

        /// <summary>
        /// Lưu dữ liệu về thời gian vào ra của nhân viên
        /// </summary>
        /// <param name="WorkingDay"></param>
        /// <param name="EmployeeID"></param>
        /// <param name="TimeInOut"></param>
        /// <param name="TimeIn"></param>
        /// <returns></returns>
        public int SaveCardData(string WorkingDay, int EmployeeID, string TimeInOut, string TimeIn)
        {
            System.DateTime timeIn = new System.DateTime();
            System.DateTime timeOut = new System.DateTime();
            //			System.TimeSpan inOut = new TimeSpan();
            int Delay = 0;

            conn = Utils.getConnection();

            if (TimeIn.Equals(""))//chua co gio den thi luu du lieu dau tien lay duoc vao gio den
            {
                strSQL = "INSERT INTO tblTimeInTimeOut(WorkingDay, EmployeeID, TimeIn) VALUES('"
                    + WorkingDay + "', '" + EmployeeID + "','" + TimeInOut + "')";
            }
            else // da co gio den
            {

                timeIn = DateTime.Parse(TimeIn);
                timeOut = DateTime.Parse(TimeInOut);


                //				inOut = timeOut.Subtract(timeIn);

                // Delay là độ trễ cho phép giữa 2 lần quẹt thẻ, khi đó lần quẹt thẻ thứ 2 sẽ không lưu vào giờ ra
                //				Delay = (timeOut.Hour*60+timeOut.Minute)-(timeIn.Hour*60+timeIn.Minute) ; 
                //				Delay = inOut.Hours*60+inOut.Minutes;
                Delay = (timeOut.Hour - timeIn.Hour) * 60 + (timeOut.Minute - timeIn.Minute);

                if (Delay < 0)//kiem tra neu TimInOut< TimeIn thi doi du lieu TimeInOut voi TimeIn vi may quet the lay du lieu theo kieu stack
                {
                    timeOut = timeIn;
                    timeIn = DateTime.Parse(TimeInOut);
                    //cap nhat gio den gio ve vao database
                    strSQL = "UPDATE tblTimeInTimeOut SET TimeOut = '" + timeOut + ",TimeIn = '" + timeIn
                        + "' WHERE EmployeeID = '" + EmployeeID + "' AND WorkingDay = '" + WorkingDay + "'";
                }
                if (Delay >= 15)// giua 2 lan quet the cach nhau 15 min moi luu vao database
                {
                    strSQL = "UPDATE tblTimeInTimeOut SET TimeOut = '" + TimeInOut
                        + "' WHERE EmployeeID = '" + EmployeeID + "' AND WorkingDay = '" + WorkingDay + "' AND (TimeOut IS NULL OR TimeOut < '" + TimeInOut + "')";
                }
                else
                {
                    //khong lam gi ca
                }

            }
            sqlCommand = new SqlCommand(strSQL, conn);

            try
            {
                conn.Open();
                return sqlCommand.ExecuteNonQuery();
            }

            catch (Exception oException)
            {
                ///MessageBox.Show(oException.ToString());
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        public int SaveCheckCardData(int iEmployeeID, DateTime dtCheckCardTime)
        {
            DateTime dtCheckCardTimePri = new DateTime(dtCheckCardTime.Year, dtCheckCardTime.Month, dtCheckCardTime.Day, dtCheckCardTime.Hour, dtCheckCardTime.Minute, 0);

            conn = Utils.getConnection();
            sqlCommand = new SqlCommand("SaveCheckCardData_X628", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = iEmployeeID;
            sqlCommand.Parameters.Add(new SqlParameter("@CheckCardTime", SqlDbType.DateTime)).Value = dtCheckCardTimePri;

            try
            {
                conn.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception oException)
            {
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

            strSQL = "SELECT TimeIn FROM tblTimeInTimeOut WHERE EmployeeID = '" +
                EmployeeID + "' AND WorkingDay = '" + WorkingDay + "'";
            SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

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