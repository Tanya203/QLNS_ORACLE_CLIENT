using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using System.Drawing;
using CLIENT.Models;
using System.Runtime.InteropServices;

namespace CLIENT.PresentationTier
{
    public partial class frmBenefitDetail : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly string staffID;
        private readonly string bnID;
        private readonly FormHandle _handle;
        private readonly BenefitBUS _benefitBUS;
        private readonly BenefitDetailBUS _benefitDetailBUS;
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private readonly StaffBUS _staffBUS;
        private List<CountBenefitViewModel> _benefit;
        private List<StaffInfoViewModel> _listStaffInfo;
        private List<StaffBenefitDetailViewModel> _listBenefitDetail;
        private List<BenefitDetail> _updateList;
        private List<BenefitDetail> _deleteList;
        public frmBenefitDetail(string staffID, string bnID)
        {
            InitializeComponent();
            _handle = new FormHandle(); 
            _benefitDetailBUS = new BenefitDetailBUS();
            _benefitBUS = new BenefitBUS(); 
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
            _staffBUS = new StaffBUS();
            _benefit = new List<CountBenefitViewModel>();
            _listStaffInfo = new List<StaffInfoViewModel>();
            _listBenefitDetail = new List<StaffBenefitDetailViewModel>();
            _updateList = new List<BenefitDetail>();
            _deleteList = new List<BenefitDetail>();
            this.staffID = staffID;
            this.bnID = bnID;
        }

        private async void frmBenefitDetail_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listBenefitDetail = await _benefitDetailBUS.GetStaffBenefitsDetail();
            _listBenefitDetail = _listBenefitDetail.Where(b => b.BnId == bnID).ToList();
            _listStaffInfo = await _staffBUS.GetAllStaffInfo();
            _benefit = await _benefitBUS.GetCountBenefit();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvBenefitDetail.RowsDefaultCellStyle.Font.Size));
            LoadHeaderInfo();
            DeleteButton();
            LoadBenefitInfo();
            LoadDepartment();
            LoadStaffBenefitDetail();
            Enabled = true;
        }
        private void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = _listStaffInfo.FirstOrDefault(s => s.StaffId == staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadBenefitInfo()
        {
            CountBenefitViewModel benefit = _benefit.FirstOrDefault(b => b.BnId == bnID);
            txtAllowanceID.Invoke((MethodInvoker)(() => txtAllowanceID.Text = benefit.BnId));
            txtAllowamceName.Invoke((MethodInvoker)(() => txtAllowamceName.Text = benefit.BenefitName));
            txtAmount.Invoke((MethodInvoker)(() => txtAmount.Text = String.Format(_fVND, "{0:N3} ₫", benefit.Amount)));
            txtStaffAmount.Invoke((MethodInvoker)(() => txtStaffAmount.Text = benefit.StaffQuantity.ToString()));
            txtTotalAmount.Invoke((MethodInvoker)(() => txtTotalAmount.Text = String.Format(_fVND, "{0:N3} ₫", benefit.Amount)));
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
        private void LoadPositonByDepartment(string dpID)
        {
            cmbPosition.Invoke((MethodInvoker)( async () =>
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
            cmbStaffID.Invoke((MethodInvoker)( async () =>
            {
                cmbStaffID.DisplayMember = "FullName";
                cmbStaffID.ValueMember = "StaffID";
                List<StaffInfoViewModel> list = await _staffBUS.GetAllStaffInfo();
                list = list.Where(s => s.PositionName == positionName).OrderBy(s => s.StaffId).ToList();
                foreach (BenefitDetail b in _updateList)
                    list.RemoveAll(s => s.StaffId == b.StaffId);
                cmbStaffID.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbStaffID);    
                if(!string.IsNullOrEmpty(cmbStaffID.Text))
                {
                    cmbStaffID.Enabled = true;
                    btnAdd.Enabled = true;
                }
                else if(string.IsNullOrEmpty(cmbStaffID.Text))
                {
                    cmbStaffID.Enabled = false;
                    btnAdd.Enabled = false;
                }
            }));
                
        }
        private void UpdateList(string bnID, string staffID)
        {
            BenefitDetail add = new BenefitDetail()
            {
                BnId = bnID,
                StaffId = staffID,
            };
            _updateList.Add(add);
        }
        private void LoadStaffBenefitDetail()
        {
            dgvBenefitDetail.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvBenefitDetail.Rows.Clear();
                int rowAdd;
                foreach (StaffBenefitDetailViewModel s in _listBenefitDetail.OrderBy(s => s.BnId))
                {
                    rowAdd = dgvBenefitDetail.Rows.Add();
                    dgvBenefitDetail.Rows[rowAdd].Cells[0].Value = s.BnId;
                    dgvBenefitDetail.Rows[rowAdd].Cells[1].Value = s.StaffId;
                    dgvBenefitDetail.Rows[rowAdd].Cells[2].Value = s.FullName;
                    dgvBenefitDetail.Rows[rowAdd].Cells[3].Value = s.PositionName;
                    dgvBenefitDetail.Rows[rowAdd].Cells[4].Value = s.DepartmentName;
                    UpdateList(s.BnId, s.StaffId);
                }
                Enabled = true;
            }));
        }
        private async void SearchStaffBenefitDetail(string search)
        {
            Enabled = false;
            dgvBenefitDetail.Rows.Clear();
            List<StaffBenefitDetailViewModel> list = await _benefitDetailBUS.SearchStaffBenefitsDetail(search);
            list = list.Where(b => b.BnId == bnID).ToList();
            int rowAdd;
            foreach (StaffBenefitDetailViewModel s in list.OrderBy(s => s.BnId))
            {
                rowAdd = dgvBenefitDetail.Rows.Add();
                dgvBenefitDetail.Rows[rowAdd].Cells[0].Value = s.BnId;
                dgvBenefitDetail.Rows[rowAdd].Cells[1].Value = s.StaffId;
                dgvBenefitDetail.Rows[rowAdd].Cells[2].Value = s.FullName;
                dgvBenefitDetail.Rows[rowAdd].Cells[3].Value = s.PositionName;
                dgvBenefitDetail.Rows[rowAdd].Cells[4].Value = s.DepartmentName;
            }
            Enabled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchStaffBenefitDetail(txtSearch.Text);
        }
        private void DeleteButton()
        {
            dgvBenefitDetail.Invoke((MethodInvoker)(() =>
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                {
                    btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    btnDelete.Text = "Xoá";
                    btnDelete.UseColumnTextForButtonValue = true;
                    btnDelete.FlatStyle = FlatStyle.Popup;
                    var buttonCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = SystemColors.ScrollBar,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    btnDelete.DefaultCellStyle = buttonCellStyle;
                    dgvBenefitDetail.Columns.Add(btnDelete);
                }
            }));                
        }
        private void Reload()
        {
            frmBenefitDetail open = new frmBenefitDetail(staffID, bnID);
            _handle.RedirectForm(open, this);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BenefitDetail benefitDetail = new BenefitDetail()
            {
                BnId = txtAllowanceID.Text,
                StaffId = cmbStaffID.SelectedValue.ToString(),
            };
            int row;
            row = dgvBenefitDetail.Rows.Add();
            dgvBenefitDetail.Rows[row].Cells[0].Value = txtAllowanceID.Text;
            dgvBenefitDetail.Rows[row].Cells[1].Value = cmbStaffID.SelectedValue.ToString();
            dgvBenefitDetail.Rows[row].Cells[2].Value = cmbStaffID.Text;
            dgvBenefitDetail.Rows[row].Cells[3].Value = cmbDepartment.Text;
            dgvBenefitDetail.Rows[row].Cells[4].Value = cmbPosition.Text;
            _updateList.Add(benefitDetail);
            _deleteList.RemoveAll(s => s.StaffId == benefitDetail.StaffId);
            LoadStaffByPosition(cmbPosition.Text);
            if (_updateList.Count > 0 || _deleteList.Count > 0)
                btnSave.Enabled = true;
            else 
                btnSave.Enabled = false;
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
            byte[] image = _listStaffInfo.FirstOrDefault(s => s.StaffId == cmbStaffID.SelectedValue.ToString()).Picture;
            if(image != null)                
                ImageHandle.LoadImage(pbStaffPicture, image);
            if(string.IsNullOrEmpty(cmbStaffID.Text))
                pbStaffPicture.Image = Properties.Resources.image;
        }

        private void dgvBenefitDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
                return;
            string staffID = dgvBenefitDetail.Rows[row].Cells[1].Value.ToString();
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow remove = dgvBenefitDetail.Rows[row];
                dgvBenefitDetail.Rows.Remove(remove);
                if (_listBenefitDetail.FirstOrDefault(s => s.StaffId == staffID) != null)
                    _deleteList.Add(_updateList.FirstOrDefault(s => s.StaffId == staffID));
                _updateList.RemoveAll(s => s.StaffId == staffID);
                LoadStaffByPosition(cmbPosition.Text);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(_deleteList.Count > 0)
                {
                    if (!await _benefitDetailBUS.DeleteBenefitDetail(_deleteList))
                        return;
                }                        
                foreach (StaffBenefitDetailViewModel staff in _listBenefitDetail)
                    _updateList.RemoveAll(s => s.StaffId == staff.StaffId);
                if(_updateList.Count > 0)
                {
                    if (!await _benefitDetailBUS.CreateBenefitDetail(_updateList))
                        return;
                }
                MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBenefit open = new frmBenefit();
            _handle.RedirectForm(open, this);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvBenefitDetail.RowsDefaultCellStyle.Font = new Font(dgvBenefitDetail.Font.FontFamily, fontSize);
        }
    }
}
