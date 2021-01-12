using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.MasterBll
{
    public class GiamThiBll :BaseBll
    {
        public List<GiamThi> GetAllGiamThi(string s)
        {
            var data = Context.GiamThis.AsQueryable();
            if (!string.IsNullOrEmpty(s))
            {
                data = data.Where(h => h.TenGiamThi.Contains(s));
            }
            return data.ToList();
        }

        public bool CheckExistGiamThi(GiamThi pGiamThi)
        {
            return Context.GiamThis.Any(p => p.MaGiamThi == pGiamThi.MaGiamThi);
        }

        public int SaveGiamThi(GiamThi pGiamThi)
        {
            var GiamThi = Context.GiamThis.FirstOrDefault(p => p.MaGiamThi == pGiamThi.MaGiamThi);

            if (GiamThi == null)
            {
                GiamThi = new GiamThi();
                Context.GiamThis.Add(GiamThi);
            }

            GiamThi.MaGiamThi = pGiamThi.MaGiamThi;
            GiamThi.HoDem = pGiamThi.HoDem;
            GiamThi.TenGiamThi = pGiamThi.TenGiamThi;
            GiamThi.GioiTinh = pGiamThi.GioiTinh;
            GiamThi.HinhAnh = pGiamThi.HinhAnh;

            return Context.SaveChanges();
        }

        public int DeleteGiamThi(string pGiamThi)
        {
            var GiamThi = Context.GiamThis.FirstOrDefault(p => p.MaGiamThi == pGiamThi);
            Context.GiamThis.Remove(GiamThi);

            return Context.SaveChanges();
        }
    }
}
