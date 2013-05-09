using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for PunishCardDO.
	/// </summary>
	public class PunishCardDO
	{
		public PunishCardDO()
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
		public int AddPunishCard(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("AddPunishCard", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CardName", SqlDbType.NVarChar, "CardName"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishFactor", SqlDbType.Float, "PunishFactor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));
 
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
		/// <param name="dataSet"></param>
		/// <returns></returns>
		public int UpdatePunishCard(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdatePunishCard", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishCardID", SqlDbType.Int, "PunishCardID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CardName", SqlDbType.NVarChar, "CardName"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishFactor", SqlDbType.Float, "PunishFactor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));
 
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
		public int DeletePunishCard(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeletePunishCard", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PunishCardID", SqlDbType.Int, "PunishCardID"));
 
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
		public DataSet GetPunishCard()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetPunishCard", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			// Adapter and DataSet
			SqlDataAdapter dadapter = new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;
			DataSet ds = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(ds,"GetPunishCard");
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


	

		

	}
}
