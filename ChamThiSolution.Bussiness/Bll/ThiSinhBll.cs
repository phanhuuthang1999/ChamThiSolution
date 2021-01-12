using QuanLyChamThiSolution.Data.DTO;
using System.Linq;

namespace ChamThiSolution.Bussiness.Bll
{
    public class ThiSinhBll : BaseBll
    {
        public int getIdThiSinh(string tk)
        {
            var a = from t in Context.TaiKhoans.Where(t => t.TenDangNhap.Equals(tk))
                    join s in Context.ThiSinhs on t.IDThiSinh equals s.Id
                    select s.Id;
            return a.FirstOrDefault();
        }

        public PhongThiDTO[] GetPhongThiChoThiSinh()
        {
            var phongthiQuery = from s in Context.PhongThis.Where(t => t.Status == 1)
                                select new PhongThiDTO
                                {
                                    Id = s.Id,
                                    TenPhongThi = s.TenPhongThi,
                                    MaPhongThi = s.MaPhongThi,
                                    Status = s.Status,
                                    Port = s.Port,
                                    ThoiGianKetThuc = s.ThoiGianKetThuc,
                                };
            return phongthiQuery.ToArray();
        }

        public ThiSinhDTO GetTaiKhoanThiSinh(int tk)
        {
            var taikhoanQuery = (from s in Context.ThiSinhs
                                 join t in Context.TaiKhoans.Where(t => t.IDThiSinh == tk) on s.Id equals t.IDThiSinh
                                 select new ThiSinhDTO
                                 {
                                     Id = s.Id,
                                     MaThiSinh = s.MaThiSinh,
                                     TenThiSinh = s.TenThiSinh,
                                     HoDem = s.HoDem,
                                     GioiTinh = s.GioiTinh,
                                     HinhAnh = s.HinhAnh
                                 });
            return taikhoanQuery.FirstOrDefault();
        }
    }
}
