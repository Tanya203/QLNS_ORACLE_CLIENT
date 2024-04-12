using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.Models;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CLIENT.DataTier.Models;
using System.Drawing;

namespace CLIENT.PresentationTier
{
    public partial class frmBenefit : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly string _staffID;
        private readonly FormHandle _handle;
        private readonly BenefitBUS _benefitBUS;
        private readonly StaffBUS _staffBUS;
        private List<CountBenefitViewModel> _listBenefit;
        public frmBenefit(string staffID)
        {
            InitializeComponent();
            _benefitBUS = new BenefitBUS();
            _staffBUS = new StaffBUS();
            _listBenefit = new List<CountBenefitViewModel>();
            _handle = new FormHandle();
            this._staffID = staffID;
        }

        private async void frmBenefit_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listBenefit = await _benefitBUS.GetCountBenefit();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvBenefit.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadStaffBenefit();
            DetailButton();
            Enabled = true;
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadStaffBenefit()
        {
            dgvBenefit.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvBenefit.Rows.Clear();
                int rowAdd;
                foreach (CountBenefitViewModel b in _listBenefit.OrderBy(s => s.BnId))
                {
                    rowAdd = dgvBenefit.Rows.Add();
                    dgvBenefit.Rows[rowAdd].Cells[0].Value = b.BnId;
                    dgvBenefit.Rows[rowAdd].Cells[1].Value = b.BenefitName;
                    dgvBenefit.Rows[rowAdd].Cells[2].Value = String.Format(_fVND, "{0:N3} ₫", b.Amount);
                    dgvBenefit.Rows[rowAdd].Cells[3].Value = b.StaffQuantity;
                    dgvBenefit.Rows[rowAdd].Cells[4].Value = String.Format(_fVND, "{0:N3} ₫", b.Totalamount);
                }
                Enabled = true;
            }));                
        }
        private async void LoadBenefitSearch(string search)
        {
            Enabled = false;
            dgvBenefit.Rows.Clear();
            int rowAdd;
            List<CountBenefitViewModel> list = await _benefitBUS.SearchCountBenefit(search);
            foreach (CountBenefitViewModel b in list.OrderBy(s => s.BnId))
            {
                rowAdd = dgvBenefit.Rows.Add();
                dgvBenefit.Rows[rowAdd].Cells[0].Value = b.BnId;
                dgvBenefit.Rows[rowAdd].Cells[1].Value = b.BenefitName;
                dgvBenefit.Rows[rowAdd].Cells[2].Value = String.Format(_fVND, "{0:N3} ₫", b.Amount);
                dgvBenefit.Rows[rowAdd].Cells[3].Value = b.StaffQuantity;
                dgvBenefit.Rows[rowAdd].Cells[4].Value = String.Format(_fVND, "{0:N3} ₫", b.Totalamount);
            }
            Enabled = true;
        }
        public void DetailButton()
        {
            dgvBenefit.Invoke((MethodInvoker)(() =>
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                {
                    btnXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    btnXoa.Text = "Chi tiết";
                    btnXoa.UseColumnTextForButtonValue = true;
                    btnXoa.FlatStyle = FlatStyle.Popup;
                    var buttonCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = SystemColors.ScrollBar,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    btnXoa.DefaultCellStyle = buttonCellStyle;
                    dgvBenefit.Columns.Add(btnXoa);
                }
            }));                
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<TextBox> listTextBox = new List<TextBox> { txtBN_ID, txtBenefitName, txtAmount, txtStaffAmount };
            for (int i = 0; i < listTextBox.Count; i++)
            {
                typeof(TextBox).GetProperty("Text").SetValue(listTextBox[i], string.Empty);
            }
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> { txtBenefitName, txtAmount };
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
        private void Reload()
        {
            frmBenefit open = new frmBenefit(_staffID);
            _handle.RedirectForm(open, this);
        }
        private void CheckEmptyText(object sender, EventArgs e)
        {
            errProvider.Clear();
            bool check;
            if (string.IsNullOrEmpty(txtBN_ID.Text))
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
        private bool CheckErrorInput()
        {
            errProvider.Clear();
            errProvider.SetError(txtBN_ID, _listBenefit.FirstOrDefault(b => b.BenefitName == txtBenefitName.Text && b.BnId != txtBN_ID.Text) != null ? "Tên phụ cấp đã tồn tại" : string.Empty);
            errProvider.SetError(txtAmount, double.TryParse(txtAmount.Text, out _) is false || string.IsNullOrEmpty(txtAmount.Text) ? "Định dạng tiền không hợp lệ" : string.Empty);
            if (errProvider.GetError(txtAmount) != string.Empty || errProvider.GetError(txtBenefitName) != string.Empty)
                return false;
            return true;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckErrorInput())
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Benefit benefit = new Benefit()
                {
                    BnId = "",
                    BenefitName = txtBenefitName.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                };
                await _benefitBUS.CreateBenefit(benefit);
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
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Benefit benefit = new Benefit()
                {
                    BnId = txtBN_ID.Text,
                    BenefitName = txtBenefitName.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                };
                await _benefitBUS.UpdateBenefit(benefit);
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
                DialogResult result = MessageBox.Show($"Xác nhận xoá phúc lợi {txtBenefitName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _benefitBUS.DeleteBenefit(txtBN_ID.Text);
                    Reload();
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                LoadBenefitSearch(txtSearch.Text);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyRealNumber(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgvBenefit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            CountBenefitViewModel benefit = _listBenefit.FirstOrDefault(b => b.BnId == dgvBenefit.Rows[rowIndex].Cells[0].Value.ToString());
            txtBN_ID.Text = benefit.BnId;
            txtBenefitName.Text = benefit.BenefitName;
            txtAmount.Text = benefit.Amount.ToString("F3");
            txtStaffAmount.Text = benefit.StaffQuantity.ToString();
            if (e.ColumnIndex == 5)
                StaffBenefitDetailOpen(_staffID, dgvBenefit.Rows[rowIndex].Cells[0].Value.ToString());
        }
        public void StaffBenefitDetailOpen(string staffID, string bnID)
        {
            frmBenefitDetail open = new frmBenefitDetail(staffID, bnID);
            _handle.RedirectForm(open, this);
        }
        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvBenefit.RowsDefaultCellStyle.Font = new Font(dgvBenefit.Font.FontFamily, fontSize);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain open = new frmMain(_staffID);
            _handle.RedirectForm(open, this);
        }
    }
}
