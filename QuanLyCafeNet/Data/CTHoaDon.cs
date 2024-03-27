namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHoaDon")]
    public partial class CTHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        public double DonGia { get; set; }

        public int SoLuong { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
