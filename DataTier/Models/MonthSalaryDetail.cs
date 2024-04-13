namespace CLIENT.DataTier.Models
{
    public class MonthSalaryDetail
    {
            public string MsId { get; set; }

            public string StaffId { get; set; } = null!;

            public decimal? BasicSalary { get; set; }

            public decimal? TotalWorkHours { get; set; }

            public decimal? TotalBenefit { get; set; }
           
    }
}
