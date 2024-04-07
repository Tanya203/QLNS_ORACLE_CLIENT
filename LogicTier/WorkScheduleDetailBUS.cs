using CLIENT.DataTier;
using CLIENT.DataTier.Models;
using CLIENT.ViewModels;
using Eco.FrameworkImpl.Ocl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.LogicTier
{
    public class WorkScheduleDetailBUS
    {
        private readonly WorkScheduleDetailDAL _workScheduleDetailDAL;

        public WorkScheduleDetailBUS()
        {
            _workScheduleDetailDAL = new WorkScheduleDetailDAL();
        }
        public async Task<List<WorkScheduleDetail>> GetAllWorkScheduleDetail()
        {
            return await _workScheduleDetailDAL.GetAllWorkScheduleDetail();
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> GetWorkScheduleDetailById(string id)
        {
            return await _workScheduleDetailDAL.GetWorkScheduleDetailById(id);
        }
        public async Task<List<StaffWorkScheduleDetailViewModel>> SearchWorkScheduleDetailById(string id, string search)
        {
            return await _workScheduleDetailDAL.SearchWorkScheduleDetailById(id, search);
        }
        public async Task<bool> CreateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            return await _workScheduleDetailDAL.CreateWorkScheduleDetail(workScheduleDetail);
        }
        public async Task<bool> UpdateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            return await _workScheduleDetailDAL.UpdateWorkScheduleDetail(workScheduleDetail);
        }
    }
}
