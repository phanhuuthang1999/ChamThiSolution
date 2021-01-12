using ChamThiSolution.Data.Entities;
using System.Linq;

namespace ChamThiSolution.Bussiness.Bll
{
    public class ChamDiemBll : BaseBll
    {
        public int ChamDiem(string Answer)
        {
            // Select join
            var query = from tc in Context.TestCases
                        join kq in Context.KetQuas on tc.Id equals kq.Id
                        join tc_kq in Context.TC_KQ on tc.Id equals tc_kq.Id
                        select new { tc, kq, tc_kq };

            //isTrue?
            if (!string.IsNullOrEmpty(Answer))
            {
                query = query.Where(x => x.tc_kq.IsTrue.Equals(Answer.Equals(x.tc.OutPut)));
            };

            return Context.KetQuas.Where(t => t.DiemThi.Equals(1)).Count();
        }

        public bool HetGio(PhongThi pPhongThi)
        {
            //    var phong = Context.PhongThis.Where(t => t.Id.Equals(pPhongThi.Id));

            //    if (phong == null)
            //    {
            //        phong = new PhongThi();
            //    }

            return true;
        }
    }
}
