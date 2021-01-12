using QuanLyChamThiSolution.Data.DTO;
using System.Linq;

namespace ChamThiSolution.Bussiness.Bll
{
    public class TaiKhoanBll : BaseBll
    {
        public bool CheckQuyenMaster(string TaiKhoan)
        {
            return Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(TaiKhoan) && x.IsQuyen == 1);
        }
        public bool CheckQuyenServer(string TaiKhoan)
        {
            return Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(TaiKhoan) && x.IsQuyen == 0);
        }
        public bool CheckQuyenClient(string TaiKhoan)
        {
            return Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(TaiKhoan) && x.IsQuyen == -1);
        }

        public bool GetLogin(string TaiKhoans, string matkhau)
        {
            return Context.TaiKhoans.Any(h => h.TenDangNhap.Equals(TaiKhoans) && h.MatKhau.Equals(matkhau));
        }

        public bool GetisActive(string tk)
        {
            return Context.TaiKhoans.Any(t => t.TenDangNhap.Equals(tk) && t.IsActive.Equals(false));
        }

        public bool GetIdPhongThi(string taikhoan, string matkhau, string idPhongThi)
        {
            var result = Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(taikhoan) && x.MatKhau.Equals(matkhau) && x.IDPhongThi.ToString().Equals(idPhongThi));
            if (result == true)
            {
                var tk = (from p in Context.TaiKhoans
                          where p.TenDangNhap == taikhoan
                          select p).SingleOrDefault();
                tk.IsHienDien = true;
                Context.SaveChanges();
            }
            return result;
        }
    }
}
