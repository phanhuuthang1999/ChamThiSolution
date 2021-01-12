﻿using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using Common;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThiSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private ThiSinhBll _bus;
        private string ID;

        #endregion
        public frmThiSinh()
        {
            InitializeComponent();
            _bus = new ThiSinhBll();
            bbiNew.ItemClick += BbiNew_ItemClick;
            bbiEdit.ItemClick += BbiEdit_ItemClick;
            bbiDelete.ItemClick += BbiDelete_ItemClick;
            bbiRefresh.ItemClick += BbiRefresh_ItemClick;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ID = gridView.GetFocusedRowCellValue("Id").ToString();
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
                var data = _bus.DeleteThiSinh(ID);
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
            frmThemThiSinh frm = new frmThemThiSinh();
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
            gridControl.DataSource = _bus.GetAllThiSinh(null);
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        #region Public

        public ThiSinh ThiSinh { get; set; }

        #endregion
    }
}