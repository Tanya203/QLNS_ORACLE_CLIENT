using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Windows.Forms;

namespace CLIENT.Function
{
    public class LoadHeader
    {
        public LoadHeader() { }
        public static void LoadHeaderMainMenu(Label staffID, Label fullName, Label department, Label position, Label dayOffAmount, StaffInfoViewModel staff)
        {
            /*staffID.Text = staff.StaffId;
            fullName.Text = staff.FullName;
            department.Text = staff.DepartmentName;
            position.Text = staff.PositionName;
            dayOffAmount.Text = */
        }
        public static void LoadHeaderInfo(Label staffID, Label fullName, Label department, Label position, StaffInfoViewModel staff)
        {
            staffID.Invoke((MethodInvoker)(() => staffID.Text = staff.StaffId));
            fullName.Invoke((MethodInvoker)(() => fullName.Text = staff.FullName));
            department.Invoke((MethodInvoker)(() => department.Text = staff.DepartmentName));
            position.Invoke((MethodInvoker)(() => position.Text = staff.PositionName));
        }
    }
}
