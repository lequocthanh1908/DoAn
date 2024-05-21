using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyCongViec.Models
{
    public partial class DoAnContext : DbContext
    {
        public DoAnContext()
        {
        }

        public DoAnContext(DbContextOptions<DoAnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<LogWork> LogWorks { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3F4L40U\\SQLEXPRESS;Initial Catalog=QuanLyCongViec;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdTask)
                    .HasConstraintName("FK__Comment__IdTask__34C8D9D1");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.PathImg)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.HasOne(d => d.IdCommentNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.IdComment)
                    .HasConstraintName("FK__Image__IdComment__37A5467C");
            });

            modelBuilder.Entity<LogWork>(entity =>
            {
                entity.ToTable("LogWork");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.LogWorks)
                    .HasForeignKey(d => d.IdStaff)
                    .HasConstraintName("FK__LogWork__IdStaff__30F848ED");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogWorks)
                    .HasForeignKey(d => d.IdTask)
                    .HasConstraintName("FK__LogWork__IdTask__31EC6D26");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(255)
                    .IsUnicode(true);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.NamePm)
                    .HasMaxLength(255)
                    .IsUnicode(true)
                    .HasColumnName("NamePM");

                entity.Property(e => e.NameProject)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.NameTask)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(true);

                entity.HasOne(d => d.IdProjectNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdProject)
                    .HasConstraintName("FK__Task__IdProject__2D27B809");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdStaff)
                    .HasConstraintName("FK__Task__IdStaff__2E1BDC42");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(true);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.AddressStaff)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.Gmail)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.NumberPhone)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.Property(e => e.StaffName)
                    .HasMaxLength(255)
                    .IsUnicode(true);

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.IdPosition)
                    .HasConstraintName("FK__Staff__IdPositio__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
