using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{
    public class ContractTypeDAL
    {
        private readonly ContractTypeAPI _api;
        public ContractTypeDAL()
        {
            _api = new ContractTypeAPI();
        }
        public async Task<List<ContractType>> GetAllContractType()
        {
            string responce = await _api.GetAllContractType();
            List<ContractType> listDepartment = JsonConvert.DeserializeObject<List<ContractType>>(responce);
            return listDepartment.ToList();
        }
        public async Task<List<ContractTypeDetailViewModel>> GetContractTypeDetail()
        {
            string responce = await _api.GetContractTypeDetail();
            List<ContractTypeDetailViewModel> listDepartment = JsonConvert.DeserializeObject<List<ContractTypeDetailViewModel>>(responce);
            return listDepartment.ToList();
        }
        public async Task<List<ContractTypeDetailViewModel>> SearchContractTypeDetail(string search)
        {
            string responce = await _api.SearchContractTypeDetail(search);
            List<ContractTypeDetailViewModel> listDepartment = JsonConvert.DeserializeObject<List<ContractTypeDetailViewModel>>(responce);
            return listDepartment.ToList();
        }
        public async Task<bool> CreateContractType(ContractType contractType)
        {
            try
            {
                string responce = await _api.CreateContractType(contractType);
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
        public async Task<bool> UpdateContractType(ContractType contractType)
        {
            try
            {
                string responce = await _api.UpdateContractType(contractType);
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
        public async Task<bool> DeleteContractType(string ctID)
        {
            try
            {
                string responce = await _api.DeleteContractType(ctID);
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
