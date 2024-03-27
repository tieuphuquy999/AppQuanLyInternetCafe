namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMay")]
    public partial class LoaiMay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiMay()
        {
            Mays = new HashSet<May>();
        }

        [Key]
        [StringLength(10)]
        public string IDLoaiMay { get; set; }

        [Required]
        [StringLength(20)]
        public string TenLoai { get; set; }

        public double PhiSuDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<May> Mays { get; set; }
    }
}
