namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUCSANPHAM")]
    public partial class DANHMUCSANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUCSANPHAM()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        public int DanhMucSPID { get; set; }

        [StringLength(50)]
        public string TenDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
