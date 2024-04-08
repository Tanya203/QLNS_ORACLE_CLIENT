namespace CLIENT.PresentationTier
{
    partial class frmStatistic
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
            this.rptSalary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbPositionSalary = new System.Windows.Forms.RadioButton();
            this.cmbPositionSalary = new System.Windows.Forms.ComboBox();
            this.rbDepartmentSalary = new System.Windows.Forms.RadioButton();
            this.rbAllStaffSalary = new System.Windows.Forms.RadioButton();
            this.lblSalaryStatistics = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbDepartmentSalary = new System.Windows.Forms.ComboBox();
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.dtpMonthSalary = new System.Windows.Forms.DateTimePicker();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tbBonus = new System.Windows.Forms.TabPage();
            this.rptBonus = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbPositionBonus = new System.Windows.Forms.RadioButton();
            this.cmbPositionBonus = new System.Windows.Forms.ComboBox();
            this.rbDepartmentBonus = new System.Windows.Forms.RadioButton();
            this.rbAllStaffBonus = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartmentBonus = new System.Windows.Forms.ComboBox();
            this.dtpMonthBonus = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPositionLoginValue = new System.Windows.Forms.Label();
            this.lblPositionLogin = new System.Windows.Forms.Label();
            this.lblDepartmentLoginValue = new System.Windows.Forms.Label();
            this.lblDepartmentLogin = new System.Windows.Forms.Label();
            this.lblFullNameLoginValue = new System.Windows.Forms.Label();
            this.lblFullNameLogin = new System.Windows.Forms.Label();
            this.lblStaffIDLoginValue = new System.Windows.Forms.Label();
            this.lblStaffIDLogin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbSalary.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tbBonus.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptSalary
            // 
            this.rptSalary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptSalary.LocalReport.ReportEmbeddedResource = "QuanLyNhanSu.ReportViewer.RptSalary.rdlc";
            this.rptSalary.Location = new System.Drawing.Point(3, 141);
            this.rptSalary.Name = "rptSalary";
            this.rptSalary.ServerReport.BearerToken = null;
            this.rptSalary.Size = new System.Drawing.Size(1910, 695);
            this.rptSalary.TabIndex = 84;
            // 
            // rbPositionSalary
            // 
            this.rbPositionSalary.AutoSize = true;
            this.rbPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPositionSalary.Location = new System.Drawing.Point(1165, 72);
            this.rbPositionSalary.Name = "rbPositionSalary";
            this.rbPositionSalary.Size = new System.Drawing.Size(154, 36);
            this.rbPositionSalary.TabIndex = 83;
            this.rbPositionSalary.TabStop = true;
            this.rbPositionSalary.Text = "Chức vụ:";
            this.rbPositionSalary.UseVisualStyleBackColor = true;
            this.rbPositionSalary.CheckedChanged += new System.EventHandler(this.EnableCombobox);
            // 
            // cmbPositionSalary
            // 
            this.cmbPositionSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPositionSalary.Enabled = false;
            this.cmbPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSalary.FormattingEnabled = true;
            this.cmbPositionSalary.Location = new System.Drawing.Point(1325, 74);
            this.cmbPositionSalary.Name = "cmbPositionSalary";
            this.cmbPositionSalary.Size = new System.Drawing.Size(244, 33);
            this.cmbPositionSalary.TabIndex = 82;
            this.cmbPositionSalary.TextChanged += new System.EventHandler(this.cmbPositionSalary_TextChanged);
            // 
            // rbDepartmentSalary
            // 
            this.rbDepartmentSalary.AutoSize = true;
            this.rbDepartmentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartmentSalary.Location = new System.Drawing.Point(718, 74);
            this.rbDepartmentSalary.Name = "rbDepartmentSalary";
            this.rbDepartmentSalary.Size = new System.Drawing.Size(191, 36);
            this.rbDepartmentSalary.TabIndex = 81;
            this.rbDepartmentSalary.TabStop = true;
            this.rbDepartmentSalary.Text = "Phòng ban:";
            this.rbDepartmentSalary.UseVisualStyleBackColor = true;
            this.rbDepartmentSalary.CheckedChanged += new System.EventHandler(this.EnableCombobox);
            // 
            // rbAllStaffSalary
            // 
            this.rbAllStaffSalary.AutoSize = true;
            this.rbAllStaffSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllStaffSalary.Location = new System.Drawing.Point(425, 74);
            this.rbAllStaffSalary.Name = "rbAllStaffSalary";
            this.rbAllStaffSalary.Size = new System.Drawing.Size(287, 36);
            this.rbAllStaffSalary.TabIndex = 80;
            this.rbAllStaffSalary.TabStop = true;
            this.rbAllStaffSalary.Text = "Toàn bộ nhân viên";
            this.rbAllStaffSalary.UseVisualStyleBackColor = true;
            this.rbAllStaffSalary.CheckedChanged += new System.EventHandler(this.EnableCombobox);
            // 
            // lblSalaryStatistics
            // 
            this.lblSalaryStatistics.AutoSize = true;
            this.lblSalaryStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryStatistics.Location = new System.Drawing.Point(799, 10);
            this.lblSalaryStatistics.Name = "lblSalaryStatistics";
            this.lblSalaryStatistics.Size = new System.Drawing.Size(332, 51);
            this.lblSalaryStatistics.TabIndex = 75;
            this.lblSalaryStatistics.Text = "Thống kê lương";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(177, 76);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(109, 32);
            this.lblMonth.TabIndex = 72;
            this.lblMonth.Text = "Tháng:";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDepartmentSalary
            // 
            this.cmbDepartmentSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmentSalary.Enabled = false;
            this.cmbDepartmentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSalary.FormattingEnabled = true;
            this.cmbDepartmentSalary.Location = new System.Drawing.Point(915, 74);
            this.cmbDepartmentSalary.Name = "cmbDepartmentSalary";
            this.cmbDepartmentSalary.Size = new System.Drawing.Size(244, 33);
            this.cmbDepartmentSalary.TabIndex = 70;
            this.cmbDepartmentSalary.TextChanged += new System.EventHandler(this.cmbDepartmentSalary_TextChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSalary.Controls.Add(this.rptSalary);
            this.tbSalary.Controls.Add(this.rbPositionSalary);
            this.tbSalary.Controls.Add(this.cmbPositionSalary);
            this.tbSalary.Controls.Add(this.rbDepartmentSalary);
            this.tbSalary.Controls.Add(this.rbAllStaffSalary);
            this.tbSalary.Controls.Add(this.lblSalaryStatistics);
            this.tbSalary.Controls.Add(this.lblMonth);
            this.tbSalary.Controls.Add(this.cmbDepartmentSalary);
            this.tbSalary.Controls.Add(this.dtpMonthSalary);
            this.tbSalary.Location = new System.Drawing.Point(4, 37);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalary.Size = new System.Drawing.Size(1916, 839);
            this.tbSalary.TabIndex = 0;
            this.tbSalary.Text = "Thống kê lương";
            // 
            // dtpMonthSalary
            // 
            this.dtpMonthSalary.CustomFormat = "MM/yyyy";
            this.dtpMonthSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthSalary.Location = new System.Drawing.Point(292, 78);
            this.dtpMonthSalary.Name = "dtpMonthSalary";
            this.dtpMonthSalary.ShowUpDown = true;
            this.dtpMonthSalary.Size = new System.Drawing.Size(127, 30);
            this.dtpMonthSalary.TabIndex = 69;
            this.dtpMonthSalary.ValueChanged += new System.EventHandler(this.dtpMonthSalary_ValueChanged);
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMenu.Controls.Add(this.tbSalary);
            this.tabControlMenu.Controls.Add(this.tbBonus);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMenu.Location = new System.Drawing.Point(0, 113);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1924, 880);
            this.tabControlMenu.TabIndex = 70;
            this.tabControlMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMenu_DrawItem);
            // 
            // tbBonus
            // 
            this.tbBonus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbBonus.Controls.Add(this.rptBonus);
            this.tbBonus.Controls.Add(this.rbPositionBonus);
            this.tbBonus.Controls.Add(this.cmbPositionBonus);
            this.tbBonus.Controls.Add(this.rbDepartmentBonus);
            this.tbBonus.Controls.Add(this.rbAllStaffBonus);
            this.tbBonus.Controls.Add(this.lbl);
            this.tbBonus.Controls.Add(this.label2);
            this.tbBonus.Controls.Add(this.cmbDepartmentBonus);
            this.tbBonus.Controls.Add(this.dtpMonthBonus);
            this.tbBonus.Location = new System.Drawing.Point(4, 37);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Padding = new System.Windows.Forms.Padding(3);
            this.tbBonus.Size = new System.Drawing.Size(1917, 227);
            this.tbBonus.TabIndex = 1;
            this.tbBonus.Text = "Thống kê thưởng";
            // 
            // rptBonus
            // 
            this.rptBonus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptBonus.LocalReport.ReportEmbeddedResource = "QuanLyNhanSu.ReportViewer.RptBonus.rdlc";
            this.rptBonus.Location = new System.Drawing.Point(3, -379);
            this.rptBonus.Name = "rptBonus";
            this.rptBonus.ServerReport.BearerToken = null;
            this.rptBonus.Size = new System.Drawing.Size(1911, 603);
            this.rptBonus.TabIndex = 93;
            // 
            // rbPositionBonus
            // 
            this.rbPositionBonus.AutoSize = true;
            this.rbPositionBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPositionBonus.Location = new System.Drawing.Point(1219, 71);
            this.rbPositionBonus.Name = "rbPositionBonus";
            this.rbPositionBonus.Size = new System.Drawing.Size(154, 36);
            this.rbPositionBonus.TabIndex = 92;
            this.rbPositionBonus.TabStop = true;
            this.rbPositionBonus.Text = "Chức vụ:";
            this.rbPositionBonus.UseVisualStyleBackColor = true;
            // 
            // cmbPositionBonus
            // 
            this.cmbPositionBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPositionBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionBonus.FormattingEnabled = true;
            this.cmbPositionBonus.Location = new System.Drawing.Point(1379, 71);
            this.cmbPositionBonus.Name = "cmbPositionBonus";
            this.cmbPositionBonus.Size = new System.Drawing.Size(244, 33);
            this.cmbPositionBonus.TabIndex = 91;
            // 
            // rbDepartmentBonus
            // 
            this.rbDepartmentBonus.AutoSize = true;
            this.rbDepartmentBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartmentBonus.Location = new System.Drawing.Point(773, 71);
            this.rbDepartmentBonus.Name = "rbDepartmentBonus";
            this.rbDepartmentBonus.Size = new System.Drawing.Size(191, 36);
            this.rbDepartmentBonus.TabIndex = 90;
            this.rbDepartmentBonus.TabStop = true;
            this.rbDepartmentBonus.Text = "Phòng ban:";
            this.rbDepartmentBonus.UseVisualStyleBackColor = true;
            // 
            // rbAllStaffBonus
            // 
            this.rbAllStaffBonus.AutoSize = true;
            this.rbAllStaffBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllStaffBonus.Location = new System.Drawing.Point(480, 71);
            this.rbAllStaffBonus.Name = "rbAllStaffBonus";
            this.rbAllStaffBonus.Size = new System.Drawing.Size(287, 36);
            this.rbAllStaffBonus.TabIndex = 89;
            this.rbAllStaffBonus.TabStop = true;
            this.rbAllStaffBonus.Text = "Toàn bộ nhân viên";
            this.rbAllStaffBonus.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(799, 6);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(359, 51);
            this.lbl.TabIndex = 88;
            this.lbl.Text = "Thống kê thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tháng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDepartmentBonus
            // 
            this.cmbDepartmentBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmentBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentBonus.FormattingEnabled = true;
            this.cmbDepartmentBonus.Location = new System.Drawing.Point(970, 73);
            this.cmbDepartmentBonus.Name = "cmbDepartmentBonus";
            this.cmbDepartmentBonus.Size = new System.Drawing.Size(244, 33);
            this.cmbDepartmentBonus.TabIndex = 86;
            // 
            // dtpMonthBonus
            // 
            this.dtpMonthBonus.CustomFormat = "yyyy-MM";
            this.dtpMonthBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthBonus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthBonus.Location = new System.Drawing.Point(347, 75);
            this.dtpMonthBonus.Name = "dtpMonthBonus";
            this.dtpMonthBonus.ShowUpDown = true;
            this.dtpMonthBonus.Size = new System.Drawing.Size(127, 30);
            this.dtpMonthBonus.TabIndex = 85;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Info;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblPositionLoginValue);
            this.pnlHeader.Controls.Add(this.lblPositionLogin);
            this.pnlHeader.Controls.Add(this.lblDepartmentLoginValue);
            this.pnlHeader.Controls.Add(this.lblDepartmentLogin);
            this.pnlHeader.Controls.Add(this.lblFullNameLoginValue);
            this.pnlHeader.Controls.Add(this.lblFullNameLogin);
            this.pnlHeader.Controls.Add(this.lblStaffIDLoginValue);
            this.pnlHeader.Controls.Add(this.lblStaffIDLogin);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1924, 113);
            this.pnlHeader.TabIndex = 69;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::CLIENT.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(1780, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 113);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPositionLoginValue
            // 
            this.lblPositionLoginValue.AutoSize = true;
            this.lblPositionLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLoginValue.Location = new System.Drawing.Point(1178, 72);
            this.lblPositionLoginValue.Name = "lblPositionLoginValue";
            this.lblPositionLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblPositionLoginValue.TabIndex = 8;
            this.lblPositionLoginValue.Text = "...";
            // 
            // lblPositionLogin
            // 
            this.lblPositionLogin.AutoSize = true;
            this.lblPositionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLogin.Location = new System.Drawing.Point(1002, 72);
            this.lblPositionLogin.Name = "lblPositionLogin";
            this.lblPositionLogin.Size = new System.Drawing.Size(133, 32);
            this.lblPositionLogin.TabIndex = 7;
            this.lblPositionLogin.Text = "Chức vụ:";
            // 
            // lblDepartmentLoginValue
            // 
            this.lblDepartmentLoginValue.AutoSize = true;
            this.lblDepartmentLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLoginValue.Location = new System.Drawing.Point(1178, 9);
            this.lblDepartmentLoginValue.Name = "lblDepartmentLoginValue";
            this.lblDepartmentLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblDepartmentLoginValue.TabIndex = 6;
            this.lblDepartmentLoginValue.Text = "...";
            // 
            // lblDepartmentLogin
            // 
            this.lblDepartmentLogin.AutoSize = true;
            this.lblDepartmentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLogin.Location = new System.Drawing.Point(1002, 9);
            this.lblDepartmentLogin.Name = "lblDepartmentLogin";
            this.lblDepartmentLogin.Size = new System.Drawing.Size(170, 32);
            this.lblDepartmentLogin.TabIndex = 5;
            this.lblDepartmentLogin.Text = "Phòng ban:";
            // 
            // lblFullNameLoginValue
            // 
            this.lblFullNameLoginValue.AutoSize = true;
            this.lblFullNameLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameLoginValue.Location = new System.Drawing.Point(529, 72);
            this.lblFullNameLoginValue.Name = "lblFullNameLoginValue";
            this.lblFullNameLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblFullNameLoginValue.TabIndex = 4;
            this.lblFullNameLoginValue.Text = "...";
            this.lblFullNameLoginValue.UseMnemonic = false;
            // 
            // lblFullNameLogin
            // 
            this.lblFullNameLogin.AutoSize = true;
            this.lblFullNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameLogin.Location = new System.Drawing.Point(318, 72);
            this.lblFullNameLogin.Name = "lblFullNameLogin";
            this.lblFullNameLogin.Size = new System.Drawing.Size(112, 32);
            this.lblFullNameLogin.TabIndex = 3;
            this.lblFullNameLogin.Text = "Họ tên:";
            // 
            // lblStaffIDLoginValue
            // 
            this.lblStaffIDLoginValue.AutoSize = true;
            this.lblStaffIDLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffIDLoginValue.Location = new System.Drawing.Point(529, 9);
            this.lblStaffIDLoginValue.Name = "lblStaffIDLoginValue";
            this.lblStaffIDLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblStaffIDLoginValue.TabIndex = 2;
            this.lblStaffIDLoginValue.Text = "...";
            this.lblStaffIDLoginValue.UseMnemonic = false;
            // 
            // lblStaffIDLogin
            // 
            this.lblStaffIDLogin.AutoSize = true;
            this.lblStaffIDLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffIDLogin.Location = new System.Drawing.Point(318, 9);
            this.lblStaffIDLogin.Name = "lblStaffIDLogin";
            this.lblStaffIDLogin.Size = new System.Drawing.Size(205, 32);
            this.lblStaffIDLogin.TabIndex = 1;
            this.lblStaffIDLogin.Text = "Mã nhân viên:";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::CLIENT.Properties.Resources._return;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 113);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 993);
            this.Controls.Add(this.tabControlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.tbSalary.ResumeLayout(false);
            this.tbSalary.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tbBonus.ResumeLayout(false);
            this.tbBonus.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptSalary;
        private System.Windows.Forms.RadioButton rbPositionSalary;
        private System.Windows.Forms.ComboBox cmbPositionSalary;
        private System.Windows.Forms.RadioButton rbDepartmentSalary;
        private System.Windows.Forms.RadioButton rbAllStaffSalary;
        private System.Windows.Forms.Label lblSalaryStatistics;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbDepartmentSalary;
        private System.Windows.Forms.TabPage tbSalary;
        private System.Windows.Forms.DateTimePicker dtpMonthSalary;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tbBonus;
        private Microsoft.Reporting.WinForms.ReportViewer rptBonus;
        private System.Windows.Forms.RadioButton rbPositionBonus;
        private System.Windows.Forms.ComboBox cmbPositionBonus;
        private System.Windows.Forms.RadioButton rbDepartmentBonus;
        private System.Windows.Forms.RadioButton rbAllStaffBonus;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartmentBonus;
        private System.Windows.Forms.DateTimePicker dtpMonthBonus;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblPositionLoginValue;
        private System.Windows.Forms.Label lblPositionLogin;
        private System.Windows.Forms.Label lblDepartmentLoginValue;
        private System.Windows.Forms.Label lblDepartmentLogin;
        private System.Windows.Forms.Label lblFullNameLoginValue;
        private System.Windows.Forms.Label lblFullNameLogin;
        private System.Windows.Forms.Label lblStaffIDLoginValue;
        private System.Windows.Forms.Label lblStaffIDLogin;
        private System.Windows.Forms.Button btnBack;
    }
}