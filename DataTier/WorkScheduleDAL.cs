﻿using CLIENT.API;
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
    public class WorkScheduleDAL
    {
        private readonly WorkScheduleAPI _api;
        public WorkScheduleDAL()
        {
            _api = new WorkScheduleAPI();
        }
        public async Task<List<WorkSchedule>> GetAllWorkSchedule()
        {
            string responce = await _api.GetAllWorkSchedule();
            List<WorkSchedule> listWorkSchedule = JsonConvert.DeserializeObject<List<WorkSchedule>>(responce);
            return listWorkSchedule.ToList();
        }
        public async Task<List<WorkSchedule>> SearchWorkSchedule(string search)
        {
            string responce = await _api.SearchWorkSchedule(search);
            List<WorkSchedule> listWorkSchedule = JsonConvert.DeserializeObject<List<WorkSchedule>>(responce);
            return listWorkSchedule.ToList();
        }
        public async Task<bool> AutoSchedule(string month)
        {
            try
            {
                string responce = await _api.AutoSchedule(month);
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
        public async Task<bool> CreateWorkSchedule(WorkSchedule workSchedule)
        {
            try
            {
                string responce = await _api.CreateWorkSchedule(workSchedule);
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
        public async Task<bool> DeleteBenefit(string wsID)
        {
            try
            {
                string responce = await _api.DeleteWorkSchedule(wsID);
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