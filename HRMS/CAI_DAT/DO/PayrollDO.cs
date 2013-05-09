using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for PayrollDO.
	/// </summary>
	public class PayrollDO
	{
		SqlConnection conn = null;

		SqlCommand sqlCommand = null;
		SqlDataAdapter dataAdapter = null;

		DataSet dataSet = null;

		/// <summary>
		/// Lấy thông tin các khoản lương trong hệ thống
		/// </summary>
		/// <returns></returns>
		public DataSet GetPayrollItems()
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("GetPayrollItems", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			
			dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;
			dataSet = new DataSet();
			try 
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "GetPayrollItems");
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
		/// Thêm một khoản lương vào CSDL
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int AddPayrollItem(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("AddPayrollItem", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@PayrollItemID", SqlDbType.VarChar, 20, "PayrollItemID"));
			sqlCommand.Parameters.Add(new SqlParameter("@PIName", SqlDbType.VarChar, 100, "PIName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Formula", SqlDbType.VarChar, 255, "Formula"));
			sqlCommand.Parameters.Add(new SqlParameter("@PICategoryID", SqlDbType.Int, 4, "PICategoryID"));

			dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;

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
		
		/// <summary>
		/// Cập nhật thông tin người dùng
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdatePayrollItem(DataSet dataSet)
		{
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("UpdatePayrollItem", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@PayrollItemID", SqlDbType.VarChar, 20, "PayrollItemID"));
			sqlCommand.Parameters.Add(new SqlParameter("@PIName", SqlDbType.VarChar, 100, "PIName"));
			sqlCommand.Parameters.Add(new SqlParameter("@Formula", SqlDbType.VarChar, 255, "Formula"));
			sqlCommand.Parameters.Add(new SqlParameter("@PICategoryID", SqlDbType.Int, 4, "PICategoryID"));
			dataAdapter = new SqlDataAdapter();
			dataAdapter.UpdateCommand = sqlCommand;

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

		/// <summary>
		/// Xóa một người dùng khỏi hệ thống
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int DeletePayrollItem(DataSet dataSet)
		{	
			conn = WorkingContext.GetConnection();

			sqlCommand = new SqlCommand("DeletePayrollItem", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(new SqlParameter("@PayrollItemID", SqlDbType.VarChar, 20, "PayrollItemID"));
			
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
	}
}
