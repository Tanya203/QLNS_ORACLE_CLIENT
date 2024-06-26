﻿using System;

namespace CLIENT.ViewModels
{
    public class DayOffUsedViewModel
    {
        public string WsId { get; set; }

        public DateTime? WorkDate { get; set; }

        public string StaffId { get; set; }

        public bool? DateOff { get; set; }

        public string FullName { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public string Note { get; set; }
    }
}
