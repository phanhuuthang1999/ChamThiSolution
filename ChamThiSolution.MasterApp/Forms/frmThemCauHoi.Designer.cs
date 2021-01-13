
namespace ChamThiSolution.MasterApp.Forms
{
    partial class frmThemCauHoi
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.txtHinhAnh = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhAnh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.82F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.56F)});
            this.tablePanel1.Controls.Add(this.txtMa);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.btnCancel);
            this.tablePanel1.Controls.Add(this.btnSave);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.txtTen);
            this.tablePanel1.Controls.Add(this.txtNoiDung);
            this.tablePanel1.Controls.Add(this.txtHinhAnh);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(377, 169);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtMa
            // 
            this.tablePanel1.SetColumn(this.txtMa, 1);
            this.tablePanel1.SetColumnSpan(this.txtMa, 3);
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.EnterMoveNextControl = true;
            this.txtMa.Location = new System.Drawing.Point(94, 29);
            this.txtMa.Name = "txtMa";
            this.tablePanel1.SetRow(this.txtMa, 1);
            this.txtMa.Size = new System.Drawing.Size(280, 20);
            this.txtMa.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 58);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên câu hỏi";
            // 
            // btnCancel
            // 
            this.tablePanel1.SetColumn(this.btnCancel, 3);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(284, 133);
            this.btnCancel.Name = "btnCancel";
            this.tablePanel1.SetRow(this.btnCancel, 5);
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            // 
            // btnSave
            // 
            this.tablePanel1.SetColumn(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(185, 133);
            this.btnSave.Name = "btnSave";
            this.tablePanel1.SetRow(this.btnSave, 5);
            this.btnSave.Size = new System.Drawing.Size(94, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 84);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nội dung";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 110);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Hình Ảnh";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 32);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mã câu hỏi";
            // 
            // txtTen
            // 
            this.tablePanel1.SetColumn(this.txtTen, 1);
            this.tablePanel1.SetColumnSpan(this.txtTen, 3);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(94, 55);
            this.txtTen.Name = "txtTen";
            this.tablePanel1.SetRow(this.txtTen, 2);
            this.txtTen.Size = new System.Drawing.Size(280, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.tablePanel1.SetColumn(this.txtNoiDung, 1);
            this.tablePanel1.SetColumnSpan(this.txtNoiDung, 3);
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.EnterMoveNextControl = true;
            this.txtNoiDung.Location = new System.Drawing.Point(94, 81);
            this.txtNoiDung.Name = "txtNoiDung";
            this.tablePanel1.SetRow(this.txtNoiDung, 3);
            this.txtNoiDung.Size = new System.Drawing.Size(280, 20);
            this.txtNoiDung.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            this.tablePanel1.SetColumn(this.txtHinhAnh, 1);
            this.tablePanel1.SetColumnSpan(this.txtHinhAnh, 3);
            this.txtHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHinhAnh.EnterMoveNextControl = true;
            this.txtHinhAnh.Location = new System.Drawing.Point(94, 107);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.tablePanel1.SetRow(this.txtHinhAnh, 4);
            this.txtHinhAnh.Size = new System.Drawing.Size(280, 20);
            this.txtHinhAnh.TabIndex = 2;
            // 
            // frmThemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 169);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmThemCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM CÂU HỎI";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhAnh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txtHinhAnh;
    }
}