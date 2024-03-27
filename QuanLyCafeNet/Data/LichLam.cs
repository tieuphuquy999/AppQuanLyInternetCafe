namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichLam")]
    public partial class LichLam
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNhanVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCa { get; set; }

        [StringLength(10)]
        public string abc { get; set; }

        public virtual CaLam CaLam { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public int thu { get { return CaLam.Thu; } }
        public int ca { get { return CaLam.Ca; } }
    }
}
