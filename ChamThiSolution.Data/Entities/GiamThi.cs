namespace ChamThiSolution.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiamThi")]
    public partial class GiamThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiamThi()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string MaGiamThi { get; set; }

        [StringLength(50)]
        public string HoDem { get; set; }

        [StringLength(525)]
        public string TenGiamThi { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
