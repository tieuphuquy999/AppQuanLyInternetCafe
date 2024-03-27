namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mon")]
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            CTHoaDons = new HashSet<CTHoaDon>();
            CTPhaChes = new HashSet<CTPhaChe>();
        }

        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        public double DonGia { get; set; }

        [StringLength(200)]
        public string Hinh { get; set; }

        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhaChe> CTPhaChes { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }


        public string TenDanhMuc { get { return DanhMuc.TenDanhMuc; } }
    }
}
