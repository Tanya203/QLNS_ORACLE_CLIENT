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
        private readonly WorkScheduleDetailBUS _workScheduleDetailBUS;
        private readonly ShiftBUS _shiftBUS;
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private List<StaffTimeKeeingViewModel> _listWorkScheduleDetail;
        private List<TimeKeeping> _updateList;
        private List<TimeKeeping> _deleteList;
        private List<Shift> _listShift;
        private readonly string _staffID;
        private readonly string _wsID;
        private readonly string formatHour = "HH:mm:ss";
        public frmWorkScheduleDetail(string staffID, string wsID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _workScheduleBUS = new WorkScheduleBUS();
            _workScheduleDetailBUS = new WorkScheduleDetailBUS();
            _timeKeepingBUS = new TimeKeepingBUS();
            _shiftBUS = new ShiftBUS();
            _departmentBUS = new DepartmentBUS();
            _positionBUS = new PositionBUS();
            _handle = new FormHandle();
            _listWorkScheduleDetail = new List<StaffTimeKeeingViewModel>();
            _updateList = new List<TimeKeeping>();
            _deleteList = new List<TimeKeeping>();
            _listShift = new List<Shift> ();
            _staffID = staffID;
            _wsID = wsID;
        }

        private async void frmWorkScheduleDetail_Load(object sender, EventArgs e)
        {
            _listWorkScheduleDetail = await _timeKeepingBUS.GetStaffTimeKeepingById(_wsID);
            _listShift = await _shiftBUS.GetAllShift();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkScheduleDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadWorkScheduleInfo();
            LoadSortShift();
            LoadUpdateList();
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadWorkScheduleInfo()
        {
            pnlFunction.Invoke((MethodInvoker)( async () =>
            {
                WorkSchedule info = await _workScheduleBUS.GetWorkScheduleInfo(_wsID);
                txtWorkScheduleID.Invoke((MethodInvoker)(() => txtWorkScheduleID.Text = info.WsId));
                dtpWorkDate.Invoke((MethodInvoker)(() => dtpWorkDate.Value = info.WorkDate));
                if (dtpWorkDate.Value.Date < DateTime.Now.Date)
                {
                    lblAddStaff.Visible = false;
                    pnlFunction.Visible = false;
                    lblWorkScheduleInfo.Location = new Point(650, 110);
                    pnlInfo.Location = new Point(610, 140);
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
        private void LoadUpdateList()
        {
            foreach (StaffTimeKeeingViewModel staff in _listWorkScheduleDetail)
                UpdateList(staff.WsId, staff.StaffId, staff.ShiftId);
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
                List<Shift> shifts =  await _shiftBUS.GetAllShift();
                int max = shifts.Count();
                list = list.Where(s => s.PositionName == positionName).OrderBy(s => s.StaffId).ToList();
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
                if (_updateList.Count(s => s.StaffId == staffID) > 0)
                {
                    foreach (TimeKeeping shift in _updateList.Where(s => s.StaffId == staffID))
                        listShift.RemoveAll(s => s.ShiftId == shift.ShiftId);
                }
                if (dtpWorkDate.Value.Date == DateTime.Now.Date)
                {
                    TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString(formatHour));
                    listShift.RemoveAll(s => s.EndTime < now);
                }
                cmbShift.DataSource = listShift;
                AutoAdjustComboBox.Adjust(cmbShift);
                if (string.IsNullOrEmpty(cmbShift.Text))
                {
                    btnAdd.Enabled = false;
                    cmbShift.Enabled = false;
                }
                else
                {
                    btnAdd.Enabled = true;
                    cmbShift.Enabled = true;
                }
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
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvWorkScheduleDetail.Rows.Clear();
                int rowAdd;
                List<StaffTimeKeeingViewModel> list = _listWorkScheduleDetail;
                if (!string.IsNullOrEmpty(cmbSortShift.SelectedValue.ToString()))
                    list = list.Where(s => s.ShiftName == cmbSortShift.Text).ToList();
                foreach (StaffTimeKeeingViewModel staff in list.OrderBy(s => s.StaffId))
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
            List<StaffTimeKeeingViewModel> list = await _timeKeepingBUS.SearchStaffTimeKeepinById(_wsID, search); ;
            if (!string.IsNullOrEmpty(cmbSortShift.SelectedValue.ToString()))
                list = list.Where(s => s.ShiftName == cmbSortShift.Text).ToList();
            foreach (StaffTimeKeeingViewModel staff in list.OrderBy(s => s.StaffId))
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
            dgvWorkScheduleDetail.Invoke((MethodInvoker)(() =>
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
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(cmbStaffID.SelectedValue.ToString());
            if (staff.Picture != null)
                ImageHandle.LoadImage(pbStaffPicture, staff.Picture);
            LoadShiftByStaff(cmbStaffID.SelectedValue.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWorkSchedule open = new frmWorkSchedule(_staffID);
            _handle.RedirectForm(open, this);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            TimeKeeping add = new TimeKeeping()
            {
                WsId = txtWorkScheduleID.Text,
                StaffId = cmbStaffID.SelectedValue.ToString(),
                ShiftId = cmbShift.SelectedValue.ToString(),
            };
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(cmbStaffID.SelectedValue.ToString());
            int rowAdd;
            rowAdd = dgvWorkScheduleDetail.Rows.Add();
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[0].Value = txtWorkScheduleID.Text;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[1].Value = staff.StaffId;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[2].Value = staff.FullName;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[3].Value = staff.DepartmentName;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[4].Value = staff.PositionName;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[5].Value = cmbShift.Text;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[6].Value = null;
            dgvWorkScheduleDetail.Rows[rowAdd].Cells[7].Value = null;
            _updateList.Add(add);
            _deleteList.RemoveAll(s => s.StaffId == staff.StaffId);
            LoadStaffByPosition(cmbPosition.Text);
            LoadShiftByStaff(cmbStaffID.SelectedValue.ToString());
            if (_updateList.Count > 0 || _deleteList.Count > 0)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_deleteList.Count > 0)
                {
                    if (!await _timeKeepingBUS.DeleteTimeKeeping(_deleteList))
                    {
                        Reload();
                        return;
                    }
                        
                }                    
                foreach (StaffTimeKeeingViewModel staff in _listWorkScheduleDetail)
                    _updateList.RemoveAll(s => s.StaffId == staff.StaffId && s.ShiftId == staff.ShiftId);
                if (_updateList.Count > 0)
                {
                    foreach (TimeKeeping staff in _updateList)
                    {
                        if (_listWorkScheduleDetail.Count(s => s.StaffId == staff.StaffId) == 0)
                        {
                            WorkScheduleDetail add = new WorkScheduleDetail()
                            {
                                WsId = staff.WsId,
                                StaffId = staff.StaffId,
                            };
                            await _workScheduleDetailBUS.CreateWorkScheduleDetail(add);
                        }
                    }
                    if (!await _timeKeepingBUS.CreateTimeKeeping(_updateList))
                    {
                        Reload();
                        return;
                    }
                }
                MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void dgvWorkScheduleDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
                return;
            if (e.ColumnIndex == 8)
            {
                string staffID = dgvWorkScheduleDetail.Rows[row].Cells[1].Value.ToString();
                string shiftName = dgvWorkScheduleDetail.Rows[row].Cells[5].Value.ToString();
                string shiftID = _listShift.FirstOrDefault(s => s.ShiftName == shiftName).ShiftId;
                TimeKeeping staff = _updateList.FirstOrDefault(s => s.StaffId == staffID && s.ShiftId == shiftID);
                if (staff.CheckIn != null)
                {
                    MessageBox.Show("Nhân viên đã chấm công, không thể xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataGridViewRow remove = dgvWorkScheduleDetail.Rows[row];
                dgvWorkScheduleDetail.Rows.Remove(remove);
                if (_listWorkScheduleDetail.FirstOrDefault(s => s.StaffId == staff.StaffId && s.ShiftId == staff.ShiftId) != null)
                    _deleteList.Add(_updateList.FirstOrDefault(s => s.StaffId == staff.StaffId && s.ShiftId == staff.ShiftId));
                _updateList.RemoveAll(s => s.StaffId == staff.StaffId && s.ShiftId == staff.ShiftId);
                LoadStaffByPosition(cmbPosition.Text);
                if(!string.IsNullOrEmpty(cmbStaffID.Text))
                    LoadShiftByStaff(cmbStaffID.SelectedValue.ToString());
            }               
        }

        private void btnUpdateDateOff_Click(object sender, EventArgs e)
        {
            frmUpdateDateOff open = new frmUpdateDateOff(_staffID, _wsID);
            _handle.RedirectForm(open, this);
        }
    }
}
