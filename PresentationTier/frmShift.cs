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
    public partial class frmShift : Form
    {
        private readonly ShiftBUS _shiftBUS;
        private readonly ShiftTypeBUS _shiftTypeBUS;
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private List<ShiftDetailViewModel> _listShift;
        private readonly string _staffID;
        public frmShift(string staffID)
        {
            InitializeComponent();
            _shiftBUS = new ShiftBUS();
            _shiftTypeBUS = new ShiftTypeBUS();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _listShift = new List<ShiftDetailViewModel>();
            _staffID = staffID;
        }

        private async void frmShift_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listShift = await _shiftBUS.GetShiftDetail();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvShift.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadShiftType();
            LoadShiftDetail();
            Enabled = true;
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadShiftType()
        {
            cmbShiftType.Invoke((MethodInvoker)(async () =>
            {
                cmbShiftType.DisplayMember = "ShiftTypeName";
                cmbShiftType.ValueMember = "StId";
                List<ShiftType> list = await _shiftTypeBUS.GetAllShiftType();
                list.OrderBy(s => s.StId);
                cmbShiftType.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbShiftType);
            }));                
        }
        private void LoadShiftDetail()
        {
            dgvShift.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvShift.Rows.Clear();
                int rowAdd;
                foreach (ShiftDetailViewModel s in _listShift.OrderBy(s => s.ShiftId))
                {
                    rowAdd = dgvShift.Rows.Add();
                    dgvShift.Rows[rowAdd].Cells[0].Value = s.ShiftId;
                    dgvShift.Rows[rowAdd].Cells[1].Value = s.ShiftName;
                    dgvShift.Rows[rowAdd].Cells[2].Value = s.ShiftTypeName;
                    dgvShift.Rows[rowAdd].Cells[3].Value = s.BeginTime;
                    dgvShift.Rows[rowAdd].Cells[4].Value = s.EndTime;
                }
                Enabled = true;
            }));                
        }
        private async void SearchShiftDetail(string search)
        {
            Enabled = false;
            dgvShift.Rows.Clear();
            List<ShiftDetailViewModel> list = await _shiftBUS.SearchShiftDetail(search);
            int rowAdd;
            foreach (ShiftDetailViewModel s in list.OrderBy(s => s.ShiftId))
            {
                rowAdd = dgvShift.Rows.Add();
                dgvShift.Rows[rowAdd].Cells[0].Value = s.ShiftId;
                dgvShift.Rows[rowAdd].Cells[1].Value = s.ShiftName;
                dgvShift.Rows[rowAdd].Cells[2].Value = s.ShiftTypeName;
                dgvShift.Rows[rowAdd].Cells[3].Value = s.BeginTime;
                dgvShift.Rows[rowAdd].Cells[4].Value = s.EndTime;
            }
            Enabled = true;
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<object> listInput = new List<object> { txtShiftID, txtShiftName, dtpStartTime, dtpEndTime };
            for (int i = 0; i < listInput.Count; i++)
            {
                if (listInput[i] is TextBox)
                {
                    typeof(TextBox).GetProperty("Text").SetValue(listInput[i], string.Empty);
                    continue;
                }
                else if (listInput[i] is DateTimePicker)
                {
                    typeof(DateTimePicker).GetProperty("Text").SetValue(listInput[i], "00:00");
                    continue;
                }
            }
        }
        private void Reload()
        {
            frmShift open = new frmShift(_staffID);
            _handle.RedirectForm(open, this);
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtShiftName };
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.IsNullOrEmpty(listTextBox[i].Text))
                {
                    if (check)
                    {
                        btnAdd.Enabled = false;
                        return false;
                    }
                    else
                    {
                        btnEdit.Enabled = false;
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckErrorInput()
        {
            errProvider.Clear();
            errProvider.SetError(txtShiftName,_listShift.FirstOrDefault(s => s.ShiftName == txtShiftName.Text && s.ShiftId != txtShiftID.Text) != null ? "Tên ca đã tồn tại" : string.Empty);
            if (errProvider.GetError(txtShiftName) != string.Empty)
                return false;
            return true;
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchShiftDetail(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckErrorInput())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Shift shift = new Shift()
                {
                    ShiftId = "",
                    ShiftName = txtShiftName.Text,
                    StId = cmbShiftType.SelectedValue.ToString(),
                    BeginTime = TimeSpan.Parse(dtpStartTime.Text),
                    EndTime = TimeSpan.Parse(dtpEndTime.Text)
                };
                await _shiftBUS.CreateShift(shift);
                Reload();
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckErrorInput())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Shift shift = new Shift()
                {
                    ShiftId = txtShiftID.Text,
                    ShiftName = txtShiftName.Text,
                    StId = cmbShiftType.SelectedValue.ToString(),
                    BeginTime = TimeSpan.Parse(dtpStartTime.Text),
                    EndTime = TimeSpan.Parse(dtpEndTime.Text)
                };
                await _shiftBUS.UpdateShift(shift);
                Reload();
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CustomMessage.YesNoCustom("Xác nhận", "Huỷ");
                DialogResult result = MessageBox.Show($"Xác nhận xoá ca {txtShiftName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _shiftBUS.DeleteShift(txtShiftID.Text);
                    Reload();
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvShift.RowsDefaultCellStyle.Font = new Font(dgvShift.Font.FontFamily, fontSize);
        }

        private void EnableButtons(object sender, EventArgs e)
        {
            bool check;
            if (string.IsNullOrEmpty(txtShiftID.Text))
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                check = true;
                if (CheckEmptyText(check))
                {
                    btnAdd.Enabled = true;
                    return;
                }
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                check = false;
                if (CheckEmptyText(check))
                {
                    btnEdit.Enabled = true;
                    return;
                }
            }
        }

        private void dgvShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            ShiftDetailViewModel shift = _listShift.FirstOrDefault(s => s.ShiftId == dgvShift.Rows[rowIndex].Cells[0].Value.ToString());
            txtShiftID.Text = shift.ShiftId;
            txtShiftName.Text = shift.ShiftName;
            cmbShiftType.Text = shift.ShiftTypeName;
            dtpStartTime.Text = shift.BeginTime.ToString();
            dtpEndTime.Text = shift.EndTime.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain open = new frmMain(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnShiftType_Click(object sender, EventArgs e)
        {
            frmShiftType open = new frmShiftType(_staffID);
            _handle.RedirectForm(open, this);
        }
    }
}
