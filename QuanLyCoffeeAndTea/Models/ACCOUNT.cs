namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        public bool? Quyen { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NhanVienID { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
