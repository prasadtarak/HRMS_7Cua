namespace HumanResourceUpdate
{
    partial class HumanResourceUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanResourceUpdateForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.humanResourceDataSet = new HumanResourceUpdate.HumanResourceDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTrial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasicSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTaxID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFamilyConditionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "GetAllEmployeesForUpdate";
            this.gridControl1.DataSource = this.humanResourceDataSet;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(744, 465);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // humanResourceDataSet
            // 
            this.humanResourceDataSet.DataSetName = "HumanResourceDataSet";
            this.humanResourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentID,
            this.colDepartmentName,
            this.colEmployeeID,
            this.colCardID,
            this.colEmployeeName,
            this.colStartTrial,
            this.colStartDate,
            this.colBasicSalary,
            this.colTaxID,
            this.colFamilyConditionNumber});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Hãy kéo thả cột bạn muốn nhóm dữ liệu vào đây";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.Caption = "DepartmentID";
            this.colDepartmentID.FieldName = "DepartmentID";
            this.colDepartmentID.Name = "colDepartmentID";
            this.colDepartmentID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "Đơn vị";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.OptionsColumn.AllowEdit = false;
            this.colDepartmentName.OptionsColumn.ReadOnly = true;
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 0;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.OptionsColumn.AllowEdit = false;
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            this.colEmployeeID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colCardID
            // 
            this.colCardID.Caption = "Mã thẻ";
            this.colCardID.FieldName = "CardID";
            this.colCardID.Name = "colCardID";
            this.colCardID.OptionsColumn.AllowEdit = false;
            this.colCardID.OptionsColumn.ReadOnly = true;
            this.colCardID.Visible = true;
            this.colCardID.VisibleIndex = 1;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Tên nhân viên";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 2;
            // 
            // colStartTrial
            // 
            this.colStartTrial.Caption = "Ngày thử việc";
            this.colStartTrial.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colStartTrial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartTrial.FieldName = "StartTrial";
            this.colStartTrial.Name = "colStartTrial";
            this.colStartTrial.OptionsColumn.AllowEdit = false;
            this.colStartTrial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStartTrial.OptionsColumn.ReadOnly = true;
            this.colStartTrial.Visible = true;
            this.colStartTrial.VisibleIndex = 3;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày chính thức";
            this.colStartDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowEdit = false;
            this.colStartDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colStartDate.OptionsColumn.ReadOnly = true;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.Caption = "Lương cơ bản";
            this.colBasicSalary.ColumnEdit = this.repositoryItemTextEdit1;
            this.colBasicSalary.DisplayFormat.FormatString = "N0";
            this.colBasicSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBasicSalary.FieldName = "BasicSalary";
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBasicSalary.Visible = true;
            this.colBasicSalary.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "N0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colTaxID
            // 
            this.colTaxID.Caption = "Mã số thuế";
            this.colTaxID.ColumnEdit = this.repositoryItemTextEdit2;
            this.colTaxID.FieldName = "TaxID";
            this.colTaxID.Name = "colTaxID";
            this.colTaxID.Visible = true;
            this.colTaxID.VisibleIndex = 6;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.MaxLength = 10;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // colFamilyConditionNumber
            // 
            this.colFamilyConditionNumber.Caption = "Số người giảm trừ gia cảnh";
            this.colFamilyConditionNumber.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colFamilyConditionNumber.FieldName = "FamilyConditionNumber";
            this.colFamilyConditionNumber.Name = "colFamilyConditionNumber";
            this.colFamilyConditionNumber.Visible = true;
            this.colFamilyConditionNumber.VisibleIndex = 7;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barEditItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu danh sách";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemProgressBar1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barEditItem1.Width = 100;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(7, 34);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(415, 18);
            this.progressBarControl1.TabIndex = 4;
            this.progressBarControl1.Visible = false;
            // 
            // HumanResourceUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HumanResourceUpdateForm";
            this.Text = "Quản lý nhân sự - Cập nhật hỗ trợ tính thuế năm 2009";
            this.Load += new System.EventHandler(this.HumanResourceUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanResourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HumanResourceDataSet humanResourceDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colCardID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTrial;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBasicSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxID;
        private DevExpress.XtraGrid.Columns.GridColumn colFamilyConditionNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}

