using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmWorkScheduleDetail : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private readonly TimeKeepingBUS _timeKeepingBUS;
        private readonly ShiftTypeBUS _shiftTypeBUS;
        private readonly ShiftBUS _shiftBUS;
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private List<StaffInfoViewModel> _listStaffInfo;
        private List<TimeKeeping> _updateList;
        private List<TimeKeeping> _deleteList;
        private readonly string _staffID;
        private readonly string _wsID;
        private readonly string formatHour = "HH:mm:ss";
        private bool check;
        public frmWorkScheduleDetail()
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _timeKeepingBUS = new TimeKeepingBUS();
            _shiftTypeBUS = new ShiftTypeBUS();
            _shiftBUS = new ShiftBUS();
            _departmentBUS = new DepartmentBUS();
            _positionBUS = new PositionBUS();
            _handle = new FormHandle();
            _listStaffInfo = new List<StaffInfoViewModel>();
            _updateList = new List<TimeKeeping>();
            _deleteList = new List<TimeKeeping>();
            check = false;
            _staffID = "S_0000000002";
            _wsID = "WS_0000000203";
        }

        private async void frmWorkScheduleDetail_Load(object sender, EventArgs e)
        {
            _listStaffInfo = await _staffBUS.GetAllStaffInfo();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkScheduleDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadSortShift();
            LoadDepartment();
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffHeaderInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
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
        private void LoadDepartment()
        {
            cmbDepartment.Invoke((MethodInvoker)(async () =>
            {
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DpId";
                List<Department> list = await _departmentBUS.GetAllDepartment();
                list.OrderBy(s => s.DpId);
                cmbDepartment.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbDepartment);
            }));
        }
        private void LoadPositonByDepartment(string dpID)
        {
            cmbPosition.Invoke((MethodInvoker)(async () =>
            {
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "PsId";
                List<Position> list = await _positionBUS.GetAllPosition();
                list = list.Where(p => p.DpId == dpID).OrderBy(s => s.PsId).ToList();
                cmbPosition.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbPosition);
            }));
        }
        private void LoadStaffByPosition(string positionName)
        {
            cmbStaffID.Invoke((MethodInvoker)(async () =>
            {
                cmbStaffID.DisplayMember = "FullName";
                cmbStaffID.ValueMember = "StaffId";
                List<StaffInfoViewModel> list = await _staffBUS.GetAllStaffInfo();
                List<Shift> shifts = await _shiftBUS.GetAllShift();
                int max = shifts.Count();
                list = list.Where(s => s.PositionName == positionName).OrderBy(s => s.StaffId).ToList();
                foreach (TimeKeeping b in _updateList)
                {
                    if (list.Count(s => s.StaffId == b.StaffId) != max)
                        continue;
                    list.RemoveAll(s => s.StaffId == b.StaffId);
                }
                list.OrderBy(s => s.StaffId);
                cmbStaffID.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbStaffID);
                //LoadShiftByStaffShiftType(cmbStaffID.SelectedValue.ToString());
            }));
        }
        private void LoadShiftByStaff(string staffID)
        {
            cmbShift.Invoke((MethodInvoker)(async () =>
            {
                cmbShift.DisplayMember = "ShiftName";
                cmbShift.ValueMember = "ShiftId";
                List<Shift> listShift = await _shiftBUS.GetAllShift();
                List<TimeKeeping> staffTimeKeeping = await _timeKeepingBUS.GetAllTimeKeeping();
                staffTimeKeeping.RemoveAll(s => s.WsId != _wsID && s.StaffId != staffID);
                if (staffTimeKeeping.Count() == 0)
                    cmbShift.DataSource = listShift;
                else
                    foreach (TimeKeeping shift in staffTimeKeeping)
                        listShift.RemoveAll(s => s.ShiftId == shift.ShiftId);
                if(dtpWorkDate.Value.Date == DateTime.Now.Date)
                {
                    TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString(formatHour));
                    listShift.RemoveAll(s => s.EndTime < now);
                }
                cmbShift.DataSource = listShift;
                AutoAdjustComboBox.Adjust(cmbShift);
            }));
        }
        private void UpdateList(string wsID,string staffID, string shiftID)
        {
            TimeKeeping add = new TimeKeeping()
            {
                WsId = wsID,
                StaffId = staffID,
                ShiftId = shiftID
            };
            _updateList.Add(add);
        }
        private void LoadWorkScheduleDetail()
        {
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(async () =>
            {
                Enabled = false;
                dgvWorkScheduleDetail.Rows.Clear();
                int rowAdd;
                List<StaffWorkScheduleDetailViewModel> list = await _timeKeepingBUS.GetStaffTimeKeepingById(_wsID);
                foreach (StaffWorkScheduleDetailViewModel staff in list)
                    UpdateList(staff.WsId, staff.StaffId, staff.ShiftId);
                if (!string.IsNullOrEmpty(cmbSortShift.SelectedValue.ToString()))
                    list = list.Where(s => s.ShiftName == cmbSortShift.Text).ToList();
                foreach (StaffWorkScheduleDetailViewModel staff in list.OrderBy(s => s.StaffId))
                {
                    rowAdd = dgvWorkScheduleDetail.Rows.Add();
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
        private async void SearchWorkScheduleDetail(string search)
        {
            Enabled = false;
            dgvWorkScheduleDetail.Rows.Clear();
            int rowAdd;
            List<StaffWorkScheduleDetailViewModel> list = await _timeKeepingBUS.SearchStaffTimeKeepinById(_wsID, search); ;
            if (!string.IsNullOrEmpty(cmbSortShift.SelectedValue.ToString()))
                list = list.Where(s => s.ShiftName == cmbSortShift.Text).ToList();
            foreach (StaffWorkScheduleDetailViewModel staff in list.OrderBy(s => s.StaffId))
            {
                rowAdd = dgvWorkScheduleDetail.Rows.Add();
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
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void cmbSortShift_TextChanged(object sender, EventArgs e)
        {
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(async () =>
            {
                LoadWorkScheduleDetail();
            }));
        }
        private void Reload()
        {
            frmWorkScheduleDetail open = new frmWorkScheduleDetail();
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

        private void cmbDepartment_TextChanged(object sender, EventArgs e)
        {
            LoadPositonByDepartment(cmbDepartment.SelectedValue.ToString());
        }

        private void cmbPosition_TextChanged(object sender, EventArgs e)
        {
            LoadStaffByPosition(cmbPosition.Text);
        }

        private void cmbStaffID_TextChanged(object sender, EventArgs e)
        {
            LoadShiftByStaff(cmbStaffID.SelectedValue.ToString());
        }

        
    }
}
