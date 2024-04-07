using System;

namespace CLIENT.ViewModels
{
    public class StaffTimeKeeingViewModel
    {
        public string WsId { get; set; }

        public DateTime? WorkDate { get; set; }

        public string StaffId { get; set; }

        public string ShiftId { get; set; }

        public string FullName { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public string ShiftName { get; set; }

        public TimeSpan? CheckIn { get; set; }

        public TimeSpan? CheckOut { get; set; }
    }
}
