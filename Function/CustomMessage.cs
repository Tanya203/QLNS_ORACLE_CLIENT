using System;
using System.Windows.Forms;
using WECPOFLogic;


namespace CLIENT.Function
{
    public class CustomMessage
    {
        public static void YesNoCustom(string yes, string no)
        {
            MessageBoxManager.Yes = yes;
            MessageBoxManager.No = no;
            MessageBoxManager.Register_OnceOnly();
        }
        public static void ExecptionCustom(Exception ex)
        {
            MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message, "UNEXPECTED ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
