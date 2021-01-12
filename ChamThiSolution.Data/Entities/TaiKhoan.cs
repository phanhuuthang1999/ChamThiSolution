namespace ChamThiSolution.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string TenDangNhap { get; set; }

        [StringLength(255)]
        public string MatKhau { get; set; }

        public int? IsQuyen { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsHienDien { get; set; }

        public int? IDGiamThi { get; set; }

        public int? IDThiSinh { get; set; }

        public int? IDPhongThi { get; set; }

        public int? IDKetQua { get; set; }

        public virtual GiamThi GiamThi { get; set; }

        public virtual KetQua KetQua { get; set; }

        public virtual PhongThi PhongThi { get; set; }

        public virtual ThiSinh ThiSinh { get; set; }
    }
}
