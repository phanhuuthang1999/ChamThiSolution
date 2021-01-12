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

        #endregion
        public frmBaiThi()
        {
            InitializeComponent();
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

            txtNoiDung.Text = CauHoi.NoiDungCauHoi;
        }

        private void ClientEventsWrapper_NopBaiReceived()
        {

        }

        #region Public

        public CauHoi CauHoi { get; set; }

        #endregion
    }
}