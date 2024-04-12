using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class MonthSalaryDetailBUS
    {
        private readonly MonthSalaryDetailDAL _monthSalaryDetailDAL;
        public MonthSalaryDetailBUS()
        {
            _monthSalaryDetailDAL = new MonthSalaryDetailDAL();
        }
        public async Task<List<MonthlySalaryStatisticsViewModels>> GetMonthSalary(string month)
        {
            return await _monthSalaryDetailDAL.GetMonthSalary(month);
        }
        public async Task<bool> CreateMonthSalaryDetail(MonthSalaryDetail monthSalaryDetail)
        {
            return await _monthSalaryDetailDAL.CreateMonthSalaryDetail(monthSalaryDetail);
        }
        public async Task<bool> UpdateMonthSalaryDetail(string month)
        {
            return await _monthSalaryDetailDAL.UpdateMonthSalaryDetail(month);
        }
    }
}
