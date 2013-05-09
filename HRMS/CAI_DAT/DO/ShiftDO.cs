//------------------------------------------------------------------------------------
//Class	    : ShiftDO
//Purpose	: Định Nghĩa ca làm việc
//Note	    :		  
//Author	: vietht 2005
//Modify	: 
//------------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
    /// Lớp kết nối và thao tác cơ sở dữ liệu của chức năng định nghĩa ca làm việc
    /// 
    public class ShiftDO
    {
        /// <summary>
        /// Thêm một ca làm việc mới
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int AddShift(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddShift", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftName", SqlDbType.NVarChar, "ShiftName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Description", SqlDbType.NVarChar, "Description"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BreakShift", SqlDbType.Bit, "BreakShift"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DeltaLateTime", SqlDbType.Int, "DeltaLateTime"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckIn1", SqlDbType.DateTime, "CheckIn1"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckOut1", SqlDbType.DateTime, "CheckOut1"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckIn2", SqlDbType.DateTime, "CheckIn2"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckOut2", SqlDbType.DateTime, "CheckOut2"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DeltaAllowCheck", SqlDbType.Int, "DeltaAllowCheck"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
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
        /// Them moi ca lam them
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int AddShiftOver(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddShiftOver", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftName", SqlDbType.NVarChar, "ShiftName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeIn", SqlDbType.DateTime, "TimeIn"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeOut", SqlDbType.DateTime, "TimeOut"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchStart", SqlDbType.DateTime, "LunchStart"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchStop", SqlDbType.DateTime, "LunchStop"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerStart", SqlDbType.DateTime, "DinnerStart"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerStop", SqlDbType.DateTime, "DinnerStop"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftDescription", SqlDbType.NVarChar, "ShiftDescription"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
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
        /// Cap nhat ca lam them
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdateShiftOver(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateShiftOver", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //string thu = dataSet.Tables[0].Rows[0][2].ToString();
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftOverID", SqlDbType.Int, "ShiftOverID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftName", SqlDbType.NVarChar, "ShiftName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftDescription", SqlDbType.NVarChar, "ShiftDescription"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeIn", SqlDbType.DateTime, "TimeIn"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeOut", SqlDbType.DateTime, "TimeOut"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchStart", SqlDbType.DateTime, "LunchStart"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchStop", SqlDbType.DateTime, "LunchStop"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerStart", SqlDbType.DateTime, "DinnerStart"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DinnerStop", SqlDbType.DateTime, "DinnerStop"));


            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
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
        /// Xoa ca lam them
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteShiftOver(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteShiftOver", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftOverID", SqlDbType.Int, "ShiftOverID"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(dataSet.Tables[0]);
                return (int)result.Value;
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
        /// Lấy thông tin các ca làm việc
        /// </summary>
        /// <returns></returns>
        public DataSet GetShift()
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetShift", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataSet dsShift = new DataSet();

            try
            {
                conn.Open();
                dadapter.Fill(dsShift, "tblShift");
                return dsShift;
            }

            catch (Exception ex)
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
        /// Lay thong tin danh sach ca lam them
        /// </summary>
        /// <returns></returns>
        public DataSet GetShiftOver()
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetShiftOver", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataSet dsShift = new DataSet();

            try
            {
                conn.Open();
                dadapter.Fill(dsShift, "tblShiftOver");
                return dsShift;
            }

            catch (Exception ex)
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
        /// Xóa ca làm việc
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteShift(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteShift", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;


            try
            {
                conn.Open();
                dataAdapter.Update(dataSet.Tables[0]);
                return (int)result.Value;
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

        public int DeleteOverTimeInMonth(int month, int year)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteOverTimeInMonth", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@Month", month));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", year));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            //SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            //result.Direction = ParameterDirection.ReturnValue;
            //sqlCommand.Parameters.Add(result);

            try
            {
                conn.Open();
                return 1;
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
        /// Cập nhật ca làm việc
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdateShift(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateShift", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftName", SqlDbType.NVarChar, "ShiftName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Description", SqlDbType.NVarChar, "Description"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BreakShift", SqlDbType.Bit, "BreakShift"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DeltaLateTime", SqlDbType.Int, "DeltaLateTime"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckIn1", SqlDbType.DateTime, "CheckIn1"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckOut1", SqlDbType.DateTime, "CheckOut1"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckIn2", SqlDbType.DateTime, "CheckIn2"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CheckOut2", SqlDbType.DateTime, "CheckOut2"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DeltaAllowCheck", SqlDbType.Int, "DeltaAllowCheck"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
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
        /// Lay thong tin chi tiet cua ca lam them theo ID
        /// </summary>
        /// <param name="shiftOverID"></param>
        /// <returns></returns>
        public DataSet GetShiftOverByID(int shiftOverID)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetShiftOverByID", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@ShiftOverID", shiftOverID));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();
            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetShiftOverByID");
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
        /// Lay thong tin chi tiet cua ca lam them theo ten
        /// </summary>
        /// <param name="shiftName"></param>
        /// <returns></returns>
        public DataSet GetShiftOverByName(string shiftName)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetShiftOverByName", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@ShiftName", shiftName));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();
            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetShiftOverByName");
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
    }

}
