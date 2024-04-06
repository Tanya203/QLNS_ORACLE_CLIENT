using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class WorkScheduleDetailBUS
    {
        private readonly WorkScheduleDetailDAL _workScheduleDetailDAL;

        public WorkScheduleDetailBUS()
        {
            _workScheduleDetailDAL = new WorkScheduleDetailDAL();
        }
        public async Task<bool> CreateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            return await _workScheduleDetailDAL.CreateWorkScheduleDetail(workScheduleDetail);
        }
    }
}
