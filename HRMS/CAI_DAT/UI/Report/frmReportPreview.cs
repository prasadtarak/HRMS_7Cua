using System;
using System.ComponentModel;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using EVSoft.HRMS.Common;
using System.IO;
using System.Threading;


namespace EVSoft.HRMS.UI.Report
{
    /// <summary>
    /// Summary description for frmLptDetailEmployee.
    /// </summary>
    public class frmReportPreview : Form
    {
        //		private CrystalReportViewer crvDetailEmployee;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDetail;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private string reportName = "test";
        public string ReportName
        {
            set { reportName = value; }
        }
        private DateTime reportDate = DateTime.Now;

        private bool exportReport = true;
        public bool ExportReport
        {
            get
            {
                return exportReport;
            }
            set
            {
                exportReport = value;
            }
        }

        public DateTime ReportDate
        {
            set { reportDate = value; }
        }
        public frmReportPreview()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private ReportDocument reportDocument = null;

        public ReportDocument SetReportDocument
        {
            set { reportDocument = value; }
        }

        private ModuleSettings settings;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmReportPreview));
            this.crvDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDetail
            // 
            this.crvDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.crvDetail.ActiveViewIndex = -1;
            this.crvDetail.DisplayGroupTree = false;
            this.crvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDetail.Location = new System.Drawing.Point(0, 0);
            this.crvDetail.Name = "crvDetail";
            this.crvDetail.ReportSource = null;
            this.crvDetail.ShowRefreshButton = false;
            this.crvDetail.Size = new System.Drawing.Size(632, 438);
            this.crvDetail.TabIndex = 0;
            this.crvDetail.Load += new System.EventHandler(this.crvDetail_Load);
            // 
            // frmReportPreview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(632, 438);
            this.Controls.Add(this.crvDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPreview";
            this.Text = "Xem trước báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLptDetailEmployee_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private void frmLptDetailEmployee_Load(object sender, EventArgs e)
        {
            crvDetail.ReportSource = reportDocument;

            //kiem tra tuy chon ExportRepost
            if (ExportReport)
            {
                settings = ModuleConfig.GetSettings();
                string reportPart = settings.ReportPath;
                string Targetfile = reportPart + "\\" + reportName + "_" + reportDate.Month + "_" + reportDate.Year + ".rpt";
                FileInfo fil = new FileInfo(Targetfile);
                if (fil.Exists)
                    if (
                        MessageBox.Show("Đã tồn tại báo cáo này, có ghi đè không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fil.Delete();
                    }
                    else
                    {
                        return;
                    }
                //reportDocument.SaveAs(Targetfile, true);
                //Application.DoEvents();
                reportDocument.ExportToDisk(ExportFormatType.CrystalReport, Targetfile);
            }
        }

        private void crvDetail_Load(object sender, System.EventArgs e)
        {
            this.Text = WorkingContext.LangManager.GetString("Bosung3_1");
        }


    }
}