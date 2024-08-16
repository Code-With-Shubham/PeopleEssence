using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class CandidateVM
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Resumefile { get; set; } = null!;
        public string AppliedPosition { get; set; } = null!;
        public string Skills { get; set; } = null!;
        public string CurrentLocation { get; set; } = null!;
        public string PreferedLocation { get; set; } = null!;
        public decimal? CurrentCtc { get; set; }
        public decimal? ExpectedCtc { get; set; }
        public string? References { get; set; }
        public int? ReferencesEmpId { get; set; }
        public string? LinkedInLink { get; set; }
        public DateTime RegistrationDate { get; set; }

        public int CandidateDetailsId { get; set; }

        public string? PreviousEmp { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Education { get; set; }
        public DateTime? EduFromDate { get; set; }
        public DateTime? EduToDate { get; set; }
    }
}
