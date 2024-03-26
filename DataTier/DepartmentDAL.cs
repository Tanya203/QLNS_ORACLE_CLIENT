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
    public class DepartmentDAL
    {
        private readonly DepartmentAPI _api;

        public DepartmentDAL()
        {
            _api = new DepartmentAPI();
        }
        public async Task<List<Department>> GetAllDepartment()
        {
            string responce = await _api.GetAllDepartment();
            List<Department> listDepartment = JsonConvert.DeserializeObject<List<Department>>(responce);
            return listDepartment.ToList();
        }
        public async Task<List<DepartmentDetailViewModel>> GetDepartmentDetail()
        {
            string responce = await _api.GetDepartmentDetail();
            List<DepartmentDetailViewModel> listDepartment = JsonConvert.DeserializeObject<List<DepartmentDetailViewModel>>(responce);
            return listDepartment.ToList();
        }
        public async Task<List<DepartmentDetailViewModel>> SearchDepartmentDetail(string search)
        {
            string responce = await _api.SearchDepartmentDetail(search);
            List<DepartmentDetailViewModel> listDepartment = JsonConvert.DeserializeObject<List<DepartmentDetailViewModel>>(responce);
            return listDepartment.ToList();
        }
        public async Task<bool> CreateDepartment(Department department)
        {
            try
            {
                string responce = await _api.CreateDepartment(department);
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
        public async Task<bool> UpdateDepartment(Department department)
        {
            try
            {
                string responce = await _api.UpdateDepartment(department);
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
        public async Task<bool> DeleteDepartment(string dpID)
        {
            try
            {
                string responce = await _api.DeleteDepartment(dpID);
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
