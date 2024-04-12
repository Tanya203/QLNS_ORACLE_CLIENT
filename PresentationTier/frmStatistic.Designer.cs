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
            this.rbPositionSalary = new System.Windows.Forms.RadioButton();
            this.cmbPositionSalary = new System.Windows.Forms.ComboBox();
            this.rbDepartmentSalary = new System.Windows.Forms.RadioButton();
            this.rbAllStaffSalary = new System.Windows.Forms.RadioButton();
            this.lblSalaryStatistics = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbDepartmentSalary = new System.Windows.Forms.ComboBox();
            this.dtpMonthSalary = new System.Windows.Forms.DateTimePicker();
            this.rptSalary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
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
            // rbPositionSalary
            // 
            this.rbPositionSalary.AutoSize = true;
            this.rbPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPositionSalary.Location = new System.Drawing.Point(1154, 187);
            this.rbPositionSalary.Name = "rbPositionSalary";
            this.rbPositionSalary.Size = new System.Drawing.Size(154, 36);
            this.rbPositionSalary.TabIndex = 92;
            this.rbPositionSalary.TabStop = true;
            this.rbPositionSalary.Text = "Chức vụ:";
            this.rbPositionSalary.UseVisualStyleBackColor = true;
            this.rbPositionSalary.CheckedChanged += new System.EventHandler(this.EnableComboBox);
            // 
            // cmbPositionSalary
            // 
            this.cmbPositionSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPositionSalary.Enabled = false;
            this.cmbPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSalary.FormattingEnabled = true;
            this.cmbPositionSalary.Location = new System.Drawing.Point(1314, 189);
            this.cmbPositionSalary.Name = "cmbPositionSalary";
            this.cmbPositionSalary.Size = new System.Drawing.Size(244, 33);
            this.cmbPositionSalary.TabIndex = 91;
            this.cmbPositionSalary.TextChanged += new System.EventHandler(this.cmbPositionSalary_TextChanged_1);
            // 
            // rbDepartmentSalary
            // 
            this.rbDepartmentSalary.AutoSize = true;
            this.rbDepartmentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartmentSalary.Location = new System.Drawing.Point(707, 189);
            this.rbDepartmentSalary.Name = "rbDepartmentSalary";
            this.rbDepartmentSalary.Size = new System.Drawing.Size(191, 36);
            this.rbDepartmentSalary.TabIndex = 90;
            this.rbDepartmentSalary.TabStop = true;
            this.rbDepartmentSalary.Text = "Phòng ban:";
            this.rbDepartmentSalary.UseVisualStyleBackColor = true;
            this.rbDepartmentSalary.CheckedChanged += new System.EventHandler(this.EnableComboBox);
            // 
            // rbAllStaffSalary
            // 
            this.rbAllStaffSalary.AutoSize = true;
            this.rbAllStaffSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllStaffSalary.Location = new System.Drawing.Point(414, 189);
            this.rbAllStaffSalary.Name = "rbAllStaffSalary";
            this.rbAllStaffSalary.Size = new System.Drawing.Size(287, 36);
            this.rbAllStaffSalary.TabIndex = 89;
            this.rbAllStaffSalary.TabStop = true;
            this.rbAllStaffSalary.Text = "Toàn bộ nhân viên";
            this.rbAllStaffSalary.UseVisualStyleBackColor = true;
            this.rbAllStaffSalary.CheckedChanged += new System.EventHandler(this.EnableComboBox);
            // 
            // lblSalaryStatistics
            // 
            this.lblSalaryStatistics.AutoSize = true;
            this.lblSalaryStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryStatistics.Location = new System.Drawing.Point(788, 125);
            this.lblSalaryStatistics.Name = "lblSalaryStatistics";
            this.lblSalaryStatistics.Size = new System.Drawing.Size(332, 51);
            this.lblSalaryStatistics.TabIndex = 88;
            this.lblSalaryStatistics.Text = "Thống kê lương";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(166, 191);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(109, 32);
            this.lblMonth.TabIndex = 87;
            this.lblMonth.Text = "Tháng:";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDepartmentSalary
            // 
            this.cmbDepartmentSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmentSalary.Enabled = false;
            this.cmbDepartmentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSalary.FormattingEnabled = true;
            this.cmbDepartmentSalary.Location = new System.Drawing.Point(904, 189);
            this.cmbDepartmentSalary.Name = "cmbDepartmentSalary";
            this.cmbDepartmentSalary.Size = new System.Drawing.Size(244, 33);
            this.cmbDepartmentSalary.TabIndex = 86;
            this.cmbDepartmentSalary.TextChanged += new System.EventHandler(this.cmbDepartmentSalary_TextChanged_1);
            // 
            // dtpMonthSalary
            // 
            this.dtpMonthSalary.CustomFormat = "MM/yyyy";
            this.dtpMonthSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthSalary.Location = new System.Drawing.Point(281, 193);
            this.dtpMonthSalary.Name = "dtpMonthSalary";
            this.dtpMonthSalary.ShowUpDown = true;
            this.dtpMonthSalary.Size = new System.Drawing.Size(127, 30);
            this.dtpMonthSalary.TabIndex = 85;
            this.dtpMonthSalary.ValueChanged += new System.EventHandler(this.dtpMonthSalary_ValueChanged_1);
            // 
            // rptSalary
            // 
            this.rptSalary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptSalary.LocalReport.ReportEmbeddedResource = "CLIENT.ReportViewers.rptSalaryStatistic.rdlc";
            this.rptSalary.Location = new System.Drawing.Point(0, 231);
            this.rptSalary.Name = "rptSalary";
            this.rptSalary.ServerReport.BearerToken = null;
            this.rptSalary.Size = new System.Drawing.Size(1924, 762);
            this.rptSalary.TabIndex = 93;
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 993);
            this.Controls.Add(this.rptSalary);
            this.Controls.Add(this.rbPositionSalary);
            this.Controls.Add(this.cmbPositionSalary);
            this.Controls.Add(this.rbDepartmentSalary);
            this.Controls.Add(this.rbAllStaffSalary);
            this.Controls.Add(this.lblSalaryStatistics);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbDepartmentSalary);
            this.Controls.Add(this.dtpMonthSalary);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.RadioButton rbPositionSalary;
        private System.Windows.Forms.ComboBox cmbPositionSalary;
        private System.Windows.Forms.RadioButton rbDepartmentSalary;
        private System.Windows.Forms.RadioButton rbAllStaffSalary;
        private System.Windows.Forms.Label lblSalaryStatistics;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbDepartmentSalary;
        private System.Windows.Forms.DateTimePicker dtpMonthSalary;
        private Microsoft.Reporting.WinForms.ReportViewer rptSalary;
    }
}