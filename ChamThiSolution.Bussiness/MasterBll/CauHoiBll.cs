using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.MasterBll
{
    public class CauHoiBll : BaseBll
    {

        public List<CauHoi> GetAllQuestion(string s)
        {
            var data = Context.CauHois.AsQueryable();
            if (!string.IsNullOrEmpty(s))
            {
                data = data.Where(h => h.TenCauHoi.Contains(s));
            }
            return data.ToList();
        }

        public bool CheckExistQuestion(CauHoi pCauHoi)
        {
            return Context.CauHois.Any(p => p.MaCauHoi == pCauHoi.MaCauHoi && p.Id != pCauHoi.Id);
        }

        public int SaveQuestion(CauHoi pCauHoi)
        {
            var CauHoi = Context.CauHois.FirstOrDefault(p => p.MaCauHoi == pCauHoi.MaCauHoi);

            if (CauHoi == null)
            {
                CauHoi = new CauHoi();
                Context.CauHois.Add(CauHoi);
            }

            CauHoi.MaCauHoi = pCauHoi.MaCauHoi;
            CauHoi.TenCauHoi = pCauHoi.TenCauHoi;
            CauHoi.NoiDungCauHoi = pCauHoi.NoiDungCauHoi;
           // CauHoi.HinhAnh = pCauHoi.HinhAnh;

            return Context.SaveChanges();
        }

        public int DeleteCauHoi(string pCauHoi)
        {
            var CauHoi = Context.CauHois.FirstOrDefault(p => p.MaCauHoi == pCauHoi);
            Context.CauHois.Remove(CauHoi);

            return Context.SaveChanges();
        }

    }
}
