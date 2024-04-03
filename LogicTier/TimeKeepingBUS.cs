using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class TimeKeepingBUS
    {
        private readonly TimeKeepingDAL _timeKeepingDAL;
        public TimeKeepingBUS()
        {
            _timeKeepingDAL = new TimeKeepingDAL();
        }
        public async Task<List<TimeKeeping>> GetAllTimeKeeping()
        {
            return await _timeKeepingDAL.GetAllTimeKeeping();
        }
        public async Task<List<TimeKeeping>> GetStaffTimeKeepingById(string wsId)
        {
            return await _timeKeepingDAL.GetStaffTimeKeepingById(wsId);
        }
        public async Task<List<TimeKeeping>> SearchStaffTimeKeepinById(string wsId, string search)
        {
            return await _timeKeepingDAL.SearchStaffTimeKeepinById(wsId, search);
        }
        public async Task<bool> CreateTimeKeeping(TimeKeeping timeKeeping)
        {
            return await _timeKeepingDAL.CreateTimeKeeping(timeKeeping);
        }
        public async Task<bool> TimeKeeping(string staffID)
        {
            return await _timeKeepingDAL.TimeKeeping(staffID);
        }
        public async Task<bool> DeleteTimeKeeping(string wsID, string staffID, string shiftID)
        {
            return await _timeKeepingDAL.DeleteTimeKeeping(wsID, staffID, shiftID);
        }
    }
}
