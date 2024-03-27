namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhaChe")]
    public partial class CTPhaChe
    {
        [Key]
        public int MaCTPhaChe { get; set; }

        [StringLength(10)]
        public string MaMon { get; set; }

        public int? MaNguyenLieu { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
