using ChamThiSolution.Data.DTO;
using ChamThiSolution.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.Bll
{
    public class DeThiBll : BaseBll
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

        public CauHoiDTO[] GetDeThiChoPhong(string tenPhong)
        {
            var deThiQuery = (from s in Context.CauHois
                              select new CauHoiDTO
                              {
                                  Id = s.Id,
                                  MaCauHoi = s.MaCauHoi,
                                  TenCauHoi = s.TenCauHoi,
                                  NoiDungCauHoi = s.NoiDungCauHoi,
                                  HinhAnh = s.HinhAnh
                              });
            return deThiQuery.ToArray();
        }
    }
}
