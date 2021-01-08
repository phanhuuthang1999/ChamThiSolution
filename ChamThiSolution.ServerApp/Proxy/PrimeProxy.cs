using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using ChamThiSolution.ProxyObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChamThiSolution.ServerApp.Proxy
{
    public class PrimeProxy : MarshalByRefObject, IPrimeProxy
    {
        #region Variable

        private TaiKhoanBll _bus;
        //private KetQuaBll _busKQ;
        //private ThiSinhBll _busTs;
        //private PhongThiBll _busPH;

        #endregion

        #region Constructor

        public PrimeProxy()
        {
            _bus = new TaiKhoanBll();
            //_busKQ = new KetQuaBll();
            //_busTs = new ThiSinhBll();
            //_busPH = new PhongThiBll();
        }

        #endregion

        #region Events

        public event EnableExam EnableExamReceived;
        public event EndChannel EndReceived;
        public event EndExam EndExamReceived;
        public event GetPoint PointReceived;
        public event GetLogin LoginReceived;
        public event GetConnection ConnectReceived;
        public event GetLoginPhong LoginPhongReceived;
        public event CheckIsQuyen IsQuyenReceived;
        public event loadThongTin loadThongTinReceived;
        public event GetIdThiSinh getIdThiSinhReceived;
      //  public event GetTaiKhoanTS getTaiKhoanTSReceived;
        public event GetPhongThi PhongThiReceived;

        #endregion
        //public ThiSinhDTO GetTaiKhoanTS(int tk)
        //{
        //    return _busTs.GetTaiKhoanThiSinh(tk);
        //}


        public bool EnableRoom()
        {

            throw new NotImplementedException();
        }

        //public async Task<int> EndChannel()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<int> EndEXam()
        //{
        //    return await 1;
        //}

        public bool GetPoint(string Answer)
        {
            return true;
        }

        public void GetConnection()
        {
            Delegate[] invocationList = ConnectReceived.GetInvocationList();

            foreach (GetConnection item in invocationList)
            {
                try
                {
                     item();
                }
                catch (Exception)
                {

                    ConnectReceived -= item;
                }
            }
        }

        public bool CheckIsQuyen(string taikhoan)
        {
            return _bus.CheckQuyenClient(taikhoan);
        }

        public bool GetLogin(string taikhoan, string matkhau)
        {
            return _bus.GetLogin(taikhoan, matkhau);
        }

        public bool LoginPhong(string IdPhong)
        {
            throw new NotImplementedException();
        }

        //public List<PhongThi> GetPhongThi()
        //{
        //    var data = _busPH.GetAll();
        //    return data.ToList();
        //}

        //public int GetIdThiSinh(string tk)
        //{
        //    return _busTs.getIdThiSinh(tk);
        //}
    }
}
