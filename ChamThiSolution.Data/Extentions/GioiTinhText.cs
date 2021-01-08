using System.ComponentModel.DataAnnotations.Schema;

namespace ChamThiSolution.Data.Entities
{
    public partial class GiamThi
    {
        [NotMapped]
        public string GioiTinhText { get{ return GioiTinh == 1 ? "Nam" : "Nữ";}}
    }

    public partial class ThiSinh
    {
        [NotMapped]
        public string GioiTinhText { get { return GioiTinh == 1 ? "Nam" : "Nữ"; } }
    }
}
