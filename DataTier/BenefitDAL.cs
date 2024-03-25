using CLIENT;
using CLIENT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINET.DataTier
{
    internal class BenefitDAL
    {
        private readonly BenefitAPI api;

        public BenefitDAL()
        {
            api = new BenefitAPI();
        }
        public async Task<List<Benefit>> GetAllBenefits()
        {
            var responce = await BenefitAPI.GetAllBenefit();
            List<Benefit> listBenefit = JsonConvert.DeserializeObject<List<Benefit>>(responce);
            return listBenefit.ToList();
        }
    }
}
