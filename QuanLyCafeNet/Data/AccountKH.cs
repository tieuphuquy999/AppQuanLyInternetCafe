namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountKH")]
    public partial class AccountKH
    {
        [Key]
        [StringLength(15)]
        public string USERR { get; set; }

        [StringLength(20)]
        public string PASS { get; set; }

        public DateTime NgayLap { get; set; }

        public double SoTien { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
