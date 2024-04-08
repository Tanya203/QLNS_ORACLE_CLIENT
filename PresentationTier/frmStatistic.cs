using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmStatistic : Form
    {
        private readonly CultureInfo _fVND = CultureInfo.GetCultureInfo("vi-VN");
        private readonly string _staffID;
        private readonly FormHandle _handle;
        private readonly PositionBUS _positionBUS;
        private readonly DepartmentBUS _departmentBUS;
        private readonly StaffBUS _staffBUS;
        private readonly TimeKeepingBUS _timeKeepingBUS;
        private StaffInfoViewModel staff;
        public frmStatistic(string staffID)
        {
            InitializeComponent();
            _handle = new FormHandle();
            _positionBUS = new PositionBUS();
            _departmentBUS = new DepartmentBUS();
            _timeKeepingBUS = new TimeKeepingBUS();
            _staffBUS = new StaffBUS();
            _staffID = staffID;
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            LoadHeaderInfo();
            LoadDepartment();
            rbAllStaffSalary.Checked = true;
        }
        private void tabControlMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*tabControlMenu.Invoke((MethodInvoker)(() =>
            {
                TabControl tabControl = (TabControl)sender;
                TabPage tabPage = tabControl.TabPages[e.Index];
                Font font = tabPage.Font;
                Brush brush = new SolidBrush(tabPage.ForeColor);
                Rectangle bounds = e.Bounds;
                e.Graphics.DrawString(tabPage.Text, font, brush, bounds);
            })); */          
        }
        private async void LoadHeaderInfo()
        {
            staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
            LoadSalaryReportViewer();
        }
        private void LoadDepartment()
        {
            cmbDepartmentSalary.Invoke((MethodInvoker)(async () =>
            {
                cmbDepartmentSalary.DisplayMember = "DepartmentName";
                cmbDepartmentSalary.ValueMember = "DpId";
                List<Department> list = await _departmentBUS.GetAllDepartment();
                list.OrderBy(s => s.DpId);
                cmbDepartmentSalary.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbDepartmentSalary);
            }));
        }
        private void LoadPositonByDepartment(string dpID)
        {
            cmbPositionSalary.Invoke((MethodInvoker)(async () =>
            {
                cmbPositionSalary.DisplayMember = "PositionName";
                cmbPositionSalary.ValueMember = "PsId";
                List<Position> list = await _positionBUS.GetAllPosition();
                list = list.Where(p => p.DpId == dpID).OrderBy(s => s.PsId).ToList();
                cmbPositionSalary.DataSource = list;
                AutoAdjustComboBox.Adjust(cmbPositionSalary);
            }));
        }
        private async void LoadSalaryReportViewer()
        {
            List<MonthlySalaryStatisticsViewModels> salary = await _timeKeepingBUS.SalaryStatistic(dtpMonthSalary.Text);

            decimal total = 0;
            if (rbDepartmentSalary.Checked)
                salary = salary.Where(s => s.Department == cmbDepartmentSalary.Text).ToList();
            else if (rbPositionSalary.Checked)
                salary = salary.Where(s => s.Position == cmbPositionSalary.Text).ToList();

            foreach (MonthlySalaryStatisticsViewModels staff in salary)
            {
                staff.FullName = staff.FullName;
                staff.TotalBenefit = staff.TotalBenefit;
                staff.TotalHour = staff.TotalHour;
                total += staff.Salary;
            }

            ReportDataSource reportDataSource = new ReportDataSource("Salary", salary);
            List<ReportParameter> parameters = new List<ReportParameter>
            {
                new ("Total", total.ToString()),
                new ("DateTime", DateTime.Now.ToString()),
                new ("Month", dtpMonthSalary.Text),
                new ("FullName", salary.FirstOrDefault()?.FullName), 
                new ("StaffID", salary.FirstOrDefault()?.StaffId), 
                new ("Department", salary.FirstOrDefault()?.Department), 
                new ("Position", salary.FirstOrDefault()?.Position), 
            };
            rptSalary.LocalReport.SetParameters(parameters);
            rptSalary.LocalReport.DataSources.Clear();
            rptSalary.LocalReport.DataSources.Add(reportDataSource);
            rptSalary.SetDisplayMode(DisplayMode.PrintLayout);
            rptSalary.ZoomMode = ZoomMode.Percent;
            rptSalary.ZoomPercent = 100;
            rptSalary.RefreshReport();
        }

        private void EnableCombobox(object sender, EventArgs e)
        {
            if (rbAllStaffSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = false;
                cmbPositionSalary.Enabled = false;
            }
            else if (rbDepartmentSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = true;
                cmbPositionSalary.Enabled = false;
            }

            else if (rbPositionSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = false;
                cmbPositionSalary.Enabled = true;
            }
        }

        private void cmbDepartmentSalary_TextChanged(object sender, EventArgs e)
        {
            LoadPositonByDepartment(cmbDepartmentSalary.SelectedValue.ToString());
            if (rbDepartmentSalary.Checked)
            {
                LoadSalaryReportViewer();
            }
        }

        private void cmbPositionSalary_TextChanged(object sender, EventArgs e)
        {
            if (rbPositionSalary.Checked)
            {
                LoadSalaryReportViewer();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain open = new frmMain(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmStatistic open = new frmStatistic(_staffID);
            _handle.RedirectForm(open, this);
        }

        private void dtpMonthSalary_ValueChanged(object sender, EventArgs e)
        {
            LoadSalaryReportViewer();
        }
    }
}
