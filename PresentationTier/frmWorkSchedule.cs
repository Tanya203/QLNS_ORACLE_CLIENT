using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using MDriven.MDrivenServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmWorkSchedule : Form
    {
        private readonly StaffBUS _staffBUS;
        private readonly WorkScheduleBUS _workScheduleBUS;
        private readonly FormHandle _handle;
        private List<WorkSchedule> _listWorkSchedule;
        private readonly string _date = "dd/MM/yyyy";
        private readonly string _staffID;
        public frmWorkSchedule(string staffID)
        {
            InitializeComponent();
            _staffBUS = new StaffBUS();
            _workScheduleBUS = new WorkScheduleBUS();
            _handle = new FormHandle();
            _listWorkSchedule = new List<WorkSchedule>();
            _staffID = "S_0000000002";
        }

        private async void frmWorkSchedule_Load(object sender, EventArgs e)
        {
            Enabled = false;
            _listWorkSchedule = await _workScheduleBUS.GetAllWorkSchedule();
            nudFontSize.Invoke((MethodInvoker)(() => nudFontSize.Value = (decimal)dgvWorkSchedule.RowsDefaultCellStyle.Font.Size));
            btnAdd.Enabled = btnAutoSchedule.Enabled = false;
            LoadHeaderInfo();
            DetailButton();
            DeleteButton();
            LoadWorkSchedule();
            Enabled = true;
        }
        private async void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = await _staffBUS.GetStaffInfo(_staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
        private void LoadWorkSchedule()
        {
            dgvWorkSchedule.Invoke((MethodInvoker)(() =>
            {
                Enabled = false;
                dgvWorkSchedule.Rows.Clear();
                int rowAdd;
                foreach (WorkSchedule s in _listWorkSchedule.OrderBy(s => s.WsId))
                {
                    rowAdd = dgvWorkSchedule.Rows.Add();
                    dgvWorkSchedule.Rows[rowAdd].Cells[0].Value = s.WsId;
                    dgvWorkSchedule.Rows[rowAdd].Cells[1].Value = s.WorkDate.ToString(_date);
                }
                Enabled = true;
            }));
        }
        private void SearchWorkSchedule(string search)
        {
            dgvWorkSchedule.Invoke((MethodInvoker)( async() =>
            {
                Enabled = false;
                dgvWorkSchedule.Rows.Clear();
                int rowAdd;
                List<WorkSchedule> workSchedules = await _workScheduleBUS.SearchWorkSchedule(search);
                foreach (WorkSchedule s in workSchedules.OrderBy(s => s.WsId))
                {
                    rowAdd = dgvWorkSchedule.Rows.Add();
                    dgvWorkSchedule.Rows[rowAdd].Cells[0].Value = s.WsId;
                    dgvWorkSchedule.Rows[rowAdd].Cells[1].Value = s.WorkDate.ToString(_date);
                }
                Enabled = true;
            }));
        }
        private void Reload()
        {
            frmWorkSchedule open = new frmWorkSchedule(_staffID);
            _handle.RedirectForm(open, this);
        }
        private void DetailButton()
        {
            dgvWorkSchedule.Invoke((MethodInvoker)(async () =>
            {
                DataGridViewButtonColumn btnChiTiet = new DataGridViewButtonColumn();
                {
                    btnChiTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    btnChiTiet.Text = "Chi tiết";
                    btnChiTiet.UseColumnTextForButtonValue = true;
                    btnChiTiet.FlatStyle = FlatStyle.Popup;
                    var buttonCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = SystemColors.ScrollBar,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    btnChiTiet.DefaultCellStyle = buttonCellStyle;
                    dgvWorkSchedule.Columns.Add(btnChiTiet);
                }
            }));
             
        }
        private void DeleteButton()
        {
            dgvWorkSchedule.Invoke((MethodInvoker)(() =>
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                {
                    btnXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    btnXoa.Text = "Xoá";
                    btnXoa.UseColumnTextForButtonValue = true;
                    btnXoa.FlatStyle = FlatStyle.Popup;
                    var buttonCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = SystemColors.ScrollBar,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    };
                    btnXoa.DefaultCellStyle = buttonCellStyle;
                    dgvWorkSchedule.Columns.Add(btnXoa);
                }
            }));            
        }
        private void OpenWorkScheduleDetail(string wsID)
        {
            frmWorkScheduleDetail open = new frmWorkScheduleDetail(_staffID, wsID);
            _handle.RedirectForm(open, this);
        }
        private async void DeleteWorkSchedule(string wsID, string workDate)
        {
            try
            {
                if (_listWorkSchedule.FirstOrDefault(s => s.WsId == wsID).WorkDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Không thể xoá lịch trong quá khứ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CustomMessage.YesNoCustom("Xác nhận", "Huỷ");
                DialogResult result = MessageBox.Show($"Xác nhận lịch làm việc ngày {workDate}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _workScheduleBUS.DeleteWorkSchedule(wsID);
                    Reload();
                }
            }
            catch(Exception ex) 
            { 
                CustomMessage.ExecptionCustom(ex);
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                await _workScheduleBUS.AutoScheduleDate(dtpWorkDate.Value.Date);
                Reload();
            }
            catch(Exception ex) 
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }

        private async void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                await _workScheduleBUS.AutoSchedule(dtpMonth.Text);
                Reload();
            }
            catch(Exception ex) 
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchWorkSchedule(txtSearch.Text);
        }

        private void dtpWorkDate_ValueChanged(object sender, EventArgs e)
        {
            if (_listWorkSchedule.FirstOrDefault(s => s.WorkDate == dtpWorkDate.Value.Date) != null ||
                dtpWorkDate.Value < DateTime.Now)
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            int month = dtpMonth.Value.Month;
            int year = dtpMonth.Value.Year;
            if(_listWorkSchedule.FirstOrDefault(s => s.WorkDate.Month == month && s.WorkDate.Year == year) != null ||
                month < DateTime.Now.Month && year <= DateTime.Now.Year)
                btnAutoSchedule.Enabled = false;
            else
                btnAutoSchedule.Enabled = true;
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            int fontSize = (int)nudFontSize.Value;
            dgvWorkSchedule.RowsDefaultCellStyle.Font = new Font(dgvWorkSchedule.Font.FontFamily, fontSize);
        }

        private void dgvWorkSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            string wsID = dgvWorkSchedule.Rows[rowIndex].Cells[0].Value.ToString();
            string workDate = dgvWorkSchedule.Rows[rowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex == 2)
                OpenWorkScheduleDetail(wsID);
            if (e.ColumnIndex == 3)
                DeleteWorkSchedule(wsID, workDate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain open = new frmMain(_staffID);
            _handle.RedirectForm(open, this);
        }
    }
}
