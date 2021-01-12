using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemPhongThi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private PhongThiBll _bus;
        private string Id;

        #endregion

        #region Constructor
        public frmThemPhongThi()
        {
            InitializeComponent();
            _bus = new PhongThiBll();
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            LoadData(Id, txtMa.Text, txtTen.Text, txtPort.Text);

        }

        #endregion



        public void LoadData(string s, string s1, string s2, string s3)
        {
            txtMa.Text = s;
            txtTen.Text = s1;
            txtPort.Text = s2;
            Id = s3;
        }



        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetData();
            if (PhongThi != null)
            {
                if (PhongThi.Id == 0)
                {
                    this.Text = "SAO CHÉP PHÒNG THI";
                }
                this.Text = "CẬP NHẬT PHÒNG THI";
            }

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
            int a = int.Parse(txtPort.Text);
           // a = PhongThi.Port;
            //HinhAnh
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
            //CauHoi.HinhAnh = null;
        }

        #endregion

        #region Events

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtPort.ResetText();
            lookUpEdit1.ResetText();
            txtMa.Focus();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mã phòng.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên phòng.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPort.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập port phòng thi.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPort.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lookUpEdit1.Text))
            {
                XtraMessageBox.Show("Bạn chưa chọn đề thi cho phòng thi.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lookUpEdit1.Focus();
                return;
            }

            GetData();

            if (_bus.CheckExistPhong(PhongThi))
            {
                XtraMessageBox.Show("Phòng thi đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            var data = _bus.SavePhongThi(PhongThi);

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

        public PhongThi PhongThi { get; set; }

        #endregion
    }
}