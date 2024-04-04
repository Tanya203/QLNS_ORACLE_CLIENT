using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class StaffDateOfffModel
    {
        public string WsId { get; set; }

        public DateTime? WorkDate { get; set; }

        public string StaffId { get; set; }

        public string FullName { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public bool? DateOff { get; set; }

        public decimal? DayOff { get; set; }
    }
}
