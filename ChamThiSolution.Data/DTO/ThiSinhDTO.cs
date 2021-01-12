using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamThiSolution.Data.DTO
{
    [Serializable]
    public class ThiSinhDTO
    {
        public int Id { get; set; }

        public string MaThiSinh { get; set; }

        public string TenThiSinh { get; set; }

        public string HoDem { get; set; }

        public int? GioiTinh { get; set; }

        public byte[] HinhAnh { get; set; }

        public int[] idPhongThi { get; set; }
    }
}
