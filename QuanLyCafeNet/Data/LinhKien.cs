namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinhKien")]
    public partial class LinhKien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LinhKien()
        {
            Mays = new HashSet<May>();
        }

        [Key]
        [StringLength(10)]
        public string IDLinhKien { get; set; }

        [Required]
        [StringLength(20)]
        public string TenLinhKien { get; set; }

        [StringLength(10)]
        public string IDLoaiLK { get; set; }

        public virtual LoaiLinhKien LoaiLinhKien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<May> Mays { get; set; }
    }
}
