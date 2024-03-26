using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINET.PresentationTier
{
    public partial class frmShift : Form
    {
        private readonly ShiftBUS _shiftBUS;
        private readonly ShiftTypeBUS _shiftTypeBUS;
        public frmShift()
        {
            InitializeComponent();
            _shiftBUS = new ShiftBUS();
            _shiftTypeBUS = new ShiftTypeBUS();
        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            LoadShiftType();
            LoadShiftDetail();
        }
        private async void LoadShiftType()
        {
            cmbShiftType.DisplayMember = "ShiftTypeName";
            cmbShiftType.ValueMember = "StId";
            List<ShiftType> list = await _shiftTypeBUS.GetAllShiftType();
            list.OrderBy(s => s.StId);
            cmbShiftType.DataSource = list;
            AutoAdjustComboBox.Adjust(cmbShiftType);
        }
        private async void LoadShiftDetail()
        {
            Enabled = false;
            dgvShift.Rows.Clear();
            List<ShiftDetailViewModel> list = await _shiftBUS.GetShiftDetail();
            int rowAdd;
            foreach (ShiftDetailViewModel s in list.OrderBy(s => s.ShiftId))
            {
                rowAdd = dgvShift.Rows.Add();
                dgvShift.Rows[rowAdd].Cells[0].Value = s.ShiftId;
                dgvShift.Rows[rowAdd].Cells[1].Value = s.ShiftName;
                dgvShift.Rows[rowAdd].Cells[2].Value = s.ShiftTypeName;
                dgvShift.Rows[rowAdd].Cells[3].Value = s.BeginTime;
                dgvShift.Rows[rowAdd].Cells[4].Value = s.EndTime;
            }
            Enabled = true;
        }
        private async void SearchShiftDetail(string search)
        {
            Enabled = false;
            dgvShift.Rows.Clear();
            List<ShiftDetailViewModel> list = await _shiftBUS.SearchShiftDetail(search);
            int rowAdd;
            foreach (ShiftDetailViewModel s in list.OrderBy(s => s.ShiftId))
            {
                rowAdd = dgvShift.Rows.Add();
                dgvShift.Rows[rowAdd].Cells[0].Value = s.ShiftId;
                dgvShift.Rows[rowAdd].Cells[1].Value = s.ShiftName;
                dgvShift.Rows[rowAdd].Cells[2].Value = s.ShiftTypeName;
                dgvShift.Rows[rowAdd].Cells[3].Value = s.BeginTime;
                dgvShift.Rows[rowAdd].Cells[4].Value = s.EndTime;
            }
            Enabled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchShiftDetail(txtSearch.Text);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Shift shift = new Shift()
                {
                    ShiftId = "",
                    ShiftName = txtShiftName.Text,
                    StId = cmbShiftType.SelectedValue.ToString(),
                    BeginTime = TimeSpan.Parse(dtpStartTime.Text),
                    EndTime = TimeSpan.Parse(dtpEndTime.Text)
                };
                await _shiftBUS.CreateShift(shift);
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
                Shift shift = new Shift()
                {
                    ShiftId = txtShiftID.Text,
                    ShiftName = txtShiftName.Text,
                    StId = cmbShiftType.SelectedValue.ToString(),
                    BeginTime = TimeSpan.Parse(dtpStartTime.Text),
                    EndTime = TimeSpan.Parse(dtpEndTime.Text)
                };
                await _shiftBUS.UpdateShift(shift);
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
                await _shiftBUS.DeleteShift(txtShiftID.Text);
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
