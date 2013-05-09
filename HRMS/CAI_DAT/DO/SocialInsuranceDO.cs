using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Summary description for SocialInsurance.
	/// </summary>

	
	public class SocialInsuranceDO
	{
		DataSet dsInsurance = null;
		SqlDataAdapter dadapter = null;
		public SocialInsuranceDO()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public DataSet GetListInsuranceInYear(int Year)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetListInsuranceInYear", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter para = new SqlParameter("@Year",SqlDbType.Int);
			para.Value = Year;
			sqlCommand.Parameters.Add(para);

			dadapter = new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			dsInsurance = new DataSet();
 
			try
			{
				conn.Open();
				dadapter.Fill(dsInsurance);
				return dsInsurance;
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
		/// L?y danh sách t?t c? nhân viên xét thanh toán b?o hi?m x? h?i trong theo đ?t
		/// </summary>
		/// <param name="PeriodID"></param>
		/// <returns></returns>
		public DataSet GetSocialInsurance(DateTime fromDate, DateTime toDate )
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GetSocialInsurance", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter para = new SqlParameter("@FromDate",SqlDbType.DateTime);
			para.Value = fromDate;
			sqlCommand.Parameters.Add(para);
			SqlParameter para2= new SqlParameter("@ToDate",SqlDbType.DateTime);
			para2.Value = toDate;
			sqlCommand.Parameters.Add(para2);

			dadapter = new SqlDataAdapter();
			dadapter.SelectCommand = sqlCommand;
			DataSet ds = new DataSet();
 
			try
			{
				conn.Open();
				dadapter.Fill(ds,"GetSocialInsurance");
				return ds;
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
		/// sinh bang tong thanh toan BHXH de xuat
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public int GenerateSocialInsurance(DateTime startDate, DateTime endDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("GenerateSocialInsurance", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(new SqlParameter("@StartDate",startDate));
			sqlCommand.Parameters.Add(new SqlParameter("@EndDate", endDate));
 
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;
 
			try
			{
				conn.Open();
				return sqlCommand.ExecuteNonQuery();
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
		/// Cập nhật bảng thanh toán BHXH
		/// </summary>
		/// <returns></returns>
		public int UpdateSocialInsuranceDO(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("UpdateSocialInsurance", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PeriodID", SqlDbType.Int, "PeriodID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RestDays", SqlDbType.Int, "RestDays"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@MoneyAllowance", SqlDbType.Money, "MoneyAllowance"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RestDaysApproved", SqlDbType.Int, "RestDaysApproved"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@AllRestDayApprovedInYear", SqlDbType.Int, "AllRestDayApprovedInYear"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsurancePeriod", SqlDbType.Float, "InsurancePeriod"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TotalRestInYear", SqlDbType.Int, "TotalRestInYear"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@MoneyAllowanceApproved", SqlDbType.Money, "MoneyAllowanceApproved"));
 
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
		public int DeleteSocialSheetDO(DataSet dataSet)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			SqlCommand sqlCommand = new SqlCommand("DeleteSocialSheet", conn);
			sqlCommand.CommandType = CommandType.StoredProcedure;
 
		
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PeriodID", SqlDbType.Int, "PeriodID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RegRestID", SqlDbType.Int, "RegRestID"));
			sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
			//sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Month", SqlDbType.Int, "Month"));
 
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
        /// Lấy thông tin phần 1 của báo cáo BHXH mẫu c47
        /// </summary>
        /// <param name="IDate"></param>
        /// <returns></returns>
        public DataTable GetInsuranceC47Part1(DateTime IDate)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetSocialInsurance_C47_P1", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@Date", SqlDbType.DateTime);
            para.Value = IDate;
            sqlCommand.Parameters.Add(para);

            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataTable tbl = new DataTable("InsuranceC47P1");

            try
            {
                conn.Open();
                dadapter.Fill(tbl);
                return tbl;
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
        /// Lấy phần 2 của mẫu C47 tháng này
        /// </summary>
        /// <returns>DataTable</returns>
        #region GetInsuranceC47Part2Now
        public DataTable GetInsuranceC47Part2Now(DateTime IDate)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetSocialInsurance_C47_P2", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@Date", SqlDbType.DateTime);
            para.Value = IDate;
            sqlCommand.Parameters.Add(para);

            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataTable tbl = new DataTable("Insurance_C47_P2Now");

            try
            {
                conn.Open();
                dadapter.Fill(tbl);
                return tbl;
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
        #endregion

        /// <summary>
        /// Lấy phần 2 mẫu báo cáo C47 dữ liệu có sẵn
        /// </summary>
        /// <param name="IDate"></param>
        /// <returns>DataTable</returns>
        #region GetInsuranceC47Part2Had
        public DataTable GetInsuranceC47Part2Had(DateTime IDate)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetSocialInsurance_C47_P2DB_Had", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("@Date", SqlDbType.DateTime);
            para.Value = IDate;
            sqlCommand.Parameters.Add(para);

            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataTable tbl = new DataTable("Insurance_C47_P2Had");

            try
            {
                conn.Open();
                dadapter.Fill(tbl);
                return tbl;
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
        #endregion

        /// <summary>
        /// Biên bản đối chiếu mẫu C46
        /// </summary>
        /// <param name="IQuarter">Quý</param>
        /// <param name="IYear">Tháng</param>
        /// <returns>DataTable</returns>
        #region GetInsuranceC46
        public DataTable GetInsuranceC46(int IQuarter,int IYear)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("GetSocialInsurance_C46", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("@IQuarter", SqlDbType.TinyInt);
            para1.Value = IQuarter;
            sqlCommand.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("@IYear", SqlDbType.Int);
            para2.Value = IYear;
            sqlCommand.Parameters.Add(para2);

            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataTable tbl = new DataTable("SocialInsurance_C46");

            try
            {
                conn.Open();
                dadapter.Fill(tbl);
                return tbl;
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
        #endregion

        /// <summary>
        /// Lưu thông tin chi tiết C46
        /// </summary>
        /// <param name="IQuarter">Quý</param>
        /// <param name="IYear">Tháng</param>
        /// <returns>DataTable</returns>
        #region GetInsuranceC47Part2Had
        public bool UpdateInsuranceC46(bool Checked,int IQuarter, int IYear,int TotalEmployee,decimal TotalSalary,decimal TotalPay,decimal LastBring,decimal ReadyPay,decimal Nextsend)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateSocialInsurancePay", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(ReturnPara("@Checked", Checked, SqlDbType.Bit));
            sqlCommand.Parameters.Add(ReturnPara("@IQuarter", IQuarter, SqlDbType.TinyInt));
            sqlCommand.Parameters.Add(ReturnPara("@IYear", IYear, SqlDbType.Int));
            sqlCommand.Parameters.Add(ReturnPara("@TotalEmployee", TotalEmployee, SqlDbType.Int));
            sqlCommand.Parameters.Add(ReturnPara("@TotalSalary", TotalSalary, SqlDbType.Money));
            sqlCommand.Parameters.Add(ReturnPara("@TotalPay", TotalPay, SqlDbType.Money));
            sqlCommand.Parameters.Add(ReturnPara("@LastBring", LastBring, SqlDbType.Money));
            sqlCommand.Parameters.Add(ReturnPara("@ReadyPay", ReadyPay, SqlDbType.Money));
            sqlCommand.Parameters.Add(ReturnPara("@Nextsend", Nextsend, SqlDbType.Money));

            dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = sqlCommand;
            DataTable tbl = new DataTable("SocialInsurance_C46");

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception oException)
            {
                MessageBox.Show(oException.ToString());
                return false;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }
        #endregion

        private SqlParameter ReturnPara(string ParaName, object ParaValue, SqlDbType TypeOfValue)
        {
            SqlParameter para = new SqlParameter(ParaName, TypeOfValue);
            para.Value = ParaValue;
            return para;
        }

    }
}
