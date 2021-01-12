using ChamThiSolution.Bussiness.MasterBll;
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
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private TaiKhoanBll _bus;
        private string Id;

        #endregion

        #region Constructor

        public frmThemTaiKhoan()
        {
            InitializeComponent();
            _bus = new TaiKhoanBll();
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            //LoadData(Id, txtMa.Text, txtTen.Text, txtNoiDung.Text);
          //  Load += FrmThemTaiKhoan_Load;
        }

        //public void LoadData(string s, string s1, string s2, string s3)
        //{
        //    txtMa.Text = s;
        //    txtTen.Text = s1;
        //    txtNoiDung.Text = s2;
        //    Id = s3;
        //}

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetData();
            if (TaiKhoan != null)
            {
                if (TaiKhoan.Id == 0)
                {
                    this.Text = "SAO CHÉP THÍ SINH";
                }
                this.Text = "CẬP NHẬT THÍ SINH";
            }

        }

        #endregion

        #region Private

        private void SetData()
        {
            //if (TaiKhoan == null)
            //{
            //    return;
            //}
            //txtMa.Text = TaiKhoan.MaTaiKhoan;
            //txtHoDem.Text = TaiKhoan.HoDem;
            //txtTen.Text = TaiKhoan.TenTaiKhoan;
            //lookUpEdit1.EditValue = TaiKhoan.GioiTinh;
            //// txtHinhAnh.Text = TaiKhoan.HinhAnh;
        }

        private void GetData()
        {
            //if (TaiKhoan == null)
            //{
            //    TaiKhoan = new TaiKhoan();
            //}
            //TaiKhoan.MaTaiKhoan = txtMa.Text;
            //TaiKhoan.HoDem = txtHoDem.Text;
            //TaiKhoan.TenTaiKhoan = txtTen.Text;
            // TaiKhoan.GioiTinh = lookUpEdit1.EditValue.ToString();
            //CauHoi.HinhAnh = null;
        }

        #endregion

        #region Events
        //private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        //{
        //    var lstGioiTinh = new List<GioiTinh>();
        //    lstGioiTinh.Add(new GioiTinh { Id = (int)EN_GioiTinh.Nam, Ten = EN_GioiTinh.Nam.GetDescription() });
        //    lstGioiTinh.Add(new GioiTinh { Id = (int)EN_GioiTinh.Nu, Ten = EN_GioiTinh.Nu.GetDescription() });

        //    lookUpEdit1.Properties.DataSource = lstGioiTinh;
        //    lookUpEdit1.Properties.DisplayMember = "Ten";
        //    lookUpEdit1.Properties.ValueMember = "Id";
        //    lookUpEdit1.SelectionStart = 1;
        //}

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtHoDem.ResetText();
            txtHinhAnh.ResetText();
            lookUpEdit1.SelectedText = "";
            txtMa.Focus();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mã thí sinh.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHoDem.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập họ đệm.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            GetData();

            if (_bus.CheckExist(TaiKhoan))
            {
                XtraMessageBox.Show("Tài khoản đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            var data = _bus.SaveTaiKhoan(TaiKhoan);

            if (data > 0)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }
        }

        #endregion

        #region Public

        public TaiKhoan TaiKhoan { get; set; }

        #endregion
    }
}