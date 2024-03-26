using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.DataTier
{
    public class TimeKeepingMethodDAL
    {
        private readonly TimeKeepingMethodApi _api;
        public TimeKeepingMethodDAL()
        {
            _api = new TimeKeepingMethodApi();
        }
        public async Task<List<TimeKeepingMethod>> GetAllTimeKeepingMethod()
        {
            string responce = await _api.GetAllTimeKeepingMethod();
            List<TimeKeepingMethod> listTimeKeeping = JsonConvert.DeserializeObject<List<TimeKeepingMethod>>(responce);
            return listTimeKeeping.ToList();
        }
    }
}
