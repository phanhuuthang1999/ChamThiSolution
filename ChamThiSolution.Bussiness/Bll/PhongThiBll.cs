using ChamThiSolution.Data.Entities;
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
    }
}
