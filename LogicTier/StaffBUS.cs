using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class StaffBUS
    {
        private readonly StaffDAL _staffDAL;

        public StaffBUS()
        {
            _staffDAL = new StaffDAL(); 
        }
        public async Task<List<Staff>> GetAllStaff()
        {
            return await _staffDAL.GetAllStaff();
        }
        public async Task<List<StaffInfoViewModel>> GetAllStaffInfo()
        {
            return await _staffDAL.GetAllStaffInfo();
        }
        public async Task<List<StaffInfoViewModel>> SearchStaffInfo(string search)
        {
            return await _staffDAL.SearchStaffInfo(search);
        }
        public async Task<bool> CreateStaff(Staff staff)
        {
            return await _staffDAL.CreateStaff(staff);
        }
        public async Task<bool> UpdateStaff(Staff staff)
        {
            return await _staffDAL.UpdateStaff(staff);
        }
        public async Task<bool> DeleteStaff(string staffID)
        {
            return await _staffDAL.DeleteStaff(staffID);
        }
    }
}
