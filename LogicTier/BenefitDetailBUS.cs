using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using CLIENT.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class BenefitDetailBUS
    {
        private readonly BenefitDetailDAL _benefitDetailDAL;

        public BenefitDetailBUS()
        {
            _benefitDetailDAL = new BenefitDetailDAL();
        }
        public async Task<List<BenefitDetail>> GetAllBenefitsDetail()
        {
            return await _benefitDetailDAL.GetAllBenefitsDetail();
        }
        public async Task<List<StaffBenefitDetailViewModel>> GetStaffBenefitsDetail()
        {
            return await _benefitDetailDAL.GetStaffBenefitsDetail();
        }
        public async Task<List<StaffBenefitDetailViewModel>> SearchStaffBenefitsDetail(string search)
        {
            return await _benefitDetailDAL.SearchStaffBenefitsDetail(search);
        }
        public async Task<bool> CreateBenefitDetail(List<BenefitDetail> createList)
        {
            return await _benefitDetailDAL.CreateBenefitDetail(createList);
        }
        public async Task<bool> DeleteBenefitDetail(List<BenefitDetail> deleteList)
        {
            return await _benefitDetailDAL.DeleteBenefitDetail(deleteList);
        }
    }
}
