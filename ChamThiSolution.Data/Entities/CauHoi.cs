namespace ChamThiSolution.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHoi")]
    public partial class CauHoi
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string MaCauHoi { get; set; }

        [StringLength(255)]
        public string TenCauHoi { get; set; }

        public string NoiDungCauHoi { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public int? IDPhongThi { get; set; }

        public int? IDTestCase { get; set; }

        public virtual PhongThi PhongThi { get; set; }

        public virtual TestCase TestCase { get; set; }
    }
}
