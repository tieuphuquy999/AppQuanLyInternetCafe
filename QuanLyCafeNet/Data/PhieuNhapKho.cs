namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapKho")]
    public partial class PhieuNhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapKho()
        {
            CTPhieuNhapKhoes = new HashSet<CTPhieuNhapKho>();
        }

        [Key]
        public int SoPhieuNK { get; set; }

        public DateTime NgayLap { get; set; }

        public int? MaDonHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuNhapKho> CTPhieuNhapKhoes { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
