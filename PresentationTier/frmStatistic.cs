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
            rbAllStaffSalary.Invoke((MethodInvoker)(() => rbAllStaffSalary.Checked = true));
        }
        private async void LoadHeaderInfo()
        {
            staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
            LoadDepartment();
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
            try
            {
                StaffInfoViewModel staffInfo = await _staffBUS.GetStaffInfo(_staffID);
                decimal total = 0;
                List<MonthlySalaryStatisticsViewModels> salary = await _timeKeepingBUS.SalaryStatistic(dtpMonthSalary.Text);
                if (rbDepartmentSalary.Checked)
                    salary = salary.Where(s => s.Department == cmbDepartmentSalary.Text).ToList();
                else if (rbPositionSalary.Checked)
                    salary = salary.Where(s => s.Position == cmbPositionSalary.Text).ToList();

                foreach (MonthlySalaryStatisticsViewModels staff in salary)
                    total += staff.Salary;
                ReportDataSource reportDataSource = new ReportDataSource("Salary", salary);
                List<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("Total", total.ToString()),
                    new ReportParameter("DateTime", DateTime.Now.ToString()),
                    new ReportParameter("Month", dtpMonthSalary.Text),
                    new ReportParameter("FullName", staffInfo.FullName),
                    new ReportParameter("StaffID", staffInfo.StaffId),
                    new ReportParameter("Department", staffInfo.DepartmentName),
                    new ReportParameter("Position", staffInfo.PositionName),
                };
                rptSalary.LocalReport.SetParameters(parameters);
                rptSalary.LocalReport.DataSources.Clear();
                rptSalary.LocalReport.DataSources.Add(reportDataSource);
                rptSalary.SetDisplayMode(DisplayMode.PrintLayout);
                rptSalary.ZoomMode = ZoomMode.Percent;
                rptSalary.ZoomPercent = 100;
                rptSalary.RefreshReport();
            }
            catch(Exception ex) 
            {
                CustomMessage.ExecptionCustom(ex);
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
            _handle.RedirectFormRtp(open, this, _staffID);
        }

        private void dtpMonthSalary_ValueChanged_1(object sender, EventArgs e)
        {
            LoadSalaryReportViewer();
        }
        private void EnableComboBox(object sender, EventArgs e)
        {
            if (rbAllStaffSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = false;
                cmbPositionSalary.Enabled = false;
                Invoke((MethodInvoker)delegate {
                    LoadSalaryReportViewer();
                });
            }
            else if (rbDepartmentSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = true;
                cmbPositionSalary.Enabled = true;
                Invoke((MethodInvoker)delegate {
                    LoadSalaryReportViewer();
                });
            }

            else if (rbPositionSalary.Checked)
            {
                cmbDepartmentSalary.Enabled = true;
                cmbPositionSalary.Enabled = true;
                Invoke((MethodInvoker)delegate {
                    LoadSalaryReportViewer();
                });
            }
        }

        private void cmbDepartmentSalary_TextChanged_1(object sender, EventArgs e)
        {
            LoadPositonByDepartment(cmbDepartmentSalary.SelectedValue.ToString());
            if (rbDepartmentSalary.Checked)
            {
                Invoke((MethodInvoker)delegate {
                    LoadSalaryReportViewer();
                });
            }
        }

        private void cmbPositionSalary_TextChanged_1(object sender, EventArgs e)
        {
            if (rbPositionSalary.Checked)
            {
                Invoke((MethodInvoker)delegate {
                    LoadSalaryReportViewer();
                });
            }
        }
    }
}
