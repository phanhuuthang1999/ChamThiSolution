using Common;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            btnPhongThi.ItemClick += BtnPhongThi_ItemClick;
            btnDangXuat.ItemClick += BtnDangXuat_ItemClick;
            btnGiamThi.ItemClick += BtnGiamThi_ItemClick;
            btnThiSinh.ItemClick += BtnThiSinh_ItemClick;
            btnTaiKhoan.ItemClick += BtnTaiKhoan_ItemClick;
            btnPhanQuyen.ItemClick += BtnPhanQuyen_ItemClick;
            btnNhapMon.ItemClick += BtnNhapMon_ItemClick;
        }

        #endregion

        #region Private
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
        private void BtnGiamThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmGiamThi));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmGiamThi frm = new frmGiamThi();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        private void BtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICommon.ShowMsgQuestionString("Bạn có chắc muốn thoát") == DialogResult.Yes)
            {
                Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private void BtnPhongThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmPhongThi));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmPhongThi frm = new frmPhongThi();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        private void BtnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmPhanQuyen));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmPhanQuyen frm = new frmPhanQuyen();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        private void BtnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmTaiKhoan));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmTaiKhoan frm = new frmTaiKhoan();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        private void BtnThiSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmThiSinh));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmThiSinh frm = new frmThiSinh();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        private void BtnNhapMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = isActive(typeof(frmCauHoi));
            if (f == null)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                frmCauHoi frm = new frmCauHoi();
                frm.MdiParent = this;
                frm.Show();
                SplashScreenManager.CloseForm(false);
            }
            else
                f.Activate();
        }

        #endregion

    }
}