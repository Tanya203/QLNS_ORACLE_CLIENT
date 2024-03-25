using System;

namespace CLIENT.DataTier.Models
{
    public class Staff
    {
        public string StaffId { get; set; }

        public string PsId { get; set; }

        public string CtId { get; set; }        

        public string Password { get; set; }

        public string Id { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FirstName { get; set; }

        public DateTime? DateOfBrith { get; set; }

        public string HouseNumber { get; set; }

        public string Street { get; set; }

        public string Ward { get; set; }

        public string District { get; set; }

        public string ProviceCity { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string EducationLevel { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? ContractDuration { get; set; }

        public string Status { get; set; }

        public decimal? DayOff { get; set; }

        public decimal? BasicSalary { get; set; }

        public byte[] Picture { get; set; }

        public DateTime? LockDate { get; set; }

    }
}
