using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINET.LogicTier
{
    public class ShiftTypeBUS
    {
        private readonly ShiftTypeDAL _shiftTypeDAL;
        public ShiftTypeBUS()
        {
            _shiftTypeDAL = new ShiftTypeDAL();
        }
        public async Task<List<ShiftType>> GetAllShiftType()
        {
            return await _shiftTypeDAL.GetAllShiftType();
        }
        public async Task<List<ShiftType>> SearchShiftType(string search)
        {
            return await _shiftTypeDAL.SearchShiftType(search);
        }
        public async Task<bool> CreateShiftType(ShiftType shiftType)
        {
            return await _shiftTypeDAL.CreateShiftType(shiftType);
        }
        public async Task<bool> UpdateShiftType(ShiftType shiftType)
        {
            return await _shiftTypeDAL.UpdateShiftType(shiftType);
        }
        public async Task<bool> DeleteShiftType(string stID)
        {
            return await _shiftTypeDAL.DeleteShiftType(stID);
        }
    }
}
