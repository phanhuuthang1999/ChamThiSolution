using ChamThiSolution.Data.Entities;
using ChamThiSolution.ProxyObject.Interfaces;
using QuanLyChamThiSolution.Data.DTO;
using System;
using System.Collections.Generic;
using Common;
using ChamThiSolution.Bussiness.Bll;
using System.Linq;

namespace ChamThiSolution.ServerApp.Proxy
{
    public class PrimeProxy : MarshalByRefObject, IPrimeProxy
    {
        #region Variable

        private TaiKhoanBll _bus = new TaiKhoanBll();
        private ChamDiemBll _busKQ = new ChamDiemBll();
        private ThiSinhBll _busTs = new ThiSinhBll();
        private PhongThiBll _busPH = new PhongThiBll();

        #endregion

        #region Events

        public event GetPhongThiMo PhongThiMoReceived;
        public event EnableExam EnableExamReceived;
        public event EndChannel EndReceived;
        public event EndExam EndExamReceived;
        public event GetPoint PointReceived;
        public event CheckIsQuyen IsQuyenReceived;
        public event GetLogin LoginReceived;
        public event GetLoginPhong LoginPhongReceived;
        public event GetPhongThi PhongThiReceived;
        public event GetIdPhongThi IdPhongThiReceived;
        public event GetThiSinhPhongThi ThiSinhPhongThiReceived;
        public event ButtonEnable ButtonEnableReceived;

        #endregion

        #region Methods

        public void ButtonEnable()
        {
            Delegate[] invocationList = ButtonEnableReceived.GetInvocationList();

            foreach (ButtonEnable d in invocationList)
            {
                try
                {
                    d();
                }
                catch (Exception ex)
                {
                    UICommon.ShowMsgErrorString(ex + "", "Error");
                    ButtonEnableReceived -= d;

                }
            }
        }

        public bool CheckIsQuyen(string taikhoan)
        {
            return _bus.CheckQuyenClient(taikhoan);
        }

        public bool EnableRoom()
        {
            return true;
        }

        public bool GetIdPhongThi(string taikhoan, string matkhau, string idPhongThi)
        {
            return _bus.GetIdPhongThi(taikhoan, matkhau, idPhongThi);
        }

        public int GetIdThiSinh(string tk)
        {
            return _busTs.getIdThiSinh(tk);
        }

        public bool GetLogin(string taikhoan, string matkhau)
        {
            return _bus.GetLogin(taikhoan, matkhau);
        }

        public List<PhongThi> GetPhongThi()
        {
            var data = _busPH.GetAll();
            return data.ToList();
        }

        public PhongThiDTO[] GetPhongThiChoThiSinh()
        {
            return _busTs.GetPhongThiChoThiSinh();
        }

        public bool GetPoint(string Answer)
        {
            return true;
        }

        public ThiSinhDTO GetTaiKhoanTS(int tk)
        {
            return _busTs.GetTaiKhoanThiSinh(tk);
        }

        public ThiSinhDTO[] GetThiSinhPhongThi(int idPhongThi)
        {
            return _busPH.GetThiSinhPhongThi(idPhongThi);
        }

        public bool LoginPhong(string IdPhong)
        {
            return true;
        }

        #endregion
    }
}
