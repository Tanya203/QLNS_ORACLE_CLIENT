using CLIENT.Models;
using CLINET.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINET.LogicTier
{
    public class BenefitBUS
    {
        private readonly BenefitDAL benefitDAL;

        public BenefitBUS()
        {
            benefitDAL = new BenefitDAL();
        }
        public async Task<List<Benefit>> GetAllBenefits()
        {
            return await benefitDAL.GetAllBenefits();
        }
    }
}
