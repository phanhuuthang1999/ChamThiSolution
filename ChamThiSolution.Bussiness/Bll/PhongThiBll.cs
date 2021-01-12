using ChamThiSolution.Data.Entities;
using QuanLyChamThiSolution.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.Bussiness.Bll
{
    public class PhongThiBll : BaseBll
    {
        public List<PhongThi> GetAll()
        {
            return Context.PhongThis.AsQueryable().ToList();
        }
        public ThiSinhDTO[] GetThiSinhPhongThi(int idPhongthi)
        {
            var thiSinhQuery = (from p in Context.ThiSinhs
                                join t in Context.TaiKhoans on p.Id equals t.IDThiSinh
                                where t.IDPhongThi == idPhongthi && t.IsHienDien == true
                                select new ThiSinhDTO
                                {
                                    Id = p.Id,
                                    MaThiSinh = p.MaThiSinh,
                                    TenThiSinh = p.TenThiSinh,
                                    HoDem = p.HoDem,
                                    GioiTinh = p.GioiTinh,
                                });
            return thiSinhQuery.ToArray();
        }
        public bool CheckExistPhong(PhongThi pPhongThi)
        {
            return Context.PhongThis.Any(p => p.MaPhongThi == pPhongThi.MaPhongThi && p.Id != pPhongThi.Id);
        }

        public int SetStutus()
        {
            var PhongThi = Context.PhongThis.FirstOrDefault(p => p.Id == 1);

            if (PhongThi == null)
            {
                PhongThi = new PhongThi();
                Context.PhongThis.Add(PhongThi);
            }

            PhongThi.Status = 1;

            return Context.SaveChanges();
        }
    }
}
