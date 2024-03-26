using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmPositon : Form
    {
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        public frmPositon()
        {
            InitializeComponent();
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
        }

        private void frmPositon_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            LoadPositionDetail();            
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
        public async void LoadPositionDetail()
        {
            Enabled = false;
            dgvPosition.Rows.Clear();
            List<PositionDetailViewModel> list = await _positionBUS.GetPositionDetail();
            int rowAdd;
            foreach (PositionDetailViewModel p in list.OrderBy(s => s.PsId))
            {
                rowAdd = dgvPosition.Rows.Add();
                dgvPosition.Rows[rowAdd].Cells[0].Value = p.PsId;
                dgvPosition.Rows[rowAdd].Cells[1].Value = p.DepartmentName;
                dgvPosition.Rows[rowAdd].Cells[2].Value = p.PositionName;
                dgvPosition.Rows[rowAdd].Cells[3].Value = p.Count;
            }
            Enabled = true;
        }
        public async void SearchPositionDetail(string search)
        {
            Enabled = false;
            dgvPosition.Rows.Clear();
            List<PositionDetailViewModel> list = await _positionBUS.SearchPositionDetail(search);
            int rowAdd;
            foreach (PositionDetailViewModel p in list.OrderBy(s => s.PsId))
            {
                rowAdd = dgvPosition.Rows.Add();
                dgvPosition.Rows[rowAdd].Cells[0].Value = p.PsId;
                dgvPosition.Rows[rowAdd].Cells[1].Value = p.DepartmentName;
                dgvPosition.Rows[rowAdd].Cells[2].Value = p.PositionName;
                dgvPosition.Rows[rowAdd].Cells[3].Value = p.Count;
            }
            Enabled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchPositionDetail(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Position position = new Position()
                {
                    PsId = "",
                    DpId = cmbDepartment.SelectedValue.ToString(),
                    PositionName = txtPositionName.Text,
                };
                await _positionBUS.CreatePosition(position);
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
                Position position = new Position()
                {
                    PsId = txtPositionID.Text,
                    DpId = cmbDepartment.SelectedValue.ToString(),
                    PositionName = txtPositionName.Text,
                };
                await _positionBUS.UpdatePosition(position);
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
                await _positionBUS.DeletePosition(txtPositionID.Text);
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
