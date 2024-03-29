using CLIENT.ViewModels;
using CLIENT.LogicTier;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using System.Drawing;

namespace CLIENT.PresentationTier
{
    public partial class frmStaff : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly string _date = "dd/MM/yyyy";
        private readonly string _staffID;
        private readonly FormHandle _handle;
        private readonly StaffBUS _staffBUS; 
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private readonly ContractTypeBUS _contractTypeBUS;
        private List<StaffInfoViewModel> _listStaffInfo;
        private List<Staff> _listStaff;
        public frmStaff()
        {
            InitializeComponent();
            _handle = new FormHandle();
            _staffBUS   = new StaffBUS();
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
            _contractTypeBUS = new ContractTypeBUS();
            _listStaffInfo = new List<StaffInfoViewModel>();
            _listStaff = new List<Staff>();
            nudFontSize.Value = (decimal)dgvStaff.RowsDefaultCellStyle.Font.Size;
            this._staffID = "S_0000000002";
        }

        private async void frmStaff_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listStaffInfo = await _staffBUS.GetAllStaffInfo();
            _listStaff = await _staffBUS.GetAllStaff();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            rbMale.Invoke((MethodInvoker)(() => rbMale.Checked = true));
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvStaff.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            LoadDepartment();
            LoadContractType();
            LoadStaffInfo();
            Enabled = true;
        }
        private void LoadHeaderInfo()
        {            
            StaffInfoViewModel staff =  _listStaffInfo.FirstOrDefault(s => s.StaffId == _staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
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

        private void LoadPositionByDepartment(string dpID)
        {
            cmbPosition.Invoke((MethodInvoker)( async () =>
            {
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "PsId";
                List<Position> list = await _positionBUS.GetAllPosition();
                list = list.Where(s => s.DpId == dpID).OrderBy(s => s.DpId).ToList();
                cmbPosition.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbPosition);
            }));
        }

        private void LoadContractType()
        {
            cmbContractType.Invoke((MethodInvoker)( async () =>
            {
                cmbContractType.DisplayMember = "ContractTypeName";
                cmbContractType.ValueMember = "CtId";
                List<ContractType> list = await _contractTypeBUS.GetAllContractType();
                list.OrderBy(s => s.CtId);
                cmbContractType.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbContractType);
            }));
        }
        private void LoadStaffInfo()
        {            
            dgvStaff.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;                
                dgvStaff.Rows.Clear();
                int rowAdd;
                foreach (StaffInfoViewModel s in _listStaffInfo.OrderBy(s => s.StaffId))
                {
                    rowAdd = dgvStaff.Rows.Add();
                    dgvStaff.Rows[rowAdd].Cells[0].Value = s.StaffId;
                    dgvStaff.Rows[rowAdd].Cells[1].Value = s.PositionName;
                    dgvStaff.Rows[rowAdd].Cells[2].Value = s.DepartmentName;
                    dgvStaff.Rows[rowAdd].Cells[3].Value = s.ContractTypeName;
                    dgvStaff.Rows[rowAdd].Cells[4].Value = s.Account;
                    dgvStaff.Rows[rowAdd].Cells[5].Value = s.Id;
                    dgvStaff.Rows[rowAdd].Cells[6].Value = s.FullName;
                    dgvStaff.Rows[rowAdd].Cells[7].Value = s.DateOfBrith.ToString(_date);
                    dgvStaff.Rows[rowAdd].Cells[8].Value = s.Address;
                    dgvStaff.Rows[rowAdd].Cells[9].Value = s.Gender;
                    dgvStaff.Rows[rowAdd].Cells[10].Value = s.Phone;
                    dgvStaff.Rows[rowAdd].Cells[11].Value = s.Email;
                    dgvStaff.Rows[rowAdd].Cells[12].Value = s.EducationLevel;
                    dgvStaff.Rows[rowAdd].Cells[13].Value = s.EntryDate.ToString(_date);
                    dgvStaff.Rows[rowAdd].Cells[14].Value = s.ContractDuration.ToString(_date);
                    dgvStaff.Rows[rowAdd].Cells[15].Value = s.Status;
                    dgvStaff.Rows[rowAdd].Cells[16].Value = s.DayOff;
                    dgvStaff.Rows[rowAdd].Cells[17].Value = String.Format(_fVND, "{0:N3} ₫", s.BasicSalary);
                    dgvStaff.Rows[rowAdd].Cells[18].Value = String.Format(_fVND, "{0:N3} ₫", s.Benefit);
                }
                Enabled = true;
            }));            
            
        }
        private async void SearchStaffInfo(string search)
        {
            Enabled = false;
            dgvStaff.Rows.Clear();
            List<StaffInfoViewModel> list = await _staffBUS.SearchStaffInfo(search);
            int rowAdd;
            foreach (StaffInfoViewModel s in list.OrderBy(s => s.StaffId))
            {
                rowAdd = dgvStaff.Rows.Add();
                dgvStaff.Rows[rowAdd].Cells[0].Value = s.StaffId;
                dgvStaff.Rows[rowAdd].Cells[1].Value = s.PositionName;
                dgvStaff.Rows[rowAdd].Cells[2].Value = s.DepartmentName;
                dgvStaff.Rows[rowAdd].Cells[3].Value = s.ContractTypeName;
                dgvStaff.Rows[rowAdd].Cells[4].Value = s.Account;
                dgvStaff.Rows[rowAdd].Cells[5].Value = s.Id;
                dgvStaff.Rows[rowAdd].Cells[6].Value = s.FullName;
                dgvStaff.Rows[rowAdd].Cells[7].Value = s.DateOfBrith.ToString(_date);
                dgvStaff.Rows[rowAdd].Cells[8].Value = s.Address;
                dgvStaff.Rows[rowAdd].Cells[9].Value = s.Gender;
                dgvStaff.Rows[rowAdd].Cells[10].Value = s.Phone;
                dgvStaff.Rows[rowAdd].Cells[11].Value = s.Email;
                dgvStaff.Rows[rowAdd].Cells[12].Value = s.EducationLevel;
                dgvStaff.Rows[rowAdd].Cells[13].Value = s.EntryDate.ToString(_date);
                dgvStaff.Rows[rowAdd].Cells[14].Value = s.ContractDuration.ToString(_date);
                dgvStaff.Rows[rowAdd].Cells[15].Value = s.Status;
                dgvStaff.Rows[rowAdd].Cells[16].Value = s.DayOff;
                dgvStaff.Rows[rowAdd].Cells[17].Value = String.Format(_fVND, "{0:N3} ₫", s.BasicSalary);
                dgvStaff.Rows[rowAdd].Cells[18].Value = String.Format(_fVND, "{0:N3} ₫", s.Benefit);
            }
            Enabled = true;
        }
        private string ChooseGender()
        {
            if (rbMale.Checked)
                return rbMale.Text;
            if (rbFemale.Checked)
                return rbFemale.Text;
            else
                return rbOthers.Text;
        }
        private bool CheckEmptyText(bool check)
        {
            List<TextBox> listTextBox = new List<TextBox> {  txtIDCard, txtLastName, txtFirstName, txtHouseNumer, txtStreet, txtWard, txtDistrict, txtProvince_City,
                                                              txtPhone, txtEmail, txtEducationLevel, txtStatus, txtDayOffMount, txtBasicSalary};          
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
        private void OnOffButton()
        {
            bool check;
            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnUnlock.Enabled = false;
                btnLock.Enabled = false;
                btnAddAccount.Enabled = false;
                check = true;
                if (CheckEmptyText(check))
                {
                    btnAdd.Enabled = true;
                    return;
                }
            }
            else
            {
                btnDelete.Enabled = true;
                btnAddAccount.Enabled = true;
                check = false;
                if (!string.IsNullOrEmpty(txtDateLock.Text))
                {
                    btnUnlock.Enabled = true;
                    btnLock.Enabled = false;
                }
                if (string.IsNullOrEmpty(txtDateLock.Text))
                {
                    btnUnlock.Enabled = false;
                    btnLock.Enabled = true;
                }
                if (CheckEmptyText(check))
                {
                    btnEdit.Enabled = true;
                    return;
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchStaffInfo(txtSearch.Text);
        }

        private void cmbDepartment_TextChanged(object sender, EventArgs e)
        {
            LoadPositionByDepartment(cmbDepartment.SelectedValue.ToString());
        }
        private void ClearAllText()
        {
            errProvider.Clear();
            List<object> listInput = new List<object> { cmbPosition, cmbContractType, cmbDepartment, txtAccount, txtIDCard, txtLastName, txtMiddleName, txtFirstName,
                                                        dtpBrithday, txtHouseNumer, txtStreet, txtWard, txtDistrict, txtProvince_City, rbMale, txtPhone, txtEmail, 
                                                        txtEducationLevel, dtpEntryDate, dtpContractDuration, txtStatus, txtDayOffMount, txtBasicSalary, txtStaffID, 
                txtAllowance, txtDateLock};
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
                else if (listInput[i] is RadioButton)
                {
                    typeof(RadioButton).GetProperty("Checked").SetValue(listInput[i], true);
                    continue;
                }
                else if (listInput[i] is DateTimePicker)
                {
                    typeof(DateTimePicker).GetProperty("Text").SetValue(listInput[i], DateTime.Now.ToString());
                    continue;
                }
                else if (listInput[i] is CheckBox)
                {
                    typeof(CheckBox).GetProperty("Enabled").SetValue(listInput[i], true);
                    continue;
                }
            }
        }
        private void EnableButton(object sender, EventArgs e)
        {
            errProvider.Clear();            
            OnOffButton();
        }
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errProvider.Clear();
            pbStaffPicture.Image = Properties.Resources.image;
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            StaffInfoViewModel staff = _listStaffInfo.FirstOrDefault(s => s.StaffId == dgvStaff.Rows[rowIndex].Cells[0].Value.ToString());
            Staff name = _listStaff.FirstOrDefault(s => s.StaffId == dgvStaff.Rows[rowIndex].Cells[0].Value.ToString());
            txtStaffID.Text = staff.StaffId;
            cmbDepartment.Text = staff.DepartmentName;
            cmbPosition.Text = staff.PositionName;
            cmbContractType.Text = staff.ContractTypeName;
            txtAccount.Text = staff.Account;
            txtIDCard.Text = staff.Id;
            txtLastName.Text = name.LastName;
            txtMiddleName.Text = name.MiddleName;
            txtFirstName.Text = name.FirstName;
            dtpBrithday.Value = staff.DateOfBrith;
            txtHouseNumer.Text = name.HouseNumber;
            txtStreet.Text = name.Street;
            txtWard.Text = name.Ward;
            txtDistrict.Text = name.District;
            txtProvince_City.Text = name.ProviceCity;
            string gioiTinh = staff.Gender;
            switch (gioiTinh)
            {
                case "Nam":
                    rbMale.Checked = true;
                    break;
                case "Nữ":
                    rbFemale.Checked = true;
                    break;
                case "Khác":
                    rbOthers.Checked = true;
                    break;
            }
            txtPhone.Text = staff.Phone;
            txtEmail.Text = staff.Email;
            txtEducationLevel.Text = staff.EducationLevel;
            dtpEntryDate.Value = staff.EntryDate;
            dtpContractDuration.Value = staff.ContractDuration;
            txtStatus.Text = staff.Status;
            txtDayOffMount.Text = staff.DayOff.ToString();
            txtBasicSalary.Text = staff.BasicSalary.ToString("F3");
            txtAllowance.Text = staff.Benefit.ToString("F3");
            txtDateLock.Text = staff.LockDate.ToString();
            byte[] image = staff.Picture;
            if (image != null)
                ImageHandle.LoadImage(pbStaffPicture, image);
        }
        private void Reload()
        {
            frmStaff open = new frmStaff();
            _handle.RedirectForm(open, this);
        }
        private bool CheckInputError(Button button)
        {
            bool flag = true;
            errProvider.Clear();
            var validationRules = new Dictionary<Control, Func<bool>>
            {
                { dtpEntryDate, () => DateTime.Parse(dtpEntryDate.Value.ToString(_date)) < DateTime.Parse(DateTime.Now.ToString(_date)) },
                { txtIDCard, () => !InputCheck.CheckCardID(txtIDCard.Text) || _listStaff.FirstOrDefault(s => s.Id == txtIDCard.Text && s.StaffId != txtStaffID.Text) != null},
                { dtpBrithday, () => DateTime.Now.Year - dtpBrithday.Value.Year < 18 },
                { txtPhone, () => !InputCheck.CheckPhone(txtPhone.Text) || _listStaff.FirstOrDefault(s => s.Phone == txtPhone.Text && s.StaffId != txtStaffID.Text) != null},
                { txtEmail, () => !InputCheck.CheckEmail(txtEmail.Text) || _listStaff.FirstOrDefault(s => s.Email == txtEmail.Text && s.StaffId != txtStaffID.Text) != null},
                { txtBasicSalary, () => double.TryParse(txtBasicSalary.Text, out _) is false },
                { dtpContractDuration, () => dtpContractDuration.Value <= dtpEntryDate.Value },
                { txtDayOffMount, () => int.TryParse(txtDayOffMount.Text, out _) is false }
            };
            var errorMessages = new Dictionary<Control, string>
            {
                { dtpEntryDate, "Ngày vào làm không thể nhỏ hơn ngày hiện tại" },
                { txtIDCard, "Căn cước công dân không đúng định dạng hoặc đã tồn tại" },
                { dtpBrithday, "Tuổi phải lớn hơn hoặc bằng 18" },
                { txtPhone, "Số điện thoại không đúng định dạng hoặc đã tồn tại" },
                { txtEmail, "Email không đúng định dạng hoặc đã tồn tại" },
                { dtpContractDuration, "Thời hạn hợp đồng phải lớn hơn ngày vào làm" },
                { txtBasicSalary, "Lương cơ bản không đúng định dạng số" },
                { txtDayOffMount, "Số ngày phép không đúng định dạng số" }
            };
            foreach (var rule in validationRules)
            {
                var control = rule.Key;
                var validate = rule.Value;
                if (control is DateTimePicker && button == btnEdit)
                {
                    if (validate() && dtpEntryDate.Value != _listStaff.FirstOrDefault(s => s.StaffId == txtStaffID.Text).EntryDate)
                    {
                        errProvider.SetError(control, errorMessages[control]);
                        flag = false;
                    }
                }
                else
                {
                    if (validate())
                    {
                        errProvider.SetError(control, errorMessages[control]);
                        flag = false;
                    }
                }
            }
            if (flag)
                return true;
            return false;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInputError(btnAdd))
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Staff staff = new Staff()
                {
                    StaffId = "",
                    PsId = cmbPosition.SelectedValue.ToString(),
                    CtId = cmbContractType.SelectedValue.ToString(),
                    Id = txtIDCard.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    FirstName = txtFirstName.Text,
                    DateOfBrith = dtpBrithday.Value,
                    HouseNumber = txtHouseNumer.Text,
                    Street = txtStreet.Text,
                    Ward = txtWard.Text,
                    District = txtDistrict.Text,
                    ProviceCity = txtProvince_City.Text,
                    Gender = ChooseGender(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    EducationLevel = txtEducationLevel.Text,
                    EntryDate = dtpEntryDate.Value,
                    ContractDuration = dtpContractDuration.Value,
                    Status = txtStatus.Text,
                    DayOff = int.Parse(txtDayOffMount.Text),
                    BasicSalary = decimal.Parse(txtBasicSalary.Text),
                    Picture = ImageHandle.GetImageBytes(pbStaffPicture)                    
                };
                await _staffBUS.CreateStaff(staff);
                Reload();
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInputError(btnEdit))
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Staff staff = new Staff()
                {
                    StaffId = txtStaffID.Text,
                    PsId = cmbPosition.SelectedValue.ToString(),
                    CtId = cmbContractType.SelectedValue.ToString(),
                    Id = txtIDCard.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    FirstName = txtFirstName.Text,
                    DateOfBrith = dtpBrithday.Value,
                    HouseNumber = txtHouseNumer.Text,
                    Street = txtStreet.Text,
                    Ward = txtWard.Text,
                    District = txtDistrict.Text,
                    ProviceCity = txtProvince_City.Text,
                    Gender = ChooseGender(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    EducationLevel = txtEducationLevel.Text,
                    EntryDate = dtpEntryDate.Value,
                    ContractDuration = dtpContractDuration.Value,
                    Status = txtStatus.Text,
                    DayOff = int.Parse(txtDayOffMount.Text),
                    BasicSalary = decimal.Parse(txtBasicSalary.Text),
                    Picture = ImageHandle.GetImageBytes(pbStaffPicture)
                };
                await _staffBUS.UpdateStaff(staff);
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
                if (txtStaffID.Text == lblStaffIDLoginValue.Text)
                {
                    MessageBox.Show("Không thể xoá tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAllText();
                    return;
                }
                CustomMessage.YesNoCustom("Xác nhận", "Huỷ");
                DialogResult result = MessageBox.Show($"Xác nhận xoá nhân viên {txtStaffID.Text}? Sau khi xoá dữ liệu của nhân viên trên hệ thống không thể khôi phục!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _staffBUS.DeleteStaff(txtStaffID.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            ImageHandle.ChooseIamge(pbStaffPicture);
        }

        private void txtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyRealNumber(sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheck.OnlyNatrualNumber(sender, e);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvStaff.RowsDefaultCellStyle.Font = new Font(dgvStaff.Font.FontFamily, fontSize);
        }
    }
}
