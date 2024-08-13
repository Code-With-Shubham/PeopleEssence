using System;
using System.Collections.Generic;
using DataContext.TableEntities;
using Microsoft.EntityFrameworkCore;

namespace DataContext.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Candidate> Candidates { get; set; }

    public virtual DbSet<CandidatesDetail> CandidatesDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.77;Initial Catalog=PeopleEssence;Persist Security Info=False;User ID=sa;Password=sa@123;MultipleActiveResultSets=False;Connection Timeout=30;Encrypt=false;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CandidatesDetail>(entity =>
        {
            entity.HasKey(e => e.CandidateDetailsId).HasName("PK__Candidat__3664EFF43A7AD83D");

            entity.HasOne(d => d.Candidate).WithMany(p => p.CandidatesDetails).HasConstraintName("FK__Candidate__Candi__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
