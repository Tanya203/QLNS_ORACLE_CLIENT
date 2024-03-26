using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.Models;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmBenefit : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly BenefitBUS _benefitBUS;
        public frmBenefit()
        {
            InitializeComponent();
            _benefitBUS = new BenefitBUS();
        }

        private void frmBenefit_Load(object sender, EventArgs e)
        {
            LoadStaffBenefit();
        }
        private async void LoadStaffBenefit()
        {
            Enabled = false;
            dgvBenefit.Rows.Clear();
            List<CountBenefitViewModel> list = await _benefitBUS.GetCountBenefit();
            int rowAdd;
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
        private async void LoadBenefitSearch(string search)
        {
            Enabled = false;
            dgvBenefit.Rows.Clear();
            List<CountBenefitViewModel> list = await _benefitBUS.SearchCountBenefit(search);
            int rowAdd;
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
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Benefit benefit = new Benefit()
                {
                    BnId = "",
                    BenefitName = txtBenefitName.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                };
                await _benefitBUS.CreateBenefit(benefit);
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
                Benefit benefit = new Benefit()
                {
                    BnId = txtBN_ID.Text,
                    BenefitName = txtBenefitName.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                };
                await _benefitBUS.UpdateBenefit(benefit);
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
                await _benefitBUS.DeleteBenefit(txtBN_ID.Text);
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
    }
}
