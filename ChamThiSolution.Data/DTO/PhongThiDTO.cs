using System;

namespace QuanLyChamThiSolution.Data.DTO
{   
    [Serializable]
    public partial class PhongThiDTO
    {
        public int Id { get; set; }

        public string MaPhongThi { get; set; }

        public string TenPhongThi { get; set; }

        public int? Port { get; set; }

        /// <summary>
        /// - 1 : Khởi tạo chờ thi
        ///   0 : Bắt đầu thi
        ///   1 : Kết thúc
        /// </summary>
        public int? Status { get; set; }

        public TimeSpan? ThoiGianKetThuc { get; set; }
    }
}
