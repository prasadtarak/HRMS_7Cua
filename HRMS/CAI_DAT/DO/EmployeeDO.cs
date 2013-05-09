//------------------------------------------------------------------------------------
//Class		: EmployeeDO
//Purpose	: Thực hiện các thao tác liên quan đến CSDL nhân viên
//			  Thêm, sửa, xóa hồ sơ nhân viên
//Author	: dungnt 16-6-2005
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
    /// Lớp kết nối và thao tác cơ sở dữ liệu của chức năng quản lý nhân viên
    /// </summary>
    public class EmployeeDO
    {
        SqlConnection conn = null;
        SqlCommand sqlCommand = null;
        SqlParameter param = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;

        #region Employee
        /// <summary>
        /// Lấy thông tin hồ sơ một nhân viên
        /// </summary>
        public DataSet GetAllEmployees(int DepartmentID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetAllEmployees", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);
            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetAllEmployees");
                return dataSet;
            }

            catch (Exception oException)
            {
                //MessageBox.Show(oException.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Lấy thông tin hồ sơ các nhân viên trong một phòng
        /// </summary>
        public DataSet GetEmployeeByDepartment(int DepartmentID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetEmployeeByDepartment", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetEmployeeByDepartment");
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
        /// Lấy danh sách nhân viên theo phòng ban và ngày vào phòng ban để thiết lập ăn trưa
        /// </summary>
        /// <param name="iDepartmentID"></param>
        /// <param name="dtLunch"></param>
        /// <returns></returns>
        public DataSet GetEmployeeForSettingLunch(int iDepartmentID, DateTime dtLunch)
        {
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("GetEmployeeByDepartmentAndDateLunch", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int)).Value = iDepartmentID;
            sqlCommand.Parameters.Add(new SqlParameter("@DateLunch", SqlDbType.DateTime)).Value = dtLunch;

            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetEmployeeByDepartmentAndDateLunch");
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
        /// Lấy thông tin hồ sơ các nhân viên đề nghị cấp sổ BHXH trong một phòng
        /// </summary>
        public DataSet GetEmployeeByDepartmentInsurance(int DepartmentID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetEmployeeByDepartmentInsurance", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetEmployeeByDepartment");
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
        /// Lấy danh sách những nhân viên đã bị xóa tạm thời
        /// </summary>
        /// <returns></returns>
        public DataSet GetDeletedEmployee(int DepartmentID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetDeletedEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDeletedEmployee");
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
        /// Lấy danh sách những nhân viên đề nghị cấp sổ BHXH đã bị xóa tạm thời
        /// </summary>
        /// <returns></returns>
        public DataSet GetDeletedEmployeeInsurance(int DepartmentID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetDeletedEmployeeInsurance", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDeletedEmployeeInsurance");
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
        /// Lấy thông tin hồ sơ các nhân viên trong một phòng
        /// </summary>
        public DataSet GetSearchEmployee(int DepartmentID, string SearchString, int delete)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetSearchEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@DepartmentID", DepartmentID);
            sqlCommand.Parameters.Add(param);
            param = new SqlParameter("@SearchString", SearchString);
            sqlCommand.Parameters.Add(param);
            param = new SqlParameter("@delete", delete);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetSearchEmployee");
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
        /// Lấy thông tin hồ sơ một nhân viên
        /// </summary>
        /// <param name="EmployeeID">Mã nhân viên</param>
        /// <returns>Hồ sơ nhân viên</returns>
        public DataSet GetEmployeeProfile(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetEmployeeProfile", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetEmployeeProfile");
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
        /// Thêm một nhân viên vào cơ sở dữ liệu
        /// </summary>
        /// <param name="EmployeeInfo">Thông tin hồ sơ nhân viên</param>
        /// <returns></returns>
        public int AddNewEmployee(DataSet EmployeeInfo)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddNewEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CardID", SqlDbType.NVarChar, "CardID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeName", SqlDbType.NVarChar, "EmployeeName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IdentityCard", SqlDbType.NVarChar, "IdentityCard"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@AllocationPlace", SqlDbType.NVarChar, "AllocationPlace")); 
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Issue", SqlDbType.DateTime, "Issue"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceID", SqlDbType.VarChar, "InsuranceID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Gender", SqlDbType.TinyInt, "Gender"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DateOfBirth", SqlDbType.DateTime, "DateOfBirth"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BirthPlace", SqlDbType.NVarChar, "BirthPlace"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Resident", SqlDbType.NVarChar, "Resident"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Address", SqlDbType.NVarChar, "Address"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Commune", SqlDbType.NVarChar, "Commune"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@District", SqlDbType.NVarChar, "District"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Province", SqlDbType.NVarChar, "Province"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Phone", SqlDbType.NVarChar, "Phone"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Email", SqlDbType.NVarChar, "Email"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@MarriageStatus", SqlDbType.SmallInt, "MarriageStatus"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@People", SqlDbType.Int, "People"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Religious", SqlDbType.Int, "Religious"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Qualification", SqlDbType.SmallInt, "Qualification"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ProfessionalLevel", SqlDbType.SmallInt, "ProfessionalLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EnglishLevel", SqlDbType.SmallInt, "EnglishLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InformaticLevel", SqlDbType.SmallInt, "InformaticLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OtherCertificate", SqlDbType.NVarChar, "OtherCertificate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Discipline", SqlDbType.NVarChar, "Discipline"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RecruitDate", SqlDbType.DateTime, "RecruitDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartDate", SqlDbType.DateTime, "StartDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartTrial", SqlDbType.DateTime, "StartTrial"));
            //sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StopDate", SqlDbType.DateTime, "StopDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractID", SqlDbType.Int, "ContractID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BasicSalary", SqlDbType.Money, "BasicSalary"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchAllowance", SqlDbType.Money, "LunchAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@HarmfulAllowance", SqlDbType.Money, "HarmfulAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ResponsibleAllowance", SqlDbType.Money, "ResponsibleAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IntimateAllowance", SqlDbType.Money, "IntimateAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IntimateAllowanceFixed", SqlDbType.Bit, "IntimateAllowanceFixed"));
            //ChinhND bo sung them phan tro cap nguy hiem va tro cap tieng Nhat
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DangerousAllowance", SqlDbType.Money, "DangerousAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@JapaneseAllowance", SqlDbType.Money, "JapaneseAllowance"));
            //end update
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentID", SqlDbType.Int, "DepartmentID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Picture", SqlDbType.VarChar, "Picture"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartDateInsurance", SqlDbType.DateTime, "StartDateInsurance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Nationality", SqlDbType.NVarChar, "Nationality"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SalaryID", SqlDbType.Int, "SalaryID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@HospitalID", SqlDbType.Char, "HospitalID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TaxID", SqlDbType.Char, "TaxID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@FamilyConditionNumber", SqlDbType.SmallInt, "FamilyConditionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BarCode", SqlDbType.VarChar, "BarCode"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TemporaryAddress", SqlDbType.NVarChar, "TemporaryAddress"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.SmallInt);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(EmployeeInfo.Tables[0]);
                return (int)result.Value;
            }
            catch (SqlException oException)
            {
                Console.WriteLine(oException.ToString());
                return 0;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }

        /// <summary>
        /// Cập nhật thông tin hồ sơ nhân viên
        /// </summary>
        /// <param name="EmployeeInfo"></param>
        /// <returns></returns>
        public int UpdateEmployee(DataSet EmployeeInfo)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CardID", SqlDbType.NVarChar, "CardID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeName", SqlDbType.NVarChar, "EmployeeName"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IdentityCard", SqlDbType.NVarChar, "IdentityCard"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Issue", SqlDbType.DateTime, "Issue"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceID", SqlDbType.VarChar, "InsuranceID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@AllocationPlace", SqlDbType.NVarChar, "AllocationPlace")); 
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Gender", SqlDbType.TinyInt, "Gender"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DateOfBirth", SqlDbType.DateTime, "DateOfBirth"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BirthPlace", SqlDbType.NVarChar, "BirthPlace"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Resident", SqlDbType.NVarChar, "Resident"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Address", SqlDbType.NVarChar, "Address"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Commune", SqlDbType.NVarChar, "Commune"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@District", SqlDbType.NVarChar, "District"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Province", SqlDbType.NVarChar, "Province"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Phone", SqlDbType.NVarChar, "Phone"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Email", SqlDbType.NVarChar, "Email"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@MarriageStatus", SqlDbType.SmallInt, "MarriageStatus"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@People", SqlDbType.Int, "People"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Religious", SqlDbType.Int, "Religious"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Qualification", SqlDbType.SmallInt, "Qualification"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ProfessionalLevel", SqlDbType.SmallInt, "ProfessionalLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EnglishLevel", SqlDbType.SmallInt, "EnglishLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InformaticLevel", SqlDbType.SmallInt, "InformaticLevel"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@OtherCertificate", SqlDbType.NVarChar, "OtherCertificate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Discipline", SqlDbType.NVarChar, "Discipline"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@RecruitDate", SqlDbType.DateTime, "RecruitDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartDate", SqlDbType.DateTime, "StartDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartTrial", SqlDbType.DateTime, "StartTrial"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StopDate", SqlDbType.DateTime, "StopDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ContractID", SqlDbType.Int, "ContractID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BasicSalary", SqlDbType.Money, "BasicSalary"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@LunchAllowance", SqlDbType.Money, "LunchAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@HarmfulAllowance", SqlDbType.Money, "HarmfulAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ResponsibleAllowance", SqlDbType.Money, "ResponsibleAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IntimateAllowance", SqlDbType.Money, "IntimateAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@IntimateAllowanceFixed", SqlDbType.Bit, "IntimateAllowanceFixed"));
            //ChinhND bo sung them phan tro cap nguy hiem va tro cap tieng Nhat
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DangerousAllowance", SqlDbType.Money, "DangerousAllowance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@JapaneseAllowance", SqlDbType.Money, "JapaneseAllowance"));
            //end update
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentID", SqlDbType.Int, "DepartmentID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Picture", SqlDbType.VarChar, "Picture"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@StartDateInsurance", SqlDbType.DateTime, "StartDateInsurance"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Nationality", SqlDbType.NVarChar, "Nationality"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@InsuranceShelf", SqlDbType.Bit, "InsuranceShelf"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SalaryID", SqlDbType.Int, "SalaryID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@HospitalID", SqlDbType.Char, "HospitalID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TaxID", SqlDbType.Char, "TaxID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@FamilyConditionNumber", SqlDbType.SmallInt, "FamilyConditionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BarCode", SqlDbType.VarChar, "BarCode"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@TemporaryAddress", SqlDbType.NVarChar, "TemporaryAddress"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.SmallInt);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(EmployeeInfo.Tables[0]);
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

        public int UpdateBarCode(DataSet EmployeeInfo)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateBarCode", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@CardID", SqlDbType.NVarChar, "CardID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BarCode", SqlDbType.VarChar, "BarCode"));

            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.SmallInt);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                dataAdapter.Update(EmployeeInfo.Tables[0]);
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
        /// Xóa nhân viên tạm thời (Remove nhân viên khỏi các danh sách nhưng chưa xóa hoàn toàn trong CSDL: Deleted = 1)
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int DeleteEmployee(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("DeleteEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);
            SqlParameter result = new SqlParameter("@ReturnValue", SqlDbType.SmallInt);
            result.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(result);


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

        /// <summary>
        /// Xóa hoàn toàn nhân viên khỏi cơ sở dữ liệu (Cùng với tất cả các dữ liệu có liên quan)
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteEmployeePermanent(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteEmployeePermanent", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// Xóa nhân viên ra khỏi danh sách cần cấp BHXH (InsuranceCheck=1)
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteEmployeeInsurance(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeInsurance", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// Khôi phục nhân viên đề nghị cấp BHXH đã bị xóa (InsuranceCheck=1)
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int RestoreEmployeeInsurance(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("RestoreEmployeeInsurance", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

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

        /// <summary>
        /// Khôi phục nhân viên đã bị xóa (Deleted = 0)
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int RestoreEmployee(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("RestoreEmployee", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

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
        #endregion

        #region Department History

        /// <summary>
        /// Lấy thông tin hồ sơ các nhân viên trong một phòng
        /// </summary>
        public DataSet GetDepartmentHistory(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetDepartmentHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDepartmentHistory");
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
        /// Thêm lịch sử phòng ban mới
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int AddDepartmentHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddDepartmentHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentID", SqlDbType.Int, "DepartmentID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdateDepartmentHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateDepartmentHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentHistoryID", SqlDbType.Int, "DepartmentHistoryID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentID", SqlDbType.Int, "DepartmentID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteDepartmentHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteDepartmentHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DepartmentHistoryID", SqlDbType.Int, "DepartmentHistoryID"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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

        #endregion

        #region Position History

        /// <summary>
        /// Lấy thông tin hồ sơ các nhân viên trong một phòng
        /// </summary>
        public DataSet GetPositionHistory(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetPositionHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetPositionHistory");
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
        /// Thêm lịch sử phòng ban mới
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int AddPositionHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddPositionHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdatePositionHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdatePositionHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionHistoryID", SqlDbType.Int, "PositionHistoryID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionID", SqlDbType.Int, "PositionID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeletePositionHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeletePositionHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@PositionHistoryID", SqlDbType.Int, "PositionHistoryID"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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

        #endregion

        #region Salary History

        /// <summary>
        /// Lấy thông tin hồ sơ các nhân viên trong một phòng
        /// </summary>
        public DataSet GetSalaryHistory(int EmployeeID)
        {
            conn = WorkingContext.GetConnection();
            // Build the command
            sqlCommand = new SqlCommand("GetSalaryHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            param = new SqlParameter("@EmployeeID", EmployeeID);
            sqlCommand.Parameters.Add(param);

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetSalaryHistory");
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


        public DataSet GetSalaryHistoryByMonth(int EmployeeID, int Year, int Month)
        { 
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("GetSalaryHistoryByMonth", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = EmployeeID;
            sqlCommand.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = Year;
            sqlCommand.Parameters.Add(new SqlParameter("@Month", SqlDbType.Int)).Value = Month;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetSalaryHistoryByMonth");
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
        /// Lấy thông tin log department của nhân viên theo tháng
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public DataSet GetDepartmentHistoryByMonth(int EmployeeID, int Year, int Month)
        { 
            conn = WorkingContext.GetConnection();
            sqlCommand = new SqlCommand("GetDepartmentHistoryByMonth", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int)).Value = EmployeeID;
            sqlCommand.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = Year;
            sqlCommand.Parameters.Add(new SqlParameter("@Month", SqlDbType.Int)).Value = Month;

            // Adapter and DataSet
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "GetDepartmentHistoryByMonth");
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int AddSalaryHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("AddSalaryHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BasicSalary", SqlDbType.Money, "BasicSalary"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int UpdateSalaryHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("UpdateSalaryHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SalaryHistoryID", SqlDbType.Int, "SalaryHistoryID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@EmployeeID", SqlDbType.Int, "EmployeeID"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@BasicSalary", SqlDbType.Money, "BasicSalary"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@DecisionNumber", SqlDbType.NVarChar, "DecisionNumber"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@ModifiedDate", SqlDbType.DateTime, "ModifiedDate"));
            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@Note", SqlDbType.NVarChar, "Note"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        /// 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public int DeleteSalaryHistory(DataSet dataSet)
        {
            SqlConnection conn = WorkingContext.GetConnection();
            // Build the command
            SqlCommand sqlCommand = new SqlCommand("DeleteSalaryHistory", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(WorkingContext.CreateParam("@SalaryHistoryID", SqlDbType.Int, "SalaryHistoryID"));

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = sqlCommand;

            try
            {
                conn.Open();
                return dataAdapter.Update(dataSet.Tables[0]);
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
        #endregion

        public int UpdateLunchCompany(Double lunchAllowance)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdateLunchCompany", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@AddLunch", lunchAllowance);
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
        }

        public int UpdateBasicSalary(Double addSalary)
        {
            SqlConnection conn = WorkingContext.GetConnection();

            SqlCommand sqlCommand = new SqlCommand("UpdateBasicSalary", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@AddSalary", addSalary);
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
        }
    }
}
