using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class ContractTypeBUS
    {
        private readonly ContractTypeDAL _contractTypeDAL;
        public ContractTypeBUS()
        {
            _contractTypeDAL = new ContractTypeDAL();
        }
        public async Task<List<ContractType>> GetAllContractType()
        {
            return await _contractTypeDAL.GetAllContractType();
        }
        public async Task<List<ContractTypeDetailViewModel>> GetContractTypeDetail()
        {
            return await _contractTypeDAL.GetContractTypeDetail();
        }
        public async Task<List<ContractTypeDetailViewModel>> SearchContractTypeDetail(string search)
        {
            return await _contractTypeDAL.SearchContractTypeDetail(search);
        }
        public async Task<bool> CreateContractType(ContractType contractType)
        {
            return await _contractTypeDAL.CreateContractType(contractType);
        }
        public async Task<bool> UpdateContractType(ContractType contractType)
        {
            return await _contractTypeDAL.UpdateContractType(contractType);
        }
        public async Task<bool> DeleteContractType(string ctID)
        {
            return await _contractTypeDAL.DeleteContractType(ctID);
        }
    }
}
