using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XPTable.Models;
using EVSoft.HRMS.DO;
using EVSoft.HRMS.Common;
namespace EVSoft.HRMS.UI.Schedule
{
    public partial class frmRestDay : Form
    {
        public frmRestDay()
        {
            InitializeComponent();
        }

        RestSheetDO Rest = new RestSheetDO();
        DataSet Ds = new DataSet();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lấy về đối tượng TextBox
            TextBox textBox = (TextBox)sender;

            char chrNumberDecimalSeparator = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator.ToCharArray()[0];

            // Lấy về mã ASCII của ký tự vừa được gõ vào TextBox
            char keycode = e.KeyChar;
            int c = (int)keycode;

            // Kiểm tra ký tự vừa nhập vào có phải là các số nằm trong khoảng
            // 0..9
            if ((c >= 48) && (c <= 57))
            {
                e.Handled = false;
            }
            else
                //Kiểm tra xem đã có dấu cách của số thập phân đã tồn tại chưa?
                if (c == (chrNumberDecimalSeparator) && textBox.Text.IndexOf(chrNumberDecimalSeparator) == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            if (c == 8)
            {
                e.Handled = false;
            }

        }
         //private DateTime[] TotalDayInNamedOnYear(DayOfWeek DayNamed, int Year)
         //{
         //    string NameDay = DateTime.Now.DayOfWeek.ToString();
         //    System.DayOfWeek.
         //    DateTime[] DT = new DateTime[55];
         //    int countValue = 0;
         //    DateTime DayExct = DateTime.MinValue;
         //    for (int i = 1; i <= 12; i++)
         //    {
         //        for(int j = 1; j <= 31 ; j ++)
         //        {
                 
         //            if ((new DateTime(Year, i, j)).DayOfWeek == DayNamed)
         //           {
         //            DayExct = new DateTime(Year, 1, i);
         //            DT[countValue] = DayExct;
         //            countValue++;
         //            }
         //        }
         //    }               
         //    return DT;
         //}
        private DateTime[] DayNamedOnYear(DayOfWeek DayNamed, int Year)
        {
            DateTime DayExct = DateTime.MinValue;
            for (int i = 1; i <= 7; i++)
                if ((new DateTime(Year, 1, i)).DayOfWeek == DayNamed)
                {
                    DayExct = new DateTime(Year, 1, i);
                }
            if (DayExct == DateTime.MinValue) return null;
            DateTime DayValue = DayExct;
            int CountDay = 0;
            while (DayValue.Year == Year)
            {
                CountDay++;
                DayValue = DayValue.AddDays(7);
            }
            DateTime[] DT = new DateTime[CountDay];
            for (int i = 0; i < CountDay; i++)
            {
                DT[i] = DayExct;
                DayExct = DayExct.AddDays(7);
            }
            return DT;
        }
        private void Init()
        {
            Ds = Rest.GetFromRestDay();           
            tableDayRest.Table.TableModel.Rows.Clear();
            if (Ds.Tables.Count > 0)
            {
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in Ds.Tables[0].Rows)
                    {
                        Row r = new Row();
                        r.Cells.Add(new Cell(Convert.ToDateTime(row["DayRest"])));
                        r.Cells.Add(new Cell(row["DayIndex"].ToString()));
                        r.Cells.Add(new Cell(row["Description"].ToString()));
                        tableDayRest.Table.TableModel.Rows.Add(r);
                    }
                }
            }
        }
        private void initfordatarow(DataRow[] rows)
        {
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    Row r = new Row();
                    r.Cells.Add(new Cell(Convert.ToDateTime(row["DayRest"])));
                    r.Cells.Add(new Cell(row["DayIndex"].ToString()));
                    r.Cells.Add(new Cell(row["Description"].ToString()));
                    tableDayRest.Table.TableModel.Rows.Add(r);
                }
            }
        }
        private DayOfWeek[] GetDayOfWeek()
        {
            DayOfWeek[] Result = new DayOfWeek[7];
            if (CheckBoxMonday.Checked)
            {
                Result[0] = DayOfWeek.Monday;

            }
            if (checkBoxSaturday.Checked)
            {
                Result[1] = DayOfWeek.Saturday;
            }
            if (checkBoxSunDay.Checked)
            {
               Result[2] = DayOfWeek.Sunday;
            }
            if (checkBoxTuesday.Checked)
            {
                Result[3] = DayOfWeek.Tuesday;
            }
            if (checkBoxThursday.Checked)
                Result[4] = DayOfWeek.Thursday;
            if (checkBoxFriday.Checked)
                Result[5] = DayOfWeek.Friday;
            if (checkBoxWednesday.Checked)
                Result[6] = DayOfWeek.Wednesday;
            return Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool check = CheckControl();
            if (check)
            {
                
                DayOfWeek[] DayinWeek = new DayOfWeek[7];
                DayinWeek = GetDayOfWeek();
                for (int i = 0; i < 7; i++)
                {
                    
                    string s = DayinWeek[i].ToString();
                   DataRow[] dtr = Ds.Tables[0].Select("Description = '" + s + "'");
                   initfordatarow(dtr);
                    if (DayinWeek[i].ToString() != "")
                    {
                        DateTime[] DT = DayNamedOnYear(DayinWeek[i], System.DateTime.Now.Year);
                        for (int j = 0; j < DT.Length; j++)
                        {
                            Row r = new Row();
                            r.Cells.Add(new Cell(DT[j]));
                            r.Cells.Add(new Cell(DayIndex.Text));
                            r.Cells.Add(new Cell(DayinWeek[i].ToString()));
                            //if (tableDayRest.Table.TableModel.Rows.Count > 0)
                            //{
                            //    foreach (Row row in tableDayRest.Table.TableModel.Rows)
                            //        if (Convert.ToDateTime(row.Cells[0].Text).ToShortDateString() == Convert.ToDateTime(r.Cells[0].Data).ToShortDateString())
                            //        {
                            //            row.Cells[1].Text = DayIndex.Text;
                            //            row.Cells[2].Text = DayinWeek[i].ToString();
                            //        }
                            //        else
                            //            tableDayRest.Table.TableModel.Rows.Add(r);
                            //}
                            //else
                            tableDayRest.Table.TableModel.Rows.Add(r);
                            
                        }

                    }
                }
            }
            else
            {
                if (txtDescription.Enabled && DayRest.Enabled)
                {
                    Row r = new Row();
                    r.Cells.Add(new Cell(Convert.ToDateTime(DayRest.Value.ToShortDateString())));
                    r.Cells.Add(new Cell(DayIndex.Text));
                    r.Cells.Add(new Cell(txtDescription.Text));
                    //DataRow[] dtRows = Ds.Tables[0].Select("DayRest = '" + DayRest.Value.ToShortDateString() + "'");
                    //initfordatarow(dtRows);
                    if (tableDayRest.Table.TableModel.Rows.Count > 0)
                    {
                        foreach (DataRow row in tableDayRest.Table.TableModel.Rows)
                        {
                            //if(Convert.ToDateTime(
                            tableDayRest.Table.TableModel.Rows.Add(r);
                        }
                    }
                    else
                    {
                        tableDayRest.Table.TableModel.Rows.Add(r);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Row r in tableDayRest.Table.TableModel.Rows)
            {
                DateTime DR = Convert.ToDateTime(r.Cells[0].Data);
                decimal DayIndex = Convert.ToDecimal(r.Cells[1].Text);
                string Description = r.Cells[2].Text;
                Rest.UpdateRestDay(DR, DayIndex, Description);
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Rest.DeleteFromRestDay(DateTime.Now.Year);
                Init();
                MessageBox.Show("Xóa dữ liệu thành công","Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa dữ liệu không thành công, vui lòng xem lại", "Thông báo");   
            }
        }

        private void frmRestDay_Load(object sender, EventArgs e)
        {
            Init();
            EVsoft.HRMS.Common.GeneralProcess.StandardFormControl(this);
        }
        private void CheckboxChange(object sender,EventArgs e)
        {
            bool check = false;
            foreach(Control c in G.Controls)
            {
                if (c.GetType().Name == "CheckBox")
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                        check = true;
                }
            }
            if (check)
            {
                txtDescription.Enabled = false;
                DayRest.Enabled = false;
            }
            else
            {
                txtDescription.Enabled = true;
                DayRest.Enabled = true;
            }
        }
        private void checkBoxSunDay_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender,e);
        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {

            CheckboxChange(sender, e);
        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender, e);
        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender, e);
        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender, e);
        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender, e);
        }

        private void CheckBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChange(sender, e);
        }
        private bool CheckControl()
        {
            bool check = false;
            foreach (Control c in G.Controls)
            {
                if (c.GetType().Name == "CheckBox")
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                        check = true;
                }
            }
            return check;
        }
    }
}