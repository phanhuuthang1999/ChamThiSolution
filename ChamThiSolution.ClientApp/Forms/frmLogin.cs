using ChamThiSolution.ClientApp.Terminal;
using ChamThiSolution.ProxyObject;
using ChamThiSolution.ProxyObject.EventsWrapper;
using ChamThiSolution.ProxyObject.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace ChamThiSolution.ClientApp.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region Varible
        public static frmLogin cl;

        TwoWaysClientTerminal twoWaysClientTerminal;

        IPrimeProxy primeProxy;

        TcpChannel tcpChannel;

        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            cl = this;
            btnOK.Click += btnDangNhap_Click;
            btnCancel.Click += btnThoat_Click;
            twoWaysClientTerminal = new TwoWaysClientTerminal();
        }
        #endregion

        #region Event

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkDangNhap(string taikhoan, string matkhau)
        {
            return primeProxy.GetLogin(taikhoan, matkhau);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txtTK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtMK.Focus();
                return;
            }
            try
            {
                primeProxy = twoWaysClientTerminal.Connect<IPrimeProxy>(Instance.IPServer, Instance.Port, Instance.objURI, Instance.TcpChannelName);

                ClientEventsWrapper clientEventsWrapper = new ClientEventsWrapper();
                // Register wrapper to remoting proxy event
                primeProxy.LoginReceived += clientEventsWrapper.LoginReceivedHandler;

                // Register client handler to wrapper event
                clientEventsWrapper.LoginReceived += ClientEventsWrapper_Login;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Error");
            }

            if (checkDangNhap(txtTK.Text, txtMK.Text))
            {
                if (primeProxy.CheckIsQuyen(txtTK.Text))
                {

                }

                else
                {
                    XtraMessageBox.Show("Bạn không được phép đăng nhập với tài khoản này", "Đăng nhập thất bại");
                    return;
                }
                Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Đăng nhập thất bại");
                return;
            }



        }

        private bool ClientEventsWrapper_Login(string taikhoan, string matkhau)
        {
            return checkDangNhap(taikhoan, matkhau);
        }

        #endregion
    }
}