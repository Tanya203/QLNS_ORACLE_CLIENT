using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.Models;
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
            List<TimeKeeping> listBenefit = JsonConvert.DeserializeObject<List<TimeKeeping>>(responce);
            return listBenefit.ToList();
        }
        public async Task<List<TimeKeeping>> GetStaffTimeKeepingById(string wsId)
        {
            string responce = await _api.GetStaffTimeKeepingById(wsId);
            List<TimeKeeping> listBenefit = JsonConvert.DeserializeObject<List<TimeKeeping>>(responce);
            return listBenefit.ToList();
        }
        public async Task<List<TimeKeeping>> SearchStaffTimeKeepinById(string wsId, string search)
        {
            string responce = await _api.SearchStaffTimeKeepinById(wsId, search);
            List<TimeKeeping> listBenefit = JsonConvert.DeserializeObject<List<TimeKeeping>>(responce);
            return listBenefit.ToList();
        }
        public async Task<bool> CreateTimeKeeping(TimeKeeping timeKeeping)
        {
            try
            {
                string responce = await _api.CreateTimeKeeping(timeKeeping);
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
        public async Task<bool> DeleteTimeKeeping(string wsID, string staffID, string shiftID)
        {
            try
            {
                string responce = await _api.DeleteTimeKeeping(wsID, staffID, shiftID);
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
