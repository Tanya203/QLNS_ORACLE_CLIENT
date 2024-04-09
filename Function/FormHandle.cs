using CLIENT.PresentationTier;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CLIENT.Function
{
    public class FormHandle
    {
        private Form open;
        private string _staffID;
        public bool RedirectForm(Form open, Form close)
        {
            try
            {
                this.open = open;
                close.Invoke((Action)delegate { close.Close(); });
                Application.Exit();
                Thread newThread = new Thread(OpenForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void OpenForm()
        {
            try
            {
                Application.Run(open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool RedirectFormRtp(Form open, Form close, string staffID)
        {
            try
            {
                _staffID = staffID;
                this.open = open;
                close.Invoke((Action)delegate { close.Close(); });
                Application.Exit();
                Thread newThread = new Thread(OpenFormSalary);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void OpenFormSalary()
        {
            Application.Run(new frmStatistic(_staffID));
        }
    }
}

