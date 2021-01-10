using ChamThiSolution.Bussiness.MasterBll;
using DevExpress.XtraBars;
using System;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmPhongThi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private PhongThiBll _bus;
        private TaiKhoanBll _bustk;
        string ID ;

        #endregion

        #region Constructor

        public frmPhongThi()
        {
            InitializeComponent();
            _bus = new PhongThiBll();
            _bustk = new TaiKhoanBll();
            gridView1.RowClick  += GridView1_Click;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            btnNew.ItemClick += BtnNew_ItemClick;

            loadPhongThi();
        }

        #region Private

        private void loadPhongThi()
        {
            gridPhongThi.DataSource = _bus.GetAll();
        } 

        #endregion

        private void BtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThemPhongThi frm = new frmThemPhongThi();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                loadPhongThi();
            }
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ID = gridView1.GetFocusedRowCellValue("Id").ToString();
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            gridTaiKhoan.DataSource = _bustk.getAllById(int.Parse(ID));
        }
  
        #endregion

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridTaiKhoan.ShowRibbonPrintPreview();
        }

    }
}
