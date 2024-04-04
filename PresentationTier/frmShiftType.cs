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
    public partial class frmShiftType : Form
    {
        private readonly ShiftTypeBUS _shiftTypeBUS;
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private List<ShiftType> _listShiftType;
        private readonly string _staffID;
        public frmShiftType()
        {
            InitializeComponent();
            _shiftTypeBUS = new ShiftTypeBUS();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _listShiftType = new List<ShiftType>();
            _staffID = "S_0000000002";
        }

        private async void frmShiftType_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listShiftType = await _shiftTypeBUS.GetAllShiftType();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvShiftType.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadShiftType();
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffHeaderInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadShiftType()
        {
            dgvShiftType.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvShiftType.Rows.Clear();
                int rowAdd;
                foreach (ShiftType s in _listShiftType.OrderBy(sh => sh.StId))
                {
                    rowAdd = dgvShiftType.Rows.Add();
                    dgvShiftType.Rows[rowAdd].Cells[0].Value = s.StId;
                    dgvShiftType.Rows[rowAdd].Cells[1].Value = s.ShiftTypeName;
                    dgvShiftType.Rows[rowAdd].Cells[2].Value = s.SalaryCoefficient;
                }
                Enabled = true;
            }));
                
        }
        private async void SearchShiftType(string search)
        {
            Enabled = false;
            dgvShiftType.Rows.Clear();
            List<ShiftType> list = await _shiftTypeBUS.SearchShiftType(search);
            int rowAdd;
            foreach (ShiftType s in list.OrderBy(sh => sh.StId))
            {
                rowAdd = dgvShiftType.Rows.Add();
                dgvShiftType.Rows[rowAdd].Cells[0].Value = s.StId;
                dgvShiftType.Rows[rowAdd].Cells[1].Value = s.ShiftTypeName;
                dgvShiftType.Rows[rowAdd].Cells[2].Value = s.SalaryCoefficient;
            }
            Enabled = true;
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<TextBox> listTextBox = new List<TextBox> { txtShiftTypeID, txtShiftTypeName, txtSalaryCoefficient };
            for (int i = 0; i < listTextBox.Count; i++)
            {
                typeof(TextBox).GetProperty("Text").SetValue(listTextBox[i], string.Empty);
            }
        }
        private void Reload()
        {
            frmShiftType open = new frmShiftType();
            _handle.RedirectForm(open, this);
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtShiftTypeName, txtSalaryCoefficient };
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
            errProvider.SetError(txtShiftTypeName, _listShiftType.FirstOrDefault(st => st.ShiftTypeName == txtShiftTypeName.Text && st.StId != txtShiftTypeID.Text) != null ? "Tên loại ca đã tồn tại" : string.Empty);
            errProvider.SetError(txtSalaryCoefficient, double.TryParse(txtSalaryCoefficient.Text, out double check) is false ? "Hệ số lương không đúng định dạng số" : string.Empty);
            if (string.IsNullOrEmpty(errProvider.GetError(txtSalaryCoefficient)))
                errProvider.SetError(txtSalaryCoefficient, double.Parse(txtSalaryCoefficient.Text) < 1 ? "Hệ số lương phải lớn hoặc bằng 1" : string.Empty);
            if (errProvider.GetError(txtShiftTypeName) != string.Empty || errProvider.GetError(txtSalaryCoefficient) != string.Empty)
                return false;
            return true;
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchShiftType(txtSearch.Text);
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
                ShiftType shiftType = new ShiftType()
                {
                    StId = "",
                    ShiftTypeName = txtShiftTypeName.Text,
                    SalaryCoefficient = decimal.Parse(txtSalaryCoefficient.Text)
                };
                await _shiftTypeBUS.CreateShiftType(shiftType);
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
                ShiftType shiftType = new ShiftType()
                {
                    StId = txtShiftTypeID.Text,
                    ShiftTypeName = txtShiftTypeName.Text,
                    SalaryCoefficient = decimal.Parse(txtSalaryCoefficient.Text)
                };
                await _shiftTypeBUS.UpdateShiftType(shiftType);
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
                DialogResult result = MessageBox.Show($"Xác nhận xoá loại ca {txtShiftTypeName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _shiftTypeBUS.DeleteShiftType(txtShiftTypeID.Text);
                    Reload();
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void txtSalaryCoefficient_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyRealNumber(sender, e);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvShiftType.RowsDefaultCellStyle.Font = new Font(dgvShiftType.Font.FontFamily, fontSize);
        }

        private void EnableButtons(object sender, EventArgs e)
        {
            bool check;
            if (string.IsNullOrEmpty(txtShiftTypeID.Text))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void dgvShiftType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            ShiftType shiftType = _listShiftType.FirstOrDefault(s => s.StId == dgvShiftType.Rows[rowIndex].Cells[0].Value.ToString());
            txtShiftTypeID.Text = shiftType.StId;
            txtShiftTypeName.Text = shiftType.ShiftTypeName;
            txtSalaryCoefficient.Text = shiftType.SalaryCoefficient.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
