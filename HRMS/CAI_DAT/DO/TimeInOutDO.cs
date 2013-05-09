using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;
namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for TimeInOutDO.
	/// </summary>
	public class TimeInOutDO
	{
		DataSet dsTimeInOut = null;
		SqlCommand sqlCommand = null;
		SqlDataAdapter dadapter = null;
		SqlConnection conn = null;

		public TimeInOutDO()
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
		public int DeleteTimeInOut(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteTimeInOut", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeID", SqlDbType.Int, "TimeID"));
 
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
		/// <returns></returns>
		public DataSet GetShift()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "select * from tblShift";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			SqlDataAdapter dataAdapter= new SqlDataAdapter();
			dataAdapter.SelectCommand=sqlCommand;
			DataSet dataSet = new DataSet();

			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet,"ShiftInfo");
				return dataSet;   
			}

			catch(Exception oException)
			{
				throw oException;
			}
			finally      
			{
				conn.Close();
			}       
		}

		/// <summary>
		/// Lấy thông tin về thời gian vào, ra của nhân viên trong một khoảng thời gian
		/// </summary>
		/// <param name="EmployeeID"></param>
		/// <param name="FromDate"></param>
		/// <param name="ToDate"></param>
		/// <returns></returns>
		public DataSet GetTimeInOut(int EmployeeID,DateTime FromDate, DateTime ToDate)
		{
			conn = WorkingContext.GetConnection();
			// Build the command
			sqlCommand = new SqlCommand("GetTimeInOut", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter para1 = new SqlParameter("@EmployeeID",SqlDbType.Int);
			para1.Value = EmployeeID;
			sqlCommand.Parameters.Add(para1);
			
			SqlParameter para2 = new SqlParameter("@FromDate",SqlDbType.DateTime);
			para2.Value = FromDate.ToShortDateString();
			sqlCommand.Parameters.Add(para2);

			SqlParameter para3 = new SqlParameter("@ToDate",SqlDbType.DateTime);
			para3.Value = ToDate.ToShortDateString();
			sqlCommand.Parameters.Add(para3);
			// Adapter and DataSet
			dadapter= new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			dsTimeInOut = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(dsTimeInOut);
				return dsTimeInOut;
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
		public int AddTimeInOut(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("AddTimeInOut", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeIn", SqlDbType.DateTime, "TimeIn"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeOut", SqlDbType.DateTime, "TimeOut"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));
            //them truong thong tin xac dinh du lieu bi edit bang tay
            //sqlCommand.Parameters.Add(WorkingContext.CreateParam("1", SqlDbType.Int, "ManuallyEdited"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.InsertCommand = sqlCommand;
			sqlCommand.Parameters.Add(result);
 
			try
			{
				conn.Open();
				dataAdapter.Update(dataSet.Tables[0]);
				return (int)result.Value;
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
		public int UpdateTimeInOut(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateTimeInOut", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeID", SqlDbType.Int, "TimeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeIn", SqlDbType.DateTime, "TimeIn"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TimeOut", SqlDbType.DateTime, "TimeOut"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@WorkingDay", SqlDbType.DateTime, "WorkingDay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ShiftID", SqlDbType.Int, "ShiftID"));
            //them truong thong tin xac dinh du lieu bi edit bang tay
            //sqlCommand.Parameters.Add(WorkingContext.CreateParam("1", SqlDbType.Int, "ManuallyEdited"));
 
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
	}
}
