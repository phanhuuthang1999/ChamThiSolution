
namespace ChamThiSolution.MasterApp.Forms
{
    partial class frmPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongThi));
            this.gridTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridPhongThi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhongThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Port = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGianBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGianKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGianLamBai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddTKExcel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTaiKhoan
            // 
            this.tablePanel1.SetColumn(this.gridTaiKhoan, 1);
            this.gridTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTaiKhoan.Location = new System.Drawing.Point(753, 3);
            this.gridTaiKhoan.MainView = this.gridView;
            this.gridTaiKhoan.MenuManager = this.ribbonControl;
            this.gridTaiKhoan.Name = "gridTaiKhoan";
            this.tablePanel1.SetRow(this.gridTaiKhoan, 0);
            this.gridTaiKhoan.Size = new System.Drawing.Size(538, 598);
            this.gridTaiKhoan.TabIndex = 2;
            this.gridTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.IsQuyen,
            this.IsActive});
            this.gridView.GridControl = this.gridTaiKhoan;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Caption = "Tên đăng nhập";
            this.TenDangNhap.FieldName = "TenDangNhap";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Visible = true;
            this.TenDangNhap.VisibleIndex = 0;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 1;
            // 
            // IsQuyen
            // 
            this.IsQuyen.Caption = "Quyền";
            this.IsQuyen.FieldName = "Quyen";
            this.IsQuyen.Name = "IsQuyen";
            this.IsQuyen.Visible = true;
            this.IsQuyen.VisibleIndex = 2;
            // 
            // IsActive
            // 
            this.IsActive.Caption = "Trạng thái";
            this.IsActive.FieldName = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = true;
            this.IsActive.VisibleIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnPrint,
            this.bsiRecordsCount,
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh,
            this.btnAddTK,
            this.btnAddTKExcel});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1294, 158);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Xem In";
            this.btnPrint.Id = 14;
            this.btnPrint.ImageOptions.ImageUri.Uri = "Preview";
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Thêm mới";
            this.btnNew.Id = 16;
            this.btnNew.ImageOptions.ImageUri.Uri = "New";
            this.btnNew.Name = "btnNew";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 17;
            this.btnEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 18;
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới";
            this.btnRefresh.Id = 19;
            this.btnRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefresh.Name = "btnRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang Chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tác vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In và Xuất ";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.29F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22.71F)});
            this.tablePanel1.Controls.Add(this.gridPhongThi);
            this.tablePanel1.Controls.Add(this.gridTaiKhoan);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 158);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1294, 604);
            this.tablePanel1.TabIndex = 4;
            // 
            // gridPhongThi
            // 
            this.tablePanel1.SetColumn(this.gridPhongThi, 0);
            this.gridPhongThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridPhongThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhongThi.Location = new System.Drawing.Point(3, 3);
            this.gridPhongThi.MainView = this.gridView1;
            this.gridPhongThi.MenuManager = this.ribbonControl;
            this.gridPhongThi.Name = "gridPhongThi";
            this.tablePanel1.SetRow(this.gridPhongThi, 0);
            this.gridPhongThi.Size = new System.Drawing.Size(744, 598);
            this.gridPhongThi.TabIndex = 3;
            this.gridPhongThi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.TenPhongThi,
            this.Port,
            this.Status,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc,
            this.ThoiGianLamBai});
            this.gridView1.GridControl = this.gridPhongThi;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "Mã Phòng";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // TenPhongThi
            // 
            this.TenPhongThi.Caption = "Tên Phòng";
            this.TenPhongThi.FieldName = "TenPhongThi";
            this.TenPhongThi.Name = "TenPhongThi";
            this.TenPhongThi.Visible = true;
            this.TenPhongThi.VisibleIndex = 1;
            // 
            // Port
            // 
            this.Port.Caption = "Port";
            this.Port.FieldName = "Port";
            this.Port.Name = "Port";
            this.Port.Visible = true;
            this.Port.VisibleIndex = 2;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "TrangThai";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.Caption = "Thời gian bắt đầu";
            this.ThoiGianBatDau.FieldName = "ThoiGianBatDau";
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.Visible = true;
            this.ThoiGianBatDau.VisibleIndex = 4;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.Caption = "Thời gian kết thúc";
            this.ThoiGianKetThuc.FieldName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.Visible = true;
            this.ThoiGianKetThuc.VisibleIndex = 5;
            // 
            // ThoiGianLamBai
            // 
            this.ThoiGianLamBai.Caption = "Thời gian làm bài";
            this.ThoiGianLamBai.FieldName = "ThoiGianLamBai";
            this.ThoiGianLamBai.Name = "ThoiGianLamBai";
            this.ThoiGianLamBai.Visible = true;
            this.ThoiGianLamBai.VisibleIndex = 6;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddTKExcel);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tài khoản sinh viên";
            // 
            // btnAddTK
            // 
            this.btnAddTK.Caption = "Thêm tài khoản";
            this.btnAddTK.Id = 20;
            this.btnAddTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTK.ImageOptions.Image")));
            this.btnAddTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddTK.ImageOptions.LargeImage")));
            this.btnAddTK.Name = "btnAddTK";
            // 
            // btnAddTKExcel
            // 
            this.btnAddTKExcel.Caption = "Thêm với Excel";
            this.btnAddTKExcel.Id = 21;
            this.btnAddTKExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTKExcel.ImageOptions.Image")));
            this.btnAddTKExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddTKExcel.ImageOptions.LargeImage")));
            this.btnAddTKExcel.Name = "btnAddTKExcel";
            // 
            // frmPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 762);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmPhongThi";
            this.Ribbon = this.ribbonControl;
            this.Text = "QUẢN LÝ PHÒNG THI";
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridPhongThi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhongThi;
        private DevExpress.XtraGrid.Columns.GridColumn Port;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGianBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGianKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGianLamBai;
        private DevExpress.XtraGrid.Columns.GridColumn TenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn IsQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraBars.BarButtonItem btnAddTK;
        private DevExpress.XtraBars.BarButtonItem btnAddTKExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}