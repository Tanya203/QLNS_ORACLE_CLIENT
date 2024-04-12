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
    public partial class frmLockAccount : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly string _staffID;
        public frmLockAccount(string staffID)
        {
            InitializeComponent();
            _staffID = staffID;
            _staffBUS = new StaffBUS();
        }

        private void frmLockAccount_Load(object sender, EventArgs e)
        {
            lblLockAccount.Text += $" {_staffID}";
        }

        private async void btnLockAccount_Click(object sender, EventArgs e)
        {
            if (dtpLockDate.Value < DateTime.Now)
            {
                MessageBox.Show("Thời gian khoá phải lớn hơn thời gian hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CustomMessage.YesNoCustom("Có", "Không");
            DialogResult ketQua = MessageBox.Show($"Xác nhận khoá tài khoản của nhân viên {_staffID} đến {dtpLockDate.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                Staff staff = await _staffBUS.GetStaff(_staffID);
                staff.LockDate = dtpLockDate.Value;
                if(await _staffBUS.UpdateStaff(staff))
                    Close();
            }
            return;
        }
    }
}
