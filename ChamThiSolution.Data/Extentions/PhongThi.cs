
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamThiSolution.Data.Entities
{
    public partial class PhongThi
    {
        [NotMapped]
        public string TrangThai 
        { 
            get 
            { 
                return Status == 1 ? "Khởi tạo" : Status == 2 ? "Đang Thi" : "Đã Đóng"; 
            } 
        }

    //    public DateTime ThoiGianLamBai
    //    {
    //        get { return ThoiGianKetThuc - ThoiGianLamBai; }
    //    }
    }
}
