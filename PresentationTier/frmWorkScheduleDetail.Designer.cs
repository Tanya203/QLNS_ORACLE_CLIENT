﻿namespace CLIENT.PresentationTier
{
    partial class frmWorkScheduleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkScheduleDetail));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFontSỉze = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblWorkScheduleInfo = new System.Windows.Forms.Label();
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnUpdateDateOff = new System.Windows.Forms.Button();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.txtWorkScheduleID = new System.Windows.Forms.TextBox();
            this.lblWorkScheduleID = new System.Windows.Forms.Label();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbStaffPicture = new System.Windows.Forms.PictureBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
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
            this.dgvWorkScheduleDetail = new System.Windows.Forms.DataGridView();
            this.colMaLLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSortShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkScheduleDetail)).BeginInit();
            this.SuspendLayout();
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
            // lblFontSỉze
            // 
            this.lblFontSỉze.AutoSize = true;
            this.lblFontSỉze.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSỉze.Location = new System.Drawing.Point(1724, 385);
            this.lblFontSỉze.Name = "lblFontSỉze";
            this.lblFontSỉze.Size = new System.Drawing.Size(118, 32);
            this.lblFontSỉze.TabIndex = 89;
            this.lblFontSỉze.Text = "Cỡ chữ:";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(765, 386);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(145, 32);
            this.lblSearch.TabIndex = 83;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(916, 388);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 30);
            this.txtSearch.TabIndex = 80;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblWorkScheduleInfo
            // 
            this.lblWorkScheduleInfo.AutoSize = true;
            this.lblWorkScheduleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkScheduleInfo.Location = new System.Drawing.Point(222, 144);
            this.lblWorkScheduleInfo.Name = "lblWorkScheduleInfo";
            this.lblWorkScheduleInfo.Size = new System.Drawing.Size(318, 32);
            this.lblWorkScheduleInfo.TabIndex = 86;
            this.lblWorkScheduleInfo.Text = "Thông tin lịch làm việc";
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.AutoSize = true;
            this.lblAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStaff.Location = new System.Drawing.Point(1063, 132);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(231, 32);
            this.lblAddStaff.TabIndex = 85;
            this.lblAddStaff.Text = "Thêm nhân viên";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Info;
            this.pnlInfo.Controls.Add(this.btnUpdateDateOff);
            this.pnlInfo.Controls.Add(this.dtpWorkDate);
            this.pnlInfo.Controls.Add(this.lblWorkDate);
            this.pnlInfo.Controls.Add(this.txtWorkScheduleID);
            this.pnlInfo.Controls.Add(this.lblWorkScheduleID);
            this.pnlInfo.Location = new System.Drawing.Point(160, 179);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(432, 194);
            this.pnlInfo.TabIndex = 87;
            // 
            // btnUpdateDateOff
            // 
            this.btnUpdateDateOff.AutoSize = true;
            this.btnUpdateDateOff.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdateDateOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDateOff.FlatAppearance.BorderSize = 0;
            this.btnUpdateDateOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateDateOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDateOff.Image = global::CLIENT.Properties.Resources.add;
            this.btnUpdateDateOff.Location = new System.Drawing.Point(118, 125);
            this.btnUpdateDateOff.Name = "btnUpdateDateOff";
            this.btnUpdateDateOff.Size = new System.Drawing.Size(196, 44);
            this.btnUpdateDateOff.TabIndex = 91;
            this.btnUpdateDateOff.Text = "Cập nhật phép";
            this.btnUpdateDateOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateDateOff.UseVisualStyleBackColor = false;
            this.btnUpdateDateOff.Click += new System.EventHandler(this.btnUpdateDateOff_Click);
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.CustomFormat = "yyyy-MM-dd";
            this.dtpWorkDate.Enabled = false;
            this.dtpWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkDate.Location = new System.Drawing.Point(206, 74);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(207, 30);
            this.dtpWorkDate.TabIndex = 6;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.AutoSize = true;
            this.lblWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDate.Location = new System.Drawing.Point(8, 74);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Size = new System.Drawing.Size(109, 25);
            this.lblWorkDate.TabIndex = 50;
            this.lblWorkDate.Text = "Ngày làm:";
            // 
            // txtWorkScheduleID
            // 
            this.txtWorkScheduleID.Enabled = false;
            this.txtWorkScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkScheduleID.Location = new System.Drawing.Point(206, 21);
            this.txtWorkScheduleID.Name = "txtWorkScheduleID";
            this.txtWorkScheduleID.Size = new System.Drawing.Size(207, 30);
            this.txtWorkScheduleID.TabIndex = 3;
            // 
            // lblWorkScheduleID
            // 
            this.lblWorkScheduleID.AutoSize = true;
            this.lblWorkScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkScheduleID.Location = new System.Drawing.Point(8, 21);
            this.lblWorkScheduleID.Name = "lblWorkScheduleID";
            this.lblWorkScheduleID.Size = new System.Drawing.Size(173, 25);
            this.lblWorkScheduleID.TabIndex = 0;
            this.lblWorkScheduleID.Text = "Mã lịch làm việc:";
            // 
            // pnlFunction
            // 
            this.pnlFunction.BackColor = System.Drawing.SystemColors.Info;
            this.pnlFunction.Controls.Add(this.label1);
            this.pnlFunction.Controls.Add(this.cmbDepartment);
            this.pnlFunction.Controls.Add(this.cmbPosition);
            this.pnlFunction.Controls.Add(this.label2);
            this.pnlFunction.Controls.Add(this.btnSave);
            this.pnlFunction.Controls.Add(this.pbStaffPicture);
            this.pnlFunction.Controls.Add(this.cmbShift);
            this.pnlFunction.Controls.Add(this.lblShift);
            this.pnlFunction.Controls.Add(this.cmbStaffID);
            this.pnlFunction.Controls.Add(this.btnAdd);
            this.pnlFunction.Controls.Add(this.lblStaffID);
            this.pnlFunction.Location = new System.Drawing.Point(614, 167);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(1100, 215);
            this.pnlFunction.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Chức vụ:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(138, 92);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(255, 33);
            this.cmbDepartment.TabIndex = 87;
            this.cmbDepartment.TextChanged += new System.EventHandler(this.cmbDepartment_TextChanged);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(578, 19);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(255, 33);
            this.cmbPosition.TabIndex = 88;
            this.cmbPosition.TextChanged += new System.EventHandler(this.cmbPosition_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Phòng ban:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CLIENT.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(455, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 44);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbStaffPicture
            // 
            this.pbStaffPicture.Image = global::CLIENT.Properties.Resources.image;
            this.pbStaffPicture.Location = new System.Drawing.Point(892, 16);
            this.pbStaffPicture.Name = "pbStaffPicture";
            this.pbStaffPicture.Size = new System.Drawing.Size(173, 177);
            this.pbStaffPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStaffPicture.TabIndex = 83;
            this.pbStaffPicture.TabStop = false;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(137, 19);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(255, 33);
            this.cmbShift.TabIndex = 8;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(13, 27);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(47, 25);
            this.lblShift.TabIndex = 64;
            this.lblShift.Text = "Ca:";
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(578, 90);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(255, 33);
            this.cmbStaffID.TabIndex = 7;
            this.cmbStaffID.TextChanged += new System.EventHandler(this.cmbStaffID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::CLIENT.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(310, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(423, 98);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(149, 25);
            this.lblStaffID.TabIndex = 53;
            this.lblStaffID.Text = "Mã nhân viên:";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFontSize.Location = new System.Drawing.Point(1848, 384);
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(64, 34);
            this.nudFontSize.TabIndex = 88;
            this.nudFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
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
            this.pnlHeader.TabIndex = 82;
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
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPositionLoginValue
            // 
            this.lblPositionLoginValue.AutoSize = true;
            this.lblPositionLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLoginValue.Location = new System.Drawing.Point(1248, 72);
            this.lblPositionLoginValue.Name = "lblPositionLoginValue";
            this.lblPositionLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblPositionLoginValue.TabIndex = 8;
            this.lblPositionLoginValue.Text = "...";
            // 
            // lblPositionLogin
            // 
            this.lblPositionLogin.AutoSize = true;
            this.lblPositionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLogin.Location = new System.Drawing.Point(1072, 72);
            this.lblPositionLogin.Name = "lblPositionLogin";
            this.lblPositionLogin.Size = new System.Drawing.Size(133, 32);
            this.lblPositionLogin.TabIndex = 7;
            this.lblPositionLogin.Text = "Chức vụ:";
            // 
            // lblDepartmentLoginValue
            // 
            this.lblDepartmentLoginValue.AutoSize = true;
            this.lblDepartmentLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLoginValue.Location = new System.Drawing.Point(1248, 9);
            this.lblDepartmentLoginValue.Name = "lblDepartmentLoginValue";
            this.lblDepartmentLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblDepartmentLoginValue.TabIndex = 6;
            this.lblDepartmentLoginValue.Text = "...";
            // 
            // lblDepartmentLogin
            // 
            this.lblDepartmentLogin.AutoSize = true;
            this.lblDepartmentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLogin.Location = new System.Drawing.Point(1072, 9);
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
            this.dgvWorkScheduleDetail.TabIndex = 81;
            this.dgvWorkScheduleDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkScheduleDetail_CellClick);
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
            // cmbSortShift
            // 
            this.cmbSortShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortShift.FormattingEnabled = true;
            this.cmbSortShift.Location = new System.Drawing.Point(65, 386);
            this.cmbSortShift.Name = "cmbSortShift";
            this.cmbSortShift.Size = new System.Drawing.Size(175, 33);
            this.cmbSortShift.TabIndex = 90;
            this.cmbSortShift.TextChanged += new System.EventHandler(this.cmbSortShift_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Ca:";
            // 
            // frmWorkScheduleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 993);
            this.Controls.Add(this.cmbSortShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFontSỉze);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWorkScheduleInfo);
            this.Controls.Add(this.lblAddStaff);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlFunction);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvWorkScheduleDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWorkScheduleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lịch làm việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWorkScheduleDetail_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlFunction.ResumeLayout(false);
            this.pnlFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkScheduleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFontSỉze;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWorkScheduleInfo;
        private System.Windows.Forms.Label lblAddStaff;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.TextBox txtWorkScheduleID;
        private System.Windows.Forms.Label lblWorkScheduleID;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbStaffPicture;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.NumericUpDown nudFontSize;
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
        private System.Windows.Forms.DataGridView dgvWorkScheduleDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSortShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Button btnUpdateDateOff;
    }
}