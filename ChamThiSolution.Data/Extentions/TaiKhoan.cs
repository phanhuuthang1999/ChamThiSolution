using LinqToExcel.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamThiSolution.Data.Entities
{
    public partial class TaiKhoan
    {
        [NotMapped]
        public string Quyen
        {
            get
            {
                return IsQuyen == -1 ? "Sinh Viên" : IsQuyen == 0 ? "Giám Thị" : "Server";
            }
        }

    }

    public class ExcelFile
    {
        [ExcelColumn("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [ExcelColumn("Mật khẩu")]
        public string MatKhau { get; set; }

    }
}
