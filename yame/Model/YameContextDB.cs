using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Fahasa_Management_System.Model
{
    public partial class YameContextDB : DbContext
    {
        public YameContextDB()
            : base("name=YameContextDB")
        {
        }

        public virtual DbSet<CHAMCONG> CHAMCONGs { get; set; }
        public virtual DbSet<CHATLIEU> CHATLIEUx { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHOM> NHOMs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SIZE> SIZEs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONGTINCONGVIEC> THONGTINCONGVIECs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<PRODUCTSIZE> PRODUCTSIZEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHATLIEU>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.CHATLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .HasForeignKey(e => e.SOHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHAMCONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHOM>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.NHOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.PRODUCTSIZEs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SIZE>()
                .HasMany(e => e.PRODUCTSIZEs)
                .WithRequired(e => e.SIZE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONGTINCONGVIEC>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.THONGTINCONGVIEC)
                .WillCascadeOnDelete(false);
        }
    }
}
