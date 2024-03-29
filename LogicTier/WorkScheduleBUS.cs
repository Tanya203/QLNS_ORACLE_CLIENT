using CLIENT.DataTier;
using CLIENT.DataTier.Models;
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
        public async Task<List<WorkSchedule>> SearchWorkSchedule(string search)
        {
            return await _workScheduleDAL.SearchWorkSchedule(search);
        }
        public async Task<bool> AutoSchedule(string month)
        {
            return await _workScheduleDAL.AutoSchedule(month);
        }
        public async Task<bool> CreateWorkSchedule(WorkSchedule workSchedule)
        {
            return await _workScheduleDAL.CreateWorkSchedule(workSchedule);
        }
        public async Task<bool> DeleteBenefit(string wsID)
        {
            return await _workScheduleDAL.DeleteBenefit(wsID);
        }
    }
}
