using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{    
    public class StaffDAL
    {
        private readonly StaffAPI _api;

        public StaffDAL()
        {
            _api = new StaffAPI();
        }
        public async Task<List<Staff>> GetAllStaff()
        {
            string responce = await _api.GetAllStaff();
            List<Staff> listStaff = JsonConvert.DeserializeObject<List<Staff>>(responce);
            return listStaff.ToList();
        }
        public async Task<List<StaffInfoViewModel>> GetAllStaffInfo()
        {
            string responce = await _api.GetAllStaffInfo();
            List<StaffInfoViewModel> listStaff = JsonConvert.DeserializeObject<List<StaffInfoViewModel>>(responce);
            return listStaff.ToList();
        }
        public async Task<List<StaffInfoViewModel>> SearchStaffInfo(string search)
        {
            string responce = await _api.SearchStaffInfo(search);
            List<StaffInfoViewModel> listStaff = JsonConvert.DeserializeObject<List<StaffInfoViewModel>>(responce);
            return listStaff.ToList();
        }
        public async Task<bool> CreateStaff(Staff staff)
        {
            try
            {
                string responce = await _api.CreateStaff(staff);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
        public async Task<bool> UpdateStaff(Staff staff)
        {
            try
            {
                string responce = await _api.UpdateStaff(staff);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
        public async Task<bool> DeleteStaff(string staffID)
        {
            try
            {
                string responce = await _api.DeleteStaff(staffID);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
    }
}
