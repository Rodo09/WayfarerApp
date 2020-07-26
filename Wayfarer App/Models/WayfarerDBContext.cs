using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Wayfarer_App.Models
{
    public partial class WayfarerDBContext : DbContext
    {
        public WayfarerDBContext()
        {
        }

        public WayfarerDBContext(DbContextOptions<WayfarerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Espers> Espers { get; set; }
        public virtual DbSet<GuildBattleComps> GuildBattleComps { get; set; }
        public virtual DbSet<OwnedEspers> OwnedEspers { get; set; }
        public virtual DbSet<OwnedUnits> OwnedUnits { get; set; }
        public virtual DbSet<OwnedVisions> OwnedVisions { get; set; }
        public virtual DbSet<Rarities> Rarities { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Visions> Visions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-M96VP5O;Database=WayfarerDB;User ID=sa;Password=TestingDatabase;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Espers>(entity =>
            {
                entity.HasKey(e => e.EsperId);

                entity.Property(e => e.EsperId).HasColumnName("EsperID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RarityId).HasColumnName("RarityID");

                entity.HasOne(d => d.Rarity)
                    .WithMany(p => p.Espers)
                    .HasForeignKey(d => d.RarityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Espers_Rarities");
            });

            modelBuilder.Entity<GuildBattleComps>(entity =>
            {
                entity.HasKey(e => e.Gbid);

                entity.Property(e => e.Gbid).HasColumnName("GBID");

                entity.Property(e => e.OwnedEsperIdslot1).HasColumnName("OwnedEsperIDSlot1");

                entity.Property(e => e.OwnedEsperIdslot2).HasColumnName("OwnedEsperIDSlot2");

                entity.Property(e => e.OwnedEsperIdslot3).HasColumnName("OwnedEsperIDSlot3");

                entity.Property(e => e.OwnedUnitIdslot1).HasColumnName("OwnedUnitIDSlot1");

                entity.Property(e => e.OwnedUnitIdslot2).HasColumnName("OwnedUnitIDSlot2");

                entity.Property(e => e.OwnedUnitIdslot3).HasColumnName("OwnedUnitIDSlot3");

                entity.Property(e => e.OwnedVisionIdslot1).HasColumnName("OwnedVisionIDSlot1");

                entity.Property(e => e.OwnedVisionIdslot2).HasColumnName("OwnedVisionIDSlot2");

                entity.Property(e => e.OwnedVisionIdslot3).HasColumnName("OwnedVisionIDSlot3");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GuildBattleComps)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuildBattleComps_Users");
            });

            modelBuilder.Entity<OwnedEspers>(entity =>
            {
                entity.HasKey(e => e.OwnedEsperId);

                entity.Property(e => e.OwnedEsperId).HasColumnName("OwnedEsperID");

                entity.Property(e => e.EsperAwakening).HasDefaultValueSql("((1))");

                entity.Property(e => e.EsperId).HasColumnName("EsperID");

                entity.Property(e => e.EsperLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Esper)
                    .WithMany(p => p.OwnedEspers)
                    .HasForeignKey(d => d.EsperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedEspers_Espers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OwnedEspers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedEspers_Users");
            });

            modelBuilder.Entity<OwnedUnits>(entity =>
            {
                entity.HasKey(e => e.OwnedUnitId);

                entity.Property(e => e.OwnedUnitId).HasColumnName("OwnedUnitID");

                entity.Property(e => e.UnitAwakening).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitJob1Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitJob2Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitJob3Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.OwnedUnits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedUnits_Units");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OwnedUnits)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedUnits_Users");
            });

            modelBuilder.Entity<OwnedVisions>(entity =>
            {
                entity.HasKey(e => e.OwnedVisionId);

                entity.Property(e => e.OwnedVisionId).HasColumnName("OwnedVisionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VisionId).HasColumnName("VisionID");

                entity.Property(e => e.VisionLevel).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OwnedVisions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedVisions_Users");

                entity.HasOne(d => d.Vision)
                    .WithMany(p => p.OwnedVisions)
                    .HasForeignKey(d => d.VisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnedVisions_Visions");
            });

            modelBuilder.Entity<Rarities>(entity =>
            {
                entity.HasKey(e => e.RarityId);

                entity.Property(e => e.RarityId).HasColumnName("RarityID");

                entity.Property(e => e.RarityName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Faction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Job1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Job2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Job3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.RarityId).HasColumnName("RarityID");

                entity.HasOne(d => d.Rarity)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.RarityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Units_Rarities");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            modelBuilder.Entity<Visions>(entity =>
            {
                entity.HasKey(e => e.VisionId);

                entity.Property(e => e.VisionId).HasColumnName("VisionID");

                entity.Property(e => e.MaxLvlBestowedEffect)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MaxLvlPartyAbility)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.RarityId).HasColumnName("RarityID");

                entity.HasOne(d => d.Rarity)
                    .WithMany(p => p.Visions)
                    .HasForeignKey(d => d.RarityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visions_Rarities");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
