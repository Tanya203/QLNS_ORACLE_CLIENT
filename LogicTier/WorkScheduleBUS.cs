using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using System;
using System.Collections.Generic;
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
