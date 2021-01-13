using System;


namespace ChamThiSolution.Data.DTO
{
    [Serializable]
    public partial class CauHoiDTO
    {
        public int Id { get; set; }
        public string MaCauHoi { get; set; }
        public string TenCauHoi { get; set; }
        public string NoiDungCauHoi { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
