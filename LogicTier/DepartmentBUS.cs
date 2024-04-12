using CLIENT.DataTier.Models;
using CLIENT.DataTier;
using System.Collections.Generic;
using System.Threading.Tasks;
using CLIENT.ViewModels;

namespace CLIENT.LogicTier
{
    public class DepartmentBUS
    {
        private readonly DepartmentDAL _departmentDAL;
        public DepartmentBUS()
        {
            _departmentDAL = new DepartmentDAL();
        }
        public async Task<List<Department>> GetAllDepartment()
        {
            return await _departmentDAL.GetAllDepartment();
        }
        public async Task<List<DepartmentDetailViewModel>> GetDepartmentDetail()
        {
            return await _departmentDAL.GetDepartmentDetail();
        }
        public async Task<List<DepartmentDetailViewModel>> SearchDepartmentDetail(string search)
        {
            return await _departmentDAL.SearchDepartmentDetail(search);
        }
        public async Task<bool> CreateDepartment(Department department)
        {
            return await _departmentDAL.CreateDepartment(department);
        }
        public async Task<bool> UpdateDepartment(Department department)
        {
            return await _departmentDAL.UpdateDepartment(department);
        }
        public async Task<bool> DeleteDepartment(string dpID)
        {
            return await _departmentDAL.DeleteDepartment(dpID);
        }
    }
}
