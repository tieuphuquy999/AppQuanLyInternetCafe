namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("May")]
    public partial class May
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public May()
        {
            PhieuBaoTris = new HashSet<PhieuBaoTri>();
            LinhKiens = new HashSet<LinhKien>();
        }

        [Key]
        [StringLength(5)]
        public string IDMay { get; set; }

        [Required]
        [StringLength(20)]
        public string TenMay { get; set; }

        [StringLength(10)]
        public string IDLoaiMay { get; set; }

        public virtual LoaiMay LoaiMay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuBaoTri> PhieuBaoTris { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinhKien> LinhKiens { get; set; }
    }
}
