
namespace THITN
{
    partial class frmBangDiem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangDiem));
            this.barDsdk = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.sP_Ds_Mon_Hoc_DK_ThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tN_DS = new THITN.TN_DS();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.sP_Ds_Lan_ThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.dsLopDKThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sP_In_Bang_DiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_In_Bang_DiemTableAdapter = new THITN.TN_DSTableAdapters.SP_In_Bang_DiemTableAdapter();
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.sP_In_Bang_DiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_Ds_Lan_ThiTableAdapter = new THITN.TN_DSTableAdapters.SP_Ds_Lan_ThiTableAdapter();
            this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter = new THITN.TN_DSTableAdapters.SP_Ds_Mon_Hoc_DK_ThiTableAdapter();
            this.dsLopDKThiTableAdapter = new THITN.TN_DSTableAdapters.DsLopDKThiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barDsdk)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Ds_Mon_Hoc_DK_ThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Ds_Lan_ThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopDKThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_Bang_DiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_Bang_DiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barDsdk
            // 
            this.barDsdk.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barDsdk.DockControls.Add(this.barDockControlTop);
            this.barDsdk.DockControls.Add(this.barDockControlBottom);
            this.barDsdk.DockControls.Add(this.barDockControlLeft);
            this.barDsdk.DockControls.Add(this.barDockControlRight);
            this.barDsdk.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDsdk.Form = this;
            this.barDsdk.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnIn,
            this.btnXoaKhoa,
            this.btnSuaKhoa,
            this.btnGhiKhoa,
            this.btnPhucHoiKhoa,
            this.btnTaiLaiKhoa,
            this.btnThoat});
            this.barDsdk.MainMenu = this.bar1;
            this.barDsdk.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In danh sách";
            this.btnIn.Id = 0;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ItemAppearance.Normal.Options.UseFont = true;
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barDsdk;
            this.barDockControlTop.Size = new System.Drawing.Size(1352, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 779);
            this.barDockControlBottom.Manager = this.barDsdk;
            this.barDockControlBottom.Size = new System.Drawing.Size(1352, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barDsdk;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 747);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1352, 32);
            this.barDockControlRight.Manager = this.barDsdk;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 747);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Caption = "Xoá";
            this.btnXoaKhoa.Id = 1;
            this.btnXoaKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKhoa.ImageOptions.SvgImage")));
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Caption = "Sửa";
            this.btnSuaKhoa.Id = 2;
            this.btnSuaKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.Image")));
            this.btnSuaKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.LargeImage")));
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhiKhoa
            // 
            this.btnGhiKhoa.Caption = "Ghi";
            this.btnGhiKhoa.Enabled = false;
            this.btnGhiKhoa.Id = 3;
            this.btnGhiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiKhoa.ImageOptions.SvgImage")));
            this.btnGhiKhoa.Name = "btnGhiKhoa";
            this.btnGhiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPhucHoiKhoa
            // 
            this.btnPhucHoiKhoa.Caption = "Phục hồi";
            this.btnPhucHoiKhoa.Enabled = false;
            this.btnPhucHoiKhoa.Id = 4;
            this.btnPhucHoiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiKhoa.ImageOptions.SvgImage")));
            this.btnPhucHoiKhoa.Name = "btnPhucHoiKhoa";
            this.btnPhucHoiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnTaiLaiKhoa
            // 
            this.btnTaiLaiKhoa.Caption = "Tải lại";
            this.btnTaiLaiKhoa.Id = 5;
            this.btnTaiLaiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLaiKhoa.ImageOptions.SvgImage")));
            this.btnTaiLaiKhoa.Name = "btnTaiLaiKhoa";
            this.btnTaiLaiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonHoc);
            this.groupBox1.Controls.Add(this.cmbLanThi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.sP_Ds_Mon_Hoc_DK_ThiBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(794, 27);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(204, 28);
            this.cmbMonHoc.TabIndex = 12;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // sP_Ds_Mon_Hoc_DK_ThiBindingSource
            // 
            this.sP_Ds_Mon_Hoc_DK_ThiBindingSource.DataMember = "SP_Ds_Mon_Hoc_DK_Thi";
            this.sP_Ds_Mon_Hoc_DK_ThiBindingSource.DataSource = this.tN_DS;
            // 
            // tN_DS
            // 
            this.tN_DS.DataSetName = "TN_DS";
            this.tN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DataSource = this.sP_Ds_Lan_ThiBindingSource;
            this.cmbLanThi.DisplayMember = "LAN";
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Location = new System.Drawing.Point(1109, 27);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(77, 28);
            this.cmbLanThi.TabIndex = 11;
            this.cmbLanThi.ValueMember = "LAN";
            this.cmbLanThi.SelectedIndexChanged += new System.EventHandler(this.cmbLanThi_SelectedIndexChanged);
            // 
            // sP_Ds_Lan_ThiBindingSource
            // 
            this.sP_Ds_Lan_ThiBindingSource.DataMember = "SP_Ds_Lan_Thi";
            this.sP_Ds_Lan_ThiBindingSource.DataSource = this.tN_DS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1027, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lần thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Môn học";
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.dsLopDKThiBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(454, 27);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(221, 28);
            this.cmbLop.TabIndex = 7;
            this.cmbLop.ValueMember = "MALOP";
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // dsLopDKThiBindingSource
            // 
            this.dsLopDKThiBindingSource.DataMember = "DsLopDKThi";
            this.dsLopDKThiBindingSource.DataSource = this.tN_DS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lớp";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(89, 27);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(221, 28);
            this.cmbCoSo.TabIndex = 5;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cơ sở";
            // 
            // sP_In_Bang_DiemBindingSource
            // 
            this.sP_In_Bang_DiemBindingSource.DataMember = "SP_In_Bang_Diem";
            this.sP_In_Bang_DiemBindingSource.DataSource = this.tN_DS;
            // 
            // sP_In_Bang_DiemTableAdapter
            // 
            this.sP_In_Bang_DiemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.TN_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_In_Bang_DiemGridControl
            // 
            this.sP_In_Bang_DiemGridControl.DataSource = this.sP_In_Bang_DiemBindingSource;
            this.sP_In_Bang_DiemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_In_Bang_DiemGridControl.Location = new System.Drawing.Point(0, 127);
            this.sP_In_Bang_DiemGridControl.MainView = this.gridView1;
            this.sP_In_Bang_DiemGridControl.MenuManager = this.barDsdk;
            this.sP_In_Bang_DiemGridControl.Name = "sP_In_Bang_DiemGridControl";
            this.sP_In_Bang_DiemGridControl.Size = new System.Drawing.Size(1352, 652);
            this.sP_In_Bang_DiemGridControl.TabIndex = 15;
            this.sP_In_Bang_DiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colDIEM,
            this.colDIEMCHU});
            this.gridView1.GridControl = this.sP_In_Bang_DiemGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 149;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 309;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 287;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm số";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.OptionsColumn.AllowEdit = false;
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            this.colDIEM.Width = 240;
            // 
            // colDIEMCHU
            // 
            this.colDIEMCHU.Caption = "Điểm chữ";
            this.colDIEMCHU.FieldName = "DIEMCHU";
            this.colDIEMCHU.MinWidth = 25;
            this.colDIEMCHU.Name = "colDIEMCHU";
            this.colDIEMCHU.OptionsColumn.AllowEdit = false;
            this.colDIEMCHU.Visible = true;
            this.colDIEMCHU.VisibleIndex = 4;
            this.colDIEMCHU.Width = 344;
            // 
            // sP_Ds_Lan_ThiTableAdapter
            // 
            this.sP_Ds_Lan_ThiTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Ds_Mon_Hoc_DK_ThiTableAdapter
            // 
            this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.ClearBeforeFill = true;
            // 
            // dsLopDKThiTableAdapter
            // 
            this.dsLopDKThiTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 779);
            this.Controls.Add(this.sP_In_Bang_DiemGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangDiem";
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barDsdk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Ds_Mon_Hoc_DK_ThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Ds_Lan_ThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopDKThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_Bang_DiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_Bang_DiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barDsdk;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sP_In_Bang_DiemBindingSource;
        private TN_DS tN_DS;
        private TN_DSTableAdapters.SP_In_Bang_DiemTableAdapter sP_In_Bang_DiemTableAdapter;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_In_Bang_DiemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCHU;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.BindingSource sP_Ds_Lan_ThiBindingSource;
        private TN_DSTableAdapters.SP_Ds_Lan_ThiTableAdapter sP_Ds_Lan_ThiTableAdapter;
        private System.Windows.Forms.BindingSource sP_Ds_Mon_Hoc_DK_ThiBindingSource;
        private TN_DSTableAdapters.SP_Ds_Mon_Hoc_DK_ThiTableAdapter sP_Ds_Mon_Hoc_DK_ThiTableAdapter;
        private System.Windows.Forms.BindingSource dsLopDKThiBindingSource;
        private TN_DSTableAdapters.DsLopDKThiTableAdapter dsLopDKThiTableAdapter;
    }
}