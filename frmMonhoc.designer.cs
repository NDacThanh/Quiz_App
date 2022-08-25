
namespace THITN
{
    partial class frmMonhoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonhoc));
            this.tN_DS = new THITN.TN_DS();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new THITN.TN_DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMon = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSuaMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTailaiMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.srcControlMH = new DevExpress.XtraEditors.SearchControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THITN.TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITN.TN_DSTableAdapters.BODETableAdapter();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new THITN.TN_DSTableAdapters.BANGDIEMTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcControlMH.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(57, 66);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 17);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(51, 173);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(95, 17);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học:";
            // 
            // tN_DS
            // 
            this.tN_DS.DataSetName = "TN_DS";
            this.tN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_DS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.TN_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMon,
            this.btnXoaMon,
            this.BtnSuaMon,
            this.btnTailaiMon,
            this.btnPhucHoiMon,
            this.btnThoat,
            this.btnGhiMon});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnSuaMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTailaiMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiMon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Caption = "Thêm";
            this.btnThemMon.Id = 0;
            this.btnThemMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.ImageOptions.Image")));
            this.btnThemMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemMon.ImageOptions.LargeImage")));
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMon_ItemClick);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Caption = "Xoá";
            this.btnXoaMon.Id = 1;
            this.btnXoaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.ImageOptions.Image")));
            this.btnXoaMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.ImageOptions.LargeImage")));
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaMon_ItemClick);
            // 
            // BtnSuaMon
            // 
            this.BtnSuaMon.Caption = "Sửa";
            this.BtnSuaMon.Id = 2;
            this.BtnSuaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuaMon.ImageOptions.Image")));
            this.BtnSuaMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSuaMon.ImageOptions.LargeImage")));
            this.BtnSuaMon.Name = "BtnSuaMon";
            this.BtnSuaMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSuaMon_ItemClick);
            // 
            // btnGhiMon
            // 
            this.btnGhiMon.Caption = "Ghi";
            this.btnGhiMon.Enabled = false;
            this.btnGhiMon.Id = 6;
            this.btnGhiMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiMon.ImageOptions.Image")));
            this.btnGhiMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiMon.ImageOptions.LargeImage")));
            this.btnGhiMon.Name = "btnGhiMon";
            this.btnGhiMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiMon_ItemClick);
            // 
            // btnTailaiMon
            // 
            this.btnTailaiMon.Caption = "Tải lại";
            this.btnTailaiMon.Id = 3;
            this.btnTailaiMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTailaiMon.ImageOptions.Image")));
            this.btnTailaiMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTailaiMon.ImageOptions.LargeImage")));
            this.btnTailaiMon.Name = "btnTailaiMon";
            this.btnTailaiMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTailaiMon_ItemClick);
            // 
            // btnPhucHoiMon
            // 
            this.btnPhucHoiMon.Caption = "Phục hồi";
            this.btnPhucHoiMon.Enabled = false;
            this.btnPhucHoiMon.Id = 4;
            this.btnPhucHoiMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMon.ImageOptions.Image")));
            this.btnPhucHoiMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiMon.ImageOptions.LargeImage")));
            this.btnPhucHoiMon.Name = "btnPhucHoiMon";
            this.btnPhucHoiMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiMon_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1536, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 776);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1536, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 742);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1536, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 742);
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 112);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(935, 290);
            this.mONHOCGridControl.TabIndex = 4;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // srcControlMH
            // 
            this.srcControlMH.Client = this.mONHOCGridControl;
            this.srcControlMH.Location = new System.Drawing.Point(322, 26);
            this.srcControlMH.MenuManager = this.barManager1;
            this.srcControlMH.Name = "srcControlMH";
            this.srcControlMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.srcControlMH.Properties.Client = this.mONHOCGridControl;
            this.srcControlMH.Properties.FindDelay = 100;
            this.srcControlMH.Size = new System.Drawing.Size(388, 22);
            this.srcControlMH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.srcControlMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1536, 76);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(tENMHLabel);
            this.panel2.Controls.Add(this.txtTenMH);
            this.panel2.Controls.Add(mAMHLabel);
            this.panel2.Controls.Add(this.txtMaMH);
            this.panel2.Location = new System.Drawing.Point(941, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 290);
            this.panel2.TabIndex = 8;
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(220, 170);
            this.txtTenMH.MenuManager = this.barManager1;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(239, 22);
            this.txtTenMH.TabIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(220, 63);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(239, 22);
            this.txtMaMH.TabIndex = 1;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "FK_BODE_MONHOC";
            this.bODEBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "FK_BANGDIEM_MONHOC";
            this.bANGDIEMBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 776);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonhoc";
            this.Text = "frmMonhoc";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcControlMH.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_DS tN_DS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TN_DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemMon;
        private DevExpress.XtraBars.BarButtonItem btnXoaMon;
        private DevExpress.XtraBars.BarButtonItem BtnSuaMon;
        private DevExpress.XtraBars.BarButtonItem btnTailaiMon;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiMon;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGhiMon;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchControl srcControlMH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TN_DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private TN_DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
    }
}