using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class PositionBUS
    {
        private readonly PositionDAL _positionDAL;
        public PositionBUS()
        {
            _positionDAL = new PositionDAL();
        }
        public async Task<List<Position>> GetAllDPosition()
        {
            return await _positionDAL.GetAllDPosition();
        }
        public async Task<List<PositionDetailViewModel>> GetPositionDetail()
        {
            return await _positionDAL.GetPositionDetail();
        }
        public async Task<List<PositionDetailViewModel>> SearchPositionDetail(string search)
        {
            return await _positionDAL.SearchPositionDetail(search);
        }
        public async Task<bool> CreatePosition(Position position)
        {
            return await _positionDAL.CreatePosition(position);
        }
        public async Task<bool> UpdatePosition(Position position)
        {
            return await _positionDAL.UpdatePosition(position);
        }
        public async Task<bool> DeletePosition(string psID)
        {
            return await _positionDAL.DeletePosition(psID);
        }
    }
}
