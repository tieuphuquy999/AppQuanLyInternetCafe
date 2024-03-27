namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountNV")]
    public partial class AccountNV
    {
        [Key]
        [StringLength(20)]
        public string USERR { get; set; }

        [StringLength(20)]
        public string PASS { get; set; }

        public DateTime NgayLap { get; set; }

        public int? IDLoaiACC { get; set; }

        public int? IDNhanVien { get; set; }

        public virtual LoaiACC LoaiACC { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public string TenNhanVien { get { return NhanVien.HoTen; } }
        public string TenLoaiTaiKhoan { get { return LoaiACC.TenLoaiACC; } }
    }
}
