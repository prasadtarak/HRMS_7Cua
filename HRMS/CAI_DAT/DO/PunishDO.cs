using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for PunishDO.
	/// </summary>
	public class PunishDO
	{
		public PunishDO()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int AddPunish(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("AddPunish", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishCardID", SqlDbType.Int, "PunishCardID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Reason", SqlDbType.NVarChar, "Reason"));
 
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
		/// 
		/// </summary>
		/// <returns></returns>
		public DataSet GetPunish()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetPunish", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			// Adapter and DataSet
			SqlDataAdapter dadapter = new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;
			DataSet ds = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(ds,"GetPunish");
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
		/// 
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdatePunish(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdatePunish", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishID", SqlDbType.Int, "PunishID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishCardID", SqlDbType.Int, "PunishCardID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Reason", SqlDbType.NVarChar, "Reason"));
 
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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int DeletePunish(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeletePunish", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishID", SqlDbType.Int, "PunishID"));
 
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
		/// 
		/// </summary>
		/// <param name="dtpFromDate"></param>
		/// <param name="dtpToDate"></param>
		/// <param name="DepartmentID"></param>
		/// <returns></returns>
		public DataSet GetListPunish(DateTime dtpFromDate,DateTime dtpToDate,int DepartmentID)
		{

			SqlConnection conn = WorkingContext.GetConnection();
			SqlCommand sqlCommand = new SqlCommand("GetListPunish",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			
			SqlParameter para1 = new SqlParameter("@dtpFromDate",SqlDbType.DateTime);
			para1.Value = dtpFromDate.Date;
			sqlCommand.Parameters.Add(para1);

			SqlParameter para2 = new SqlParameter("@dtpToDate",SqlDbType.DateTime);
			para2.Value = dtpToDate.Date;
			sqlCommand.Parameters.Add(para2);

			SqlParameter para3 = new SqlParameter("@DepartmentID",SqlDbType.Int);
			para3.Value = DepartmentID;
			sqlCommand.Parameters.Add(para3);

			SqlDataAdapter dadapter = new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			DataSet dataSet = new DataSet();
			try
			{
				conn.Open();
				dadapter.Fill(dataSet,"GetListPunish");
				return dataSet;   
			}

			catch(Exception oException)
			{
				MessageBox.Show(oException.ToString());
				return null;
			}
			finally      
			{
				conn.Close();
			}       

		}
	}
}
