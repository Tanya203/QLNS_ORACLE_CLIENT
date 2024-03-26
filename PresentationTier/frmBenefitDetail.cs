using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmBenefitDetail : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly BenefitDetailBUS _benefitDetailBUS;
        public frmBenefitDetail()
        {
            InitializeComponent();
            _benefitDetailBUS = new BenefitDetailBUS();
        }

        private void frmBenefitDetail_Load(object sender, EventArgs e)
        {
            LoadStaffBenefitDetail();
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
    }
}
