namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuBaoTri")]
    public partial class PhieuBaoTri
    {
        [Key]
        public int SoPhieuBT { get; set; }

        public DateTime NgayLap { get; set; }

        public double ChiPhi { get; set; }

        [Required]
        [StringLength(500)]
        public string LyDo { get; set; }

        public int? IDNhanVien { get; set; }

        public int? MaThongKe { get; set; }

        [StringLength(5)]
        public string IDMay { get; set; }

        public virtual May May { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual ThongKe ThongKe { get; set; }
    }
}
