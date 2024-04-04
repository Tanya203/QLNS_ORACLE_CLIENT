using CLIENT.DataTier.Models;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CLIENT.Function;
using System.Drawing;

namespace CLIENT.PresentationTier
{
    public partial class frmDepartment : Form
    {
        private readonly DepartmentBUS _departmentBUS;
        private readonly StaffBUS _staffBUS;
        private readonly FormHandle _handle;
        private List<DepartmentDetailViewModel> _listDepartment;
        private readonly string _staffID;
        public frmDepartment()
        {
            InitializeComponent();
            _departmentBUS = new DepartmentBUS();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _listDepartment = new List<DepartmentDetailViewModel>();  
            _staffID = "S_0000000002";
        }

        private async void frmDepartment_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listDepartment = await _departmentBUS.GetDepartmentDetail();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            LoadHeaderInfo();
            LoadDepartmentDetail();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvDepartment.RowsDefaultCellStyle.Font.Size));
            Enabled = true;
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffHeaderInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadDepartmentDetail()
        {
            dgvDepartment.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvDepartment.Rows.Clear();
                int rowAdd;
                foreach (DepartmentDetailViewModel d in _listDepartment.OrderBy(s => s.DpId))
                {
                    rowAdd = dgvDepartment.Rows.Add();
                    dgvDepartment.Rows[rowAdd].Cells[0].Value = d.DpId;
                    dgvDepartment.Rows[rowAdd].Cells[1].Value = d.DepartmentName;
                    dgvDepartment.Rows[rowAdd].Cells[2].Value = d.Count;
                }
                Enabled = true;
            }));
                
        }
        private async void SearchDepartmentDetail(string search)
        {
            Enabled = false;
            dgvDepartment.Rows.Clear();
            List<DepartmentDetailViewModel> list = await _departmentBUS.SearchDepartmentDetail(search);
            int rowAdd;
            foreach (DepartmentDetailViewModel d in list.OrderBy(s => s.DpId))
            {
                rowAdd = dgvDepartment.Rows.Add();
                dgvDepartment.Rows[rowAdd].Cells[0].Value = d.DpId;
                dgvDepartment.Rows[rowAdd].Cells[1].Value = d.DepartmentName;
                dgvDepartment.Rows[rowAdd].Cells[2].Value = d.Count;
            }
            Enabled = true;
        }
        private void Reload()
        {
            frmDepartment open = new frmDepartment();
            _handle.RedirectForm(open, this);
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<TextBox> listTextBox = new List<TextBox> { txtDepartmentID, txtDepartmentName, txtStaffAmount };
            for (int i = 0; i < listTextBox.Count; i++)
            {
                typeof(TextBox).GetProperty("Text").SetValue(listTextBox[i], string.Empty);
            }
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtDepartmentName };
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
            errProvider.SetError(txtDepartmentName, _listDepartment.FirstOrDefault(dp => dp.DepartmentName == txtDepartmentName.Text && dp.DpId != txtDepartmentID.Text) != null ? "Tên phòng ban đã tồn tại" : string.Empty);
            if (errProvider.GetError(txtDepartmentName) != string.Empty)
                return false;
            return true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchDepartmentDetail(txtSearch.Text);
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
                Department department = new Department()
                {
                    DpId = "",
                    DepartmentName = txtDepartmentName.Text,
                };
                await _departmentBUS.CreateDepartment(department);
                Reload();
            }
            catch(Exception ex)
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
                Department department = new Department()
                {
                    DpId = txtDepartmentID.Text,
                    DepartmentName = txtDepartmentName.Text,
                };
                await _departmentBUS.UpdateDepartment(department);
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
                DialogResult result = MessageBox.Show($"Xác nhận xoá phòng ban {txtDepartmentName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _departmentBUS.DeleteDepartment(txtDepartmentID.Text);
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
            dgvDepartment.RowsDefaultCellStyle.Font = new Font(dgvDepartment.Font.FontFamily, fontSize);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void EnableButtons(object sender, EventArgs e)
        {
            bool check;
            if (string.IsNullOrEmpty(txtDepartmentID.Text))
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            DepartmentDetailViewModel department = _listDepartment.FirstOrDefault(d => d.DpId == dgvDepartment.Rows[rowIndex].Cells[0].Value.ToString());
            txtDepartmentID.Text = department.DpId;
            txtDepartmentName.Text = department.DepartmentName;
            txtStaffAmount.Text = department.Count.ToString();
        }
    }
}
