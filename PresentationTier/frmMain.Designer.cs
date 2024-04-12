namespace CLIENT.PresentationTier
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblFontSỉze = new System.Windows.Forms.Label();
            this.dtpWorkSchedule = new System.Windows.Forms.DateTimePicker();
            this.lblWorkSchedule = new System.Windows.Forms.Label();
            this.lblValueAbsence = new System.Windows.Forms.Label();
            this.lblAbsenceRemain = new System.Windows.Forms.Label();
            this.lblValueFullName = new System.Windows.Forms.Label();
            this.lblValuePosition = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnContractType = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnBenefit = new System.Windows.Forms.Button();
            this.btnWorkSchedule = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnStaffs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblValueDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblValueStaffID = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.pbStaffPicture = new System.Windows.Forms.PictureBox();
            this.cmbSortShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvWorkScheduleDetail = new System.Windows.Forms.DataGridView();
            this.colMaLLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkScheduleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFontSize
            // 
            this.nudFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFontSize.Location = new System.Drawing.Point(1860, 384);
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(64, 34);
            this.nudFontSize.TabIndex = 76;
            this.nudFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // lblFontSỉze
            // 
            this.lblFontSỉze.AutoSize = true;
            this.lblFontSỉze.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSỉze.Location = new System.Drawing.Point(1736, 385);
            this.lblFontSỉze.Name = "lblFontSỉze";
            this.lblFontSỉze.Size = new System.Drawing.Size(118, 32);
            this.lblFontSỉze.TabIndex = 77;
            this.lblFontSỉze.Text = "Cỡ chữ:";
            // 
            // dtpWorkSchedule
            // 
            this.dtpWorkSchedule.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpWorkSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkSchedule.Location = new System.Drawing.Point(823, 377);
            this.dtpWorkSchedule.Name = "dtpWorkSchedule";
            this.dtpWorkSchedule.Size = new System.Drawing.Size(308, 34);
            this.dtpWorkSchedule.TabIndex = 71;
            this.dtpWorkSchedule.ValueChanged += new System.EventHandler(this.dtpWorkSchedule_ValueChanged);
            // 
            // lblWorkSchedule
            // 
            this.lblWorkSchedule.AutoSize = true;
            this.lblWorkSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkSchedule.Location = new System.Drawing.Point(838, 328);
            this.lblWorkSchedule.Name = "lblWorkSchedule";
            this.lblWorkSchedule.Size = new System.Drawing.Size(264, 46);
            this.lblWorkSchedule.TabIndex = 75;
            this.lblWorkSchedule.Text = "Lịch làm việc";
            // 
            // lblValueAbsence
            // 
            this.lblValueAbsence.AutoSize = true;
            this.lblValueAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAbsence.Location = new System.Drawing.Point(1582, 92);
            this.lblValueAbsence.Name = "lblValueAbsence";
            this.lblValueAbsence.Size = new System.Drawing.Size(39, 36);
            this.lblValueAbsence.TabIndex = 24;
            this.lblValueAbsence.Text = "...";
            // 
            // lblAbsenceRemain
            // 
            this.lblAbsenceRemain.AutoSize = true;
            this.lblAbsenceRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsenceRemain.Location = new System.Drawing.Point(1270, 90);
            this.lblAbsenceRemain.Name = "lblAbsenceRemain";
            this.lblAbsenceRemain.Size = new System.Drawing.Size(306, 38);
            this.lblAbsenceRemain.TabIndex = 23;
            this.lblAbsenceRemain.Text = "Số ngày phép còn:";
            // 
            // lblValueFullName
            // 
            this.lblValueFullName.AutoSize = true;
            this.lblValueFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueFullName.Location = new System.Drawing.Point(249, 145);
            this.lblValueFullName.Name = "lblValueFullName";
            this.lblValueFullName.Size = new System.Drawing.Size(44, 38);
            this.lblValueFullName.TabIndex = 20;
            this.lblValueFullName.Text = "...";
            // 
            // lblValuePosition
            // 
            this.lblValuePosition.AutoSize = true;
            this.lblValuePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePosition.Location = new System.Drawing.Point(827, 145);
            this.lblValuePosition.Name = "lblValuePosition";
            this.lblValuePosition.Size = new System.Drawing.Size(44, 38);
            this.lblValuePosition.TabIndex = 22;
            this.lblValuePosition.Text = "...";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnChangePassword);
            this.pnlMenu.Controls.Add(this.btnContractType);
            this.pnlMenu.Controls.Add(this.btnStatistics);
            this.pnlMenu.Controls.Add(this.btnBenefit);
            this.pnlMenu.Controls.Add(this.btnWorkSchedule);
            this.pnlMenu.Controls.Add(this.btnShift);
            this.pnlMenu.Controls.Add(this.btnPosition);
            this.pnlMenu.Controls.Add(this.btnDepartment);
            this.pnlMenu.Controls.Add(this.btnStaffs);
            this.pnlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1924, 100);
            this.pnlMenu.TabIndex = 73;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::CLIENT.Properties.Resources.log_out;
            this.btnLogOut.Location = new System.Drawing.Point(1821, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(103, 100);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = global::CLIENT.Properties.Resources.lock_big;
            this.btnChangePassword.Location = new System.Drawing.Point(800, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(129, 100);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnContractType
            // 
            this.btnContractType.AutoSize = true;
            this.btnContractType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContractType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContractType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContractType.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnContractType.FlatAppearance.BorderSize = 2;
            this.btnContractType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractType.Image = global::CLIENT.Properties.Resources.contract;
            this.btnContractType.Location = new System.Drawing.Point(663, 0);
            this.btnContractType.Name = "btnContractType";
            this.btnContractType.Size = new System.Drawing.Size(137, 100);
            this.btnContractType.TabIndex = 10;
            this.btnContractType.Text = "Loại hợp đồng";
            this.btnContractType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContractType.UseVisualStyleBackColor = true;
            this.btnContractType.Click += new System.EventHandler(this.btnContractType_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.AutoSize = true;
            this.btnStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStatistics.FlatAppearance.BorderSize = 2;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Image = global::CLIENT.Properties.Resources.chart;
            this.btnStatistics.Location = new System.Drawing.Point(568, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(95, 100);
            this.btnStatistics.TabIndex = 9;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnBenefit
            // 
            this.btnBenefit.AutoSize = true;
            this.btnBenefit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBenefit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBenefit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBenefit.FlatAppearance.BorderSize = 2;
            this.btnBenefit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenefit.Image = global::CLIENT.Properties.Resources.allowance;
            this.btnBenefit.Location = new System.Drawing.Point(481, 0);
            this.btnBenefit.Name = "btnBenefit";
            this.btnBenefit.Size = new System.Drawing.Size(87, 100);
            this.btnBenefit.TabIndex = 7;
            this.btnBenefit.Text = "Phúc lợi";
            this.btnBenefit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBenefit.UseVisualStyleBackColor = true;
            this.btnBenefit.Click += new System.EventHandler(this.btnBenefit_Click);
            // 
            // btnWorkSchedule
            // 
            this.btnWorkSchedule.AutoSize = true;
            this.btnWorkSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWorkSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWorkSchedule.FlatAppearance.BorderSize = 2;
            this.btnWorkSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkSchedule.Image = global::CLIENT.Properties.Resources.timetable;
            this.btnWorkSchedule.Location = new System.Drawing.Point(350, 0);
            this.btnWorkSchedule.Name = "btnWorkSchedule";
            this.btnWorkSchedule.Size = new System.Drawing.Size(131, 100);
            this.btnWorkSchedule.TabIndex = 6;
            this.btnWorkSchedule.Text = "Lịch làm việc";
            this.btnWorkSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWorkSchedule.UseVisualStyleBackColor = true;
            this.btnWorkSchedule.Click += new System.EventHandler(this.btnWorkSchedule_Click);
            // 
            // btnShift
            // 
            this.btnShift.AutoSize = true;
            this.btnShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShift.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShift.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShift.FlatAppearance.BorderSize = 2;
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.Image = global::CLIENT.Properties.Resources.shitf;
            this.btnShift.Location = new System.Drawing.Point(296, 0);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(54, 100);
            this.btnShift.TabIndex = 4;
            this.btnShift.Text = "Ca";
            this.btnShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.AutoSize = true;
            this.btnPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPosition.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPosition.FlatAppearance.BorderSize = 2;
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.Image = global::CLIENT.Properties.Resources.position;
            this.btnPosition.Location = new System.Drawing.Point(209, 0);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(87, 100);
            this.btnPosition.TabIndex = 3;
            this.btnPosition.Text = "Chức vụ";
            this.btnPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.AutoSize = true;
            this.btnDepartment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDepartment.FlatAppearance.BorderSize = 2;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Image = global::CLIENT.Properties.Resources.department;
            this.btnDepartment.Location = new System.Drawing.Point(102, 0);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(107, 100);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Phòng ban";
            this.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnStaffs
            // 
            this.btnStaffs.AutoSize = true;
            this.btnStaffs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStaffs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStaffs.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStaffs.FlatAppearance.BorderSize = 2;
            this.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffs.Image = global::CLIENT.Properties.Resources.staff;
            this.btnStaffs.Location = new System.Drawing.Point(0, 0);
            this.btnStaffs.Name = "btnStaffs";
            this.btnStaffs.Size = new System.Drawing.Size(102, 100);
            this.btnStaffs.TabIndex = 1;
            this.btnStaffs.Text = "Nhân viên";
            this.btnStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStaffs.UseVisualStyleBackColor = true;
            this.btnStaffs.Click += new System.EventHandler(this.btnStaffs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblValueAbsence);
            this.panel1.Controls.Add(this.lblAbsenceRemain);
            this.panel1.Controls.Add(this.lblValueFullName);
            this.panel1.Controls.Add(this.lblValuePosition);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblValueDepartment);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblValueStaffID);
            this.panel1.Controls.Add(this.lblStaffID);
            this.panel1.Controls.Add(this.pbStaffPicture);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 210);
            this.panel1.TabIndex = 74;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 143);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(129, 38);
            this.lblFullName.TabIndex = 19;
            this.lblFullName.Text = "Họ tên:";
            // 
            // lblValueDepartment
            // 
            this.lblValueDepartment.AutoSize = true;
            this.lblValueDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueDepartment.Location = new System.Drawing.Point(827, 19);
            this.lblValueDepartment.Name = "lblValueDepartment";
            this.lblValueDepartment.Size = new System.Drawing.Size(44, 38);
            this.lblValueDepartment.TabIndex = 4;
            this.lblValueDepartment.Text = "...";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(628, 143);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(155, 38);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(628, 17);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(193, 38);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Phòng ban:";
            // 
            // lblValueStaffID
            // 
            this.lblValueStaffID.AutoSize = true;
            this.lblValueStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueStaffID.Location = new System.Drawing.Point(249, 19);
            this.lblValueStaffID.Name = "lblValueStaffID";
            this.lblValueStaffID.Size = new System.Drawing.Size(44, 38);
            this.lblValueStaffID.TabIndex = 2;
            this.lblValueStaffID.Text = "...";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(12, 17);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(234, 38);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Mã nhân viên:";
            // 
            // pbStaffPicture
            // 
            this.pbStaffPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbStaffPicture.Image = global::CLIENT.Properties.Resources.image;
            this.pbStaffPicture.Location = new System.Drawing.Point(1706, 0);
            this.pbStaffPicture.Name = "pbStaffPicture";
            this.pbStaffPicture.Size = new System.Drawing.Size(218, 210);
            this.pbStaffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStaffPicture.TabIndex = 0;
            this.pbStaffPicture.TabStop = false;
            // 
            // cmbSortShift
            // 
            this.cmbSortShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortShift.FormattingEnabled = true;
            this.cmbSortShift.Location = new System.Drawing.Point(54, 385);
            this.cmbSortShift.Name = "cmbSortShift";
            this.cmbSortShift.Size = new System.Drawing.Size(175, 33);
            this.cmbSortShift.TabIndex = 93;
            this.cmbSortShift.TextChanged += new System.EventHandler(this.cmbSortShift_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "Ca:";
            // 
            // dgvWorkScheduleDetail
            // 
            this.dgvWorkScheduleDetail.AllowUserToAddRows = false;
            this.dgvWorkScheduleDetail.AllowUserToDeleteRows = false;
            this.dgvWorkScheduleDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkScheduleDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkScheduleDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkScheduleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkScheduleDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLLV,
            this.colMaNV,
            this.colHoTen,
            this.colPhongBan,
            this.colChucVu,
            this.colCa,
            this.colThoiGianDen,
            this.colThoiGianVe});
            this.dgvWorkScheduleDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvWorkScheduleDetail.Location = new System.Drawing.Point(0, 424);
            this.dgvWorkScheduleDetail.Name = "dgvWorkScheduleDetail";
            this.dgvWorkScheduleDetail.ReadOnly = true;
            this.dgvWorkScheduleDetail.RowHeadersVisible = false;
            this.dgvWorkScheduleDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkScheduleDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorkScheduleDetail.RowTemplate.Height = 24;
            this.dgvWorkScheduleDetail.Size = new System.Drawing.Size(1924, 569);
            this.dgvWorkScheduleDetail.TabIndex = 92;
            // 
            // colMaLLV
            // 
            this.colMaLLV.HeaderText = "Mã lịch làm việc";
            this.colMaLLV.MinimumWidth = 6;
            this.colMaLLV.Name = "colMaLLV";
            this.colMaLLV.ReadOnly = true;
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colPhongBan
            // 
            this.colPhongBan.HeaderText = "Phòng ban";
            this.colPhongBan.MinimumWidth = 6;
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            // 
            // colChucVu
            // 
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            // 
            // colCa
            // 
            this.colCa.HeaderText = "Ca";
            this.colCa.MinimumWidth = 6;
            this.colCa.Name = "colCa";
            this.colCa.ReadOnly = true;
            // 
            // colThoiGianDen
            // 
            this.colThoiGianDen.HeaderText = "Thời gian đến";
            this.colThoiGianDen.MinimumWidth = 6;
            this.colThoiGianDen.Name = "colThoiGianDen";
            this.colThoiGianDen.ReadOnly = true;
            // 
            // colThoiGianVe
            // 
            this.colThoiGianVe.HeaderText = "Thời gian về";
            this.colThoiGianVe.MinimumWidth = 6;
            this.colThoiGianVe.Name = "colThoiGianVe";
            this.colThoiGianVe.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 993);
            this.Controls.Add(this.cmbSortShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvWorkScheduleDetail);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.lblFontSỉze);
            this.Controls.Add(this.dtpWorkSchedule);
            this.Controls.Add(this.lblWorkSchedule);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkScheduleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label lblFontSỉze;
        private System.Windows.Forms.DateTimePicker dtpWorkSchedule;
        private System.Windows.Forms.Label lblWorkSchedule;
        private System.Windows.Forms.Label lblValueAbsence;
        private System.Windows.Forms.Label lblAbsenceRemain;
        private System.Windows.Forms.Label lblValueFullName;
        private System.Windows.Forms.Label lblValuePosition;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnContractType;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnBenefit;
        private System.Windows.Forms.Button btnWorkSchedule;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnStaffs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblValueDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblValueStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.PictureBox pbStaffPicture;
        private System.Windows.Forms.ComboBox cmbSortShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvWorkScheduleDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianVe;
    }
}