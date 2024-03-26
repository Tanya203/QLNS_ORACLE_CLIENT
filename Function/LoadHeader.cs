using CLIENT.DataTier.Models;
using System.Windows.Forms;

namespace CLIENT.Function
{
    public class LoadHeader
    {
        public LoadHeader() { }
        public static void LoadHeaderMainMenu(Label staffID, Label fullName, Label department, Label position, Label dayOffAmount, Staff staff)
        {
            /*staffID.Text = staff.StaffId;
            fullName.Text = StringAdjust.AddSpacesBetweenUppercaseLetters($"{staff.LastName}{staff.MiddleName}{staff.FirstName}");
            department.Text = staff.Position.Department.DepartmentName;
            position.Text = staff.Position.PositionName;
            dayOffAmount.Text = staff.DayOffAmount.ToString();*/
        }
        public static void LoadHeaderInfo(Label staffID, Label fullName, Label department, Label position, Staff staff)
        {
            /*staffID.Text = staff.StaffID;
            fullName.Text = StringAdjust.AddSpacesBetweenUppercaseLetters($"{staff.LastName}{staff.MiddleName}{staff.FirstName}");
            department.Text = staff.Position.Department.DepartmentName;
            position.Text = staff.Position.PositionName;*/
        }
    }
}
