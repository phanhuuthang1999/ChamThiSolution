using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemCauHoi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private CauHoiBll _bus;
        private string Id;

        #endregion

        #region Constructor

        public frmThemCauHoi()
        {
            InitializeComponent();
            _bus = new CauHoiBll();
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            LoadData(Id,txtMa.Text,txtTen.Text,txtNoiDung.Text);
        }

        public void LoadData(string s, string s1, string s2, string s3)
        {
            txtMa.Text = s;
            txtTen.Text = s1;
            txtNoiDung.Text = s2;
            Id = s3;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetData();
            if (CauHoi != null)
            {
                if (CauHoi.Id == 0)
                {
                    this.Text = "SAO CHÉP CÂU HỎI";
                }
                this.Text = "CẬP NHẬT CÂU HỎI";
            }

        }

        #endregion

        #region Private

        private void SetData()
        {
            if (CauHoi == null)
            {
                return;
            }
            txtMa.Text = CauHoi.MaCauHoi;
            txtTen.Text = CauHoi.TenCauHoi;
            txtNoiDung.Text = CauHoi.TenCauHoi;
            //HinhAnh
        }

        private void GetData()
        {
            if (CauHoi == null)
            {
                CauHoi = new CauHoi();
            }
            CauHoi.MaCauHoi = txtMa.Text;
            CauHoi.TenCauHoi = txtTen.Text;
            CauHoi.NoiDungCauHoi = txtNoiDung.Text;
            //CauHoi.HinhAnh = null;
        }

        #endregion

        #region Events

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtNoiDung.ResetText();
            txtHinhAnh.ResetText();
            txtMa.Focus();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập mã câu hỏi.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên câu hỏi.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNoiDung.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập nội dung câu hỏi.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDung.Focus();
                return;
            }

            GetData();

            if (_bus.CheckExistQuestion(CauHoi))
            {
                XtraMessageBox.Show("Câu hỏi đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            var data = _bus.SaveQuestion(CauHoi);

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

        public CauHoi CauHoi { get; set; } 

        #endregion

    }
}