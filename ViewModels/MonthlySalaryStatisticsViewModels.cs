using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.ViewModels
{
    public class MonthlySalaryStatisticsViewModels
    {
        public string MsId { get; set; }

        public string StaffId { get; set; }

        public string FullName { get; set; }

        public string DepartmentName { get; set; }

        public string PositionName { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal TotalWorkHours { get; set; }

        public decimal TotalBenefit { get; set; }

        public decimal TotalSalary { get; set; }

        public string Month { get; set; }
    }
}
