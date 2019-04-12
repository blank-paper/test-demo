using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Infrastructure
{
    public partial class MyCourseContext : DbContext
    {
        public MyCourseContext()
        {
        }

        public MyCourseContext(DbContextOptions<MyCourseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CourseEntity> Course { get; set; }
        public virtual DbSet<ScoreEntity> Score { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=North@09170302; database=mycourse;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>(entity =>
            {
                entity.ToTable("course");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(500)");

                entity.Property(e => e.IsOptional).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ScoreEntity>(entity =>
            {
                entity.ToTable("score");

                entity.HasIndex(e => e.CourseId)
                    .HasName("FK_Reference_2");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_Reference_3");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CourseId).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(500)");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Reference_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reference_3");
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("varchar(20)");

                entity.Property(e => e.Password).HasColumnType("varchar(100)");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });
        }
    }
}
