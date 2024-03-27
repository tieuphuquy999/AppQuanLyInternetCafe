namespace QuanLyCafeNet.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongKe")]
    public partial class ThongKe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongKe()
        {
            DonHangs = new HashSet<DonHang>();
            HoaDons = new HashSet<HoaDon>();
            LuongTras = new HashSet<LuongTra>();
            PhieuBaoTris = new HashSet<PhieuBaoTri>();
        }

        public ThongKe(int a, int b, int c, double d, double e)
        {
            this.MaThongKe = a;
            this.Thang = b;
            this.Nam = c;
            this.TongChi = d;
            this.TongThu = e;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThongKe { get; set; }

        public int Thang { get; set; }

        public int Nam { get; set; }

        public double? TongChi { get; set; }

        public double? TongThu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuongTra> LuongTras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuBaoTri> PhieuBaoTris { get; set; }
    }
}
