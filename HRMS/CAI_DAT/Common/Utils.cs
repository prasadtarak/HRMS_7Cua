using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using XPTable.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace EVSoft.HRMS.Common
{
	/// <summary>
	/// Các hàm dùng chung
	/// </summary>
	public class Utils
	{
        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };



        public static string RemoveSign4VietnameseString(string str)
        {
            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }

            return str;
        }

		public static bool ExportExcel(XPTable.Models.Table table, String Title)
		{
			System.Threading.Thread thisThread = System.Threading.Thread.CurrentThread;
			CultureInfo originalCulture = thisThread.CurrentCulture;

			thisThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//chuyển regional setting sang US do lỗi của Excel

			try
			{
				// Launch Excel and make sure there is an open workbook.
				Excel.Application excel= new Excel.Application();

				ColumnModel columnModel = table.ColumnModel;
				Workbook book = excel.Workbooks.Add(XlSheetType.xlWorksheet);
				Worksheet sheet = (Worksheet)book.ActiveSheet;
				Range rCompanyName = (Range)sheet.Cells[1,"A"]; // di chuyển con trỏ đến hàng 1 cột A
				Range rTitle = (Range)sheet.Cells[2,"E"]; // di chuyển con trỏ đến hàng 2 cột E
				
				rCompanyName.Value2 = "CÔNG TY TNHH ESTELLE VIỆT NAM";// điền dữ liệu vào cell
				rCompanyName.Font.Bold = true;
				rTitle.Value2 = Title;// điền dữ liệu vào cell
				rTitle.Font.Bold = true;

				int rowIndex = 4; // Bắt đầu điền dữ liệu từ XPTable vào bảng Excel từ hàng thứ 4
				int colIndex = 0;

				// Fill the worksheet column headings from the dataset.
				foreach(Column col in columnModel.Columns)
				{
					colIndex++;	
					Excel.Range cell = (Excel.Range)excel.Cells[4,colIndex];
                    cell.NumberFormat = "@";
					cell.Value2 = col.Text;
					cell.ColumnWidth =  col.Width/6;
					cell.Font.Bold = true;
				}

				// Điền dữ liệu từ listview vào file excel
				for(rowIndex = 0;rowIndex < table.RowCount;rowIndex ++)
				{
					for(colIndex=0;colIndex < columnModel.Columns.Count;colIndex ++)
					{
						if (columnModel.Columns[colIndex] is TextColumn) 
						{
                            Excel.Range cell = (Excel.Range)excel.Cells[rowIndex + 5, colIndex + 1];
                            cell.NumberFormat = "@";
                            excel.Cells[rowIndex + 5, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Text;
						}
						else
						{
							excel.Cells[rowIndex+5,colIndex+1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Data;
						}
                       
					    
					}
				}
				excel.Visible = true;
				return true; // Xuất excel thành công
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false; // Xuất excel thất bại
			}
			finally
			{
				thisThread.CurrentCulture = originalCulture;//chuyển lại regional mặc định của máy
			}
		}

        /// <summary>
        /// Xuat excel ho tro barcode
        /// </summary>
        /// <param name="table"></param>
        /// <param name="Title"></param>
        /// <returns></returns>
        public static bool ExportExcelBC(XPTable.Models.Table table, String Title)
        {
            System.Threading.Thread thisThread = System.Threading.Thread.CurrentThread;
            CultureInfo originalCulture = thisThread.CurrentCulture;

            thisThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");//chuyển regional setting sang US do lỗi của Excel

            try
            {
                // Launch Excel and make sure there is an open workbook.
                Excel.Application excel = new Excel.Application();

                ColumnModel columnModel = table.ColumnModel;
                Workbook book = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet sheet = (Worksheet)book.ActiveSheet;
                Range rCompanyName = (Range)sheet.Cells[1, "A"]; // di chuyển con trỏ đến hàng 1 cột A
                //Range rTitle = (Range)sheet.Cells[2, "E"]; // di chuyển con trỏ đến hàng 2 cột E

                //rCompanyName.Value2 = "CÔNG TY TNHH ESTELLE VIỆT NAM";// điền dữ liệu vào cell
                //rCompanyName.Font.Bold = true;
                //rTitle.Value2 = Title;// điền dữ liệu vào cell
                //rTitle.Font.Bold = true;

                int rowIndex = 1; // Bắt đầu điền dữ liệu từ XPTable vào bảng Excel từ hàng thứ 4
                int colIndex = 0;

                // Fill the worksheet column headings from the dataset.
                foreach (Column col in columnModel.Columns)
                {
                    colIndex++;
                    Excel.Range cell = (Excel.Range)excel.Cells[1, colIndex];
                    cell.NumberFormat = "@";
                    cell.Value2 = col.Text;
                    cell.ColumnWidth = col.Width / 6;
                    cell.Font.Bold = true;
                }

                // Điền dữ liệu từ listview vào file excel
                for (rowIndex = 0; rowIndex < table.RowCount; rowIndex++)
                {
                    for (colIndex = 0; colIndex < columnModel.Columns.Count; colIndex++)
                    {
                        if (columnModel.Columns[colIndex] is TextColumn)
                        {
                            Excel.Range cell = (Excel.Range)excel.Cells[rowIndex + 2, colIndex + 1];
                            cell.NumberFormat = "@";
                            excel.Cells[rowIndex + 2, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Text;
                        }
                        else
                        {
                            excel.Cells[rowIndex + 2, colIndex + 1] = table.TableModel.Rows[rowIndex].Cells[colIndex].Data;
                        }


                    }
                }
                excel.Visible = true;
                return true; // Xuất excel thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false; // Xuất excel thất bại
            }
            finally
            {
                thisThread.CurrentCulture = originalCulture;//chuyển lại regional mặc định của máy
            }
        }
	}
}
