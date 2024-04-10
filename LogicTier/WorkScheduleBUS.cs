using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class WorkScheduleBUS
    {
        private readonly WorkScheduleDAL _workScheduleDAL;
        public WorkScheduleBUS()
        {
            _workScheduleDAL = new WorkScheduleDAL();
        }
        public async Task<List<WorkSchedule>> GetAllWorkSchedule()
        {
            return await _workScheduleDAL.GetAllWorkSchedule();
        }
        public async Task<WorkSchedule> GetWorkScheduleInfo(string wsID)
        {
            return await _workScheduleDAL.GetWorkScheduleInfo(wsID);
        }
        public async Task<List<WorkSchedule>> SearchWorkSchedule(string search)
        {
            return await _workScheduleDAL.SearchWorkSchedule(search);
        }
        public async Task<List<MonthlySalaryStatisticsViewModels>> GetMonthSalary(string month)
        {
            return await _workScheduleDAL.GetMonthSalary(month);
        }
        public async Task<bool> AutoSchedule(string month)
        {
            return await _workScheduleDAL.AutoSchedule(month);
        }
        public async Task<bool> AutoScheduleDate(DateTime date)
        {
            return await _workScheduleDAL.AutoScheduleDate(date);
        }
        public async Task<bool> DeleteWorkSchedule(string wsID)
        {
            return await _workScheduleDAL.DeleteWorkSchedule(wsID);
        }
    }
}
