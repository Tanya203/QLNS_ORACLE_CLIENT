using System;

namespace CLIENT.ViewModels
{
    public class ShiftDetailViewModel
    {
        public string ShiftId { get; set; }

        public string ShiftTypeName { get; set; }

        public string ShiftName { get; set; }

        public TimeSpan BeginTime { get; set; }

        public TimeSpan EndTime { get; set; }
    }
}
