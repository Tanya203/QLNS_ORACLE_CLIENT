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
    public partial class frmLogin : Form
    {
        private readonly FormHandle _handle;
        private readonly StaffBUS _staffBUS;

        public frmLogin()
        {
            InitializeComponent();
            KeyPreview = true;
            _handle = new FormHandle();
            _staffBUS = new StaffBUS();
        }

        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpassword.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string account = txtAccount.Text;
                string password = txtPassword.Text;
                string staffID =  await _staffBUS.LoginVerify(account, password);
                if(staffID != null)
                {
                    frmMain open = new frmMain(staffID);
                    _handle.RedirectForm(open, this);
                }
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtAccount.Text))
            {
                btnLogin.Enabled = false;
                return;
            }
            btnLogin.Enabled = true;
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtAccount.Text = "ACC01";
            txtPassword.Text = "Aa@12345";
        }
    }
}
