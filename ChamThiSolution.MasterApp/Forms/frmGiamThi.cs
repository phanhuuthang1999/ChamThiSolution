using ChamThiSolution.Bussiness.MasterBll;
using Common;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
        private string ID;

        #endregion
        public frmGiamThi()
        {
            InitializeComponent();
            _bus = new GiamThiBll();
            bbiNew.ItemClick += BbiNew_ItemClick;
            bbiEdit.ItemClick += BbiEdit_ItemClick;
            bbiDelete.ItemClick += BbiDelete_ItemClick;
            bbiRefresh.ItemClick += BbiRefresh_ItemClick;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ID = gridView.GetFocusedRowCellValue("MaGiamThi").ToString();
        }

        private void BbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void BbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var data = _bus.DeleteGiamThi(ID);
                if (data > 0)
                {
                    UICommon.ShowMsgInfoString("Xóa thành công");
                    LoadData();
                }
                else
                    UICommon.ShowMsgErrorString("Xóa thất bại");
            }
            else
                return;
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
