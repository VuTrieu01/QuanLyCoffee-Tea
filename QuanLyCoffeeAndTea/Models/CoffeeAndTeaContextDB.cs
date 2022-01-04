using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCoffeeAndTea.Models
{
    public partial class CoffeeAndTeaContextDB : DbContext
    {
        public CoffeeAndTeaContextDB()
            : base("name=CoffeeAndTeaContextDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<DANHMUCSANPHAM> DANHMUCSANPHAMs { get; set; }
        public virtual DbSet<DANHMUCTHUCDON> DANHMUCTHUCDONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<THUCDON> THUCDONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUCSANPHAM>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.DANHMUCSANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHMUCTHUCDON>()
                .HasMany(e => e.THUCDONs)
                .WithRequired(e => e.DANHMUCTHUCDON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}
