namespace CLIENT.PresentationTier
{
    partial class frmChangePassword
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
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterNewPassword = new System.Windows.Forms.TextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cbShowpassword = new System.Windows.Forms.CheckBox();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(260, 30);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(256, 27);
            this.txtOldPassword.TabIndex = 8;
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(10, 32);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(137, 25);
            this.lblAccount.TabIndex = 20;
            this.lblAccount.Text = "Mật khẩu cũ:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(260, 78);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(256, 27);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // txtReEnterNewPassword
            // 
            this.txtReEnterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterNewPassword.Location = new System.Drawing.Point(260, 125);
            this.txtReEnterNewPassword.MaxLength = 20;
            this.txtReEnterNewPassword.Name = "txtReEnterNewPassword";
            this.txtReEnterNewPassword.Size = new System.Drawing.Size(256, 27);
            this.txtReEnterNewPassword.TabIndex = 10;
            this.txtReEnterNewPassword.UseSystemPasswordChar = true;
            this.txtReEnterNewPassword.TextChanged += new System.EventHandler(this.EnableButton);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Info;
            this.pnlInfo.Controls.Add(this.cbShowpassword);
            this.pnlInfo.Controls.Add(this.lblReEnterPassword);
            this.pnlInfo.Controls.Add(this.lblPassword);
            this.pnlInfo.Controls.Add(this.btnChangePassword);
            this.pnlInfo.Controls.Add(this.txtOldPassword);
            this.pnlInfo.Controls.Add(this.lblAccount);
            this.pnlInfo.Controls.Add(this.txtNewPassword);
            this.pnlInfo.Controls.Add(this.txtReEnterNewPassword);
            this.pnlInfo.Location = new System.Drawing.Point(51, 56);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(583, 265);
            this.pnlInfo.TabIndex = 42;
            // 
            // cbShowpassword
            // 
            this.cbShowpassword.AutoSize = true;
            this.cbShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowpassword.Location = new System.Drawing.Point(15, 184);
            this.cbShowpassword.Name = "cbShowpassword";
            this.cbShowpassword.Size = new System.Drawing.Size(162, 24);
            this.cbShowpassword.TabIndex = 39;
            this.cbShowpassword.Text = "Hiển thị mật khẩu";
            this.cbShowpassword.UseVisualStyleBackColor = true;
            this.cbShowpassword.CheckedChanged += new System.EventHandler(this.cbShowpassword_CheckedChanged);
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPassword.Location = new System.Drawing.Point(10, 125);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(232, 25);
            this.lblReEnterPassword.TabIndex = 38;
            this.lblReEnterPassword.Text = "Nhập lại mật khẩu mới:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(10, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(148, 25);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Mật khẩu mới:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = global::CLIENT.Properties.Resources.lock_big;
            this.btnChangePassword.Location = new System.Drawing.Point(249, 169);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(217, 70);
            this.btnChangePassword.TabIndex = 36;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(235, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(221, 38);
            this.lblHeader.TabIndex = 43;
            this.lblHeader.Text = "Đổi mật khẩu";
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 350);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtReEnterNewPassword;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.CheckBox cbShowpassword;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}