using CLIENT.Function;
using CLIENT.LogicTier;
using CLIENT.Models;
using CLIENT.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{
    internal class BenefitDAL
    {
        private readonly BenefitAPI _api;
        private readonly MonthSalaryDetailBUS _monthSalaryDetailBUS;
        public BenefitDAL() 
        {
            _api = new BenefitAPI();
            _monthSalaryDetailBUS = new MonthSalaryDetailBUS();
        }
        public async Task<List<Benefit>> GetAllBenefits()
        {
            string responce = await _api.GetAllBenefit();
            List<Benefit> listBenefit = JsonConvert.DeserializeObject<List<Benefit>>(responce);
            return listBenefit.ToList();
        }
        public async Task<List<CountBenefitViewModel>> GetCountBenefit()
        {
            string responce = await _api.GetCountBenefit();
            List<CountBenefitViewModel> listBenefit = JsonConvert.DeserializeObject<List<CountBenefitViewModel>>(responce);
            return listBenefit.ToList();
        }
        public async Task<List<CountBenefitViewModel>> SearchCountBenefit(string search)
        {
            string responce = await _api.SearchCountBenefit(search);
            List<CountBenefitViewModel> listBenefit = JsonConvert.DeserializeObject<List<CountBenefitViewModel>>(responce);
            return listBenefit.ToList();
        }
        public async Task<bool> CreateBenefit(Benefit benefit)
        {
            try
            {
                string responce = await _api.CreateBenefit(benefit);
                if(responce == "Success") 
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
        public async Task<bool> UpdateBenefit(Benefit benefit)
        {
            try
            {
                string responce = await _api.UpdateBenefit(benefit);
                if (responce == "Success")
                {
                    await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
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
        public async Task<bool> DeleteBenefit(string bnID)
        {
            try
            {
                string responce = await _api.DeleteBenefit(bnID);
                if (responce == "Success")
                {
                    await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
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
