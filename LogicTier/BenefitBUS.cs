using CLIENT.Models;
using CLIENT.DataTier;
using System.Collections.Generic;
using System.Threading.Tasks;
using CLIENT.ViewModels;

namespace CLIENT.LogicTier
{
    public class BenefitBUS
    {
        private readonly BenefitDAL _benefitDAL;

        public BenefitBUS()
        {
            _benefitDAL = new BenefitDAL();
        }
        public async Task<List<Benefit>> GetAllBenefits()
        {
            return await _benefitDAL.GetAllBenefits();
        }
        public async Task<List<CountBenefitViewModel>> GetCountBenefit()
        {            
            return await _benefitDAL.GetCountBenefit();
        }
        public async Task<List<CountBenefitViewModel>> SearchCountBenefit(string search)
        {
            return await _benefitDAL.SearchCountBenefit(search);
        }
        public async Task<bool> CreateBenefit(Benefit benefit)
        {
            return await _benefitDAL.CreateBenefit(benefit);
        }
        public async Task<bool> UpdateBenefit(Benefit benefit)
        {
            return await _benefitDAL.UpdateBenefit(benefit);
        }
        public async Task<bool> DeleteBenefit(string bnID)
        {
            return await _benefitDAL.DeleteBenefit(bnID);
        }
    }
}
