namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public int SanPhamID { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        [StringLength(30)]
        public string QuyCach { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public double? Gia { get; set; }

        public int DanhMucSPID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual DANHMUCSANPHAM DANHMUCSANPHAM { get; set; }
    }
}
