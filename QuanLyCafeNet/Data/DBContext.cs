using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCafeNet.Data
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<AccountKH> AccountKHs { get; set; }
        public virtual DbSet<AccountNV> AccountNVs { get; set; }
        public virtual DbSet<CaLam> CaLams { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTDonHang> CTDonHangs { get; set; }
        public virtual DbSet<CTHoaDon> CTHoaDons { get; set; }
        public virtual DbSet<CTPhaChe> CTPhaChes { get; set; }
        public virtual DbSet<CTPhieuNhapKho> CTPhieuNhapKhoes { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichLam> LichLams { get; set; }
        public virtual DbSet<LinhKien> LinhKiens { get; set; }
        public virtual DbSet<LoaiACC> LoaiACCs { get; set; }
        public virtual DbSet<LoaiLinhKien> LoaiLinhKiens { get; set; }
        public virtual DbSet<LoaiMay> LoaiMays { get; set; }
        public virtual DbSet<LuongTra> LuongTras { get; set; }
        public virtual DbSet<May> Mays { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuBaoTri> PhieuBaoTris { get; set; }
        public virtual DbSet<PhieuNhapKho> PhieuNhapKhoes { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountKH>()
                .Property(e => e.USERR)
                .IsUnicode(false);

            modelBuilder.Entity<AccountKH>()
                .Property(e => e.PASS)
                .IsUnicode(false);

            modelBuilder.Entity<AccountNV>()
                .Property(e => e.USERR)
                .IsUnicode(false);

            modelBuilder.Entity<AccountNV>()
                .Property(e => e.PASS)
                .IsUnicode(false);

            modelBuilder.Entity<CaLam>()
                .HasMany(e => e.LichLams)
                .WithRequired(e => e.CaLam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CTHoaDon>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<CTPhaChe>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.MaDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.CTDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.IDVoucher)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasOptional(e => e.AccountKH)
                .WithRequired(e => e.KhachHang);

            modelBuilder.Entity<LichLam>()
                .Property(e => e.abc)
                .IsFixedLength();

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.IDLinhKien)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.IDLoaiLK)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.Mays)
                .WithMany(e => e.LinhKiens)
                .Map(m => m.ToTable("CauHinh").MapLeftKey("IDLinhKien").MapRightKey("IDMay"));

            modelBuilder.Entity<LoaiLinhKien>()
                .Property(e => e.IDLoaiLK)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiMay>()
                .Property(e => e.IDLoaiMay)
                .IsUnicode(false);

            modelBuilder.Entity<May>()
                .Property(e => e.IDMay)
                .IsUnicode(false);

            modelBuilder.Entity<May>()
                .Property(e => e.IDLoaiMay)
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.MaDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.CTHoaDons)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.CTDonHangs)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.CTPhieuNhapKhoes)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LichLams)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LuongTras)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuBaoTri>()
                .Property(e => e.IDMay)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapKho>()
                .HasMany(e => e.CTPhieuNhapKhoes)
                .WithRequired(e => e.PhieuNhapKho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.IDVoucher)
                .IsUnicode(false);
        }
    }
}
