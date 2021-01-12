using ChamThiSolution.ClientApp.Terminal;
using ChamThiSolution.ProxyObject.EventsWrapper;
using ChamThiSolution.ProxyObject.Interfaces;
using QuanLyChamThiSolution.Data.DTO;
using System;
using System.Drawing;
using System.Runtime.Remoting.Channels.Tcp;

namespace ChamThiSolution.ClientApp.Forms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        #region Varible

        public static frmLogin cl;
        TwoWaysClientTerminal twoWaysClientTerminal;
        TwoWaysClientTerminal c_terminal;
        IPrimeProxy primeProxy = frmLogin.primeProxy;
        TcpChannel tcpChannel;
        private string TkText;

        #endregion

        #region Constructor

        public frmMain(string s, string cbb)
        {
            InitializeComponent();

            TkText = s;
            txtPhongThi.Text = cbb;
            ClientEventsWrapper clientEventsWrapper = new ClientEventsWrapper();

            primeProxy.EnableExamReceived += clientEventsWrapper.ExamReceivedHandler;

            // Register client handler to wrapper event
            clientEventsWrapper.ExamReceived += ClientEventsWrapper_ExamReceived; ;

            btnThi.Click += BtnThi_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (primeProxy.CheckIsQuyen(TkText))
            {
                int id = primeProxy.GetIdThiSinh(TkText);
                ThiSinhDTO thiSinhDTO = primeProxy.GetTaiKhoanTS(id);
                txtHoDem.Text = thiSinhDTO.HoDem;
                txtTen.Text = thiSinhDTO.TenThiSinh;
                txtMSSV.Text = thiSinhDTO.MaThiSinh;
                txtGioiTinh.Text = thiSinhDTO.GioiTinh == 1 ? "Nam" : "Nữ";
                if (thiSinhDTO.HinhAnh != null)
                {
                    Image img = Common.UICommon.ByteArrayToImage(thiSinhDTO.HinhAnh);
                    pictureEdit1.Image = img;
                }
            }
            PhongThiDTO[] phongThiDTO = primeProxy.GetPhongThiChoThiSinh();

        }

        #endregion

        #region Private
        private void ClientEventsWrapper_ExamReceived()
        {
            btnThi.Enabled = true;
        }
        #endregion

        #region Events
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //primeProxy.EnableRoom();
            btnThi.Enabled = true;
        }

        private void BtnThi_Click(object sender, EventArgs e)
        {
            frmBaiThi fmr = new frmBaiThi();
            fmr.ShowDialog();
        }

        #endregion

    }

}