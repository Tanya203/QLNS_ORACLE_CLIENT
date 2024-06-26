﻿namespace CLIENT.PresentationTier
{
    partial class frmBenefit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBenefit));
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblFontSỉze = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPositionLoginValue = new System.Windows.Forms.Label();
            this.lblPositionLogin = new System.Windows.Forms.Label();
            this.lblDepartmentLoginValue = new System.Windows.Forms.Label();
            this.lblDepartmentLogin = new System.Windows.Forms.Label();
            this.lblFullNameLoginValue = new System.Windows.Forms.Label();
            this.lblFullNameLogin = new System.Windows.Forms.Label();
            this.lblStaffIDLoginValue = new System.Windows.Forms.Label();
            this.lblStaffIDLogin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblStaffAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStaffAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBenefitName = new System.Windows.Forms.TextBox();
            this.lblAllowanceName = new System.Windows.Forms.Label();
            this.txtBN_ID = new System.Windows.Forms.TextBox();
            this.lblAllowanceID = new System.Windows.Forms.Label();
            this.dgvBenefit = new System.Windows.Forms.DataGridView();
            this.colMaPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefit)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFontSize
            // 
            this.nudFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFontSize.Location = new System.Drawing.Point(1860, 367);
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(64, 34);
            this.nudFontSize.TabIndex = 75;
            this.nudFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
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
            // lblFontSỉze
            // 
            this.lblFontSỉze.AutoSize = true;
            this.lblFontSỉze.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSỉze.Location = new System.Drawing.Point(1736, 368);
            this.lblFontSỉze.Name = "lblFontSỉze";
            this.lblFontSỉze.Size = new System.Drawing.Size(118, 32);
            this.lblFontSỉze.TabIndex = 76;
            this.lblFontSỉze.Text = "Cỡ chữ:";
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
            this.pnlHeader.TabIndex = 71;
            // 
            // lblPositionLoginValue
            // 
            this.lblPositionLoginValue.AutoSize = true;
            this.lblPositionLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLoginValue.Location = new System.Drawing.Point(1160, 72);
            this.lblPositionLoginValue.Name = "lblPositionLoginValue";
            this.lblPositionLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblPositionLoginValue.TabIndex = 8;
            this.lblPositionLoginValue.Text = "...";
            // 
            // lblPositionLogin
            // 
            this.lblPositionLogin.AutoSize = true;
            this.lblPositionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLogin.Location = new System.Drawing.Point(984, 72);
            this.lblPositionLogin.Name = "lblPositionLogin";
            this.lblPositionLogin.Size = new System.Drawing.Size(133, 32);
            this.lblPositionLogin.TabIndex = 7;
            this.lblPositionLogin.Text = "Chức vụ:";
            // 
            // lblDepartmentLoginValue
            // 
            this.lblDepartmentLoginValue.AutoSize = true;
            this.lblDepartmentLoginValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLoginValue.Location = new System.Drawing.Point(1160, 9);
            this.lblDepartmentLoginValue.Name = "lblDepartmentLoginValue";
            this.lblDepartmentLoginValue.Size = new System.Drawing.Size(38, 32);
            this.lblDepartmentLoginValue.TabIndex = 6;
            this.lblDepartmentLoginValue.Text = "...";
            // 
            // lblDepartmentLogin
            // 
            this.lblDepartmentLogin.AutoSize = true;
            this.lblDepartmentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentLogin.Location = new System.Drawing.Point(984, 9);
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(855, 372);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 30);
            this.txtSearch.TabIndex = 69;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(704, 369);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(145, 32);
            this.lblSearch.TabIndex = 74;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // lblStaffAmount
            // 
            this.lblStaffAmount.AutoSize = true;
            this.lblStaffAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAmount.Location = new System.Drawing.Point(434, 93);
            this.lblStaffAmount.Name = "lblStaffAmount";
            this.lblStaffAmount.Size = new System.Drawing.Size(205, 25);
            this.lblStaffAmount.TabIndex = 43;
            this.lblStaffAmount.Text = "Số lượng nhân viên:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::CLIENT.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(650, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::CLIENT.Properties.Resources.fix;
            this.btnEdit.Location = new System.Drawing.Point(355, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 49);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::CLIENT.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(496, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowance.Location = new System.Drawing.Point(816, 116);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(258, 32);
            this.lblAllowance.TabIndex = 73;
            this.lblAllowance.Text = "Thông tin phụ cấp";
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Info;
            this.pnlMenu.Controls.Add(this.txtAmount);
            this.pnlMenu.Controls.Add(this.txtStaffAmount);
            this.pnlMenu.Controls.Add(this.lblStaffAmount);
            this.pnlMenu.Controls.Add(this.btnCancel);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnDelete);
            this.pnlMenu.Controls.Add(this.btnAdd);
            this.pnlMenu.Controls.Add(this.lblAmount);
            this.pnlMenu.Controls.Add(this.txtBenefitName);
            this.pnlMenu.Controls.Add(this.lblAllowanceName);
            this.pnlMenu.Controls.Add(this.txtBN_ID);
            this.pnlMenu.Controls.Add(this.lblAllowanceID);
            this.pnlMenu.Location = new System.Drawing.Point(476, 151);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(933, 215);
            this.pnlMenu.TabIndex = 72;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(164, 88);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(252, 30);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.CheckEmptyText);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtStaffAmount
            // 
            this.txtStaffAmount.Enabled = false;
            this.txtStaffAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAmount.Location = new System.Drawing.Point(645, 88);
            this.txtStaffAmount.Name = "txtStaffAmount";
            this.txtStaffAmount.Size = new System.Drawing.Size(263, 30);
            this.txtStaffAmount.TabIndex = 6;
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
            this.btnAdd.Location = new System.Drawing.Point(190, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(25, 91);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(87, 25);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Số tiền:";
            // 
            // txtBenefitName
            // 
            this.txtBenefitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefitName.Location = new System.Drawing.Point(645, 38);
            this.txtBenefitName.MaxLength = 50;
            this.txtBenefitName.Name = "txtBenefitName";
            this.txtBenefitName.Size = new System.Drawing.Size(263, 30);
            this.txtBenefitName.TabIndex = 4;
            this.txtBenefitName.TextChanged += new System.EventHandler(this.CheckEmptyText);
            // 
            // lblAllowanceName
            // 
            this.lblAllowanceName.AutoSize = true;
            this.lblAllowanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowanceName.Location = new System.Drawing.Point(434, 41);
            this.lblAllowanceName.Name = "lblAllowanceName";
            this.lblAllowanceName.Size = new System.Drawing.Size(140, 25);
            this.lblAllowanceName.TabIndex = 9;
            this.lblAllowanceName.Text = "Tên phụ cấp:";
            // 
            // txtBN_ID
            // 
            this.txtBN_ID.Enabled = false;
            this.txtBN_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBN_ID.Location = new System.Drawing.Point(164, 38);
            this.txtBN_ID.Name = "txtBN_ID";
            this.txtBN_ID.Size = new System.Drawing.Size(252, 30);
            this.txtBN_ID.TabIndex = 3;
            this.txtBN_ID.TextChanged += new System.EventHandler(this.CheckEmptyText);
            // 
            // lblAllowanceID
            // 
            this.lblAllowanceID.AutoSize = true;
            this.lblAllowanceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowanceID.Location = new System.Drawing.Point(25, 38);
            this.lblAllowanceID.Name = "lblAllowanceID";
            this.lblAllowanceID.Size = new System.Drawing.Size(132, 25);
            this.lblAllowanceID.TabIndex = 6;
            this.lblAllowanceID.Text = "Mã phụ cấp:";
            // 
            // dgvBenefit
            // 
            this.dgvBenefit.AllowUserToAddRows = false;
            this.dgvBenefit.AllowUserToDeleteRows = false;
            this.dgvBenefit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenefit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenefit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenefit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenefit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPC,
            this.colTenPhuCap,
            this.colSoTien,
            this.colSoLuongNhanVien,
            this.Column1});
            this.dgvBenefit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBenefit.Location = new System.Drawing.Point(0, 404);
            this.dgvBenefit.Name = "dgvBenefit";
            this.dgvBenefit.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenefit.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenefit.RowHeadersVisible = false;
            this.dgvBenefit.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBenefit.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBenefit.RowTemplate.Height = 24;
            this.dgvBenefit.Size = new System.Drawing.Size(1924, 589);
            this.dgvBenefit.TabIndex = 77;
            this.dgvBenefit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenefit_CellClick);
            // 
            // colMaPC
            // 
            this.colMaPC.HeaderText = "Mã phụ cấp";
            this.colMaPC.MinimumWidth = 6;
            this.colMaPC.Name = "colMaPC";
            this.colMaPC.ReadOnly = true;
            // 
            // colTenPhuCap
            // 
            this.colTenPhuCap.HeaderText = "Tên phụ cấp";
            this.colTenPhuCap.MinimumWidth = 6;
            this.colTenPhuCap.Name = "colTenPhuCap";
            this.colTenPhuCap.ReadOnly = true;
            // 
            // colSoTien
            // 
            this.colSoTien.HeaderText = "Số tiền";
            this.colSoTien.MinimumWidth = 6;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.ReadOnly = true;
            // 
            // colSoLuongNhanVien
            // 
            this.colSoLuongNhanVien.HeaderText = "Số lượng nhân viên";
            this.colSoLuongNhanVien.MinimumWidth = 6;
            this.colSoLuongNhanVien.Name = "colSoLuongNhanVien";
            this.colSoLuongNhanVien.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tổng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmBenefit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 993);
            this.Controls.Add(this.dgvBenefit);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.lblFontSỉze);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblAllowance);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBenefit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phúc lợi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBenefit_Load);
            this.TextChanged += new System.EventHandler(this.CheckEmptyText);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.DataGridView dgvBenefit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhanVien;
        private System.Windows.Forms.Label lblFontSỉze;
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtStaffAmount;
        private System.Windows.Forms.Label lblStaffAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBenefitName;
        private System.Windows.Forms.Label lblAllowanceName;
        private System.Windows.Forms.TextBox txtBN_ID;
        private System.Windows.Forms.Label lblAllowanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}