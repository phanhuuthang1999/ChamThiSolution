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

    }
}
