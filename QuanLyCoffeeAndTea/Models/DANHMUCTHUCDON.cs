namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUCTHUCDON")]
    public partial class DANHMUCTHUCDON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUCTHUCDON()
        {
            THUCDONs = new HashSet<THUCDON>();
        }

        [Key]
        public int DanhMucTDID { get; set; }

        [StringLength(50)]
        public string TenDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCDON> THUCDONs { get; set; }
    }
}
