using CLIENT.DataTier.Models;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CLIENT.Function;

namespace CLIENT.PresentationTier
{
    public partial class frmDepartment : Form
    {
        private readonly DepartmentBUS _departmentBUS;
        public frmDepartment()
        {
            InitializeComponent();
            _departmentBUS = new DepartmentBUS();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartmentDetail();
        }
        private async void LoadDepartmentDetail()
        {
            Enabled = false;
            dgvDepartment.Rows.Clear();
            List<DepartmentDetailViewModel> list = await _departmentBUS.GetDepartmentDetail();
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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchDepartmentDetail(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department()
                {
                    DpId = "",
                    DepartmentName = txtDepartmentName.Text,
                };
                await _departmentBUS.CreateDepartment(department);
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
                Department department = new Department()
                {
                    DpId = txtDepartmentID.Text,
                    DepartmentName = txtDepartmentName.Text,
                };
                await _departmentBUS.UpdateDepartment(department);
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
                await _departmentBUS.DeleteDepartment(txtDepartmentID.Text);
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
