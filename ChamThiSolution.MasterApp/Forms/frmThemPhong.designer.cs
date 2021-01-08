
namespace ChamThiSolution.MasterApp.Forms
{
    partial class frmThemPhong
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
            this.timeStart = new DevExpress.XtraEditors.TimeSpanEdit();
            this.cbbTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.timeEnd = new DevExpress.XtraEditors.TimeSpanEdit();
            this.timeDoing = new DevExpress.XtraEditors.TimeSpanEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDoing.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25.59F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 19.41F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel1.Controls.Add(this.timeStart);
            this.tablePanel1.Controls.Add(this.cbbTrangThai);
            this.tablePanel1.Controls.Add(this.txtPort);
            this.tablePanel1.Controls.Add(this.txtTen);
            this.tablePanel1.Controls.Add(this.txtMa);
            this.tablePanel1.Controls.Add(this.btnSave);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.btnCancel);
            this.tablePanel1.Controls.Add(this.timeEnd);
            this.tablePanel1.Controls.Add(this.timeDoing);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(427, 217);
            this.tablePanel1.TabIndex = 0;
            // 
            // timeStart
            // 
            this.tablePanel1.SetColumn(this.timeStart, 1);
            this.tablePanel1.SetColumnSpan(this.timeStart, 3);
            this.timeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeStart.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeStart.Location = new System.Drawing.Point(118, 109);
            this.timeStart.Name = "timeStart";
            this.timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.timeStart, 4);
            this.timeStart.Size = new System.Drawing.Size(306, 20);
            this.timeStart.TabIndex = 4;
            // 
            // cbbTrangThai
            // 
            this.tablePanel1.SetColumn(this.cbbTrangThai, 1);
            this.tablePanel1.SetColumnSpan(this.cbbTrangThai, 3);
            this.cbbTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTrangThai.Location = new System.Drawing.Point(118, 81);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.cbbTrangThai, 3);
            this.cbbTrangThai.Size = new System.Drawing.Size(306, 20);
            this.cbbTrangThai.TabIndex = 3;
            // 
            // txtPort
            // 
            this.tablePanel1.SetColumn(this.txtPort, 1);
            this.tablePanel1.SetColumnSpan(this.txtPort, 3);
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(118, 55);
            this.txtPort.Name = "txtPort";
            this.tablePanel1.SetRow(this.txtPort, 2);
            this.txtPort.Size = new System.Drawing.Size(306, 20);
            this.txtPort.TabIndex = 2;
            // 
            // txtTen
            // 
            this.tablePanel1.SetColumn(this.txtTen, 1);
            this.tablePanel1.SetColumnSpan(this.txtTen, 3);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Location = new System.Drawing.Point(118, 29);
            this.txtTen.Name = "txtTen";
            this.tablePanel1.SetRow(this.txtTen, 1);
            this.txtTen.Size = new System.Drawing.Size(306, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.tablePanel1.SetColumn(this.txtMa, 1);
            this.tablePanel1.SetColumnSpan(this.txtMa, 3);
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.Location = new System.Drawing.Point(118, 3);
            this.txtMa.Name = "txtMa";
            this.tablePanel1.SetRow(this.txtMa, 0);
            this.txtMa.Size = new System.Drawing.Size(306, 20);
            this.txtMa.TabIndex = 0;
            // 
            // btnSave
            // 
            this.tablePanel1.SetColumn(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(205, 185);
            this.btnSave.Name = "btnSave";
            this.tablePanel1.SetRow(this.btnSave, 7);
            this.btnSave.Size = new System.Drawing.Size(106, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(3, 162);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 6);
            this.labelControl7.Size = new System.Drawing.Size(79, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Thời gian làm bài";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 136);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 5);
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Thời gian kết thúc";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 0);
            this.labelControl5.Location = new System.Drawing.Point(3, 112);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Thời gian bắt đầu";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 84);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Trạng Thái";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 58);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Port";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 32);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Phòng";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Phòng";
            // 
            // btnCancel
            // 
            this.tablePanel1.SetColumn(this.btnCancel, 3);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(318, 185);
            this.btnCancel.Name = "btnCancel";
            this.tablePanel1.SetRow(this.btnCancel, 7);
            this.btnCancel.Size = new System.Drawing.Size(106, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Thoát";
            // 
            // timeEnd
            // 
            this.tablePanel1.SetColumn(this.timeEnd, 1);
            this.tablePanel1.SetColumnSpan(this.timeEnd, 3);
            this.timeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeEnd.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeEnd.Location = new System.Drawing.Point(118, 133);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.timeEnd, 5);
            this.timeEnd.Size = new System.Drawing.Size(306, 20);
            this.timeEnd.TabIndex = 5;
            // 
            // timeDoing
            // 
            this.tablePanel1.SetColumn(this.timeDoing, 1);
            this.tablePanel1.SetColumnSpan(this.timeDoing, 3);
            this.timeDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDoing.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeDoing.Location = new System.Drawing.Point(118, 159);
            this.timeDoing.Name = "timeDoing";
            this.timeDoing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.timeDoing, 6);
            this.timeDoing.Size = new System.Drawing.Size(306, 20);
            this.timeDoing.TabIndex = 6;
            // 
            // frmThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 217);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM MỚI ";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDoing.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TimeSpanEdit timeStart;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTrangThai;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TimeSpanEdit timeEnd;
        private DevExpress.XtraEditors.TimeSpanEdit timeDoing;
    }
}