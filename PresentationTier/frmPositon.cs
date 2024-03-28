using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmPositon : Form
    {
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private List<StaffInfoViewModel> _listStaffInfo;
        private List<PositionDetailViewModel> _listPosition;
        private readonly string _staffID;
        public frmPositon()
        {
            InitializeComponent();
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _listStaffInfo = new List<StaffInfoViewModel>();
            _listPosition = new List<PositionDetailViewModel>();
            _staffID = "S_0000000002";
        }

        private async void frmPositon_Load(object sender, EventArgs e)
        {
            Enabled = false;            
            _listStaffInfo = await _staffBUS.GetAllStaffInfo();
            _listPosition = await _positionBUS.GetPositionDetail();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            nudFontSize.Invoke((MethodInvoker)(() =>
            {
                nudFontSize.Value = (decimal)dgvPosition.RowsDefaultCellStyle.Font.Size;
            }));
            LoadHeaderInfo();
            LoadDepartment();
            LoadPositionDetail();     
            Enabled = true;
        }
        private void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = _listStaffInfo.FirstOrDefault(s => s.StaffId == _staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadDepartment()
        {
            cmbDepartment.Invoke((MethodInvoker)( async () =>
            {
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DpId";
                List<Department> list = await _departmentBUS.GetAllDepartment();
                list.OrderBy(s => s.DpId);
                cmbDepartment.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbDepartment);
            }));                
        }
        public void LoadPositionDetail()
        {
            dgvPosition.Invoke((MethodInvoker)(async () =>
            {
                Enabled = false;
                dgvPosition.Rows.Clear();
                int rowAdd;
                foreach (PositionDetailViewModel p in _listPosition.OrderBy(s => s.PsId))
                {
                    rowAdd = dgvPosition.Rows.Add();
                    dgvPosition.Rows[rowAdd].Cells[0].Value = p.PsId;
                    dgvPosition.Rows[rowAdd].Cells[1].Value = p.DepartmentName;
                    dgvPosition.Rows[rowAdd].Cells[2].Value = p.PositionName;
                    dgvPosition.Rows[rowAdd].Cells[3].Value = p.Count;
                }
                Enabled = true;
            }));
        }
        public async void SearchPositionDetail(string search)
        {
            Enabled = false;
            dgvPosition.Rows.Clear();
            List<PositionDetailViewModel> list = await _positionBUS.SearchPositionDetail(search);
            int rowAdd;
            foreach (PositionDetailViewModel p in list.OrderBy(s => s.PsId))
            {
                rowAdd = dgvPosition.Rows.Add();
                dgvPosition.Rows[rowAdd].Cells[0].Value = p.PsId;
                dgvPosition.Rows[rowAdd].Cells[1].Value = p.DepartmentName;
                dgvPosition.Rows[rowAdd].Cells[2].Value = p.PositionName;
                dgvPosition.Rows[rowAdd].Cells[3].Value = p.Count;
            }
            Enabled = true;
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<object> listInput = new List<object> { txtPositionID, cmbDepartment, txtPositionName, txtTotalStaff };
            for (int i = 0; i < listInput.Count; i++)
            {
                if (listInput[i] is TextBox)
                {
                    typeof(TextBox).GetProperty("Text").SetValue(listInput[i], string.Empty);
                    continue;
                }
                else if (listInput[i] is ComboBox)
                {
                    typeof(ComboBox).GetProperty("SelectedIndex").SetValue(listInput[i], 0);
                    continue;
                }
            }
        }
        private void Reload()
        {
            frmPositon open = new frmPositon();
            _handle.RedirectForm(open, this);
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtPositionName };
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
        private bool CheckInputError()
        {
            errProvider.Clear();
            errProvider.SetError(txtPositionName, _listPosition.FirstOrDefault(ps => ps.PositionName == txtPositionName.Text && ps.PsId != txtPositionID.Text) != null ? "Tên chức vụ đã tồn tại" : string.Empty);
            if (errProvider.GetError(txtPositionName) != string.Empty)
                return false;
            return true;
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchPositionDetail(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputError())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Position position = new Position()
                {
                    PsId = "",
                    DpId = cmbDepartment.SelectedValue.ToString(),
                    PositionName = txtPositionName.Text,
                };
                await _positionBUS.CreatePosition(position);
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
                if (!CheckInputError())
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Position position = new Position()
                {
                    PsId = txtPositionID.Text,
                    DpId = cmbDepartment.SelectedValue.ToString(),
                    PositionName = txtPositionName.Text,
                };
                await _positionBUS.UpdatePosition(position);
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
                DialogResult result = MessageBox.Show($"Xác nhận xoá chức vụ {txtPositionName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _positionBUS.DeletePosition(txtPositionID.Text);
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
            dgvPosition.RowsDefaultCellStyle.Font = new Font(dgvPosition.Font.FontFamily, fontSize);
        }

        private void EnableButtons(object sender, EventArgs e)
        {
            bool check;
            if (string.IsNullOrEmpty(txtPositionID.Text))
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

        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            PositionDetailViewModel position = _listPosition.FirstOrDefault(p => p.PsId == dgvPosition.Rows[rowIndex].Cells[0].Value.ToString());
            txtPositionID.Text = position.PsId;
            cmbDepartment.Text = position.DepartmentName;
            txtPositionName.Text = position.PositionName;
            txtTotalStaff.Text = position.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }
    }
}
