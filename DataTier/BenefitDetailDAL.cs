using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{
    public class BenefitDetailDAL
    {
        private readonly BenefitDetailApi _api;
        private readonly MonthSalaryDetailBUS _monthSalaryDetailBUS;
        public BenefitDetailDAL()
        {
            _api = new BenefitDetailApi();
        }
        public async Task<List<BenefitDetail>> GetAllBenefitsDetail()
        {
            string responce = await _api.GetAllBenefitDetail();
            List<BenefitDetail> listBenefitDeatail = JsonConvert.DeserializeObject<List<BenefitDetail>>(responce);
            return listBenefitDeatail.ToList();
        }
        public async Task<List<StaffBenefitDetailViewModel>> GetStaffBenefitsDetail()
        {
            string responce = await _api.GetStaffBenefitDetail();
            List<StaffBenefitDetailViewModel> listBenefitDeatail = JsonConvert.DeserializeObject<List<StaffBenefitDetailViewModel>>(responce);
            return listBenefitDeatail.ToList();
        }
        public async Task<List<StaffBenefitDetailViewModel>> SearchStaffBenefitsDetail(string search)
        {
            string responce = await _api.SearchStaffBenefitDetail(search);
            List<StaffBenefitDetailViewModel> listBenefitDeatail = JsonConvert.DeserializeObject<List<StaffBenefitDetailViewModel>>(responce);
            return listBenefitDeatail.ToList();
        }
        public async Task<bool> CreateBenefitDetail(List<BenefitDetail> createList)
        {
            try
            {
                foreach (BenefitDetail staff in createList)
                    await _api.CreateBenefitDetail(staff);
                await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
                return true;
               
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
        public async Task<bool> DeleteBenefitDetail(List<BenefitDetail> deleteList)
        {
            try
            {
                foreach(BenefitDetail staff in deleteList)
                    await _api.DeleteBenefitDetail(staff.BnId, staff.StaffId);
                await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
                return true;
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
    }
}
