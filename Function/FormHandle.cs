using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.Function
{
    public class FormHandle
    {
        private Form open;
        public bool RedirectForm(Form open, Form close)
        {
            try
            {
                this.open = open;
                close.Close();
                Application.ExitThread();
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
            Application.Run(open);
        }
    }
}

