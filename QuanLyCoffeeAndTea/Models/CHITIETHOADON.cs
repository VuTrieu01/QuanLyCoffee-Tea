namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        public int IDCTHD { get; set; }

        public int? HoaDonID { get; set; }

        public int? ThucDonID { get; set; }

        public int? SanPhamID { get; set; }

        public int NhanVienID { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public double? ThanhTien { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual THUCDON THUCDON { get; set; }
    }
}
