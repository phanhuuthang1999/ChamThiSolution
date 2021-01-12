using ChamThiSolution.Data.Entities;
using QuanLyChamThiSolution.Data.DTO;
using System;
using System.Collections.Generic;

namespace ChamThiSolution.ProxyObject.Interfaces
{
    /// <summary>
    /// Kích hoạt giờ thi
    /// </summary>
    [Serializable]
    public delegate void EnableExam();

    /// <summary>
    /// Hết giờ hoặc thí sinh vi phạm | Lấy kết quả từ server để chấm
    /// </summary>
    [Serializable]
    #region

    public delegate void EndChannel();
    public delegate void NopBai();
    public delegate void ReceiveResult();

    #endregion

    /// <summary>
    /// Lấy kết quả trả về cho thí sinh điểm
    /// </summary>
    [Serializable]
    public delegate void GetDeThi();
    public delegate void EndExam();
    public delegate void GetPoint(string Answer);

    [Serializable]
    public delegate bool CheckIsQuyen(string taikhoan);
    public delegate bool GetLogin(string taikhoan, string matkhau);
    public delegate bool GetLoginPhong(string IdPhong);
    public delegate List<PhongThi> GetPhongThi();

    [Serializable]
    public delegate void loadThongTin();
    public delegate int GetIdThiSinh(string tk);

    [Serializable]
    public delegate ThiSinhDTO GetTaiKhoanTS(int tk);
    public delegate PhongThiDTO[] GetPhongThiChoThiSinh();
    public delegate bool GetIdPhongThi(string taikhoan, string matkhau, string idPhongThi);
    public delegate ThiSinhDTO[] GetThiSinhPhongThi(int idPhongthi);
    public delegate bool GetPhongThiMo(int idPhongThi);



    public interface IPrimeProxy
    { 

        PhongThiDTO[] GetPhongThiChoThiSinh();

        ThiSinhDTO[] GetThiSinhPhongThi(int idPhongThi);

        void NopBai();

        bool GetIdPhongThi(string taikhoan, string matkhau, string idPhongThi);
        //void GetConnection();

        bool LoginPhong(string IdPhong);

        bool CheckIsQuyen(string taikhoan);
        bool GetLogin(string taikhoan, string matkhau);

        int GetIdThiSinh(string tk);

        ThiSinhDTO GetTaiKhoanTS(int tk);

        List<PhongThi> GetPhongThi();

        void GetDeThi();

        void EnableRoom();

        bool GetPoint(string Answer);

        event NopBai NopBaiReceived;

        event GetPhongThiMo PhongThiMoReceived;

        event EnableExam EnableExamReceived;

        event EndChannel EndReceived;

        event EndExam EndExamReceived;

        event GetPoint PointReceived;

        event CheckIsQuyen IsQuyenReceived;

        event GetLogin LoginReceived;

        event GetLoginPhong LoginPhongReceived;

        event GetPhongThi PhongThiReceived;

        event GetIdPhongThi IdPhongThiReceived;

        event GetThiSinhPhongThi ThiSinhPhongThiReceived;

        event GetDeThi DeThiReceived;

    }
}
