using System;
using System.Windows.Forms;
using HumanResourceUpdate.HumanResourceDataSetTableAdapters;
using System.Globalization;
using DevExpress.XtraBars;

namespace HumanResourceUpdate
{
    public partial class HumanResourceUpdateForm : Form
    {
        private GetAllEmployeesForUpdateTableAdapter adapter;

        private QueriesTableAdapter queryUpdate;
        public HumanResourceUpdateForm()
        {
            InitializeComponent();

            Cursor.Current = Cursors.WaitCursor;

            adapter = new GetAllEmployeesForUpdateTableAdapter();

            adapter.Fill(humanResourceDataSet.GetAllEmployeesForUpdate);

            queryUpdate = new QueriesTableAdapter();

            gridView1.BestFitColumns();

            Cursor.Current = Cursors.Default;
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                if (gridView1.FocusedColumn == colBasicSalary)
                {
                    decimal _ValueDecimal;
                    if (e.Value == null
                        || !decimal.TryParse(e.Value.ToString(), NumberStyles.Number, null, out _ValueDecimal)
                        || _ValueDecimal < 0)
                    {
                        e.ErrorText = "Lương cơ bản phải >= 0. Vui lòng kiểm tra lại.";
                        e.Valid = false;
                    }
                }
                else if (gridView1.FocusedColumn == colEmployeeName)
                {
                    if (e.Value == null || e.Value.ToString().Trim().Length == 0)
                    {
                        e.ErrorText = "Họ tên nhân viên không thể rỗng. Vui lòng kiểm tra lại.";
                        e.Valid = false;
                    }
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!gridView1.ValidateEditor())
                return;

            System.Windows.Forms.DialogResult result =
                MessageBox.Show(
                    this,
                    "Bạn có muốn lưu toàn bộ thông tin trong danh sách vào hệ thống?",
                    this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != System.Windows.Forms.DialogResult.Yes)
                return;

            Cursor = Cursors.WaitCursor;
            progressBarControl1.Visible = true;
            progressBarControl1.Properties.Maximum = gridView1.RowCount;
            progressBarControl1.Properties.Step = 0;
            for (int rowHandle = 0; rowHandle < gridView1.RowCount; rowHandle++)
            {
                int employeeID = (int)gridView1.GetRowCellValue(rowHandle, colEmployeeID);
                string employeeName = gridView1.GetRowCellDisplayText(rowHandle, colEmployeeName);
                decimal basicSalary = (decimal)gridView1.GetRowCellValue(rowHandle, colBasicSalary);
                string taxID = gridView1.GetRowCellDisplayText(rowHandle, colTaxID);

                object obj = gridView1.GetRowCellValue(rowHandle, colFamilyConditionNumber);
                short? familyConditionNumber = null;

                if (obj != DBNull.Value)
                    familyConditionNumber = (short)obj;

                if (taxID.Trim().Length == 0)
                    taxID = null;

                queryUpdate.UpdateEmployeeForTax2009(
                    employeeID,
                    employeeName, basicSalary, taxID, familyConditionNumber);

                progressBarControl1.Properties.Step = (rowHandle + 1);
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
                Application.DoEvents();
            }

            progressBarControl1.Visible = false;
            Cursor = Cursors.Default;

            MessageBox.Show(
                this,
                "Thông tin nhân sự cập nhật cho việc tính thuế mới đã được thực hiện thành công.",
                this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void HumanResourceUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}