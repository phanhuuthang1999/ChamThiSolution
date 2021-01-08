using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private TaiKhoanBll _bus;

        #endregion
        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            _bus = new TaiKhoanBll();

            this.FormClosing += FrmDangNhap_FormClosing;
            btnCancel.Click += BtnHuy_Click;
            btnOK.Click += BtnDangNhap_Click;
            ckcMK.CheckedChanged += CheckBox1_CheckedChanged;
            ckcNhoPass.Click += CkcNhoPass_Click;
            Load += FrmDangNhap_Load;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTK.Text = Properties.Settings.Default.UserName;
            txtMK.Text = Properties.Settings.Default.Password;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (TaiKhoan != null)
            {
                // SetData();

            }
        }

        #endregion

        #region Private

        private void SetData()
        {
            txtTK.Text = TaiKhoan.TenDangNhap;
            txtMK.Text = TaiKhoan.MatKhau;
        }

        public void GetData()
        {
            if (TaiKhoan == null)
            {
                TaiKhoan = new TaiKhoan();
            }

            TaiKhoan.TenDangNhap = txtTK.Text;
            TaiKhoan.MatKhau = txtMK.Text;
        }

        #endregion

        #region Events
        private void CkcNhoPass_Click(object sender, EventArgs e)
        {
            if (ckcNhoPass.Checked)
            {
                Properties.Settings.Default.UserName = txtTK.Text;
                Properties.Settings.Default.Password = txtMK.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            txtTK.ResetText();
            txtMK.ResetText();
            txtTK.Focus();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTK.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập tài khoản.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMK.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }

            GetData();



            if (_bus.GetLogin(txtTK.Text, txtMK.Text))
            {
                if (_bus.CheckQuyenMaster(txtTK.Text))
                {
                    Hide();
                    frmMain frm = new frmMain();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                    }
                    if (ckcNhoPass.Checked)
                    {
                        Properties.Settings.Default.UserName = txtTK.Text;
                        Properties.Settings.Default.Password = txtMK.Text;
                        Properties.Settings.Default.Save();

                    }
                    else
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn không được phép đăng nhập với tài khoản này", "Đăng nhập thất bại");
                    return;
                }
                
            }
            else
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Đăng nhập thất bại");
                return;
            }
        }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (ckcMK.Checked)
        {
            txtMK.Properties.UseSystemPasswordChar = true;
        }
        else
            txtMK.Properties.UseSystemPasswordChar = false;
    }

    #endregion

    #region Properties

    public TaiKhoan TaiKhoan { get; set; }

    #endregion
}
}