using ChamThiSolution.Data.Entities;
using ChamThiSolution.ProxyObject.EventsWrapper;
using ChamThiSolution.ProxyObject.Interfaces;
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

namespace ChamThiSolution.ClientApp.Forms
{
    public partial class frmBaiThi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        public static frmMain fMain;
        IPrimeProxy primeProxy = frmLogin.primeProxy;
        string tenPhong;
        string cauhoi;
        string noidung;

        #endregion
        public frmBaiThi(string TenCau, string NoiDung)
        {
            InitializeComponent();
            txtTenCau.Text = TenCau;
            txtNoiDung.Text = NoiDung;
            btnLink.Click += BtnLink_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadData();
        }

        private void LoadData()
        {
            ClientEventsWrapper clientEventsWrapper = new ClientEventsWrapper();

            primeProxy.NopBaiReceived += clientEventsWrapper.NopBaiReceiveHandler;

            // Register client handler to wrapper event
            clientEventsWrapper.NopBaiReceived += ClientEventsWrapper_NopBaiReceived;

        }

        private void ClientEventsWrapper_NopBaiReceived()
        {

        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                btnLink.Text = choofdlog.FileName;
            }
        }

        #region Public

        public CauHoi CauHoi { get; set; }

        #endregion

        
       
    }
}