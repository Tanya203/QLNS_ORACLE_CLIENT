using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
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
    public partial class frmUpdateDateOff : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private readonly WorkScheduleBUS _workScheduleBUS;
        private readonly WorkScheduleDetailBUS _workScheduleDetailBUS;
        private List<StaffWorkScheduleDetailViewModel> _listWorkScheduleDetails;
        private readonly string _staffID;
        private readonly string _wsID;
        public frmUpdateDateOff(string staffID, string wsID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _workScheduleBUS = new WorkScheduleBUS();
            _workScheduleDetailBUS = new WorkScheduleDetailBUS();
            _listWorkScheduleDetails = new List<StaffWorkScheduleDetailViewModel>();
            _staffID = staffID;
            _wsID = wsID;
        }
        private async void frmUpdateDateOff_Load(object sender, EventArgs e)
        {
            _listWorkScheduleDetails = await _workScheduleDetailBUS.GetWorkScheduleDetailById(_wsID);
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkScheduleDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadWorkScheduleInfo();      
            LoadWorkScheduleDetail();
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private async void LoadWorkScheduleInfo()
        {
            WorkSchedule info = await _workScheduleBUS.GetWorkScheduleInfo(_wsID);
            txtWorkScheduleID.Invoke((MethodInvoker)(() => txtWorkScheduleID.Text = info.WsId));
            dtpWorkDate.Invoke((MethodInvoker)(() => dtpWorkDate.Value = info.WorkDate));
            CheckMonth();
        }
        private void CheckMonth()
        {
            if(dtpWorkDate.Value.Month < DateTime.Now.Month && dtpWorkDate.Value.Year <= DateTime.Now.Year)
                dgvWorkScheduleDetail.ReadOnly = true;
        }
        private void LoadWorkScheduleDetail()
        {
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvWorkScheduleDetail.Rows.Clear();
                int rowAdd;
                List<StaffWorkScheduleDetailViewModel> list = _listWorkScheduleDetails;
                foreach (StaffWorkScheduleDetailViewModel staff in list.OrderBy(s => s.StaffId))
                {
                    rowAdd = dgvWorkScheduleDetail.Rows.Add();
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[0].Value = staff.WsId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[1].Value = staff.StaffId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[2].Value = staff.FullName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[3].Value = staff.DepartmentName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[4].Value = staff.PositionName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[5].Value = staff.DayOff;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[6].Value = staff.DateOff;
                }
                Enabled = true;
            }));
        }
        private void SearchWorkScheduleDetail(string search)
        {
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(async () =>
            {
                Enabled = false;
                dgvWorkScheduleDetail.Rows.Clear();
                int rowAdd;
                List<StaffWorkScheduleDetailViewModel> list =  await _workScheduleDetailBUS.SearchWorkScheduleDetailById(_wsID, search);
                foreach (StaffWorkScheduleDetailViewModel staff in list.OrderBy(s => s.StaffId))
                {
                    rowAdd = dgvWorkScheduleDetail.Rows.Add();
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[0].Value = staff.WsId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[1].Value = staff.StaffId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[2].Value = staff.FullName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[3].Value = staff.DepartmentName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[4].Value = staff.PositionName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[5].Value = staff.DayOff;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[6].Value = staff.DateOff;
                }
                Enabled = true;
            }));
        }
        private void Reload()
        {
            frmUpdateDateOff open = new frmUpdateDateOff(_staffID, _wsID);
            _handle.RedirectForm(open, this);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvWorkScheduleDetail.RowsDefaultCellStyle.Font = new Font(dgvWorkScheduleDetail.Font.FontFamily, fontSize);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchWorkScheduleDetail(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private async void dgvWorkScheduleDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
                return;
            if (dgvWorkScheduleDetail.ReadOnly)
                return;
            if (e.ColumnIndex == 6)
            {
                string staffID = dgvWorkScheduleDetail.Rows[row].Cells[1].Value.ToString();
                string name = dgvWorkScheduleDetail.Rows[row].Cells[2].Value.ToString();
                bool check = (bool)dgvWorkScheduleDetail.Rows[row].Cells[6].Value;
                CustomMessage.YesNoCustom("Xác nhận", "Huỷ");
                DialogResult result = MessageBox.Show($"Cập nhật phép cho {name} ngày {dtpWorkDate.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    WorkScheduleDetail update = new WorkScheduleDetail()
                    {
                        WsId = _wsID,
                        StaffId = staffID,
                        DateOff = !check
                    };
                    await _workScheduleDetailBUS.UpdateWorkScheduleDetail(update);
                }
            }
            Reload();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWorkScheduleDetail open = new frmWorkScheduleDetail(_staffID, _wsID);
            _handle.RedirectForm(open, this);
        }
    }
}
