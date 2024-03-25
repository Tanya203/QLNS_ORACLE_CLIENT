using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class StaffBenefitDetailViewModel
    {
        public string BnId { get; set; }

        public string BenefitName { get; set; }

        public decimal? Amount { get; set; }

        public string Note { get; set; }

        public string StaffId { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public string FullName { get; set; }
    }
}
