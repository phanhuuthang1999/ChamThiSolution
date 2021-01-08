using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamThiSolution.Data.Entities
{
    [NotMapped]
    public partial class GioiTinh
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

    }


    public class StructEnum
    {
        public enum EN_GioiTinh
        {
            [Description("Nữ")]
            Nu = 0,
            [Description("Nam")]
            Nam = 1
        }

        public enum EN_Quyen
        {
            [Description("Sinh Viên")]
            SinhVien = -1,
            [Description("Giám Thị")]
            GiamThi = 0,
            [Description("Master")]
            Master = 1
        }

        public enum EN_TrangThai
        {
            [Description("Khởi tạo")]
            KhoiTao = -1,
            [Description("Chờ Thi")]
            ChoThi = 0,
            [Description("Đang Thi")]
            DangThi = 1,
            [Description("Đóng")]
            Dong = 2,
        }
    }

}
