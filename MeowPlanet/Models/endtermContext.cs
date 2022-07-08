using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MeowPlanet.Models
{
    public partial class endtermContext : DbContext
    {
        public endtermContext()
        {
        }

        public endtermContext(DbContextOptions<endtermContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Missing> Missings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Missing>(entity =>
            {
                entity.ToTable("missing");

                entity.Property(e => e.MissingId).HasColumnName("missing_id");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Found).HasColumnName("found");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(10, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Reward).HasColumnName("reward");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
