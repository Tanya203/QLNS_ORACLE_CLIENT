using CLIENT.ViewModels;
using CLIENT.LogicTier;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmStaff : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly string date = "dd/MM/yyyy";
        private readonly StaffBUS _staffBUS; 
        public frmStaff()
        {
            InitializeComponent();
            _staffBUS   = new StaffBUS();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadStaffInfo();
        }
        private async void LoadStaffInfo()
        {
            Enabled = false;
            dgvStaff.Rows.Clear();
            List<StaffInfoViewModel> list = await _staffBUS.GetAllStaffInfo();
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
                dgvStaff.Rows[rowAdd].Cells[7].Value = s.DateOfBrith.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[8].Value = s.Address;
                dgvStaff.Rows[rowAdd].Cells[9].Value = s.Gender;
                dgvStaff.Rows[rowAdd].Cells[10].Value = s.Phone;
                dgvStaff.Rows[rowAdd].Cells[11].Value = s.Email;
                dgvStaff.Rows[rowAdd].Cells[12].Value = s.EducationLevel;
                dgvStaff.Rows[rowAdd].Cells[13].Value = s.EntryDate.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[14].Value = s.ContractDuration.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[15].Value = s.Status;
                dgvStaff.Rows[rowAdd].Cells[16].Value = s.DayOff;
                dgvStaff.Rows[rowAdd].Cells[17].Value = String.Format(_fVND, "{0:N3} ₫", s.BasicSalary);
                dgvStaff.Rows[rowAdd].Cells[18].Value = String.Format(_fVND, "{0:N3} ₫", s.Benefit);
            }
            Enabled = true;
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
                dgvStaff.Rows[rowAdd].Cells[7].Value = s.DateOfBrith.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[8].Value = s.Address;
                dgvStaff.Rows[rowAdd].Cells[9].Value = s.Gender;
                dgvStaff.Rows[rowAdd].Cells[10].Value = s.Phone;
                dgvStaff.Rows[rowAdd].Cells[11].Value = s.Email;
                dgvStaff.Rows[rowAdd].Cells[12].Value = s.EducationLevel;
                dgvStaff.Rows[rowAdd].Cells[13].Value = s.EntryDate.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[14].Value = s.ContractDuration.ToString(date);
                dgvStaff.Rows[rowAdd].Cells[15].Value = s.Status;
                dgvStaff.Rows[rowAdd].Cells[16].Value = s.DayOff;
                dgvStaff.Rows[rowAdd].Cells[17].Value = String.Format(_fVND, "{0:N3} ₫", s.BasicSalary);
                dgvStaff.Rows[rowAdd].Cells[18].Value = String.Format(_fVND, "{0:N3} ₫", s.Benefit);
            }
            Enabled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchStaffInfo(txtSearch.Text);
        }
    }
}
