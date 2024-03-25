using System;

namespace CLIENT.DataTier.Models
{
    public class Shift
    {
        public string ShiftId { get; set; }

        public string ShiftName { get; set; }

        public TimeSpan? BeginTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        public string StId { get; set; }
    }
}
