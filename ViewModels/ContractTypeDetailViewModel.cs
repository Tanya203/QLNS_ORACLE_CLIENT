using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class ContractTypeDetailViewModel
    {
        public string CtId { get; set; }

        public string ContractTypeName { get; set; }

        public string TimeKeepingMethodName { get; set; }

        public decimal? Count { get; set; }
    }
}
