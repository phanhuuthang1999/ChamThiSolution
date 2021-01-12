using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.MasterBll
{
    public class TaiKhoanBll : BaseBll
    {
        public bool CheckQuyen(string TaiKhoan)
        {
            return Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(TaiKhoan) && x.IsQuyen == 1);
        }

        public bool GetLogin(string taikhoan, string matkhau)
        {
            return Context.TaiKhoans.Any(x => x.TenDangNhap.Equals(taikhoan) && x.MatKhau.Equals(matkhau));
        }

        public List<TaiKhoan> GetDanhSach(string s)
        {
            var data = Context.TaiKhoans.AsQueryable();

            if (!string.IsNullOrEmpty(s))
            {
                data = data.Where(p => p.TenDangNhap.Contains(s));
            }
            return data.ToList();
        }

        public bool CheckExist(TaiKhoan pTaiKhoans)
        {
            return Context.TaiKhoans.Any(n => n.TenDangNhap.Equals(pTaiKhoans.TenDangNhap) && n.Id != pTaiKhoans.Id);
        }

        public int SaveTaiKhoan(TaiKhoan pTaiKhoans)
        {
            var TaiKhoans = Context.TaiKhoans.FirstOrDefault(p => p.Id.Equals(pTaiKhoans.Id));
            if (TaiKhoans == null)
            {
                TaiKhoans = new TaiKhoan();
            }
            TaiKhoans.TenDangNhap = pTaiKhoans.TenDangNhap;
            TaiKhoans.MatKhau = pTaiKhoans.MatKhau;
            TaiKhoans.IsActive = pTaiKhoans.IsActive;
            TaiKhoans.IsQuyen = pTaiKhoans.IsQuyen;

            Context.TaiKhoans.Add(TaiKhoans);

            return Context.SaveChanges();
        }

        public int DeleteTaiKhoans(TaiKhoan pTaiKhoans)
        {
            var TaiKhoans = Context.TaiKhoans.FirstOrDefault(p => p.TenDangNhap.Equals(pTaiKhoans.TenDangNhap));

            Context.TaiKhoans.Remove(TaiKhoans);

            return Context.SaveChanges();
        }

        public int DeleteMulti(TaiKhoan pTaiKhoans)
        {
            var TaiKhoans = Context.TaiKhoans.FirstOrDefault(p => p.TenDangNhap.Equals(pTaiKhoans.TenDangNhap));

            Context.TaiKhoans.RemoveRange(Context.TaiKhoans.Where(t => t.Id.Equals(pTaiKhoans.Id)));
            return Context.SaveChanges();
        }

        public List<TaiKhoan> getAllById(int pTaiKhoan)
        {
            return Context.TaiKhoans.Where(h => h.IDPhongThi == pTaiKhoan).AsQueryable().ToList();
        }
    }
}
