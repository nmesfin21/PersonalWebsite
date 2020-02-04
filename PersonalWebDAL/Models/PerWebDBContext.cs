using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

namespace PersonalWebDAL.Models
{
    public partial class PerWebDBContext : DbContext
    {
        public PerWebDBContext()
        {
        }

        public PerWebDBContext(DbContextOptions<PerWebDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Resumes> Resumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json");

            var config = builder.Build();
            var connectionString = config.GetConnectionString("PerWebDBConnectionString");

            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.Property(e => e.Description).HasColumnType("text");
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__ContactI__5C66259BABCA2B8F");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TicTok)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__Courses__C92D71A7393BF0CF");

                entity.Property(e => e.CourseDescription).HasColumnType("text");

                entity.Property(e => e.CourseLink)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Semester)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__Projects__761ABEF0856A023F");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Languages)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tools)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Resumes>(entity =>
            {
                entity.HasKey(e => e.ResumeId)
                    .HasName("PK__Resumes__D7D7A0F77DDEEEA2");

                entity.Property(e => e.ResumePdf)
                    .HasColumnName("ResumePDF")
                    .HasColumnType("image");

                entity.Property(e => e.ResumeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
