﻿using ChamThiSolution.Bussiness.MasterBll;
using ChamThiSolution.Data.Entities;
using Common;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ChamThiSolution.Data.Entities.StructEnum;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemGiamThi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private GiamThiBll _bus;
        private string Id;

        #endregion

        #region Constructor

        public frmThemGiamThi()
        {
            InitializeComponent();
            _bus = new GiamThiBll();
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            //LoadData(Id, txtMa.Text, txtTen.Text, txtNoiDung.Text);
            Load += FrmThemGiamThi_Load;
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
            if (GiamThi != null)
            {
                if (GiamThi.Id == 0)
                {
                    this.Text = "SAO CHÉP GIÁM THỊ";
                }
                this.Text = "CẬP NHẬT GIÁM THỊ";
            }

        }

        #endregion

        #region Private

        private void SetData()
        {
            if (GiamThi == null)
            {
                return;
            }
            txtMa.Text = GiamThi.MaGiamThi;
            txtHoDem.Text = GiamThi.HoDem;
            txtTen.Text = GiamThi.TenGiamThi;
            lookUpEdit1.EditValue = GiamThi.GioiTinh;
           // txtHinhAnh.Text = GiamThi.HinhAnh;
        }

        private void GetData()
        {
            if (GiamThi == null)
            {
                GiamThi = new GiamThi();
            }
            GiamThi.MaGiamThi = txtMa.Text;
            GiamThi.HoDem = txtHoDem.Text;
            GiamThi.TenGiamThi = txtTen.Text;
           // GiamThi.GioiTinh = lookUpEdit1.EditValue.ToString();
            //CauHoi.HinhAnh = null;
        }

        #endregion

        #region Events
        private void FrmThemGiamThi_Load(object sender, EventArgs e)
        {
            var lstGioiTinh = new List<GioiTinh>();
            lstGioiTinh.Add(new GioiTinh { Id = (int)EN_GioiTinh.Nam, Ten = EN_GioiTinh.Nam.GetDescription() });
            lstGioiTinh.Add(new GioiTinh { Id = (int)EN_GioiTinh.Nu, Ten = EN_GioiTinh.Nu.GetDescription() });

            lookUpEdit1.Properties.DataSource = lstGioiTinh;
            lookUpEdit1.Properties.DisplayMember = "Ten";
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.SelectionStart = 1;
        }

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
                XtraMessageBox.Show("Bạn chưa nhập mã giám thị.", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (_bus.CheckExistGiamThi(GiamThi))
            {
                XtraMessageBox.Show("Giám thị đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }

            var data = _bus.SaveGiamThi(GiamThi);

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

        public GiamThi GiamThi { get; set; }

        #endregion
    }
}