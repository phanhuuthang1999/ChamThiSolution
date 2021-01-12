using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.MasterBll
{
    public class ThiSinhBll : BaseBll
    {
        public List<ThiSinh> GetAllThiSinh(string s)
        {
            var data = Context.ThiSinhs.AsQueryable();
            if (!string.IsNullOrEmpty(s))
            {
                data = data.Where(h => h.TenThiSinh.Contains(s));
            }
            return data.ToList();
        }

        public bool CheckExistThiSinh(ThiSinh pThiSinh)
        {
            return Context.ThiSinhs.Any(p => p.MaThiSinh == pThiSinh.MaThiSinh);
        }

        public int SaveThiSinh(ThiSinh pThiSinh)
        {
            var ThiSinh = Context.ThiSinhs.FirstOrDefault(p => p.MaThiSinh == pThiSinh.MaThiSinh);

            if (ThiSinh == null)
            {
                ThiSinh = new ThiSinh();
                Context.ThiSinhs.Add(ThiSinh);
            }

            ThiSinh.MaThiSinh = pThiSinh.MaThiSinh;
            ThiSinh.HoDem = pThiSinh.HoDem;
            ThiSinh.TenThiSinh = pThiSinh.TenThiSinh;
            ThiSinh.GioiTinh = pThiSinh.GioiTinh;
            ThiSinh.HinhAnh = pThiSinh.HinhAnh;

            return Context.SaveChanges();
        }

        public int DeleteThiSinh(string ID)
        {
            var ThiSinh = Context.ThiSinhs.FirstOrDefault(p => p.MaThiSinh == ID);
            Context.ThiSinhs.Remove(ThiSinh);

            return Context.SaveChanges();
        }

        public int getIdThiSinh(string tk)
        {
            var a = from t in Context.TaiKhoans.Where(t => t.TenDangNhap.Equals(tk))
                    join s in Context.ThiSinhs on t.IDThiSinh equals s.Id
                    select s.Id;
            return a.FirstOrDefault();
        }
    }
}
