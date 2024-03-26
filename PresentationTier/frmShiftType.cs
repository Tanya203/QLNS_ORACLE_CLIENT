using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.Models;
using CLINET.LogicTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CLINET.PresentationTier
{
    public partial class frmShiftType : Form
    {
        private readonly ShiftTypeBUS _shiftTypeBUS;
        public frmShiftType()
        {
            InitializeComponent();
            _shiftTypeBUS = new ShiftTypeBUS();
        }

        private void frmShiftType_Load(object sender, EventArgs e)
        {
            LoadShiftType();
        }
        private async void LoadShiftType()
        {
            Enabled = false;
            dgvShiftType.Rows.Clear();
            List<ShiftType> list = await _shiftTypeBUS.GetAllShiftType();
            int rowAdd;
            foreach (ShiftType s in list.OrderBy(sh => sh.StId))
            {
                rowAdd = dgvShiftType.Rows.Add();
                dgvShiftType.Rows[rowAdd].Cells[0].Value = s.StId;
                dgvShiftType.Rows[rowAdd].Cells[1].Value = s.ShiftTypeName;
                dgvShiftType.Rows[rowAdd].Cells[2].Value = s.SalaryCoefficient;
            }
            Enabled = true;
        }
        private async void SearchShiftType(string search)
        {
            Enabled = false;
            dgvShiftType.Rows.Clear();
            List<ShiftType> list = await _shiftTypeBUS.SearchShiftType(search);
            int rowAdd;
            foreach (ShiftType s in list.OrderBy(sh => sh.StId))
            {
                rowAdd = dgvShiftType.Rows.Add();
                dgvShiftType.Rows[rowAdd].Cells[0].Value = s.StId;
                dgvShiftType.Rows[rowAdd].Cells[1].Value = s.ShiftTypeName;
                dgvShiftType.Rows[rowAdd].Cells[2].Value = s.SalaryCoefficient;
            }
            Enabled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchShiftType(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ShiftType shiftType = new ShiftType()
                {
                    StId = "",
                    ShiftTypeName = txtShiftTypeName.Text,
                    SalaryCoefficient = decimal.Parse(txtSalaryCoefficient.Text)
                };
                await _shiftTypeBUS.CreateShiftType(shiftType);
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
                ShiftType shiftType = new ShiftType()
                {
                    StId = txtShiftTypeID.Text,
                    ShiftTypeName = txtShiftTypeName.Text,
                    SalaryCoefficient = decimal.Parse(txtSalaryCoefficient.Text)
                };
                await _shiftTypeBUS.UpdateShiftType(shiftType);
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
                await _shiftTypeBUS.DeleteShiftType(txtShiftTypeID.Text);
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
