
namespace THITN
{
    partial class frmDsdkThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsdkThi));
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tN_DS = new THITN.TN_DS();
            this.sP_In_DSDK_ThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_In_DSDK_ThiTableAdapter = new THITN.TN_DSTableAdapters.SP_In_DSDK_ThiTableAdapter();
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.sP_In_DSDK_ThiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọtên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldathi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barDsdk)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_DSDK_ThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_DSDK_ThiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 739);
            this.barDockControlBottom.Manager = this.barDsdk;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barDsdk;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 32);
            this.barDockControlRight.Manager = this.barDsdk;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
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
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.btnXemTruoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(944, 23);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(153, 28);
            this.dateTo.TabIndex = 12;
            this.dateTo.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(610, 23);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(153, 28);
            this.dateFrom.TabIndex = 11;
            this.dateFrom.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Location = new System.Drawing.Point(63, 66);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(109, 31);
            this.btnXemTruoc.TabIndex = 10;
            this.btnXemTruoc.Text = "Xem trước";
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(857, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ ngày";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(121, 23);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(261, 28);
            this.cmbCoSo.TabIndex = 5;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cơ sở";
            // 
            // tN_DS
            // 
            this.tN_DS.DataSetName = "TN_DS";
            this.tN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_In_DSDK_ThiBindingSource
            // 
            this.sP_In_DSDK_ThiBindingSource.DataMember = "SP_In_DSDK_Thi";
            this.sP_In_DSDK_ThiBindingSource.DataSource = this.tN_DS;
            // 
            // sP_In_DSDK_ThiTableAdapter
            // 
            this.sP_In_DSDK_ThiTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.TN_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_In_DSDK_ThiGridControl
            // 
            this.sP_In_DSDK_ThiGridControl.DataSource = this.sP_In_DSDK_ThiBindingSource;
            this.sP_In_DSDK_ThiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_In_DSDK_ThiGridControl.Location = new System.Drawing.Point(0, 144);
            this.sP_In_DSDK_ThiGridControl.MainView = this.gridView1;
            this.sP_In_DSDK_ThiGridControl.MenuManager = this.barDsdk;
            this.sP_In_DSDK_ThiGridControl.Name = "sP_In_DSDK_ThiGridControl";
            this.sP_In_DSDK_ThiGridControl.Size = new System.Drawing.Size(1332, 595);
            this.sP_In_DSDK_ThiGridControl.TabIndex = 10;
            this.sP_In_DSDK_ThiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOP,
            this.colTENMH,
            this.colHọtên,
            this.colSOCAUTHI,
            this.colColumn1,
            this.coldathi});
            this.gridView1.GridControl = this.sP_In_DSDK_ThiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            this.colTENLOP.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colHọtên
            // 
            this.colHọtên.Caption = "Họ và tên";
            this.colHọtên.FieldName = "Họ tên";
            this.colHọtên.MinWidth = 25;
            this.colHọtên.Name = "colHọtên";
            this.colHọtên.OptionsColumn.AllowEdit = false;
            this.colHọtên.Visible = true;
            this.colHọtên.VisibleIndex = 2;
            this.colHọtên.Width = 94;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "Số câu thi";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 25;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 3;
            this.colSOCAUTHI.Width = 94;
            // 
            // colColumn1
            // 
            this.colColumn1.Caption = "Ngày thi";
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.MinWidth = 25;
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.OptionsColumn.AllowEdit = false;
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 4;
            this.colColumn1.Width = 94;
            // 
            // coldathi
            // 
            this.coldathi.Caption = "Đã thi";
            this.coldathi.FieldName = "dathi";
            this.coldathi.MinWidth = 25;
            this.coldathi.Name = "coldathi";
            this.coldathi.OptionsColumn.AllowEdit = false;
            this.coldathi.Visible = true;
            this.coldathi.VisibleIndex = 5;
            this.coldathi.Width = 94;
            // 
            // frmDsdkThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 739);
            this.Controls.Add(this.sP_In_DSDK_ThiGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDsdkThi";
            this.Text = "Danh sách đăng ký thi";
            this.Load += new System.EventHandler(this.frmDsdkThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barDsdk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_DSDK_ThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_In_DSDK_ThiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barDsdk;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiKhoa;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sP_In_DSDK_ThiBindingSource;
        private TN_DS tN_DS;
        private TN_DSTableAdapters.SP_In_DSDK_ThiTableAdapter sP_In_DSDK_ThiTableAdapter;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_In_DSDK_ThiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHọtên;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn coldathi;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
    }
}