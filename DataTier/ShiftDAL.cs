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
    public class ShiftDAL
    {
        private readonly ShiftAPI _api;
        public ShiftDAL()
        {
            _api = new ShiftAPI();
        }
        public async Task<List<Shift>> GetAllShift()
        {
            string responce = await _api.GetAllShift();
            List<Shift> listShift = JsonConvert.DeserializeObject<List<Shift>>(responce);
            return listShift.ToList();
        }
        public async Task<List<ShiftDetailViewModel>> GetShiftDetail()
        {
            string responce = await _api.GetShiftDetail();
            List<ShiftDetailViewModel> listShift = JsonConvert.DeserializeObject<List<ShiftDetailViewModel>>(responce);
            return listShift.ToList();
        }
        public async Task<List<ShiftDetailViewModel>> SearchShiftDetail(string search)
        {
            string responce = await _api.SearchShiftDetail(search);
            List<ShiftDetailViewModel> listShift = JsonConvert.DeserializeObject<List<ShiftDetailViewModel>>(responce);
            return listShift.ToList();
        }
        public async Task<bool> CreateShift(Shift shift)
        {
            try
            {
                string responce = await _api.CreateShift(shift);
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
        public async Task<bool> UpdateShift(Shift shift)
        {
            try
            {
                string responce = await _api.UpdateShift(shift);
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
        public async Task<bool> DeleteShift(string shiftID)
        {
            try
            {
                string responce = await _api.DeleteShift(shiftID);
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
