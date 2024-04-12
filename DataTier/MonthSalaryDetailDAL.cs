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
    public class MonthSalaryDetailDAL
    {
        private readonly MonthSalaryDetailAPI _api;
        public MonthSalaryDetailDAL()
        {
            _api = new MonthSalaryDetailAPI();
        }
        public async Task<List<MonthlySalaryStatisticsViewModels>> GetMonthSalary(string month)
        {
            string responce = await _api.GetMonthSalary(month);
            List<MonthlySalaryStatisticsViewModels> salary = JsonConvert.DeserializeObject<List<MonthlySalaryStatisticsViewModels>>(responce);
            return salary.ToList();
        }
        public async Task<bool> CreateMonthSalaryDetail(MonthSalaryDetail monthSalaryDetail)
        {
            try
            {
                string responce = await _api.CreateMonthSalaryDetail(monthSalaryDetail);
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
        public async Task<bool> UpdateMonthSalaryDetail(string month)
        {
            try
            {
                string responce = await _api.UpdateMonthSalaryDetail(month);
                if (responce == "Success")
                    return true;
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
    }
}
