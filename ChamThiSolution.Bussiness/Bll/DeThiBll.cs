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
    }
}
