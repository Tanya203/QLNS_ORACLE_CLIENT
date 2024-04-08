using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using CLINET.PresentationTier;
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
    public partial class frmMain : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private readonly ShiftBUS _shiftBUS;
        private readonly TimeKeepingBUS _timeKeepingBUS;
        private readonly string _staffID;
        public frmMain(string staffID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _shiftBUS = new ShiftBUS();
            _timeKeepingBUS = new TimeKeepingBUS();
            _staffID = staffID;
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkScheduleDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderMainMenu(lblValueStaffID, lblValueFullName, lblValueDepartment, lblValuePosition, lblValueAbsence,staff);
            ImageHandle.LoadImage(pbStaffPicture, staff.Picture);
            LoadSortShift();
        }
        private void LoadSortShift()
        {
            cmbSortShift.Invoke((MethodInvoker)(async () =>
            {
                cmbSortShift.DisplayMember = "ShiftName";
                cmbSortShift.ValueMember = "ShiftId";
                List<Shift> list = new List<Shift>()
                {
                    new Shift()
                    {
                        ShiftId = "",
                        ShiftName = "Toàn bộ"
                    }
                };
                list.AddRange(await _shiftBUS.GetAllShift());
                list.OrderBy(s => s.ShiftId);
                cmbSortShift.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbSortShift);
            }));
        }
        private void LoadWorkScheduleDetail()
        {
            cmbSortShift.Invoke((MethodInvoker)(async () =>
            {
                Enabled = false;
                dgvWorkScheduleDetail.Rows.Clear();
                List<StaffTimeKeeingViewModel> list = await _timeKeepingBUS.GetStaffTimeKeepingByDate(dtpWorkSchedule.Value.Date);
                if (!string.IsNullOrEmpty(cmbSortShift.SelectedValue?.ToString()))
                {
                    string selectedShift = cmbSortShift.Text;
                    list = list.Where(s => s.ShiftName == selectedShift).ToList();
                }
                foreach (StaffTimeKeeingViewModel staff in list.OrderBy(s => s.StaffId))
                {
                    int rowAdd = dgvWorkScheduleDetail.Rows.Add();
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[0].Value = staff.WsId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[1].Value = staff.StaffId;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[2].Value = staff.FullName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[3].Value = staff.DepartmentName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[4].Value = staff.PositionName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[5].Value = staff.ShiftName;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[6].Value = staff.CheckIn;
                    dgvWorkScheduleDetail.Rows[rowAdd].Cells[7].Value = staff.CheckOut;
                }
                Enabled = true;
            }));
        }
        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvWorkScheduleDetail.RowsDefaultCellStyle.Font = new Font(dgvWorkScheduleDetail.Font.FontFamily, fontSize);
        }

        private void cmbSortShift_TextChanged(object sender, EventArgs e)
        {
            cmbSortShift.Invoke((MethodInvoker)(() =>
            {
                LoadWorkScheduleDetail();
            }));
        }

        private void dtpWorkSchedule_ValueChanged(object sender, EventArgs e)
        {
            dtpWorkSchedule.Invoke((MethodInvoker)(() =>
            {
                LoadWorkScheduleDetail();
            }));
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            frmStaff open = new frmStaff(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment open = new frmDepartment(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPositon open = new frmPositon(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            frmShift open = new frmShift(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {
            frmWorkSchedule open = new frmWorkSchedule(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnBenefit_Click(object sender, EventArgs e)
        {
            frmBenefit open = new frmBenefit(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            frmStatistic open = new frmStatistic(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnContractType_Click(object sender, EventArgs e)
        {
            frmContractType open = new frmContractType(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
