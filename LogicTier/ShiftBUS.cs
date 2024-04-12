using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLIENT.DataTier
{
    public class ShiftBUS
    {
        private readonly ShiftDAL _shiftDAL;
        public ShiftBUS()
        {
            _shiftDAL = new ShiftDAL();
        }
        public async Task<List<Shift>> GetAllShift()
        {
            return await _shiftDAL.GetAllShift();
        }
        public async Task<List<ShiftDetailViewModel>> GetShiftDetail()
        {
            return await _shiftDAL.GetShiftDetail();
        }
        public async Task<List<ShiftDetailViewModel>> SearchShiftDetail(string search)
        {
            return await _shiftDAL.SearchShiftDetail(search);
        }
        public async Task<bool> CreateShift(Shift shift)
        {
            return await _shiftDAL.CreateShift(shift);
        }
        public async Task<bool> UpdateShift(Shift shift)
        {
            return await _shiftDAL.UpdateShift(shift);
        }
        public async Task<bool> DeleteShift(string shiftID)
        {
            return await _shiftDAL.DeleteShift(shiftID);
        }
    }
}
