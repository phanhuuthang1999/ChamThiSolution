using ChamThiSolution.Data.Entities;

namespace ChamThiSolution.Bussiness.Bll
{
    public class BaseBll
    {
        private ChamThiDbContext _context;

        public BaseBll()
        {
            Context = new ChamThiDbContext();
        }

        public ChamThiDbContext Context { get => _context; set => _context = value; }
    }
}
