using CLIENT.Function;
using CLIENT.LogicTier;
using System;
using System.Windows.Forms;

namespace CLIENT.PresentationTier
{
    public partial class frmTimeKeeping : Form
    {
        private readonly TimeKeepingBUS timeKeepingBUS;
        public frmTimeKeeping()
        {
            InitializeComponent();
            timeKeepingBUS = new TimeKeepingBUS();
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStaffID.Text))
                btnTimekeeping.Enabled = false;
            else
                btnTimekeeping.Enabled = true;
        }

        private async void btnTimekeeping_Click(object sender, EventArgs e)
        {
            try
            {
                await timeKeepingBUS.TimeKeeping(txtStaffID.Text);
                txtStaffID.Text = string.Empty;
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
            }
        }
    }
}
