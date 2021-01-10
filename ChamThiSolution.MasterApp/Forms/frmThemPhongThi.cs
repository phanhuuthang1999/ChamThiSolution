using ChamThiSolution.Bussiness.MasterBll;
using DevExpress.XtraEditors;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemPhongThi : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private PhongThiBll _bus;

        #endregion

        public frmThemPhongThi()
        {
            InitializeComponent();
            _bus = new PhongThiBll();

        }
    }
}