using ChamThiSolution.Bussiness.MasterBll;
using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmCauHoi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private CauHoiBll _bus;

        #endregion

        #region Constructor

        public frmCauHoi()
        {
            InitializeComponent();
            _bus = new CauHoiBll();
            bbiNew.ItemClick += BbiNew_ItemClick;
            bbiEdit.ItemClick += BbiEdit_ItemClick;
            bbiDelete.ItemClick += BbiDelete_ItemClick;
            bbiRefresh.ItemClick += BbiRefresh_ItemClick;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadData();
        }

        #endregion

        #region Private

        private void LoadData()
        {
            gridControl.DataSource = _bus.GetAllQuestion(null);
        }

        #endregion

        #region Events

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
            frmThemCauHoi frm = new frmThemCauHoi();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                LoadData();
            }
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        #endregion
    }
}