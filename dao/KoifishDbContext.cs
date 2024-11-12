using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Bussinessobject;

namespace dao
{
    public partial class KoifishDbContext : DbContext
    {
        public KoifishDbContext()
        {
        }

        public KoifishDbContext(DbContextOptions<KoifishDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FishInformation> FishInformations { get; set; }
        public virtual DbSet<HealthRecord> HealthRecords { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
                string connectionString = configuration.GetConnectionString("DefaultConnectionStringDB");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FishInformation>(entity =>
            {
                entity.HasKey(e => e.FishId).HasName("PK__FishInfo__F82A5BF9313C2A6B");
                entity.ToTable("FishInformation");
                entity.Property(e => e.FishId)
                    .ValueGeneratedNever()
                    .HasColumnName("FishID");
                entity.Property(e => e.SizeCm).HasColumnName("Size_cm");
                entity.Property(e => e.Species)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId).HasName("PK__HealthRe__FBDF78C9068322A3");
                entity.Property(e => e.RecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("RecordID");
                entity.Property(e => e.FishId).HasColumnName("FishID");
                entity.Property(e => e.HealthStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Notes).HasColumnType("text");
                entity.Property(e => e.Treatment)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.HasOne(d => d.Fish).WithMany(p => p.HealthRecords)
                    .HasForeignKey(d => d.FishId)
                    .HasConstraintName("FK__HealthRec__FishI__267ABA7A");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__UserAcco__1788CCAC0B04ABDC");
                entity.HasIndex(e => e.Username, "UQ__UserAcco__536C85E4316273C4").IsUnique();
                entity.HasIndex(e => e.Email, "UQ__UserAcco__A9D10534C4830EDF").IsUnique();
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Password).HasMaxLength(60);
                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
