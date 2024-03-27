namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuongTra")]
    public partial class LuongTra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNhanVien { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgayTra { get; set; }

        public double Luong { get; set; }

        public int? MaThongKe { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual ThongKe ThongKe { get; set; }
    }
}
