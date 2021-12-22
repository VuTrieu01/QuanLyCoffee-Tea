namespace QuanLyCoffeeAndTea.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HoaDonID { get; set; }

        public int? ThucDonID { get; set; }

        public int? SanPhamID { get; set; }

        public int? ThietBiID { get; set; }

        public int NhanVienID { get; set; }

        public DateTime? NgayHD { get; set; }

        public int? SoLuong { get; set; }

        public double? ThanhTien { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual THIETBI THIETBI { get; set; }

        public virtual THUCDON THUCDON { get; set; }
    }
}