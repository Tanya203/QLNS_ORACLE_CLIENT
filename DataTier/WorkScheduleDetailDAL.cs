using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
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
    public class WorkScheduleDetailDAL
    {
        private readonly WorkScheduleDetailApi _api;
        private readonly MonthSalaryDetailBUS _monthSalaryDetailBUS;

        public WorkScheduleDetailDAL()
        {
            _api = new WorkScheduleDetailApi();
            _monthSalaryDetailBUS = new MonthSalaryDetailBUS();
        }
        public async Task<List<WorkScheduleDetail>> GetAllWorkScheduleDetail()
        {
            string responce = await _api.GetAllWorkScheduleDetail();
            List<WorkScheduleDetail> listWorkScheduleDetai = JsonConvert.DeserializeObject<List<WorkScheduleDetail>>(responce);
            return listWorkScheduleDetai.ToList();
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> GetWorkScheduleDetailById(string id)
        {
            string responce = await _api.GetWorkScheduleDetailById(id);
            List<StaffWorkScheduleDetailViewModel> listWorkScheduleDetai = JsonConvert.DeserializeObject<List<StaffWorkScheduleDetailViewModel>>(responce);
            return listWorkScheduleDetai.ToList();
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> SearchWorkScheduleDetailById(string id, string search)
        {
            string responce = await _api.SearchWorkScheduleDetailById(id, search);
            List<StaffWorkScheduleDetailViewModel> listWorkScheduleDetai = JsonConvert.DeserializeObject<List<StaffWorkScheduleDetailViewModel>>(responce);
            return listWorkScheduleDetai.ToList();
        }
        public async Task<bool> CreateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            try
            {
                string responce = await _api.CreateWorkScheduleDetail(workScheduleDetail);
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
        public async Task<bool> UpdateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            try
            {
                string responce = await _api.UpdateWorkScheduleDetail(workScheduleDetail);
                if(responce == "Success")
                {
                    await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
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
