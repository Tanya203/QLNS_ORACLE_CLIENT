using CLIENT.API;
using CLIENT.DataTier.Models;
using CLIENT.Function;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT.DataTier
{
    public class ShiftTypeDAL
    {
        private readonly ShiftTypeAPI _api;
        public ShiftTypeDAL()
        {
            _api = new ShiftTypeAPI();
        }
        public async Task<List<ShiftType>> GetAllShiftType()
        {
            string responce = await _api.GetAllShiftType();
            List<ShiftType> listShiftType = JsonConvert.DeserializeObject<List<ShiftType>>(responce);
            return listShiftType.ToList();
        }
        public async Task<List<ShiftType>> SearchShiftType(string search)
        {
            string responce = await _api.SearchShiftType(search);
            List<ShiftType> listShiftType = JsonConvert.DeserializeObject<List<ShiftType>>(responce);
            return listShiftType.ToList();
        }
        public async Task<bool> CreateShiftType(ShiftType shiftType)
        {
            try
            {
                string responce = await _api.CreateShiftType(shiftType);
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
        public async Task<bool> UpdateShiftType(ShiftType shiftType)
        {
            try
            {
                string responce = await _api.UpdateShiftType(shiftType);
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
        public async Task<bool> DeleteShiftType(string stID)
        {
            try
            {
                string responce = await _api.DeleteBenefit(stID);
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
