using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataContext.TableEntities;

public partial class CandidatesDetail
{
    [Key]
    public int CandidateDetailsId { get; set; }

    [Column("CandidateID")]
    public int? CandidateId { get; set; }

    [StringLength(100)]
    public string? PreviousEmp { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    [StringLength(255)]
    public string? Education { get; set; }

    public DateOnly? EduFromDate { get; set; }

    public DateOnly? EduToDate { get; set; }

    [ForeignKey("CandidateId")]
    [InverseProperty("CandidatesDetails")]
    public virtual Candidate? Candidate { get; set; }
}
