using ChamThiSolution.ProxyObject;
using ChamThiSolution.ServerApp.Forms;
using ChamThiSolution.ServerApp.Proxy;
using ChamThiSolution.ServerApp.Terminal;
using DevExpress.XtraBars;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace ChamThiSolution.Server.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private TcpChannel tcpChannel = null;
        public static PrimeProxy primeProxy;

        #endregion

        #region Constructor

        public frmMain(string chao)
        {
            InitializeComponent();

            #region RegistEvent

            lblChao.Caption += chao;
            btnPhongThi.ItemClick += BtnPhongThi_ItemClick;
            btnDangXuat.ItemClick += BtnDangXuat_ItemClick;
            FormClosing += FrmMain_FormClosing;
            #endregion

        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Enable();
        }

        #endregion

        #region Private
        private void Enable()
        {
            primeProxy = new PrimeProxy();
            tcpChannel = TwoWaysServerTerminal.StartListening(Instance.Port, Instance.TcpChannelName, primeProxy, Instance.objURI);
        }

        private Form isActive(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        #endregion

        #region Events

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChannelServices.GetChannel(tcpChannel.ChannelName) != null)
            {
                RemotingServices.Disconnect(this);
                ChannelServices.UnregisterChannel(tcpChannel);
            }
            Application.ExitThread();
            Application.Exit();
        }

        private void BtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void BtnPhongThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmPhongThi));
            if (f == null)
            {
                frmPhongThi frm = new frmPhongThi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                f.Activate();
        }

        #endregion

    }
}