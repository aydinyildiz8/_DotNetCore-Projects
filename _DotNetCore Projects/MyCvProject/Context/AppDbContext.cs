using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyCvProject.Models.Entities;

#nullable disable

namespace MyCvProject.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Meslek).HasMaxLength(100);

                entity.Property(e => e.ResimUrl).HasMaxLength(100);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KullaniciAdi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SertifikaAdı).HasMaxLength(100);

                entity.Property(e => e.Tarih).HasMaxLength(50);

                entity.Property(e => e.VerenKurulus).HasMaxLength(100);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdSoyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Konu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mesaj)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bölüm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fakülte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNO");

                entity.Property(e => e.MezuniyetTarihi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Okul)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).IsUnicode(false);

                entity.Property(e => e.Alan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meslek)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih).HasMaxLength(100);
            });

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hobi).HasMaxLength(30);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Yetenek).HasMaxLength(100);
            });

            modelBuilder.Entity<SocialMedia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ikon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ikon");

                entity.Property(e => e.Link)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
