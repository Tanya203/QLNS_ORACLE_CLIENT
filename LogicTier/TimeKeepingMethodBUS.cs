using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class TimeKeepingMethodBUS
    {
        private readonly TimeKeepingMethodDAL _timeKeepingMethodDAL;
        public TimeKeepingMethodBUS()
        {
            _timeKeepingMethodDAL = new TimeKeepingMethodDAL();
        }
        public async Task<List<TimeKeepingMethod>> GetAllTimeKeepingMethod()
        {
            return await _timeKeepingMethodDAL.GetAllTimeKeepingMethod();
        }
    }
}
