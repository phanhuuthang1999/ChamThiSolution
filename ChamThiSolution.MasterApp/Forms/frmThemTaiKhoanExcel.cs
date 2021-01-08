using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Data.OleDb;

namespace ChamThiSolution.MasterApp.Forms
{
    public partial class frmThemTaiKhoanExcel : DevExpress.XtraEditors.XtraForm
    {
        #region Variable

        #endregion

        #region Constructor

        public frmThemTaiKhoanExcel()
        {
            InitializeComponent();
            btnLink.Click += BtnLink_Click;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
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

        private void sdfdsfdsfsdnf()
        {
            //OleDbCommand ocCount = new OleDbCommand("SELECT COUNT(*) FROM [Sheet1$]", con);

            //con.Open();
            //int count = (int)ocCount.ExecuteScalar();

            //progressBarControl1.MaximumSize = 100%;
          
        }
        #endregion

        private void BtnLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                btnLink.Text = choofdlog.FileName;
               // string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }

        private void ExportDataFromExcel(string link)
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(btnLink.Text);
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            int colCount = 2;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");

                    //add useful things here!   
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            Console.WriteLine();
            Console.WriteLine("---Complete---");
        }

        
    }
}