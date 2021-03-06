namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUCDON")]
    public partial class THUCDON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUCDON()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public int ThucDonID { get; set; }

        [StringLength(50)]
        public string TenThucDon { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public double? Gia { get; set; }

        public int DanhMucTDID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual DANHMUCTHUCDON DANHMUCTHUCDON { get; set; }
    }
}
