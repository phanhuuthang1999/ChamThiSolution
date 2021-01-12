using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using Common;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmCauHoi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private CauHoiBll _bus;
        private string ID;
        private string MaCau;
        private string TenCau;
        private string NoiDung;

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
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;

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

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ID = gridView.GetFocusedRowCellValue("Id").ToString();
            MaCau = gridView.GetFocusedRowCellValue("MaCauHoi").ToString();
            TenCau = gridView.GetFocusedRowCellValue("TenCauHoi").ToString();
            NoiDung = gridView.GetFocusedRowCellValue("NoiDungCauHoi").ToString();
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
                var data = _bus.DeleteCauHoi(ID);
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
            if (!string.IsNullOrEmpty(ID))
            {
                frmThemCauHoi frm = new frmThemCauHoi();
                frm.LoadData(ID,MaCau,TenCau,NoiDung);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                } 
            }
        }

        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThemCauHoi frm = new frmThemCauHoi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        #endregion

        #region Public 

        public CauHoi CauHoi { get; set; }

        #endregion
    }
}