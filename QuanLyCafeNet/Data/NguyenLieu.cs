namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguyenLieu")]
    public partial class NguyenLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguyenLieu()
        {
            CTDonHangs = new HashSet<CTDonHang>();
            CTPhaChes = new HashSet<CTPhaChe>();
            CTPhieuNhapKhoes = new HashSet<CTPhieuNhapKho>();
        }

        [Key]
        public int MaNguyenLieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNgueyLieu { get; set; }

        [StringLength(10)]
        public string DVT { get; set; }

        public int? SLTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDonHang> CTDonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhaChe> CTPhaChes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuNhapKho> CTPhieuNhapKhoes { get; set; }
    }
}
