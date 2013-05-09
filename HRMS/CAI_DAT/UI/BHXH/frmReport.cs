using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using EVSoft.HRMS.Common;

namespace EVSoft.HRMS.UI.BHXH
{
    public partial class frmReport : Form
    {
        Database crDatabase;
        Tables crTables;
        TableLogOnInfo crTableLogOnInfo;
        ConnectionInfo crConnectioninfo;
        private ModuleSettings settings;
        
        public frmReport()
        {
            InitializeComponent();
        }

        public void ShowInsuranceC47(DataSet ds,int IMonth,int IYear)
        {
            //ReportDocument rptDoc = new ReportDocument();
            ReportDocument rptDoc = null;
            //rptDoc.Load(@"Reports\BHXH\InsuranceC47.rpt");
            rptDoc = new Reports.BHXH.InsuranceC47();
            rptDoc.Refresh();
            rptDoc.SetDatabaseLogon(WorkingContext.Setting.UserName, WorkingContext.Setting.Password, WorkingContext.Setting.Server, WorkingContext.Setting.Database);
            rptDoc.SetDataSource(ds);
            rptDoc.Subreports["Part2"].SetDataSource(ds);
            rptDoc.DataDefinition.ParameterFields["IMonth"].ApplyCurrentValues(GetReportPara((object)IMonth));
            rptDoc.DataDefinition.ParameterFields["IYear"].ApplyCurrentValues(GetReportPara(IYear));
            if (rptDoc != null)
            {
                SetDBLogonForReport(rptDoc);
            }
            crViewer.ReportSource = rptDoc;
           
            settings = ModuleConfig.GetSettings();
            string reportPart = settings.ReportPath;
            string Targetfile = reportPart + "\\" + "BHXH mẫu C47" + "_" + IMonth + "_" + IYear + ".rpt";
            FileInfo fil = new FileInfo(Targetfile);
            if (fil.Exists)
                if (
                    MessageBox.Show("Đã tồn tại báo cáo này, có ghi đè không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    fil.Delete();
                }
                else
                {
                    return;
                }
            //reportDocument.SaveAs(Targetfile, true);
            //Application.DoEvents();
            rptDoc.ExportToDisk(ExportFormatType.CrystalReport, Targetfile);
            
            this.Show();
        }

        public void ShowInsuranceC46(int IQuarter, int IYear, string SocialInsuranceOffice, string ComName, string ComAddress, string ComAcc,
            string ComBank, string ComTel, string ComFax, string YC1, string YC2, string YC3, string YC4, 
            string YC5, string YC6, string YC7, string YC8, DateTime CreateDate, string CopyNum, string ComID)
        {
            //ReportDocument rptDoc = new ReportDocument();
            ReportDocument rptDoc = null;
            //rptDoc.Load(@"Reports\BHXH\InsuranceC46.rpt");
            rptDoc = new Reports.BHXH.InsuranceC46();
            rptDoc.Refresh();
            rptDoc.SetDatabaseLogon(WorkingContext.Setting.UserName, WorkingContext.Setting.Password, WorkingContext.Setting.Server, WorkingContext.Setting.Database);
            rptDoc.DataDefinition.ParameterFields["IQuarter"].ApplyCurrentValues(GetReportPara(IQuarter));
            rptDoc.DataDefinition.ParameterFields["IYear"].ApplyCurrentValues(GetReportPara(IYear));
            rptDoc.DataDefinition.ParameterFields["SocialInsuranceOffice"].ApplyCurrentValues(GetReportPara(SocialInsuranceOffice));
            rptDoc.DataDefinition.ParameterFields["ComName"].ApplyCurrentValues(GetReportPara(ComName));
            rptDoc.DataDefinition.ParameterFields["ComAddress"].ApplyCurrentValues(GetReportPara(ComAddress));
            rptDoc.DataDefinition.ParameterFields["ComAcc"].ApplyCurrentValues(GetReportPara(ComAcc));
            rptDoc.DataDefinition.ParameterFields["ComBank"].ApplyCurrentValues(GetReportPara(ComBank));
            rptDoc.DataDefinition.ParameterFields["ComTel"].ApplyCurrentValues(GetReportPara(ComTel));
            rptDoc.DataDefinition.ParameterFields["ComFax"].ApplyCurrentValues(GetReportPara(ComFax));
            rptDoc.DataDefinition.ParameterFields["YC1"].ApplyCurrentValues(GetReportPara(YC1));
            rptDoc.DataDefinition.ParameterFields["YC2"].ApplyCurrentValues(GetReportPara(YC2));
            rptDoc.DataDefinition.ParameterFields["YC3"].ApplyCurrentValues(GetReportPara(YC3));
            rptDoc.DataDefinition.ParameterFields["YC4"].ApplyCurrentValues(GetReportPara(YC4));
            rptDoc.DataDefinition.ParameterFields["YC5"].ApplyCurrentValues(GetReportPara(YC5));
            rptDoc.DataDefinition.ParameterFields["YC6"].ApplyCurrentValues(GetReportPara(YC6));
            rptDoc.DataDefinition.ParameterFields["YC7"].ApplyCurrentValues(GetReportPara(YC7));
            rptDoc.DataDefinition.ParameterFields["YC8"].ApplyCurrentValues(GetReportPara(YC8));
            rptDoc.DataDefinition.ParameterFields["CreateDate"].ApplyCurrentValues(GetReportPara(CreateDate));
            rptDoc.DataDefinition.ParameterFields["CopyNum"].ApplyCurrentValues(GetReportPara(CopyNum));
            rptDoc.DataDefinition.ParameterFields["ComID"].ApplyCurrentValues(GetReportPara(ComID));
            if (rptDoc != null)
            {
                SetDBLogonForReport(rptDoc);
            }
            crViewer.ReportSource = rptDoc;

            settings = ModuleConfig.GetSettings();
            string reportPart = settings.ReportPath;
            string Targetfile = reportPart + "\\" + "BHXH mẫu C46" + "_" + IYear + ".rpt";
            FileInfo fil = new FileInfo(Targetfile);
            if (fil.Exists)
                if (
                    MessageBox.Show("Đã tồn tại báo cáo này, có ghi đè không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    fil.Delete();
                }
                else
                {
                    return;
                }
            //reportDocument.SaveAs(Targetfile, true);
            //Application.DoEvents();
            rptDoc.ExportToDisk(ExportFormatType.CrystalReport, Targetfile);

            this.Show();
        }

        private ParameterValues GetReportPara(object ParaValue)
        {
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = ParaValue;
            pv.Add(pdv);
            return pv;
        }

        /// <summary>
        /// Thiáº¿t láº­p cĂ¡c thĂ´ng tin káº¿t ná»‘i cÆ¡ sá»Ÿ dá»¯ liá»‡u cho bĂ¡o cĂ¡o
        /// </summary>
        /// <param name="reportDocument"></param>
        private void SetDBLogonForReport(ReportDocument reportDocument)
        {
            crConnectioninfo = new ConnectionInfo();
            crConnectioninfo.ServerName = WorkingContext.Setting.Server;
            crConnectioninfo.DatabaseName = WorkingContext.Setting.Database;
            crConnectioninfo.UserID = WorkingContext.Setting.UserName;
            crConnectioninfo.Password = WorkingContext.Setting.Password;

            crTables = reportDocument.Database.Tables;
            crDatabase = reportDocument.Database;
            crTables = crDatabase.Tables;


            foreach (Table crTable in crTables)
            {
                try
                {
                    crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectioninfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                    //					crTable.Location = WorkingContext.Setting.Server + crTable.Name;
                    // Note that if you wish to change Database (catalog) name as well as
                    // the server, you must set new crTable.Location property as follows:
                    // crTable.Location = "<new_database_name>.<owner>." + crTable.Name;
                }

                catch
                {
                    string str = WorkingContext.LangManager.GetString("frmListReport_thongbao");
                    string str1 = WorkingContext.LangManager.GetString("frmListReport_thongbao_Title");
                    //MessageBox.Show("KhĂ´ng thá»ƒ Ä‘Äƒng nháº­p Ä‘Æ°á»£c vĂ o cÆ¡ sá»Ÿ dá»¯ liá»‡u","ThĂ´ng bĂ¡o",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(str, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}