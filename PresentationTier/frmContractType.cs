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

namespace CLINET.PresentationTier
{
    public partial class frmContractType : Form
    {
        private readonly ContractTypeBUS _contractTypeBUS;
        private readonly TimeKeepingMethodBUS _timeKeepingMethodBUS;
        private readonly StaffBUS _staffBUS;
        private readonly string _staffID;
        private readonly FormHandle _handle;
        private List<ContractTypeDetailViewModel> _listContractType;
        public frmContractType()
        {
            InitializeComponent();
            _contractTypeBUS = new ContractTypeBUS();
            _timeKeepingMethodBUS = new TimeKeepingMethodBUS();
            _staffBUS = new StaffBUS();
            _handle = new FormHandle();
            _listContractType = new List<ContractTypeDetailViewModel>();            
            _staffID = "S_0000000002";
        }

        private async void frmContractType_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listContractType = await _contractTypeBUS.GetContractTypeDetail();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvContractType.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadTimeKeepingMethod();
            LoadContractTypeDetail();
            Enabled = true;
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadTimeKeepingMethod()
        {
            cmbTimekeepingMethod.Invoke((MethodInvoker)(async () =>
            {
                cmbTimekeepingMethod.DisplayMember = "TimeKeepingMethodName";
                cmbTimekeepingMethod.ValueMember = "TkmID";
                List<TimeKeepingMethod> list = await _timeKeepingMethodBUS.GetAllTimeKeepingMethod();
                list.OrderBy(s => s.TkmId);
                cmbTimekeepingMethod.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbTimekeepingMethod);
            }));                
        }
        private void LoadContractTypeDetail()
        {
            dgvContractType.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvContractType.Rows.Clear();
                int rowAdd;
                foreach (ContractTypeDetailViewModel d in _listContractType.OrderBy(s => s.CtId))
                {
                    rowAdd = dgvContractType.Rows.Add();
                    dgvContractType.Rows[rowAdd].Cells[0].Value = d.CtId;
                    dgvContractType.Rows[rowAdd].Cells[1].Value = d.ContractTypeName;
                    dgvContractType.Rows[rowAdd].Cells[2].Value = d.TimeKeepingMethodName;
                    dgvContractType.Rows[rowAdd].Cells[3].Value = d.Count;
                }
                Enabled = true;
            }));
                
        }
        private async void SearchContractTypeDetail(string search)
        {
            Enabled = false;
            dgvContractType.Rows.Clear();
            int rowAdd;
            List<ContractTypeDetailViewModel> list = await _contractTypeBUS.SearchContractTypeDetail(search);
            foreach (ContractTypeDetailViewModel d in list.OrderBy(s => s.CtId))
            {
                rowAdd = dgvContractType.Rows.Add();
                dgvContractType.Rows[rowAdd].Cells[0].Value = d.CtId;
                dgvContractType.Rows[rowAdd].Cells[1].Value = d.ContractTypeName;
                dgvContractType.Rows[rowAdd].Cells[2].Value = d.TimeKeepingMethodName;
                dgvContractType.Rows[rowAdd].Cells[3].Value = d.Count;
            }
            Enabled = true;
        }
        private void Reload()
        {
            frmContractType open = new frmContractType();
            _handle.RedirectForm(open, this);
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<object> listInput = new List<object> { txtContractTypeID, txtContractTypeName, txtStaffAmount, cmbTimekeepingMethod };
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
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtContractTypeName };
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchContractTypeDetail(txtSearch.Text);
        }
        private bool CheckErrorInput()
        {
            errProvider.Clear();
            errProvider.SetError(txtContractTypeName, _listContractType.FirstOrDefault(ct => ct.ContractTypeName == txtContractTypeName.Text) != null ? "Tên loại hợp đồng đã tồn tại" : string.Empty);
            if (errProvider.GetError(txtContractTypeName) != string.Empty)
                return false;
            return true;
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
                ContractType contractType = new ContractType()
                {
                    CtId = "",
                    TkmId = cmbTimekeepingMethod.SelectedValue.ToString(),
                    ContractTypeName = txtContractTypeName.Text,
                };
                await _contractTypeBUS.CreateContractType(contractType);
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
                ContractType contractType = new ContractType()
                {
                    CtId = txtContractTypeID.Text,
                    TkmId = cmbTimekeepingMethod.SelectedValue.ToString(),
                    ContractTypeName = txtContractTypeName.Text,
                };
                await _contractTypeBUS.UpdateContractType(contractType);
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
                DialogResult result = MessageBox.Show($"Xác nhận xoá loại hợp đồng {txtContractTypeName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _contractTypeBUS.DeleteContractType(txtContractTypeID.Text);
                    Reload();
                }                    
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void txtContractTypeID_TextChanged(object sender, EventArgs e)
        {

        }
        private void EnableButtons(object sender, EventArgs e)
        {
            bool check;
            if (string.IsNullOrEmpty(txtContractTypeID.Text))
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

        private void dgvContractType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            ContractTypeDetailViewModel contract = _listContractType.FirstOrDefault(c => c.CtId == dgvContractType.Rows[rowIndex].Cells[0].Value.ToString());
            txtContractTypeID.Text = contract.CtId;
            cmbTimekeepingMethod.Text = contract.TimeKeepingMethodName;
            txtContractTypeName.Text = contract.ContractTypeName;
            txtStaffAmount.Text = contract.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvContractType.RowsDefaultCellStyle.Font = new Font(dgvContractType.Font.FontFamily, fontSize);
        }
    }
}
