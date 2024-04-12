using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmChangePassword : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly string _staffID;
        public frmChangePassword(string staffID)
        {
            InitializeComponent();
            _staffID = staffID;
            _staffBUS = new StaffBUS(); 
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
        private async Task<bool> CheckError()
        {
            errProvider.Clear();
            bool flag = true;
            Staff staff = await _staffBUS.GetStaff(_staffID);
            if(!BCrypt.Net.BCrypt.Verify(txtOldPassword.Text, staff.Password))
            {
                flag = false;
                errProvider.SetError(txtOldPassword, "Mật khẩu cũ không hợp lệ");
            }
            if (!InputCheck.CheckPassword(txtNewPassword.Text))
            {
                flag = false;
                errProvider.SetError(txtNewPassword, "Mật khẩu phải có ít nhất 1 ký tự hoa, 1 ký tự thường, 1 ký tự đặc biệt, 1 ký tự số và có độ dài >= 8");
            }
            if(txtNewPassword.Text != txtReEnterNewPassword.Text)
            {
                flag = false;
                errProvider.SetError(txtReEnterNewPassword, "Mật khẩu nhập lại không khớp với mật khẩu trước đó");
            }
            if (flag)
                return true;
            return false;
        }

        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowpassword.Checked)
            {
                txtOldPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtReEnterNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtReEnterNewPassword.UseSystemPasswordChar = true;

            }
        }

        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!await CheckError())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Staff staff = await _staffBUS.GetStaff(_staffID);
                staff.Password = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text);
                if(await _staffBUS.UpdateStaff(staff))
                    Close();
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void EnableButton(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) ||
               string.IsNullOrEmpty(txtReEnterNewPassword.Text))
                btnChangePassword.Enabled = false;
            else
                btnChangePassword.Enabled = true;
        }
    }
}
