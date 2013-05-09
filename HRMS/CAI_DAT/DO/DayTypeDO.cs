//------------------------------------------------------------------------------------
//Class	    : 
//Purpose	: 
//Note	    :		  
//Author	: chinhnd 9-2005
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Lớp kết nối và thao tác cơ sở dữ liệu của chức năng định nghĩa kiểu ngày làm việc
	/// </summary>
	public class DayTypeDO
	{
	
		SqlConnection conn = null;
		SqlCommand sqlCommand = null;
		SqlDataAdapter dadapter = null;
		DataSet dataSet = null;
		
		/// <summary>
		/// Thêm mới kiểu ngày
		/// </summary>
		/// <param name="dsDayType"></param>
		/// <returns></returns>
		public int AddDayTypeDO(DataSet dsDayType)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("AddDayType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayName",SqlDbType.NVarChar,"DayName"));
//			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayColor",SqlDbType.VarChar,"DayColor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayFactor",SqlDbType.Float,"DayFactor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayShortName",SqlDbType.VarChar,"DayShortName"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceCheck",SqlDbType.Bit,"InsuranceCheck"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceFactor",SqlDbType.Float,"InsuranceFactor"));
//			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Quantity",SqlDbType.Int,"Quantity"));

			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dadapter = new SqlDataAdapter();
			dadapter.InsertCommand = sqlCommand;
			try
			{
				conn.Open();
				dadapter.Update(dsDayType,"tblDayType");
				return (int)result.Value;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0;
			}
			finally
			{
				conn.Dispose();
				conn.Close();
			}


		}

		/// <summary>
		/// Lấy ra một bảng đưa vào Dataset
		/// </summary>
		/// <returns></returns>
		public DataSet GetDayType()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "SELECT DayID,DayName, DayShortName, DayFactor,InsuranceCheck,InsuranceFactor FROM tblDayType";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			dadapter= new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;
			dataSet = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(dataSet,"tblDayType");
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

		/// <summary>
		/// cập nhật kiểu ngày vào cơ sở dữ liệu
		/// </summary>
		/// <param name="dsDayType"></param>
		/// <returns></returns>
		public int UpdateDayType(DataSet dsDayType)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("UpdateDayType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayID",SqlDbType.NVarChar,"DayID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayName",SqlDbType.NVarChar,"DayName"));
//			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayColor",SqlDbType.VarChar,"DayColor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayFactor",SqlDbType.Float,"DayFactor"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayShortName",SqlDbType.NVarChar,"DayShortName"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceCheck",SqlDbType.Bit,"InsuranceCheck"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceFactor",SqlDbType.Float,"InsuranceFactor"));
//			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Quantity",SqlDbType.Int,"Quantity"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dadapter = new SqlDataAdapter();
			dadapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				 dadapter.Update(dsDayType,"tblDayType");
				return (int)result.Value;
			}
			catch(Exception ex)
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
		/// Xóa một kiểu ngày
		/// </summary>
		/// <param name="dsDayType"></param>
		/// <returns></returns>
		public int DeleteDayTypeDB(DataSet dsDayType)
		{
			
			SqlConnection conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("DeleteDayType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DayID",SqlDbType.Int,"DayID"));

			dadapter = new SqlDataAdapter();
			dadapter.DeleteCommand = sqlCommand;
			try
			{
				conn.Open();
				return dadapter.Update(dsDayType.Tables[0]);
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
        public DataSet GetTypeSalary()
        {
            DataSet Result = new DataSet();
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("ST_GETTYPESALARY", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                dadapter.Fill(Result);
                
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
        public int UpdateTypeSalary(int SalaryID,string SalaryName,string SalaryDescription,int ContractID,decimal BasicSalary)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("ST_UPDATETYPESALARY", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.Add("@SalaryID", SqlDbType.Int).Value = SalaryID;
            sqlCommand.Parameters.Add("@SalaryName", SqlDbType.NVarChar).Value = SalaryName;
            sqlCommand.Parameters.Add("@SalaryDescription", SqlDbType.NVarChar).Value = SalaryDescription;
            sqlCommand.Parameters.Add("@ContractID", SqlDbType.Int).Value = ContractID;
            sqlCommand.Parameters.Add("@SalaryBasic", SqlDbType.Int).Value = BasicSalary;

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
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
	    /// Xoa kieu luong co dinh
	    /// </summary>
	    /// <param name="SalaryID"></param>
	    /// <returns></returns>
        public int DeleleteTypeSalary(int SalaryID)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("DeleteFixSalary", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            
            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.Add("@SalaryID", SqlDbType.Int).Value = SalaryID;

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.Int);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return (int)result.Value;
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
        public DataSet GetTypeSalaryByContractID(int ContractID)
        {
            DataSet dsResult = new DataSet();
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("Select  *  From tblFixSalary Where ContractID = '" + ContractID.ToString() + "'", conn);
            sqlCommand.CommandType = CommandType.Text;
            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                dadapter.Fill(dsResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
            finally
            {
                conn.Close();
            }
            return dsResult;
        }

	    /// <summary>
        /// Lay thong tin chi tiet cua kieu luong co dinh
	    /// </summary>
	    /// <param name="salaryID"></param>
	    /// <returns></returns>
        public DataSet GetsalaryByID(int salaryID)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetsalaryByID", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@SalaryID", salaryID));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();
            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetSalaryByID");
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