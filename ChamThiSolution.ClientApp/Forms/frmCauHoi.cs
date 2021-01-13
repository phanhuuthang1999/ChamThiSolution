using ChamThiSolution.ProxyObject.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.ClientApp.Forms
{
    public partial class frmCauHoi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        public static IPrimeProxy primeProxy;
        string tenPhong;
        string cauhoi;
        string noidung;

        #endregion

        #region Constructure

        public frmCauHoi(string _idPhong, IPrimeProxy _primeProxy)
        {
            InitializeComponent();
            tenPhong = _idPhong;
            primeProxy = _primeProxy;
            dataGridView1.CellClick += GRVDethi_CellClick;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dataGridView1.DataSource = primeProxy.GetDeThiChoPhong(tenPhong);
        }

        #endregion

        private void GRVDethi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cauhoi = row.Cells[2].Value.ToString();
                noidung = row.Cells[3].Value.ToString();
            }
            frmBaiThi frmCH = new frmBaiThi(cauhoi, noidung);
            frmCH.Show();
        }
    }
}