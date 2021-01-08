using DevExpress.XtraEditors;
using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemPhong : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private PhongThiBll _bus;

        #endregion

        #region Constructor

        public frmThemPhong()
        {
            InitializeComponent();
            _bus = new PhongThiBll();
            btnCancel.Click += BtnCancel_Click;
            btnSave.Click += BtnSave_Click;
        }

        #endregion

        #region Private

        private void SetData()
        {

            if (PhongThi == null)
            {
                return;
            }
            txtMa.Text = PhongThi.MaPhongThi;
            txtTen.Text = PhongThi.TenPhongThi;
            txtPort.Text = PhongThi.Port.ToString();
            //timeEnd.TimeSpan = PhongThi.ThoiGianKetThuc;

        }

        private void GetData() 
        {
            if (PhongThi == null)
            {
                PhongThi = new PhongThi();
            }
            PhongThi.MaPhongThi = txtMa.Text;
            PhongThi.TenPhongThi = txtTen.Text;
            PhongThi.Port = int.Parse(txtPort.Text);
            PhongThi.ThoiGianKetThuc = timeEnd.TimeSpan;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetData();
            if (PhongThi != null)
            {
                if (PhongThi.Id == 0)
                {
                    Text = "SAO CHÉP PHÒNG THI";
                }
                Text = "CẬP NHẬT PHÒNG THI";
            }
            Text = "THÊM MỚI PHÒNG THI";
        }

        #endregion

        #region Events

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mã phòng.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            GetData();

            var data = _bus.SavePhongThi(PhongThi);

            if (data > 0)
            {
                Close();
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Public

        public PhongThi PhongThi { get; set; }

        #endregion
    }
}