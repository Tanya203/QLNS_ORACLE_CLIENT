using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{
    public class WorkScheduleDAL
    {
        private readonly WorkScheduleAPI _api;
        public WorkScheduleDAL()
        {
            _api = new WorkScheduleAPI();
        }
        public async Task<List<WorkSchedule>> GetAllWorkSchedule()
        {
            string responce = await _api.GetAllWorkSchedule();
            List<WorkSchedule> listWorkSchedule = JsonConvert.DeserializeObject<List<WorkSchedule>>(responce);
            return listWorkSchedule.ToList();
        }
        public async Task<WorkSchedule> GetWorkScheduleInfo(string wsID)
        {
            string responce = await _api.GetAllWorkSchedule();
            List<WorkSchedule> listWorkSchedule = JsonConvert.DeserializeObject<List<WorkSchedule>>(responce);
            WorkSchedule info = listWorkSchedule.FirstOrDefault(s => s.WsId == wsID);
            return info;
        }
        public async Task<List<WorkSchedule>> SearchWorkSchedule(string search)
        {
            string responce = await _api.SearchWorkSchedule(search);
            List<WorkSchedule> listWorkSchedule = JsonConvert.DeserializeObject<List<WorkSchedule>>(responce);
            return listWorkSchedule.ToList();
        }
        public async Task<List<MonthlySalaryStatisticsViewModels>> GetMonthSalary(string month)
        {
            string responce = await _api.GetMonthSalary(month);
            List<MonthlySalaryStatisticsViewModels> salary = JsonConvert.DeserializeObject<List<MonthlySalaryStatisticsViewModels>>(responce);
            return salary.ToList();
        }
        public async Task<bool> AutoSchedule(string month)
        {
            try
            {
                string responce = await _api.AutoSchedule(month);
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
        public async Task<bool> AutoScheduleDate(DateTime date)
        {
            try
            {
                string responce = await _api.AutoScheduleDate(date);
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
        public async Task<bool> DeleteWorkSchedule(string wsID)
        {
            try
            {
                string responce = await _api.DeleteWorkSchedule(wsID);
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
