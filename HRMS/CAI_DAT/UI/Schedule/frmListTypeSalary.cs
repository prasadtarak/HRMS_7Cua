using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using XPTable.Models;
namespace EVSoft.HRMS.UI.Schedule
{
    public partial class frmListTypeSalarys : Form
    {
        DayTypeDO DayType = new DayTypeDO();
        public frmListTypeSalarys()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddSalaryType FrmAdd = new frmAddSalaryType(-1, "", "","",0,this);
            FrmAdd.StartPosition = FormStartPosition.CenterScreen; 
            FrmAdd.ShowDialog();
        }
        public void Init()
        {
            DataSet TypeSalary = DayType.GetTypeSalary();
            tblTypeSalary.TableModel.Rows.Clear();
            int STT =0;
            if (TypeSalary != null)
            {
                if(TypeSalary.Tables.Count > 0)
                {  
                    
                    foreach (DataRow r in TypeSalary.Tables[0].Rows)
                    {
                    STT += 1;
                    Row row = new Row(new string[] { STT.ToString(),r["SalaryName"].ToString(),r["SalaryDescription"].ToString(),r["ContractName"].ToString(),r["SalaryBasic"].ToString(),r["SalaryID"].ToString()});
                    tblTypeSalary.TableModel.Rows.Add(row);
                    
                    }
                }
            }
        }

        private void frmListTypeSalarys_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tblTypeSalary.SelectedItems.Length > 0)
            {
                Row r = tblTypeSalary.SelectedItems[0];
                frmAddSalaryType FrmAdd = new frmAddSalaryType(Convert.ToInt16(r.Cells[5].Text), r.Cells[1].Text, r.Cells[2].Text, r.Cells[3].Text, Convert.ToDecimal(r.Cells[4].Text),this);
                FrmAdd.StartPosition = FormStartPosition.CenterScreen;
                FrmAdd.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (tblTypeSalary.SelectedItems.Length > 0)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int check = 0;
                    try
                    {
                        check = DayType.DeleleteTypeSalary(Convert.ToInt16(tblTypeSalary.SelectedItems[0].Cells[5].Text));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "thông báo");
                    }

                    if (check == 0)
                        MessageBox.Show("Xóa thất bại. Kiểu lương cố định này đã được sử dụng !","Thông báo");
                    else if(check==-1)
                        MessageBox.Show("Lỗi hệ thống !", "Thông báo");
                    else if (check == 1)
                        MessageBox.Show("Xóa thành công !", "Thông báo");
                    
                    this.Init();
                    
                }
            }
        }

        private void tblTypeSalary_DoubleClick(object sender, EventArgs e)
        {
            if (tblTypeSalary.SelectedItems.Length > 0)
            {
                Row r = tblTypeSalary.SelectedItems[0];
                frmAddSalaryType FrmAdd = new frmAddSalaryType(Convert.ToInt16(r.Cells[5].Text), r.Cells[1].Text, r.Cells[2].Text, r.Cells[3].Text, Convert.ToDecimal(r.Cells[4].Text), this);
                FrmAdd.StartPosition = FormStartPosition.CenterScreen;
                FrmAdd.ShowDialog();
            }
        }

    }
}