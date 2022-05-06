using Core.CounterPointModels;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public partial class AffWeb_XYZContext : DbContext
    {
        public AffWeb_XYZContext()
        {
        }

        public AffWeb_XYZContext(DbContextOptions<AffWeb_XYZContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Spot> Spots { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AffWeb_XYZ;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spot>(entity =>
            {
                entity.HasKey(e => e.AstCode);

                entity.HasIndex(e => e.ExportedFlag, "IX_Spots_ExportedFlag")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.AttCode, "IX_Spots_Headers")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PledgeEndDate, "IX_Spots_Pledge_End_Date")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PledgeStartDate, "IX_Spots_Pledge_Start_Date")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.RecType, "IX_Spots_RecType")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SpotSeqNum, "IX_Spots_SpotSeqNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostedFlag, "IX_Spots_postedFlag")
                    .HasFillFactor(90);

                entity.Property(e => e.AstCode)
                    .ValueGeneratedNever()
                    .HasColumnName("astCode");

                entity.Property(e => e.ActualAirDate).HasColumnType("datetime");

                entity.Property(e => e.ActualAirtime).HasColumnType("datetime");

                entity.Property(e => e.ActualDateTime).HasColumnType("datetime");

                entity.Property(e => e.Advt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttCode).HasColumnName("attCode");

                entity.Property(e => e.AvailName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeOrAfter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')")
                    .IsFixedLength();

                entity.Property(e => e.Cart)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreativeTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmbeddedOrRos)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EmbeddedOrROS")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedDay)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exportDate");

                entity.Property(e => e.ExportedFlag).HasColumnName("exportedFlag");

                entity.Property(e => e.FeedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedTime).HasColumnType("datetime");

                entity.Property(e => e.FlightDays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightEndTime).HasColumnType("datetime");

                entity.Property(e => e.FlightStartTime).HasColumnType("datetime");

                entity.Property(e => e.GsfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gsfCode")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDayPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.IsOverridable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isOverridable")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength();

                entity.Property(e => e.Isci)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISCI")
                    .IsFixedLength();

                entity.Property(e => e.Mrreason).HasColumnName("MRReason");

                entity.Property(e => e.OrgstatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PledgeEndDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeEndTime).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartDate).HasColumnType("datetime");

                entity.Property(e => e.PledgeStartTime).HasColumnType("datetime");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("postDate");

                entity.Property(e => e.PostedFlag).HasColumnName("postedFlag");

                entity.Property(e => e.Prod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RotendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ROTEndDate");

                entity.Property(e => e.SentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1899-12-31')");

                entity.Property(e => e.ShowVehName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("showVehName")
                    .IsFixedLength();

                entity.Property(e => e.Source)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SrcAttCode).HasColumnName("srcAttCode");

                entity.Property(e => e.Srlink).HasColumnName("SRLink");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("statusCode");

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrueDaysPledged)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
