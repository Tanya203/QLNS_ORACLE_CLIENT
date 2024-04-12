using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using CLIENT.LogicTier;
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
    public class StaffDAL
    {
        private readonly StaffAPI _api;
        private readonly MonthSalaryDetailBUS _monthSalaryDetailBUS;
        private int _count;
        public StaffDAL()
        {
            _api = new StaffAPI();
            _monthSalaryDetailBUS = new MonthSalaryDetailBUS();
            _count = 0;
        }
        public async Task<List<Staff>> GetAllStaff()
        {
            string responce = await _api.GetAllStaff();
            List<Staff> listStaff = JsonConvert.DeserializeObject<List<Staff>>(responce);
            return listStaff.ToList();
        }
        public async Task<Staff> GetStaff(string staffID)
        {
            string responce = await _api.GetAllStaff();
            List<Staff> listStaff = JsonConvert.DeserializeObject<List<Staff>>(responce);
            Staff staff = listStaff.FirstOrDefault(s => s.StaffId == staffID);
            return staff;
        }
        public async Task<List<StaffInfoViewModel>> GetAllStaffInfo()
        {
            string responce = await _api.GetAllStaffInfo();
            List<StaffInfoViewModel> listStaff = JsonConvert.DeserializeObject<List<StaffInfoViewModel>>(responce);
            return listStaff.ToList();
        }
        public async Task<List<StaffInfoViewModel>> SearchStaffInfo(string search)
        {
            string responce = await _api.SearchStaffInfo(search);
            List<StaffInfoViewModel> listStaff = JsonConvert.DeserializeObject<List<StaffInfoViewModel>>(responce);
            return listStaff.ToList();
        }
        public async Task<StaffInfoViewModel> GetStaffInfo(string staffID)
        {
            string responce = await _api.GetAllStaffInfo();
            List<StaffInfoViewModel> listStaff = JsonConvert.DeserializeObject<List<StaffInfoViewModel>>(responce);
            StaffInfoViewModel info = listStaff.FirstOrDefault(s => s.StaffId == staffID);
            return info;
        }
        public async Task<string> LoginVerify(string account, string password)
        {
            try
            {
                string responce = await _api.GetAllStaff();
                List<Staff> listStaff = JsonConvert.DeserializeObject<List<Staff>>(responce);
                Staff info = listStaff.FirstOrDefault(s => s.Account == account);
                if(info == null)
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    if(info.LockDate != null && info.LockDate > DateTime.Now)
                    {
                        MessageBox.Show($"Tài khoản đang bị khoá đến {info.LockDate}! Liên hệ phòng kỹ thuật để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    else if(!BCrypt.Net.BCrypt.Verify(password, info.Password))
                    {
                        _count++;
                        if (_count == 3)
                        {
                            info.LockDate = DateTime.Now.AddMinutes(30);
                            await _api.UpdateStaff(info);
                            MessageBox.Show($"Nhập sai mật khẩu lần thứ {_count}! Tài khoản đã bị khoá đến{info.LockDate}. Liên hệ phòng kỹ thuật để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            _count = 0;
                            return null;
                        }
                        MessageBox.Show($"Nhập sai mật khẩu lần thứ {_count}! Lần thứ 3 tài khoản sẽ bị khoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    else if(BCrypt.Net.BCrypt.Verify(password, info.Password))
                    {
                        if(info.LockDate != null &&  DateTime.Now > info.LockDate)
                        {
                            info.LockDate = null;
                            await _api.UpdateStaff(info);
                        }
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return info.StaffId;
                    }
                }
                return null;
            }
            catch(Exception ex)
            {
                CustomMessage.ExecptionCustom(ex);
                return null;
            }
            
        }
        public async Task<bool> CreateStaff(Staff staff)
        {
            try
            {
                string responce = await _api.CreateStaff(staff);
                if (responce == "Success")
                {
                    List<MonthlySalaryStatisticsViewModels> list = await _monthSalaryDetailBUS.GetMonthSalary(DateTime.Now.ToString("MM/yyyy"));
                    if(list != null) 
                    {
                        string msID = list.FirstOrDefault().MsId;
                        MonthSalaryDetail add = new MonthSalaryDetail()
                        {
                            MsId = msID,
                            StaffId = staff.Id,
                        };
                        await _monthSalaryDetailBUS.CreateMonthSalaryDetail(add);
                        await _monthSalaryDetailBUS.UpdateMonthSalaryDetail(DateTime.Now.ToString("MM/yyyy"));
                    }
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
        public async Task<bool> UpdateStaff(Staff staff)
        {
            try
            {
                string responce = await _api.UpdateStaff(staff);
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
        public async Task<bool> DeleteStaff(string staffID)
        {
            try
            {
                string responce = await _api.DeleteStaff(staffID);
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
