//------------------------------------------------------------------------------------
//Class		: WorkingDayReportDO.cs
//Purpose	: Lấy dữ liệu để kết xuất báo cáo từ CSDL
//			  
//Author	: dungnt 16-6-2005
//Modify	: 
//------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.DO
{
	/// <summary>
	/// Lớp kết nối và thao tác cơ sở dữ liệu của chức năng tạo báo cáo
	/// </summary>
	public class WorkingDayReportDO
	{

		//----------------------------------------------------------------------------
		//Purpose	: Lấy dữ liệu báo cáo
		//Input		: Thời điểm bắt đầu, thời điểm kết thúc
		//Output	: 
		//----------------------------------------------------------------------------
		public DataSet getReportInfo(string FromDate, string ToDate)
		{
			SqlConnection conn = WorkingContext.GetConnection();
			// Build the command
			string strSQL = "SELECT tblEmployee.CardID AS [Mã thẻ], tblDepartment.DepartmentName AS [Bộ phận], tblEmployee.EmployeeName as [Tên nhân viên], tblEmployee.IdentityCard as [Số CMND], tblTimeInOut.TimeInOut as [Thời gian vào ra]";
			strSQL += " FROM tblEmployee INNER JOIN tblDepartment on tblEmployee.DepartmentID = tblDepartment.DepartmentID ";
			strSQL += " INNER JOIN tblTimeInOut on tblEmployee.EmployeeID = tblTimeInOut.EmployeeID ";
			strSQL += " WHERE tblTimeInOut.WorkingDay >= '" + FromDate + "' AND tblTimeInOut.WorkingDay <= '" + ToDate + "' ";

			SqlCommand sqlCommand = new SqlCommand(strSQL, conn);

			// Adapter and DataSet
			SqlDataAdapter dataAdapter = new SqlDataAdapter();
			dataAdapter.SelectCommand = sqlCommand;
			DataSet dataSet = new DataSet();

			try
			{
				conn.Open();
				dataAdapter.Fill(dataSet, "ReportInfo");
				return dataSet;
			}

			catch (Exception oException)
			{
				throw oException;
			}
			finally
			{
				conn.Close();
			}
		}

		//----------------------------------------------------------------------------
		//Purpose	: 
		//Input		: 
		//Output	: 
		//----------------------------------------------------------------------------
		public void getWokingDayInfo()
		{
		}
	}
}