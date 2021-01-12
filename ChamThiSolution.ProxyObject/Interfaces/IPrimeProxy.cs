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
    public delegate void EndExam();
    public delegate void GetPoint(string Answer);

    [Serializable]
    public delegate bool CheckIsQuyen(string taikhoan);
    public delegate bool GetLogin(string taikhoan, string matkhau);
    public delegate bool GetLoginPhong(string IdPhong);
    //public delegate void GetConnection();
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
    public delegate void ButtonEnable();



    public interface IPrimeProxy
    {
        event GetPhongThiMo PhongThiMoReceived;
        void ButtonEnable();
        PhongThiDTO[] GetPhongThiChoThiSinh();

        ThiSinhDTO[] GetThiSinhPhongThi(int idPhongThi);

        bool GetIdPhongThi(string taikhoan, string matkhau, string idPhongThi);
        //void GetConnection();

        bool LoginPhong(string IdPhong);

        bool CheckIsQuyen(string taikhoan);
        bool GetLogin(string taikhoan, string matkhau);

        int GetIdThiSinh(string tk);

        ThiSinhDTO GetTaiKhoanTS(int tk);

        List<PhongThi> GetPhongThi();

        bool EnableRoom();

        //Task<int> EndChannel();

        //Task<int> EndEXam();

        bool GetPoint(string Answer);

        event EnableExam EnableExamReceived;

        event EndChannel EndReceived;

        event EndExam EndExamReceived;

        event GetPoint PointReceived;

        event CheckIsQuyen IsQuyenReceived;

        event GetLogin LoginReceived;

        event GetLoginPhong LoginPhongReceived;

        //event GetConnection ConnectReceived;

        event GetPhongThi PhongThiReceived;

        event GetIdPhongThi IdPhongThiReceived;

        event GetThiSinhPhongThi ThiSinhPhongThiReceived;

        event ButtonEnable ButtonEnableReceived;
    }
}
