using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_CuoiKy.model
{
    public partial class QuanLyPhongTroContextDB : DbContext
    {
        public QuanLyPhongTroContextDB()
            : base("name=QuanLyPhongTroContextDB")
        {
        }

        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<MALOAIPHONG> MALOAIPHONGs { get; set; }
        public virtual DbSet<PHIEUDANGKY> PHIEUDANGKies { get; set; }
        public virtual DbSet<PHIEUPHAT> PHIEUPHATs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<CT_DICHVU> CT_DICHVU { get; set; }
        public virtual DbSet<CT_LAPDAT> CT_LAPDAT { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TienDien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TienNuoc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TienDichVu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDANGKies)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUPHATs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MALOAIPHONG>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MALOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.MALOAIPHONG1)
                .HasForeignKey(e => e.MaLoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDANGKY>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDANGKies)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CT_LAPDAT)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.CT_LAPDAT)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.PassWord)
                .IsFixedLength();
        }
    }
}
