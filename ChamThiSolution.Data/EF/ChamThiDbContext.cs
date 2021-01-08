using ChamThiSolution.Data.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChamThiSolution.Data.EF
{
    public partial class ChamThiDbContext : DbContext
    {
        public ChamThiDbContext()
            : base("name=ChamThiDbContext")
        {
        }

        public virtual DbSet<CauHoi> CauHois { get; set; }
        public virtual DbSet<GiamThi> GiamThis { get; set; }
        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<PhongThi> PhongThis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TC_KQ> TC_KQ { get; set; }
        public virtual DbSet<TestCase> TestCases { get; set; }
        public virtual DbSet<ThiSinh> ThiSinhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauHoi>()
                .Property(e => e.MaCauHoi)
                .IsUnicode(false);

            modelBuilder.Entity<GiamThi>()
                .Property(e => e.MaGiamThi)
                .IsUnicode(false);

            modelBuilder.Entity<GiamThi>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.GiamThi)
                .HasForeignKey(e => e.IDGiamThi);

            modelBuilder.Entity<KetQua>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.KetQua)
                .HasForeignKey(e => e.IDKetQua);

            modelBuilder.Entity<KetQua>()
                .HasOptional(e => e.TC_KQ)
                .WithRequired(e => e.KetQua);

            modelBuilder.Entity<PhongThi>()
                .Property(e => e.MaPhongThi)
                .IsUnicode(false);

            modelBuilder.Entity<PhongThi>()
                .HasOptional(e => e.CauHoi)
                .WithRequired(e => e.PhongThi);

            modelBuilder.Entity<PhongThi>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.PhongThi)
                .HasForeignKey(e => e.IDPhongThi);

            modelBuilder.Entity<TestCase>()
                .HasOptional(e => e.CauHoi)
                .WithRequired(e => e.TestCase);

            modelBuilder.Entity<TestCase>()
                .HasOptional(e => e.TC_KQ)
                .WithRequired(e => e.TestCase);

            modelBuilder.Entity<ThiSinh>()
                .Property(e => e.MaThiSinh)
                .IsUnicode(false);

            modelBuilder.Entity<ThiSinh>()
                .HasMany(e => e.TaiKhoans)
                .WithOptional(e => e.ThiSinh)
                .HasForeignKey(e => e.IDThiSinh);
        }
    }
}