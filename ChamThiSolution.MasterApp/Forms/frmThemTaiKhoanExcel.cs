using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using ChamThiSolution.Data.Entities;
using ChamThiSolution.Bussiness.MasterBll;
using DevExpress.XtraEditors;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemTaiKhoanExcel : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        private TaiKhoanBll _bus;

        #endregion

        #region Constructor

        public frmThemTaiKhoanExcel()
        {
            InitializeComponent();
            _bus = new TaiKhoanBll();

            btnLink.Click += BtnLink_Click;
            btnImport.Click += BtnImport_Click;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
        }

        #endregion

        #region Private

        private void ExportDataFromExcel(string link)
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(btnLink.Text);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            int colCount = 1;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    ////new line
                    //if (j == 1)
                    //    Console.Write("\r\n");

                    ////write the value to the console
                    //if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        //string s = xlRange.Cells[i, j].Value2.ToString() + "\t");

                    //add useful things here!   
                }
}
        }

        #endregion

        #region Events

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

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var data = _bus.SaveTaiKhoan(TaiKhoan);

            if (data > 0)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
            backgroundWorker1.WorkerReportsProgress = true;
            int process = 0;
            while (true)
            {
                backgroundWorker1.ReportProgress(++process);
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Insert here
        }

        #endregion

        #region Public

        public TaiKhoan TaiKhoan { get; set; }

        #endregion
    }
}