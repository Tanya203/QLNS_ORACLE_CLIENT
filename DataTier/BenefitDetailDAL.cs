using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
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
        public async Task<bool> CreateBenefitDetail(BenefitDetail benefitDetail)
        {
            try
            {
                string responce = await _api.CreateBenefitDetail(benefitDetail);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
        public async Task<bool> UpdateBenefitDetail(BenefitDetail benefitDetail)
        {
            try
            {
                string responce = await _api.UpdateBenefitDetail(benefitDetail);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
        public async Task<bool> DeleteBenefitDetail(string bnID, string staffID)
        {
            try
            {
                string responce = await _api.DeleteBenefitDetail(bnID, staffID);
                if (responce == "Success")
                {
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show(responce, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return false;
            }
        }
    }
}
