using System;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Summary description for EmployeeStatus.
	/// </summary>
	public class EmployeeStatus
	{
		/// <summary>
		/// Nhân viên đang làm việc (có quẹt thẻ)
		/// </summary>
		public const int EMPLOYEE_WORKING = 1;
		/// <summary>
		/// Nhân viên đã đăng ký đi công tác
		/// </summary>
		public const int EMPLOYEE_LEAVE = 2;
		/// <summary>
		/// Nhân viên đã đăng ký nghỉ
		/// </summary>
		public const int EMPLOYEE_REST = 3;
		/// <summary>
		/// Nhân viên vắng mặt (không có dữ liệu quẹt thẻ)
		/// </summary>
		public const int EMPLOYEE_ABSENT = 4;
		/// <summary>
		/// Có lỗi xảy ra
		/// </summary>
		public const int EMPLOYEE_ERROR = 0;
		/// <summary>
		/// Nhân viên đã quẹt thẻ về
		/// </summary>
		public const int EMPLOYEE_GOHOME = 5;
	}
}
