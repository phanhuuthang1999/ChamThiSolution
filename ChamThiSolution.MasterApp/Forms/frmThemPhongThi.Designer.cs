
namespace ChamThiSolution.MasterApp.Forms
{
    partial class frmThemPhongThi
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
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.tablePanel1.SetColumn(this.txtPort, 1);
            this.tablePanel1.SetColumnSpan(this.txtPort, 3);
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.EnterMoveNextControl = true;
            this.txtPort.Location = new System.Drawing.Point(103, 81);
            this.txtPort.Name = "txtPort";
            this.txtPort.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPort.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPort.Properties.MaxLength = 4;
            this.tablePanel1.SetRow(this.txtPort, 3);
            this.txtPort.Size = new System.Drawing.Size(308, 20);
            this.txtPort.TabIndex = 2;
            // 
            // txtTen
            // 
            this.tablePanel1.SetColumn(this.txtTen, 1);
            this.tablePanel1.SetColumnSpan(this.txtTen, 3);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(103, 55);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.MaxLength = 255;
            this.tablePanel1.SetRow(this.txtTen, 2);
            this.txtTen.Size = new System.Drawing.Size(308, 20);
            this.txtTen.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 32);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mã phòng thi";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 110);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Câu Hỏi";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 84);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Port";
            // 
            // btnSave
            // 
            this.tablePanel1.SetColumn(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(202, 133);
            this.btnSave.Name = "btnSave";
            this.tablePanel1.SetRow(this.btnSave, 5);
            this.btnSave.Size = new System.Drawing.Size(103, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            // 
            // btnCancel
            // 
            this.tablePanel1.SetColumn(this.btnCancel, 3);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(312, 133);
            this.btnCancel.Name = "btnCancel";
            this.tablePanel1.SetRow(this.btnCancel, 5);
            this.btnCancel.Size = new System.Drawing.Size(99, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 58);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên phòng thi";
            // 
            // txtMa
            // 
            this.tablePanel1.SetColumn(this.txtMa, 1);
            this.tablePanel1.SetColumnSpan(this.txtMa, 3);
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.EnterMoveNextControl = true;
            this.txtMa.Location = new System.Drawing.Point(103, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.MaxLength = 50;
            this.tablePanel1.SetRow(this.txtMa, 1);
            this.txtMa.Size = new System.Drawing.Size(308, 20);
            this.txtMa.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            this.tablePanel1.SetColumn(this.lookUpEdit1, 1);
            this.tablePanel1.SetColumnSpan(this.lookUpEdit1, 3);
            this.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEdit1.EnterMoveNextControl = true;
            this.lookUpEdit1.Location = new System.Drawing.Point(103, 107);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.lookUpEdit1, 4);
            this.lookUpEdit1.Size = new System.Drawing.Size(308, 20);
            this.lookUpEdit1.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.82F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.56F)});
            this.tablePanel1.Controls.Add(this.lookUpEdit1);
            this.tablePanel1.Controls.Add(this.txtMa);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.btnCancel);
            this.tablePanel1.Controls.Add(this.btnSave);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.txtTen);
            this.tablePanel1.Controls.Add(this.txtPort);
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
            this.tablePanel1.Size = new System.Drawing.Size(414, 166);
            this.tablePanel1.TabIndex = 1;
            // 
            // frmThemPhongThi
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 166);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmThemPhongThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM MỚI PHÒNG THI";
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTen;
    }
}