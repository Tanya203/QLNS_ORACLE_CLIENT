using System;

namespace CLIENT.DataTier.Models
{
    public class TimeKeeping
    {
        public string WsId { get; set; }

        public string StaffId { get; set; }

        public string ShiftId { get; set; }

        public TimeSpan? CheckIn { get; set; }

        public TimeSpan? CheckOut { get; set; }
    }
}
