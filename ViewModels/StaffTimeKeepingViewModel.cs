using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class StaffTimeKeepingViewModel
    {
        public string WsId { get; set; }

        public DateTime? WorkDate { get; set; }

        public string StaffId { get; set; }

        public string FullName { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public string ShiftName { get; set; }

        public TimeSpan? CheckIn { get; set; }

        public TimeSpan? CheckOut { get; set; }
    }
}
