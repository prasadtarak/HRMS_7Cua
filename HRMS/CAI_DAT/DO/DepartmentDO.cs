//------------------------------------------------------------------------------------
//Class	    : DepartmentDO
//Purpose	: Xây dựng cây phòng ban
//Note	    :
//Author	: vietht 2005
//Modify	: dungnt 18-6-2005, 30-09-2005
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
    /// <summary>
    /// Lớp kết nối và thao tác cơ sở dữ liệu của chức năng xây dựng bộ máy tổ chức
    /// </summary>
    public class DepartmentDO
    {
        private SqlConnection conn = null;
        private SqlCommand sqlCommand = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;

        #region Department management methods

        /// <summary>
        /// Lấy danh sách tất cả các phòng ban, bộ phân kể cả phòng ban gốc- tên công ty
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllDepartments()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetAllDepartments", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAllDepartments");
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
        /// Lấy tất cả danh sách các phòng ban, bộ phận (trừ phòng ban gốc - tên công ty)
        /// </summary>
        /// <returns></returns>
        public DataSet GetDepartments()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetDepartments", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDepartments");
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
        /// Lấy tất cả danh sách các phòng ban, bộ phận (trừ phòng ban gốc - tên công ty)
        /// </summary>
        /// <returns></returns>
        public DataSet GetDepartmentsToViewStatus()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetDepartmentsToViewStatus", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDepartments");
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
        /// Lấy danh sách các nhân viên của một phòng ban
        /// </summary>
        /// <param name="DepartmentID">Mã phòng ban</param>
        /// <returns>Thông tin các nhân viên trong phòng ban</returns>
        public DataSet GetDepEmployees(int DepartmentID)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            string strSQL = "SELECT * FROM tblEmployee";
            if (DepartmentID != 1)
            {
                strSQL += " WHERE DepartmentID = " + DepartmentID;
            }

            SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();

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
        /// Thêm một phòng ban vào cây phòng ban
        /// </summary>
        /// <param name="DepartmentName"></param>
        /// <param name="Description"></param>
        /// <param name="ParentNode"></param>
        /// <returns></returns>
        public int AddDepartment(string DepartmentName, string Description, int ParentNode, int SortIndex, int groupID)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("AddDepartment", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@DepartmentName", DepartmentName);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@Description", Description);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@ParentNode", ParentNode);
            sqlCommand.Parameters.Add(param3);
            //if(SortIndex!=0)
            //{
            SqlParameter param4 = new SqlParameter("@SortIndex", SortIndex);
            sqlCommand.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter("@GroupID", groupID);
            sqlCommand.Parameters.Add(param5);
            //}
            //else
            //{
            //    SqlParameter param4 = new SqlParameter("@SortIndex", null);
            //    sqlCommand.Parameters.Add(param4);
            //}

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Cập nhật thông tin một phòng ban
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <param name="DepartmentName"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public int UpdateDepartmentInfo(int DepartmentID, string DepartmentName, string Description, int SortIndex, int groupID)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdateDepartment", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@DepartmentName", DepartmentName);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@Description", Description);
            sqlCommand.Parameters.Add(param3);

            if (SortIndex != 0)
            {
                SqlParameter param4 = new SqlParameter("@SortIndex", SortIndex);
                sqlCommand.Parameters.Add(param4);
            }
            else
            {
                SqlParameter param4 = new SqlParameter("@SortIndex", null);
                sqlCommand.Parameters.Add(param4);
            }

            SqlParameter param5 = new SqlParameter("@GroupID", groupID);
            sqlCommand.Parameters.Add(param5);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Xóa một phòng ban
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public int DeleteDepartment(int DepartmentID)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("DeleteDepartment", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param1);

            int result = 0;
            SqlParameter param2 = new SqlParameter("@Result", result);
            param2.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(param2);

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

        #endregion Department management methods

        #region Position management methods

        /// <summary>
        /// Thêm một chức vụ
        /// </summary>
        /// <param name="dsPosition"></param>
        /// <returns></returns>
        public int AddPosition(DataSet dsPosition)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("AddPosition", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionName", SqlDbType.NVarChar, "PositionName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Description", SqlDbType.NVarChar, "Description"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionShortName", SqlDbType.NVarChar, "PositionShortName"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(dsPosition.Tables[0]);
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                //				throw oException;
                MessageBox.Show(oException.ToString());
                return 0;
            }

            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Cập nhật thông tin một chức vụ
        /// </summary>
        /// <param name="dsPosition"></param>
        /// <returns></returns>
        public int UpdatePosition(DataSet dsPosition)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdatePosition", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionName", SqlDbType.NVarChar, "PositionName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Description", SqlDbType.NVarChar, "Description"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionShortName", SqlDbType.NVarChar, "PositionShortName"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(dsPosition.Tables[0]);
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                //				throw oException;
                MessageBox.Show(oException.ToString());
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Xóa một Chức Vụ
        /// </summary>
        /// <param name="dsPosition"></param>
        /// <returns></returns>
        public int DeletePosition(DataSet dsPosition)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("DeletePosition", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(dsPosition.Tables[0]);
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Lấy tất cả các chức vụ
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllPositions()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetAllPositions", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAllPositions");
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
        /// Lấy thông tin một chức vụ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetPositionInfo(string id)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command

            string strSQL = "SELECT *  from tblPosition where PositionID=" + id;

            SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "SPInfo");
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

        #endregion Position management methods

        #region theo doi phong ban , nhan vien

        public DataSet GetAttendRecord(int DepartmentID, DateTime Month)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand command = new SqlCommand();

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            // Build the command
            command.CommandText = "GetAttendanceRecord";
            command.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int)).Value = DepartmentID;
            command.Parameters.Add(new SqlParameter("@Month", SqlDbType.DateTime)).Value = Month;
            // Adapter and DataSet
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet);
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
            return dataSet;
        }

        public DataSet GetAttendRecordByEmployee(int EmployeeID, DateTime Month)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand command = new SqlCommand();

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            // Build the command
            command.CommandText = "GetAttendanceRecordByEmployee";
            command.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = EmployeeID;
            command.Parameters.Add(new SqlParameter("@Month", SqlDbType.DateTime)).Value = Month;
            // Adapter and DataSet
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet);
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
            return dataSet;
        }

        public DataSet GetAttendRecordNew(int DepartmentID, DateTime Month)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand command = new SqlCommand();

            // Adapter and DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            // Build the command
            command.CommandText = "GetAttendanceRecord_New";
            command.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int)).Value = DepartmentID;
            command.Parameters.Add(new SqlParameter("@Month", SqlDbType.DateTime)).Value = Month;
            // Adapter and DataSet
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet);
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
            return dataSet;
        }

        #endregion theo doi phong ban , nhan vien

        #region Quan ly benh vien

        /// <summary>
        /// Lấy tất cả bệnh viện
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllHospitals()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetAllHospitals", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAllHospitals");
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
        /// Lay thong tin chi tiet cua benh vien can xem
        /// </summary>
        /// <param name="hospitalID"></param>
        /// <returns></returns>
        public DataSet GetHospital(string hospitalID)
        {
            DataSet dsHospital = new DataSet();
            SqlConnection con = WorkingContext.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("GetHospital", con.ConnectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@HospitalID", SqlDbType.Char);
            param.Value = hospitalID;
            da.SelectCommand.Parameters.Add(param);

            con.Open();
            da.Fill(dsHospital, "Hospital");
            con.Dispose();
            con.Close();

            return dsHospital;
        }

        /// <summary>
        /// Them moi 1 benh vien
        /// </summary>
        /// <param name="hospitalName"></param>
        /// <param name="hospitalAddress"></param>
        /// <param name="hospitalID"></param>
        /// <returns></returns>
        public int AddNewHospital(string hospitalName, string hospitalAddress, string hospitalID)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("AddNewHospital", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@HospitalName", hospitalName);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@HospitalAddress", hospitalAddress);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@HospitalID", hospitalID);
            sqlCommand.Parameters.Add(param3);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdateHospital(string hospitalID, string hospitalName, string hospitalAddress, int hospitalCode)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("UpdateHospital", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@HospitalName", hospitalName);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@HospitalAddress", hospitalAddress);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@HospitalID", hospitalID);
            sqlCommand.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter("@HospitalCode", hospitalCode);
            sqlCommand.Parameters.Add(param4);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteHospital(int HospitalID)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("DeleteHospital", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@HospitalID", HospitalID);
            sqlCommand.Parameters.Add(param1);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }

            //SqlConnection conn = WorkingContext.GetConnection();

            //SqlCommand sqlCommand = new SqlCommand("DeleteHospital", conn);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //SqlParameter param1 = new SqlParameter("@HospitalID", hospitalID);
            //sqlCommand.Parameters.Add(param1);

            //int result = 0;
            //SqlParameter param2 = new SqlParameter("@Result", result);
            //param2.Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(param2);

            //try
            //{
            //    conn.Open();
            //    return sqlCommand.ExecuteNonQuery();
            //}

            //catch (Exception oException)
            //{
            //    MessageBox.Show(oException.ToString());
            //    return 0;
            //}
            //finally
            //{
            //    conn.Dispose();
            //    conn.Close();
            //}
        }

        #endregion Quan ly benh vien

        #region Quan ly nhom phong ban

        /// <summary>
        /// Lấy danh sách nhóm phòng ban
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllGroupDepartments()
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetAllGroupDepartments", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAllGroupDepartments");
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
        /// Lay thong tin chi tiet nhom phong ban
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public DataSet GetGroupDepartments(int groupID)
        {
            DataSet dsHospital = new DataSet();
            SqlConnection con = WorkingContext.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("GetGroupDepartments", con.ConnectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@GroupID", SqlDbType.Int);
            param.Value = groupID;
            da.SelectCommand.Parameters.Add(param);

            con.Open();
            da.Fill(dsHospital, "GetGroupDepartments");
            con.Dispose();
            con.Close();

            return dsHospital;
        }

        /// <summary>
        /// Them nhom phong ban moi
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="groupName"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public int AddDepartmentGroup(int groupID, string groupName, string Description)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("AddDepartmentGroup", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@GroupID", groupID);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@GroupName", groupName);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@GroupDescription", Description);
            sqlCommand.Parameters.Add(param3);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Cập nhật thông tin một nhóm phòng ban
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="groupName"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public int UpdateDepartmentGroup(int groupID, string groupName, string Description)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdateDepartmentGroup", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@GroupID", groupID);
            sqlCommand.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("@GroupName", groupName);
            sqlCommand.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("@GroupDescription", Description);
            sqlCommand.Parameters.Add(param3);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
            }

            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString(), "Lỗi cập nhật cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Xóa một nhóm phòng ban
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public int DeleteDepartmentGroup(int groupID)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("DeleteDepartmentGroup", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@GroupID", groupID);
            sqlCommand.Parameters.Add(param1);

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
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

        #endregion Quan ly nhom phong ban
    }
}