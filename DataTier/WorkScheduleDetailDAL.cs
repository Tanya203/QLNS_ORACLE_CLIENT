using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.Models;
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

        public WorkScheduleDetailDAL()
        {
            _api = new WorkScheduleDetailApi();
        }

        public async Task<bool> CreateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            try
            {
                string responce = await _api.CreateWorkScheduleDetail(workScheduleDetail);
                if (responce == "Success")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
    }
}
