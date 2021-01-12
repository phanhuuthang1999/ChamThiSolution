using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using ChamThiSolution.Server.Forms;
using ChamThiSolution.ServerApp.Proxy;
using System;
using System.Runtime.Remoting.Channels.Tcp;

namespace ChamThiSolution.ServerApp.Forms
{
    public partial class frmPhongThi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private PhongThiBll _bus;
        private PrimeProxy primeProxy = frmMain.primeProxy;

        #endregion

        #region Constructor

        public frmPhongThi()
        {
            InitializeComponent();
            _bus = new PhongThiBll();

            btnThuBai.ItemClick += TsThuBai_Click;
            btnCamThi.ItemClick += TsCamThi_Click;
            btnBatDau.ItemClick += TsBatDau_Click;
        }

        #endregion

        #region Events

        private void TsBatDau_Click(object sender, EventArgs e)
        {
            primeProxy.EnableRoom();
        }

        private void TsCamThi_Click(object sender, EventArgs e)
        {
            //gridSv
        }
        private void TsThuBai_Click(object sender, EventArgs e)
        {
            //primeProxy.EndEXam();
        }

        #endregion

        #region Public 

        public PhongThi PhongThi { get; set; }

        #endregion
    }
}