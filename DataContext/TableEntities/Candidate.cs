using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataContext.TableEntities;

public partial class Candidate
{
    [Key]
    [Column("CandidateID")]
    public int CandidateId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Gender { get; set; } = null!;

    [Unicode(false)]
    public string Address { get; set; } = null!;

    public string Resumefile { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AppliedPosition { get; set; } = null!;

    [StringLength(500)]
    public string Skills { get; set; } = null!;

    [StringLength(500)]
    public string CurrentLocation { get; set; } = null!;

    [StringLength(500)]
    public string PreferedLocation { get; set; } = null!;

    [Column("CurrentCTC", TypeName = "decimal(18, 2)")]
    public decimal? CurrentCtc { get; set; }

    [Column("ExpectedCTC", TypeName = "decimal(18, 2)")]
    public decimal? ExpectedCtc { get; set; }

    [StringLength(50)]
    public string? References { get; set; }

    [Column("References_EmpId")]
    public int? ReferencesEmpId { get; set; }

    [StringLength(200)]
    public string? LinkedInLink { get; set; }

    public DateOnly RegistrationDate { get; set; }

    [InverseProperty("Candidate")]
    public virtual ICollection<CandidatesDetail> CandidatesDetails { get; set; } = new List<CandidatesDetail>();
}
