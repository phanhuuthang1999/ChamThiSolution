using ChamThiSolution.ClientApp.Terminal;
using ChamThiSolution.ProxyObject;
using ChamThiSolution.ProxyObject.EventsWrapper;
using ChamThiSolution.ProxyObject.Interfaces;
using Common;
using DevExpress.XtraEditors;
using QuanLyChamThiSolution.Data.DTO;
using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;
using System.Windows.Forms;

namespace ChamThiSolution.ClientApp.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        #region Varible

        public static frmLogin cl;

        TwoWaysClientTerminal twoWaysClientTerminal;

        public static IPrimeProxy primeProxy;

        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            cl = this;
            btnOK.Click += btnDangNhap_Click;
            btnCancel.Click += btnThoat_Click;
            btnreload.Click += Btnreload_Click;
            ckcMK.CheckedChanged += CkcMK_CheckedChanged;
            twoWaysClientTerminal = new TwoWaysClientTerminal();
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            for (int attempts = 0; attempts < 20; attempts++)
            // if you really want to keep going until it works, use   for(;;)
            {
                try
                {
                    primeProxy = twoWaysClientTerminal.Connect<IPrimeProxy>(Instance.IPServer, Instance.Port, Instance.objURI, Instance.TcpChannelName);
                    ClientEventsWrapper clientEventsWrapper = new ClientEventsWrapper();
                    // Register wrapper to remoting proxy event
                    primeProxy.LoginReceived += clientEventsWrapper.LoginReceivedHandler;

                    // Register client handler to wrapper event
                    clientEventsWrapper.LoginReceived += ClientEventsWrapper_Login;
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "", "Error");
                    return;
                }

                Thread.Sleep(500);

            }
            LoadPhongThi();
        }

        #endregion

        #region Private
        private void LoadPhongThi()
        {
            PhongThiDTO[] phongThiDTO = primeProxy.GetPhongThiChoThiSinh();
            cbb_maphongthi.DataSource = phongThiDTO;
            cbb_maphongthi.DisplayMember = "TenPhongThi";
            cbb_maphongthi.ValueMember = "Id";
        }

        #endregion

        #region Event

        private void Btnreload_Click(object sender, EventArgs e)
        {
            LoadPhongThi();
        }
        private void CkcMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcMK.Checked)
            {
                txtMK.Properties.UseSystemPasswordChar = true;
            }
            else
                txtMK.Properties.UseSystemPasswordChar = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtTK.ResetText();
            txtMK.ResetText();
            cbb_maphongthi.Text = "";
            txtTK.Focus();
        }

        private bool checkDangNhap(string taikhoan, string matkhau)
        {
            return primeProxy.GetLogin(taikhoan, matkhau);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                UICommon.ShowMsgInfoString("Bạn chưa nhập tên đăng nhập!");
                txtTK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMK.Text))
            {
                UICommon.ShowMsgInfoString("Bạn chưa nhập mật khẩu!");
                txtMK.Focus();
                return;
            }

            if (checkDangNhap(txtTK.Text, txtMK.Text))
            {
                if (primeProxy.CheckIsQuyen(txtTK.Text) && primeProxy.GetIdPhongThi(txtTK.Text, txtMK.Text, cbb_maphongthi.SelectedValue.ToString()))
                {
                    Hide();
                    frmMain frm = new frmMain(txtTK.Text, cbb_maphongthi.SelectedValue.ToString());
                    frm.Show();
                }

                else
                {
                    XtraMessageBox.Show("Bạn không được phép đăng nhập với tài khoản này hoặc phòng thi không đúng", "Đăng nhập thất bại");
                    return;
                }

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