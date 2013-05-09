//--------------------------------------------------------------------
//class       :
//purpose     :
//author      :tuyetna
//note        :


using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;


namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Lớp kết nối và thao tác với CSDL cho chức năng định nghĩa các loại hợp đồng
	/// </summary>
	public class ContractTypeDO
	{
		SqlConnection conn = null;
		SqlCommand sqlCommand = null;
		SqlDataAdapter dadapter = null;
		DataSet dataSet = null;
		
		/// <summary>
		/// Thêm mới kiểu hợp đồng
		/// </summary>
		/// <param name="dsContractType"></param>
		/// <returns></returns>
		
		
		public int AddContractTypeDO(DataSet dsDayType)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("AddContractType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			//sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractID",SqlDbType.Int ,"ContractID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractName",SqlDbType.NVarChar ,"ContractName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsurancePay", SqlDbType.Bit, "InsurancePay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note",SqlDbType.NVarChar,"Note"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dadapter = new SqlDataAdapter();
			dadapter.InsertCommand = sqlCommand;
			try
			{
				conn.Open();
				dadapter.Update(dsDayType,"tblContract");
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
		/// Lấy ra một bảng đưa vào DataSet
		/// </summary>
		/// <returns></returns>
		public DataSet GetContractType()
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "SELECT ContractID,ContractName,InsurancePay,Note FROM tblContract";
			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			dadapter= new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;
			dataSet = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(dataSet,"tblContract");
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

		public DataSet GetAllContract()
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("GetAllContracts",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			dadapter= new SqlDataAdapter();
			dadapter.SelectCommand=sqlCommand;

			dataSet = new DataSet();

			try
			{
				conn.Open();
				dadapter.Fill(dataSet,"GetAllContracts");
				return dataSet;   
			}

			catch(Exception oException)
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
		/// Cập nhật kiểu hợp đồng vào CSDL
		/// </summary>
		/// <param name=""></param>
		/// <returns></returns>
		public int UpdateContractType(DataSet dsContractType)
		{
			conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("UpdateContractType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractID",SqlDbType.Int,"ContractID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractName",SqlDbType.NVarChar,"ContractName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsurancePay", SqlDbType.Bit, "InsurancePay"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note",SqlDbType.NVarChar,"Note"));
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);

			dadapter = new SqlDataAdapter();
			dadapter.UpdateCommand = sqlCommand;

			try
			{
				conn.Open();
				dadapter.Update(dsContractType,"tblContract");
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
		/// Xóa kiều hợp đồng
		/// </summary>
		/// <param name="dsDayType"></param>
		/// <returns></returns>
		public int DeleteContractTypeDB(DataSet dsContractType)
		{
			
			SqlConnection conn = WorkingContext.GetConnection();
			sqlCommand = new SqlCommand("DeleteContractType",conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractID",SqlDbType.Int,"ContractID"));
			
			SqlParameter result = new SqlParameter("@ReturnValue",SqlDbType.Int);
			result.Direction = ParameterDirection.ReturnValue;
			sqlCommand.Parameters.Add(result);


			dadapter = new SqlDataAdapter();
			dadapter.DeleteCommand = sqlCommand;
			try
			{
				conn.Open();
				dadapter.Update(dsContractType.Tables[0]);
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
        public DataSet GetFixSalaryByContract(int ContractID)
        {
            DataSet Result = new DataSet();
            
            SqlConnection conn = WorkingContext.GetConnection();
           
            sqlCommand.Parameters.Clear();
            sqlCommand = new SqlCommand("GetFixSalaryByContractID", conn);            
            sqlCommand.Parameters.Add(new SqlParameter("@ContractID", ContractID));
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


//		public ContractType()
//		{
//			//
//			// TODO: Add constructor logic here
//			//
//		}
	}
}
