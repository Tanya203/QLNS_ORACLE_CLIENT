using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class PositionDetailViewModel
    {
        public string PsId { get; set; }

        public string DepartmentName { get; set; }

        public string PositionName { get; set; }

        public decimal? Count { get; set; }
    }
}
