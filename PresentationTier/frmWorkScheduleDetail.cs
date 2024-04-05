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
        private readonly WorkScheduleBUS _workScheduleBUS;
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
        public frmWorkScheduleDetail(string staffID, string wsID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _workScheduleBUS = new WorkScheduleBUS();
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
            _staffID = staffID;
            _wsID = wsID;
        }

        private async void frmWorkScheduleDetail_Load(object sender, EventArgs e)
        {
            _listStaffInfo = await _staffBUS.GetAllStaffInfo();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkScheduleDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadWorkScheduleInfo();
            LoadSortShift();            
                  
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffHeaderInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadWorkScheduleInfo()
        {
            pnlFunction.Invoke((MethodInvoker)( async () =>
            {
                WorkSchedule info = await _workScheduleBUS.GetAWorkScheduleInfo(_wsID);
                nudFontSize.Invoke((MethodInvoker)(() => txtWorkScheduleID.Text = info.WsId));
                nudFontSize.Invoke((MethodInvoker)(() => dtpWorkDate.Value = info.WorkDate));
                if (dtpWorkDate.Value.Date < DateTime.Now.Date)
                {
                    lblAddStaff.Visible = false;
                    pnlFunction.Visible = false;
                    lblWorkScheduleInfo.Location = new Point(700, 130);
                    pnlInfo.Location = new Point(660, 160);
                }
                else
                {
                    LoadDepartment();
                    DeleteButton();
                }
            }));
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
        private void DeleteButton()
        {
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(() =>
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                {
                    btnXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    btnXoa.Text = "Xoá";
                    btnXoa.UseColumnTextForButtonValue = true;
                    btnXoa.FlatStyle = FlatStyle.Popup;
                    var buttonCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = SystemColors.ScrollBar,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    btnXoa.DefaultCellStyle = buttonCellStyle;
                    dgvWorkScheduleDetail.Columns.Add(btnXoa);
                }
            }));                
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
            frmWorkScheduleDetail open = new frmWorkScheduleDetail(_staffID, _wsID);
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

        private async void cmbStaffID_TextChanged(object sender, EventArgs e)
        {
            pbStaffPicture.Image = Properties.Resources.image;
            if (string.IsNullOrEmpty(cmbStaffID.Text))
            {
                btnAdd.Enabled = false;
                cmbShift.Enabled = false;
            }
            else
            {
                StaffInfoViewModel staff = await _staffBUS.GetStaffHeaderInfo(cmbStaffID.SelectedValue.ToString());
                ImageHandle.LoadImage(pbStaffPicture, staff.Picture);
                btnAdd.Enabled = true;
                cmbShift.Enabled = false;
            }
            LoadShiftByStaff(cmbStaffID.SelectedValue.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWorkSchedule open = new frmWorkSchedule();
            _handle.RedirectForm(open, this);
        }
    }
}
