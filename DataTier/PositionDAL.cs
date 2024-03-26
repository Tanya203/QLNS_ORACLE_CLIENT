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
    public class PositionDAL
    {
        private readonly PositionAPI _api;

        public PositionDAL()
        {
            _api = new PositionAPI();
        }
        public async Task<List<Position>> GetAllDPosition()
        {
            string responce = await _api.GetAllPosition();
            List<Position> listPosition = JsonConvert.DeserializeObject<List<Position>>(responce);
            return listPosition.ToList();
        }
        public async Task<List<PositionDetailViewModel>> GetPositionDetail()
        {
            string responce = await _api.GetPositionDetail();
            List<PositionDetailViewModel> listPosition = JsonConvert.DeserializeObject<List<PositionDetailViewModel>>(responce);
            return listPosition.ToList();
        }
        public async Task<List<PositionDetailViewModel>> SearchPositionDetail(string search)
        {
            string responce = await _api.SearchPositionDetail(search);
            List<PositionDetailViewModel> listPosition = JsonConvert.DeserializeObject<List<PositionDetailViewModel>>(responce);
            return listPosition.ToList();
        }
        public async Task<bool> CreatePosition(Position position)
        {
            try
            {
                string responce = await _api.CreatePosition(position);
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
        public async Task<bool> UpdatePosition(Position position)
        {
            try
            {
                string responce = await _api.UpdatePosition(position);
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
        public async Task<bool> DeletePosition(string psID)
        {
            try
            {
                string responce = await _api.DeletePosition(psID);
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
