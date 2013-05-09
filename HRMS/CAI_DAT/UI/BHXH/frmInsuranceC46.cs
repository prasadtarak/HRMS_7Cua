using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.DO;

namespace EVSoft.HRMS.UI.BHXH
{
    public partial class frmInsuranceC46 : Form
    {
        SocialInsuranceDO socialInsuranceDO = new SocialInsuranceDO();

        public frmInsuranceC46()
        {
            InitializeComponent();
        }

        private void TimeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboQuarter.SelectedIndex == -1) || (cboYear.SelectedIndex == -1)) return;
            DataTable tbl = socialInsuranceDO.GetInsuranceC46(int.Parse(cboQuarter.Text), int.Parse(cboYear.Text));
            ResetTableValue();
            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                    if (row["Checked"].ToString().ToUpper() == "TRUE")
                        InsertInfo(row, 2);
                    else if (row["Checked"].ToString().ToUpper() == "FALSE")
                        InsertInfo(row, 1);
                tblDetail.BeginUpdate();
                for (int i = 0; i < 6; i++)
                    tblmdlDetail.Rows[i].Cells[3].Data = decimal.Parse(tblmdlDetail.Rows[i].Cells[1].Data.ToString()) - decimal.Parse(tblmdlDetail.Rows[i].Cells[2].Data.ToString());
                tblDetail.EndUpdate();
            }
        }

        private void ResetTableValue()
        {
            tblDetail.BeginUpdate();
            for (int colxp = 1; colxp < tblcolDetail.Columns.Count; colxp++)
                for (int rowxp = 0; rowxp < tblmdlDetail.Rows.Count; rowxp++)
                    tblmdlDetail.Rows[rowxp].Cells[colxp].Data = 0;
            tblDetail.EndUpdate();
        }
        private void InsertInfo(DataRow row, int ColIndex)
        {
            tblDetail.BeginUpdate();
            tblmdlDetail.Rows[0].Cells[ColIndex].Data = row["TotalEmployee"];
            tblmdlDetail.Rows[1].Cells[ColIndex].Data = row["TotalSalary"];
            tblmdlDetail.Rows[2].Cells[ColIndex].Data = row["TotalPay"];
            tblmdlDetail.Rows[3].Cells[ColIndex].Data = row["LastBring"];
            tblmdlDetail.Rows[4].Cells[ColIndex].Data = row["ReadyPay"];
            tblmdlDetail.Rows[5].Cells[ColIndex].Data = row["NextSend"];
            tblDetail.EndUpdate();
        }

        private void frmInsuranceC46_Load(object sender, EventArgs e)
        {
            LoadThisTime();
        }

        private void LoadThisTime()
        {
            /*Quarter Year*/
            double OnQuarter = ((double)(DateTime.Now.Month)) / 3 + 0.7;            
            
            /*Year Number*/
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 50; i--)
                cboYear.Items.Add(i);

            cboQuarter.SelectedIndex =cboQuarter.FindStringExact(((int)OnQuarter).ToString());
            cboYear.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*Lưu thông tin vào cơ sở dữ liệu*/
            if (!(SingleRowInsert(true) & (SingleRowInsert(false))))
            {
                MessageBox.Show("Thông tin ngày tháng đầu vào sai", "Thông báo");
                return;
            }
            /*Hiển thị báo cáo*/
            int IQuarter = int.Parse(cboQuarter.Text);
            int IYear = int.Parse(cboYear.Text);
            string SocialInsuranceOffice = txtSocialInsuranceOffice.Text;
            string ComName = txtComName.Text;
            string ComAddress = txtComAddress.Text;
            string ComAcc = txtComAcc.Text;
            string ComBank = txtComBank.Text;
            string ComTel = txtComTel.Text;
            string ComFax = txtComFax.Text;
            string YC1 = txtYC1.Text;
            string YC2 = txtYC2.Text;
            string YC3 = txtYC3.Text;
            string YC4 = txtYC4.Text;
            string YC5 = txtYC5.Text;
            string YC6 = txtYC6.Text;
            string YC7 = txtYC7.Text;
            string YC8 = txtYC8.Text;
            DateTime CreateDate = dtCreateDate.Value;
            string CopyNum = txtCopyNum.Text;
            string ComID = txtComID.Text;
            frmReport frm = new frmReport();
            frm.ShowInsuranceC46(IQuarter, IYear, SocialInsuranceOffice, ComName, ComAddress, ComAcc, ComBank, ComTel, ComFax, YC1, YC2, YC3, YC4, YC5, YC6, YC7, YC8, CreateDate, CopyNum, ComID);
        }

        private bool SingleRowInsert(bool RowChecked)
        { 
            int i= 1;
            if (RowChecked)
                i = 2;
            int IQuarter = 0;
            int IYear = 0;
            int TotalEmployee = 0;
            decimal TotalSalary = 0;
            decimal TotalPay = 0;
            decimal LastBring = 0;
            decimal ReadyPay = 0;
            decimal Nextsend = 0;
            if (!int.TryParse(cboQuarter.Text, out IQuarter))
                return false;
            if (!int.TryParse(cboYear.Text, out IYear))
                return false;
            int.TryParse(tblDetail.TableModel.Rows[0].Cells[i].Data.ToString(), out TotalEmployee);
            decimal.TryParse(tblDetail.TableModel.Rows[1].Cells[i].Data.ToString(), out TotalSalary);
            decimal.TryParse(tblDetail.TableModel.Rows[2].Cells[i].Data.ToString(), out TotalPay);
            decimal.TryParse(tblDetail.TableModel.Rows[3].Cells[i].Data.ToString(), out LastBring);
            decimal.TryParse(tblDetail.TableModel.Rows[4].Cells[i].Data.ToString(), out ReadyPay);
            decimal.TryParse(tblDetail.TableModel.Rows[5].Cells[i].Data.ToString(), out Nextsend);
            socialInsuranceDO.UpdateInsuranceC46(RowChecked, IQuarter, IYear, TotalEmployee, TotalSalary, TotalPay, LastBring, ReadyPay, Nextsend);
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}