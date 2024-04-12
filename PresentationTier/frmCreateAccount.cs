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
    public partial class frmCreateAccount : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly string _staffID;
        public frmCreateAccount(string staffID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _staffID = staffID;
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            lblValue.Text = _staffID;
        }

        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if( cbShowpassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtReEnterPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtReEnterPassword.UseSystemPasswordChar = true;
            }
        }

        private void EnableButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
               string.IsNullOrEmpty(txtReEnterPassword.Text))
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
        }
        private bool CheckInputError()
        {
            bool flag = true;
            errProvider.Clear();
            var validationRules = new Dictionary<Control, Func<bool>>
            {
                { txtAccount, () => txtAccount.Text.Length < 5 || txtAccount.Text.Length > 20 },
                { txtPassword, () => !InputCheck.CheckPassword(txtPassword.Text) },
                { txtReEnterPassword, () => txtPassword.Text != txtReEnterPassword.Text }
            };
            var errorMessages = new Dictionary<Control, string>
            {
                { txtAccount, "Tài khoản phải có độ dài >=5 và <= 20" },
                { txtPassword, "Mật khẩu phải có ít nhất 1 ký tự hoa, 1 ký tự thường, 1 ký tự đặc biệt, 1 ký tự số và có độ dài >= 8" },
                { txtReEnterPassword, "Mật khẩu nhập lại không giống mật khẩu trước đó" },

            };
            foreach (var rule in validationRules)
            {
                var control = rule.Key;
                var validate = rule.Value;
                if (validate())
                {
                    errProvider.SetError(control, errorMessages[control]);
                    flag = false;
                }
            }
            if (flag)
                return true;
            return false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(!CheckInputError())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Staff staff = await _staffBUS.GetStaff(_staffID);
                staff.Account = txtAccount.Text;
                staff.Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                if(await _staffBUS.UpdateStaff(staff))
                    Close();
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
