using ChamThiSolution.Bussiness.Bll;
using ChamThiSolution.Data.Entities;
using ChamThiSolution.Server.Forms;
using ChamThiSolution.ServerApp.Proxy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace ChamThiSolution.ServerApp.Forms
{
    public partial class frmPhongThi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variable

        private PhongThiBll _bus;
        private PrimeProxy primeProxy = frmMain.primeProxy;

        #endregion

        #region Constructor

        public frmPhongThi()
        {
            InitializeComponent();
            _bus = new PhongThiBll();

            btnThuBai.ItemClick += TsThuBai_Click;
            btnCamThi.ItemClick += TsCamThi_Click;
            btnBatDau.ItemClick += TsBatDau_Click;
        }

        #endregion

        #region Protected

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadPhongThi();
            
        }

        #endregion

        #region Private


        private void LoadPhongThi()
        {
            List<PhongThi> tbl = _bus.GetAll();
            foreach (var item in tbl)
            {
                Button btn = new Button() { Width = 85, Height = 85 };

                btn.Text = item.TenPhongThi + Environment.NewLine + item.TrangThai;
                btn.Click += (sender, EventArgs) => { Btn_Click(sender, EventArgs, item.Id); };
                switch (item.Status)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }


        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e, int IdPhongThi)
        {
            var a = _bus.GetThiSinhPhongThi(IdPhongThi);
            dataGridView1.DataSource = a;
            if (_bus.GetPhongThiMo(IdPhongThi) == true)
            {
                btnBatDau.Enabled = true;
            }
            else
            {
                btnBatDau.Enabled = false;
            }

        }

        private void TsBatDau_Click(object sender, EventArgs e)
        {
            primeProxy.EnableRoom();
        }

        private void TsCamThi_Click(object sender, EventArgs e)
        {
            //gridSv
        }

        private void TsThuBai_Click(object sender, EventArgs e)
        {
            //primeProxy.EndEXam();
        }

        #endregion

        #region Public 

        public PhongThi PhongThi { get; set; }

        #endregion
    }
}