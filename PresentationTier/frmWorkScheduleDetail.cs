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

namespace CLIENT.PresentationTier
{
    public partial class frmWorkScheduleDetail : Form
    {
        private readonly StaffBUS _staffBUS;
        private List<StaffInfoViewModel> _listStaffInfo;
        private readonly string staffID;
        public frmWorkScheduleDetail(string wsID, string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
        }

        private void frmWorkScheduleDetail_Load(object sender, EventArgs e)
        {

        }
        private void LoadHeaderInfo()
        {
            StaffInfoViewModel staff = _listStaffInfo.FirstOrDefault(s => s.StaffId == staffID);
            LoadHeader.LoadHeaderInfo(lblStaffIDLoginValue, lblFullNameLoginValue, lblDepartmentLoginValue, lblPositionLoginValue, staff);
        }
    }
}
