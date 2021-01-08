using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamThiSolution.Bussiness.MasterBll
{
    public class PhongThiBll : BaseBll
    {
        public List<PhongThi> GetAll()
        {
            return Context.PhongThis.AsQueryable().ToList();
        }

        public List<PhongThi> GetAllPhongThis(string s)
        {
            var data = Context.PhongThis.AsQueryable();
            if (!string.IsNullOrEmpty(s))
            {
                data = data.Where(h => h.TenPhongThi.Contains(s));
            }
            return data.ToList();
        }

        public bool CheckExistPhong(PhongThi pPhongThi)
        {
            return Context.PhongThis.Any(p => p.MaPhongThi == pPhongThi.MaPhongThi);
        }

        public int SavePhongThi(PhongThi pPhongThi)
        {
            var PhongThi = Context.PhongThis.FirstOrDefault(p => p.Id == pPhongThi.Id);

            if (PhongThi == null)
            {
                PhongThi = new PhongThi();
                Context.PhongThis.Add(PhongThi);
            }

            PhongThi.MaPhongThi = pPhongThi.MaPhongThi;
            PhongThi.TenPhongThi = pPhongThi.TenPhongThi;
            PhongThi.Port = pPhongThi.Port;
            PhongThi.Status = pPhongThi.Status;
            PhongThi.ThoiGianKetThuc = pPhongThi.ThoiGianKetThuc;

            return Context.SaveChanges();
        }

        public int DeletePhongThi(PhongThi pPhongThi)
        {
            var PhongThi = Context.PhongThis.FirstOrDefault(p => p.MaPhongThi == pPhongThi.MaPhongThi);
            Context.PhongThis.Remove(PhongThi);


            return Context.SaveChanges();
        }

        /// <summary>
        /// Trạng Thái 1 : Đang có sinh viên thi : 0
        /// </summary>
        /// <param name="pPhongThi"></param>
        /// <returns></returns>
        public bool CheckExistInPhongThi(PhongThi pPhongThi)
        {
            return Context.PhongThis.Any(h => h.Status.Equals(pPhongThi.Status == 1));
        }
    }
}
