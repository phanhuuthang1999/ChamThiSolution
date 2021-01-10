using ChamThiSolution.Bussiness.MasterBll;
using DevExpress.XtraBars;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmGiamThi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private GiamThiBll _bus;

        #endregion
        public frmGiamThi()
        {
            InitializeComponent();
            _bus = new GiamThiBll();
            bbiNew.ItemClick += BbiNew_ItemClick;
            bbiEdit.ItemClick += BbiEdit_ItemClick;
            bbiDelete.ItemClick += BbiDelete_ItemClick;
            bbiRefresh.ItemClick += BbiRefresh_ItemClick;
        }

        private void BbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void BbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThemGiamThi frm = new frmThemGiamThi();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                LoadData();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadData();
        }

        private void LoadData()
        {
            gridControl.DataSource = _bus.GetAllGiamThi(null);
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
    }
}