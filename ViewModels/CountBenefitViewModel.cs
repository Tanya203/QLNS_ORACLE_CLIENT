using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class CountBenefitViewModel
    {
        public string BnId { get; set; }

        public string BenefitName { get; set; }

        public decimal? Amount { get; set; }

        public decimal? StaffQuantity { get; set; }

        public decimal? Totalamount { get; set; }
    }
}
