using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.Models;
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
    public class TimeKeepingDAL
    {
        private readonly TimeKeepingApi _api;
        public TimeKeepingDAL()
        {
            _api = new TimeKeepingApi();
        }
        public async Task<List<TimeKeeping>> GetAllTimeKeeping()
        {
            string responce = await _api.GetAllTimeKeeping();
            List<TimeKeeping> listWorkScheduleDetail = JsonConvert.DeserializeObject<List<TimeKeeping>>(responce);
            return listWorkScheduleDetail.ToList();
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> GetStaffTimeKeepingById(string wsId)
        {
            string responce = await _api.GetStaffTimeKeepingById(wsId);
            List<StaffWorkScheduleDetailViewModel> listWorkScheduleDetail = JsonConvert.DeserializeObject<List<StaffWorkScheduleDetailViewModel>>(responce);
            return listWorkScheduleDetail.ToList();
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> SearchStaffTimeKeepinById(string wsId, string search)
        {
            string responce = await _api.SearchStaffTimeKeepinById(wsId, search);
            List<StaffWorkScheduleDetailViewModel> listWorkScheduleDetail = JsonConvert.DeserializeObject<List<StaffWorkScheduleDetailViewModel>>(responce);
            return listWorkScheduleDetail.ToList();
        }
        public async Task<bool> CreateTimeKeeping(List<TimeKeeping> timeKeeping)
        {
            try
            {
                string responce = "";
                foreach (TimeKeeping staff in timeKeeping)
                {
                    responce = await _api.CreateTimeKeeping(staff);
                }
                if (responce == "Success")
                    return true;
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
        public async Task<bool> TimeKeeping(string staffID)
        {
            try
            {
                string responce = await _api.TimeKeeping(staffID);
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
        public async Task<bool> DeleteTimeKeeping(List<TimeKeeping> timeKeeping)
        {
            try
            {
                string responce = "";
                foreach (TimeKeeping staff in timeKeeping)
                    responce = await _api.DeleteTimeKeeping(staff.WsId, staff.StaffId, staff.ShiftId);
                if (responce == "Success")
                    return true;
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
