using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using System.Text;
using System.Security.Cryptography;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for AdminDO.
	/// </summary>
	public class AdminDO
	{
		SqlConnection conn = null;

		SqlCommand sqlCommand = null;
		SqlDataAdapter dataAdapter = null;

		DataSet dataSet = null;
		
		/// <summary>
		/// Lấy thông tin người dùng trong hệ thống
		/// </summary>
		/// <returns></returns>
		public DataSet GetAllUsers()
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "HT_GetAllUsers";
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Connection = conn;
			
			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Users");
				return dataSet;
			}
			catch 
			{
				MessageBox.Show("Không thể kết nối CSDL. Bạn hay xem lại các thiết lập thông số kết nối hệ thống.", "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally
			{
				conn.Close();
			}
		}
		
		/// <summary>
		/// Thêm một người dùng vào CSDL
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int AddUser(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_AddUser", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 30, "UserName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 30, "Password"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));
			sqlCommand.Parameters.Add(new SqlParameter("@CardID", SqlDbType.VarChar, 10, "CardID"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;

			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		/// Cập nhật thông tin người dùng
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateUser(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("HT_UpdateUser", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, "UserID"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 30, "UserName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 30, "Password"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));
			sqlCommand.Parameters.Add(new SqlParameter("@CardID", SqlDbType.VarChar, 10, "CardID"));
			sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4, "EmployeeID"));
			
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		/// Xóa một người dùng khỏi hệ thống
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int DeleteUser(DataSet dataSet)
		{	
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_DeleteUser", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 30, "UserID"));
			
			dataAdapter = new SqlDataAdapter();
			dataAdapter.DeleteCommand = sqlCommand;
			
			try 
			{
				conn.Open();
				return dataAdapter.Update(dataSet.Tables[0]);
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

		public int DeleteUser1(DataSet dataSet)
		{	
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_DeleteUser1", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 30, "UserName"));
			
			dataAdapter = new SqlDataAdapter();
			dataAdapter.DeleteCommand = sqlCommand;
			
			try 
			{
				conn.Open();
				return dataAdapter.Update(dataSet.Tables[0]);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return -1;
			}
			finally
			{
				conn.Close();
			}
		}
		
		/// <summary>
		/// Lấy danh sách các nhóm trong CSDL
		/// </summary>
		/// <returns></returns>
		public DataSet GetAllGroups()
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("HT_GetAllGroups", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Groups");
				return dataSet;
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
		/// Thêm một nhóm mới
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int AddGroup(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("HT_AddGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupName", SqlDbType.NVarChar, 50, "UserGroupName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 50, "Description"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;
			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.ToString());
				return 0;
			}
			finally
			{
				conn.Close();
			}
		}
		
		/// <summary>
		/// Cập nhật nhóm
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdateGroup(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("HT_UpdateGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupName", SqlDbType.NVarChar, 50, "UserGroupName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 50, "Description"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int) result.Value;
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
		/// Xóa nhóm trong CSDL
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int DeleteGroup(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_DeleteGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
						
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.DeleteCommand = sqlCommand;

			try 
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		/// 
		/// </summary>
		/// <returns></returns>
		public DataSet GetAllPermissions()
		{
			conn = WorkingContext.GetConnection();
			// Lấy danh sách sách các quyền từ CSDL
			SqlDataAdapter dataAdapter = new SqlDataAdapter("HT_GetAllPermissions", conn);

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Permissions");
				return dataSet;
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
		
		public DataSet GetUsersNotInGroup(string UserGroupID)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_GetUsersNotInGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", UserGroupID));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Users");
				return dataSet;
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
        public string GetEmail(string UserID)
        {
            string Result = "";
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            string strSQL = "Select  tblEmployee.Email From tblEmployee Inner Join tblUser on tblEmployee.EmployeeID = tblUser.EmployeeID Where tblUser.UserID = '"+ UserID +"'";
            SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet);
                if (dataSet != null)
                {
                    if(dataSet.Tables.Count > 0)
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            Result = dataSet.Tables[0].Rows[0]["Email"].ToString();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return Result;

        }
		public DataSet GetUsersInGroup(string UserGroupID)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_GetUsersInGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", UserGroupID));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Members");
				return dataSet;
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

		public DataSet GetPermissionByGroup(string UserGroupID)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_GetPermissionByGroup", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", UserGroupID));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Users");
				return dataSet;
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

		public int AddGroupPermission(string UserGroupID, int PermissionID)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_AddGroupPermission", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", UserGroupID));
			sqlCommand.Parameters.Add(new SqlParameter("@PermissionID", PermissionID));

			try
			{
				conn.Open();
				return sqlCommand.ExecuteNonQuery();
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

		public int DeleteGroupPermission(string UserGroupID)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_DeleteGroupPermission", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", UserGroupID));
			
			try
			{
				conn.Open();
				return sqlCommand.ExecuteNonQuery();
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
		
		public DataSet GetPermissionByUser (string UserName)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_GetPermissionByUser", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", UserName));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Permission");
				return dataSet;
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

		public string GetEmployeeNameByUser(string UserName)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("HT_GetEmployeeNameByUser", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", UserName));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;

			dataSet = new DataSet();
			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Permission");
				DataRow[] datarow = dataSet.Tables[0].Select();
				string str = datarow[0]["EmployeeName"].ToString();
				return str;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
	
		}

		public int ChangePass(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("ChangePass", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			//sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, "UserID"));
			sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 30, "UserName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 30, "Password"));
			//sqlCommand.Parameters.Add(new SqlParameter("@UserGroupID", SqlDbType.VarChar, 10, "UserGroupID"));
			//sqlCommand.Parameters.Add(new SqlParameter("@CardID", SqlDbType.VarChar, 10, "CardID"));
			
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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

		public DataSet GetUser(string UserName)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "SELECT UserName,CardID,Password From tblUser Where UserName = '"+ UserName+"'";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			dataAdapter= new SqlDataAdapter();
			dataAdapter.SelectCommand=sqlCommand;
			dataSet = new DataSet();

			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet,"tblUser");
				return dataSet;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return dataSet;
		}

		public String SetMD5hash (String str)
		{
			byte[] data = new byte [1000] ;
			data = Encoding.UTF8.GetBytes(str);
			HashAlgorithm hash;
			hash = new MD5CryptoServiceProvider();
			byte[] hashbyte = hash.ComputeHash(data);
			return Convert.ToBase64String(hashbyte);
		}
		
		/// <summary>
		/// Sao lưu dữ liệu
		/// </summary>
		/// <param name="fromDate"></param>
		/// <param name="toDate"></param>
		/// <returns></returns>
		public int BackUpDataInMonth(DateTime fromDate, DateTime toDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			SqlCommand command = new SqlCommand("BackUpDataInMonth", conn);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter param = new SqlParameter("@FromDate", SqlDbType.DateTime);
			param.Value = fromDate;
			command.Parameters.Add(param);


			param = new SqlParameter("@ToDate", SqlDbType.DateTime);
			param.Value = toDate;
			command.Parameters.Add(param);

			SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			command.Parameters.Add(result);
			try
			{
				conn.Open();
				return command.ExecuteNonQuery();
			}
			catch
			{
				return -1;
			}
			finally
			{
				conn.Close();
			}
		}
		
		/// <summary>
		/// Khôi phục dữ liệu
		/// </summary>
		/// <param name="fromDate"></param>
		/// <param name="toDate"></param>
		/// <returns></returns>
		public int RestoreDataInMonth(DateTime fromDate, DateTime toDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			SqlCommand command = new SqlCommand("RestoreDataInMonth", conn);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter param = new SqlParameter("@FromDate", SqlDbType.DateTime);
			param.Value = fromDate;
			command.Parameters.Add(param);


			param = new SqlParameter("@ToDate", SqlDbType.DateTime);
			param.Value = toDate;
			command.Parameters.Add(param);

			SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			command.Parameters.Add(result);
			try
			{
				conn.Open();
				return command.ExecuteNonQuery();
			}
			catch
			{
				return -1;
			}
			finally
			{
				conn.Close();
			}
		}
		
		#region Lấy dữ liệu từ bảng SysVar
		public DataSet GetSysvar()
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("Sys_GetSysvar", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;
			dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "Sysvar");
				return dataSet;
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
        public string GetSysVarByNam(string Name)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("ST_SysGetSysVarByName", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Sys_name", SqlDbType.NVarChar).Value = Name;
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();
            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "Sysvar");
                return dataSet.Tables[0].Rows[0]["Sys_value"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
            finally
            {
                conn.Close();
            }
        }
		public void UpdateSysVar(string Sys_name,string Descriptions,string Sysvalue,Boolean modify)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("Sys_UpdateSysVar", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Sys_name",SqlDbType.NVarChar).Value = Sys_name;
			sqlCommand.Parameters.Add("@Descriptions",SqlDbType.NVarChar).Value = Descriptions;
            sqlCommand.Parameters.Add("@Sys_value",SqlDbType.NVarChar).Value = Sysvalue;
			sqlCommand.Parameters.Add("@Modify",SqlDbType.Bit).Value = modify;
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
		#endregion

	}
}
