using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EVSoft.HRMS.DO;
using XPTable.Editors;
using XPTable.Models;

namespace EVSoft.HRMS.UI.BHXH
{
    public partial class frmInsuranceC47 : Form
    {
        SocialInsuranceDO socialInsuranceDO = new SocialInsuranceDO();
        decimal sumGreater = 0;
        decimal sumLess = 0;
        int Inrc = 0;

        public frmInsuranceC47()
        {
            InitializeComponent();
        }

        private void frmInsuranceC47_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(tbl.Rows.Count.ToString());
            dtIDate.Value = DateTime.Now;
        }

        #region P1
        private void LoadFirstPart()
        {
            DataTable tbl = socialInsuranceDO.GetInsuranceC47Part1(dtIDate.Value);
            Inrc = 0;
            tblP1.BeginUpdate();
            tblmdlP1.Rows.Clear();
            sumGreater = 0;
            sumLess = 0;
            foreach (DataRow row in tbl.Rows)
            {
                Inrc++;
                Row xpRow = NewTblP1BlankRow();
                xpRow.Cells[0].Text = Inrc.ToString();
                xpRow.Cells[1].Text = row["EmployeeName"].ToString();
                xpRow.Cells[2].Text = row["InsuranceID"].ToString();
                decimal OldSalary = 0;
                decimal BasicSalary = 0;
                decimal.TryParse(row["OldSalary"].ToString(), out OldSalary);
                decimal.TryParse(row["BasicSalary"].ToString(), out BasicSalary);
                xpRow.Cells[3].Data = OldSalary;
                xpRow.Cells[5].Data = BasicSalary;
                if (BasicSalary > OldSalary)
                {
                    xpRow.Cells[7].Data = BasicSalary - OldSalary;
                    xpRow.Cells[12].Data = (BasicSalary - OldSalary)*23/100;
                    sumGreater += (BasicSalary - OldSalary) * 23 / 100;
                }
                if (BasicSalary < OldSalary)
                {
                    xpRow.Cells[8].Data = OldSalary-BasicSalary;
                    xpRow.Cells[13].Data = (OldSalary - BasicSalary) * 23 / 100;
                    sumLess += (OldSalary - BasicSalary) * 23 / 100;
                }
                xpRow.Cells[14].Text = row["Note"].ToString();
                tblP1.TableModel.Rows.Add(xpRow);
            }
            tblP1.EndUpdate();
        }
        private Row NewTblP1BlankRow()
        {
            Row xpRow = new Row();
            for(int i=0;i<tblcolP1.Columns.Count;i++)
                xpRow.Cells.Add(new Cell(""));
            return xpRow;
        }
        #endregion

        #region P2
        private void LoadSecondPart()
        {
            BlankP2Table();
            //FillToTableP2(socialInsuranceDO.GetInsuranceC47Part2Had(dtIDate.Value.Date), 2);
            FillToTableP2(socialInsuranceDO.GetInsuranceC47Part2Now(dtIDate.Value.AddMonths(-1)), 2);
            FillToTableP2(socialInsuranceDO.GetInsuranceC47Part2Now(dtIDate.Value), 5);
            GreaterOrLess();
        }

        private bool FillToTableP2(DataTable tbl,int cellindex)
        {
            if (tbl.Rows.Count == 0)
            {
                tblP2.BeginUpdate();
                tblP2.TableModel.Rows[0].Cells[cellindex].Data =
                tblP2.TableModel.Rows[1].Cells[cellindex].Data =
                tblP2.TableModel.Rows[2].Cells[cellindex].Data =
                tblP2.TableModel.Rows[3].Cells[cellindex].Data =
                tblP2.TableModel.Rows[4].Cells[cellindex].Data =
                tblP2.TableModel.Rows[5].Cells[cellindex].Data = 0;
                tblP2.EndUpdate();
                return false;
            }
            else
            try
            {
                tblP2.BeginUpdate();
                tblP2.TableModel.Rows[0].Cells[cellindex].Data = tbl.Rows[0]["TongLaoDong"];
                tblP2.TableModel.Rows[1].Cells[cellindex].Data = tbl.Rows[0]["PhieuKCB"];
                tblP2.TableModel.Rows[2].Cells[cellindex].Data = tbl.Rows[0]["TongLuong"];
                tblP2.TableModel.Rows[3].Cells[cellindex].Data = tbl.Rows[0]["TongNopTheoLuong"];
                tblP2.TableModel.Rows[4].Cells[cellindex].Data = tbl.Rows[0]["SoDieuChinh"];
                tblP2.TableModel.Rows[5].Cells[cellindex].Data = tbl.Rows[0]["TongNopBH"];
                tblP2.EndUpdate();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void BlankP2Table()
        { 
            tblP2.BeginUpdate();
            for (int i = 0; i < tblmdlP2.Rows.Count; i++)
            {
                tblmdlP2.Rows[i].Cells[2].Data = 0;
                tblmdlP2.Rows[i].Cells[3].Data = 0;
                tblmdlP2.Rows[i].Cells[4].Data = 0;
                tblmdlP2.Rows[i].Cells[5].Data = 0;
            }
            tblP2.EndUpdate();
        }

        private bool GreaterOrLess()
        {
            for (int rowindex = 0; rowindex < 4; rowindex++)
            {
                decimal Last = 0;
                decimal Next = 0;
                decimal.TryParse(tblP2.TableModel.Rows[rowindex].Cells[2].Data.ToString(), out Last);
                decimal.TryParse(tblP2.TableModel.Rows[rowindex].Cells[5].Data.ToString(), out Next);
                tblP2.BeginUpdate();
                tblP2.TableModel.Rows[rowindex].Cells[2].Data = Last;
                if (Next > Last)
                    tblP2.TableModel.Rows[rowindex].Cells[3].Data = Next - Last;
                else
                    tblP2.TableModel.Rows[rowindex].Cells[4].Data = Last - Next;
                
                tblP2.EndUpdate();
            }
            tblP2.TableModel.Rows[5].Cells[2].Data = 0;
            //Tinh so dieu chinh thang
            decimal TryCatchTotalValue = 0;
            decimal.TryParse(tblP2.TableModel.Rows[3].Cells[5].Data.ToString(),out TryCatchTotalValue);
            if (sumGreater > sumLess)
            {
                tblP2.TableModel.Rows[4].Cells[3].Data = sumGreater-sumLess;
                tblP2.TableModel.Rows[4].Cells[5].Data = sumGreater-sumLess;
                //tblP2.TableModel.Rows[5].Cells[3].Data = sumGreater - sumLess + (decimal)tblP2.TableModel.Rows[3].Cells[5].Data;
                tblP2.TableModel.Rows[5].Cells[5].Data = sumGreater - sumLess + TryCatchTotalValue;
                
            }
            else
            {
                tblP2.TableModel.Rows[4].Cells[4].Data = sumLess-sumGreater  ;
                tblP2.TableModel.Rows[4].Cells[5].Data = sumLess-sumGreater  ;
                //tblP2.TableModel.Rows[5].Cells[3].Data = (decimal)tblP2.TableModel.Rows[3].Cells[5].Data- (sumLess - sumGreater);
                tblP2.TableModel.Rows[5].Cells[5].Data = TryCatchTotalValue - (sumLess - sumGreater);
            }
            return false;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtIDate_ValueChanged(object sender, EventArgs e)
        {
            LoadFirstPart();
            LoadSecondPart();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dsInsurance dtsValue = SendToDataSet();
            LoadReport(dtsValue);
        }

        private void LoadReport(dsInsurance ds)
        {
            //ReportDocument rptDoc = new ReportDocument();            
            //rptDoc.SetDataSource(ds);

            frmReport frm = new frmReport();
            //frm.SetReportDocument = rptDoc;
            frm.ShowInsuranceC47(ds,dtIDate.Value.Month,dtIDate.Value.Year);
        }

        #region SendtoDataSet
        private dsInsurance SendToDataSet()
        {
            dsInsurance DS_Insurance = new dsInsurance();
            DS_Insurance.tblInsuranceC47P1.Rows.Clear();
            for (int i = 0; i < tblmdlP1.Rows.Count; i++)
            {
                object[] RowObj = new object[15];
                RowObj[0] = tblmdlP1.Rows[i].Cells[0].Text;
                RowObj[1] = tblmdlP1.Rows[i].Cells[1].Text;
                RowObj[2] = tblmdlP1.Rows[i].Cells[2].Text;
                RowObj[3] = tblmdlP1.Rows[i].Cells[3].Data;
                RowObj[4] = tblmdlP1.Rows[i].Cells[4].Data;
                RowObj[5] = tblmdlP1.Rows[i].Cells[5].Data;
                RowObj[6] = tblmdlP1.Rows[i].Cells[6].Data;
                RowObj[7] = tblmdlP1.Rows[i].Cells[7].Data;
                RowObj[8] = tblmdlP1.Rows[i].Cells[8].Data;
                RowObj[9] = tblmdlP1.Rows[i].Cells[9].Text;
                RowObj[10] = tblmdlP1.Rows[i].Cells[10].Text;
                RowObj[11] = tblmdlP1.Rows[i].Cells[11].Text;
                //RowObj[12] = tblmdlP1.Rows[i].Cells[12].Data;
                //RowObj[13] = tblmdlP1.Rows[i].Cells[13].Data;
                RowObj[12] = tblmdlP1.Rows[i].Cells[12].Data;
                RowObj[13] = tblmdlP1.Rows[i].Cells[13].Data;
                RowObj[14] = tblmdlP1.Rows[i].Cells[14].Text;                
                DS_Insurance.tblInsuranceC47P1.Rows.Add(RowObj);
            }

            DS_Insurance.tblInsuranceC47P2.Rows.Clear();
            for (int i = 0; i < tblmdlP2.Rows.Count; i++)
            {
                object[] RowObj = new object[5];
                RowObj[0] = tblmdlP2.Rows[i].Cells[0].Text;
                RowObj[1] = tblmdlP2.Rows[i].Cells[1].Text;
                RowObj[2] = tblmdlP2.Rows[i].Cells[2].Data;
                RowObj[3] = tblmdlP2.Rows[i].Cells[5].Data;
                if(i<5)
                    if (Convert.ToDecimal(tblmdlP2.Rows[i].Cells[3].Data) > 0)
                        RowObj[4] = 1;//tang
                    else 
                    RowObj[4] = 2;//giam
            else RowObj[4] = 0;//ko the hien tren cot tang va giam
                
                DS_Insurance.tblInsuranceC47P2.Rows.Add(RowObj);
            }
            return DS_Insurance;

        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblP1.BeginUpdate();
            Inrc++;
            Row xpRow = NewTblP1BlankRow();
            xpRow.Cells[0].Text = Inrc.ToString();
            tblP1.TableModel.Rows.Add(xpRow);
            tblP1.EndUpdate();

        }

        //private void tblP1_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        //{
        //    if (e.NewSelectedIndicies.Length > 0)
        //    {
        //        selectedRowIndex = Convert.ToInt32(tblP1.TableModel.Rows[e.NewSelectedIndicies[0]].Cells[0].Text)-1;
        //    }
        //    //selectedRowIndex = Convert.ToInt32(tblP1.SelectedItems);
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblP1.SelectedItems != null)
            {
                tblP1.BeginUpdate();
                foreach (Row selectedItem in tblP1.SelectedItems)
                {
                    tblP1.TableModel.Rows.Remove(selectedItem);
                }

                tblP1.EndUpdate();
            }
            else MessageBox.Show("Bạn phải chọn một nhân viên !", "Thông báo");
        }

        private void tblP1_EditingStopped(object sender, XPTable.Events.CellEditEventArgs e)
        {
            //e.Handled = false;
            //tblP1.TableModel.Rows[e.Row].Cells[0].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[1].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[2].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[3].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[4].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[5].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[6].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[7].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[8].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[9].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[10].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[11].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[12].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[13].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[14].Text = ((TextCellEditor)e.Editor).TextBox.Text;
            //tblP1.TableModel.Rows[e.Row].Cells[1].Text = tblP1.TableModel.Rows[e.Row].Cells[1].Text;
            //tblP1.BeginUpdate();
            //Row xpRow = NewTblP1BlankRow();
            //for(int i=0;i<15;i++)
            //{
                //xpRow.Cells[i].Text = tblP1.TableModel.Rows[e.Row].Cells[i].Text;
               // xpRow.Cells[i].Text =((TextCellEditor) e.Editor).TextBox.Text;
            //}
            //tblP1.TableModel.Rows.Remove(tblP1.SelectedItems[0]);
            //tblP1.TableModel.Rows.Add(xpRow);
            //tblP1.EndUpdate();
            //tblP1.Sort(0);
        }
    }
}