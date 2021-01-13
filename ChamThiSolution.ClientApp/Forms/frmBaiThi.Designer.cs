
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCau = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Enabled = false;
            this.txtNoiDung.Location = new System.Drawing.Point(12, 79);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(561, 183);
            this.txtNoiDung.TabIndex = 0;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(12, 275);
            this.btnLink.Name = "btnLink";
            this.btnLink.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnLink.Size = new System.Drawing.Size(480, 20);
            this.btnLink.TabIndex = 1;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(498, 272);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(75, 23);
            this.btnNopBai.TabIndex = 2;
            this.btnNopBai.Text = "Nộp bài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên câu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung";
            // 
            // txtTenCau
            // 
            this.txtTenCau.Enabled = false;
            this.txtTenCau.Location = new System.Drawing.Point(12, 25);
            this.txtTenCau.Name = "txtTenCau";
            this.txtTenCau.Size = new System.Drawing.Size(561, 20);
            this.txtTenCau.TabIndex = 4;
            // 
            // frmBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 308);
            this.Controls.Add(this.txtTenCau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "frmBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đề thi";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtNoiDung;
        private DevExpress.XtraEditors.ButtonEdit btnLink;
        private DevExpress.XtraEditors.SimpleButton btnNopBai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenCau;
    }
}