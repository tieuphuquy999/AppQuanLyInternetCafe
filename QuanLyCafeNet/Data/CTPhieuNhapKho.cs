namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuNhapKho")]
    public partial class CTPhieuNhapKho
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoPhieuNK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNguyenLieu { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        public int SoLuong { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }

        public virtual PhieuNhapKho PhieuNhapKho { get; set; }
    }
}
