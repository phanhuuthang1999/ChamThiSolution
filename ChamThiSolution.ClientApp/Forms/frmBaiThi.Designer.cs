
namespace ChamThiSolution.ClientApp.Forms
{
    partial class frmBaiThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.btnLink = new DevExpress.XtraEditors.ButtonEdit();
            this.btnNopBai = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(12, 12);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(561, 227);
            this.txtNoiDung.TabIndex = 0;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(12, 251);
            this.btnLink.Name = "btnLink";
            this.btnLink.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnLink.Size = new System.Drawing.Size(480, 20);
            this.btnLink.TabIndex = 1;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(498, 248);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(75, 23);
            this.btnNopBai.TabIndex = 2;
            this.btnNopBai.Text = "Nộp bài";
            // 
            // frmBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 290);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "frmBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đề thi";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtNoiDung;
        private DevExpress.XtraEditors.ButtonEdit btnLink;
        private DevExpress.XtraEditors.SimpleButton btnNopBai;
    }
}