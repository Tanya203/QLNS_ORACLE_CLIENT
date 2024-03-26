using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CLIENT.DataTier.Models;
using CLIENT.Function;

namespace CLIENT.PresentationTier
{
    public partial class frmBenefitDetail : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly BenefitDetailBUS _benefitDetailBUS;
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private readonly StaffBUS _staffBUS;
        public frmBenefitDetail()
        {
            InitializeComponent();
            _benefitDetailBUS = new BenefitDetailBUS();
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
            _staffBUS = new StaffBUS();
        }

        private void frmBenefitDetail_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            LoadPositon();
            LoadStaff();
            LoadStaffBenefitDetail();
        }
        private async void LoadDepartment()
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DpId";
            List<Department> list = await _departmentBUS.GetAllDepartment();
            list.OrderBy(s => s.DpId);
            cmbDepartment.DataSource = list;
            AutoAdjustComboBox.Adjust(cmbDepartment);
        }
        private async void LoadPositon()
        {
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "PsId";
            List<Position> list = await _positionBUS.GetAllPosition();
            list.OrderBy(s => s.PsId);
            cmbPosition.DataSource = list;
            AutoAdjustComboBox.Adjust(cmbPosition);
        }
        private async void LoadStaff()
        {
            cmbStaffID.DisplayMember = "FullName";
            cmbStaffID.ValueMember = "StaffID";
            List<StaffInfoViewModel> list = await _staffBUS.GetAllStaffInfo();
            list.OrderBy(s => s.StaffId);
            cmbStaffID.DataSource = list;
            AutoAdjustComboBox.Adjust(cmbStaffID);
        }
        private async void LoadStaffBenefitDetail()
        {
            Enabled = false;
            dgvBenefitDetail.Rows.Clear();
            List<StaffBenefitDetailViewModel> list = await _benefitDetailBUS.GetStaffBenefitsDetail();
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
        private async void SearchStaffBenefitDetail(string search)
        {
            Enabled = false;
            dgvBenefitDetail.Rows.Clear();
            List<StaffBenefitDetailViewModel> list = await _benefitDetailBUS.SearchStaffBenefitsDetail(search);
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
    }
}
