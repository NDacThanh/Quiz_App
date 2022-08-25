
namespace THITN
{
    partial class frmKhoa
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.Windows.Forms.Label mAKHLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctxKhoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChuyenKhoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhuchoiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTailaiGV = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCoSoKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srchGV = new DevExpress.XtraEditors.SearchControl();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_DS = new THITN.TN_DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barKhoa = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLaiKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.kHOATableAdapter = new THITN.TN_DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.tablePanelKhoa = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaKhoaGV = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenKhoa = new System.Windows.Forms.ComboBox();
            this.dsKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbThemKhoa = new System.Windows.Forms.ComboBox();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.tENKHLabel = new System.Windows.Forms.Label();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.mAKHLabel = new System.Windows.Forms.Label();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cOSOTableAdapter = new THITN.TN_DSTableAdapters.COSOTableAdapter();
            this.lOPTableAdapter = new THITN.TN_DSTableAdapters.LOPTableAdapter();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.gIAOVIENTableAdapter = new THITN.TN_DSTableAdapters.GIAOVIENTableAdapter();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THITN.TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITN.TN_DSTableAdapters.BODETableAdapter();
            this.dsKHOATableAdapter = new THITN.TN_DSTableAdapters.DsKHOATableAdapter();
            mACSLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            mAKHLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ctxKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barKhoa)).BeginInit();
            this.tablePanelKhoa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(160, 124);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(85, 21);
            mACSLabel.TabIndex = 6;
            mACSLabel.Text = "Mã cơ sở:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(49, 38);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(122, 21);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giảng viên: ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(49, 80);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(42, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ: ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(49, 124);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(49, 169);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel1.Location = new System.Drawing.Point(399, 38);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(89, 21);
            mAKHLabel1.TabIndex = 8;
            mAKHLabel1.Text = "Tên khoa: ";
            // 
            // mAKHLabel2
            // 
            mAKHLabel2.AutoSize = true;
            mAKHLabel2.Location = new System.Drawing.Point(399, 80);
            mAKHLabel2.Name = "mAKHLabel2";
            mAKHLabel2.Size = new System.Drawing.Size(79, 21);
            mAKHLabel2.TabIndex = 12;
            mAKHLabel2.Text = "Mã khoa:";
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.ctxKhoa;
            this.groupBox1.Controls.Add(this.cmbCoSoKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.srchGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1451, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ctxKhoa
            // 
            this.ctxKhoa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxKhoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemGV,
            this.btnXoaGV,
            this.btnSuaGV,
            this.btnChuyenKhoaGV,
            this.btnPhuchoiGV,
            this.btnGhiGV,
            this.btnTailaiGV});
            this.ctxKhoa.Name = "contextMenuStrip1";
            this.ctxKhoa.Size = new System.Drawing.Size(193, 186);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Image = global::THITN.Properties.Resources.plus;
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(192, 26);
            this.btnThemGV.Text = "Thêm giảng viên";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGVItem_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Image = global::THITN.Properties.Resources.ezgif_com_gif_maker__13_;
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(192, 26);
            this.btnXoaGV.Text = "Xoá giảng viên";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Image = global::THITN.Properties.Resources.ezgif_com_gif_maker__17_;
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(192, 26);
            this.btnSuaGV.Text = "Sửa giảng viên";
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnChuyenKhoaGV
            // 
            this.btnChuyenKhoaGV.Image = global::THITN.Properties.Resources.ezgif_com_gif_maker__16_;
            this.btnChuyenKhoaGV.Name = "btnChuyenKhoaGV";
            this.btnChuyenKhoaGV.Size = new System.Drawing.Size(192, 26);
            this.btnChuyenKhoaGV.Text = "Chuyển khoa";
            this.btnChuyenKhoaGV.Click += new System.EventHandler(this.btnChuyenKhoaGV_Click);
            // 
            // btnPhuchoiGV
            // 
            this.btnPhuchoiGV.Enabled = false;
            this.btnPhuchoiGV.Image = global::THITN.Properties.Resources._3669259_ic_restore_icon;
            this.btnPhuchoiGV.Name = "btnPhuchoiGV";
            this.btnPhuchoiGV.Size = new System.Drawing.Size(192, 26);
            this.btnPhuchoiGV.Text = "Phục hồi ";
            this.btnPhuchoiGV.Click += new System.EventHandler(this.btnPhuchoiGV_Click);
            // 
            // btnGhiGV
            // 
            this.btnGhiGV.Enabled = false;
            this.btnGhiGV.Image = global::THITN.Properties.Resources.ezgif_com_gif_maker__14_;
            this.btnGhiGV.Name = "btnGhiGV";
            this.btnGhiGV.Size = new System.Drawing.Size(192, 26);
            this.btnGhiGV.Text = "Ghi giảng viên";
            this.btnGhiGV.Click += new System.EventHandler(this.btnGhiGV_Click);
            // 
            // btnTailaiGV
            // 
            this.btnTailaiGV.Image = global::THITN.Properties.Resources.ezgif_com_gif_maker__15_;
            this.btnTailaiGV.Name = "btnTailaiGV";
            this.btnTailaiGV.Size = new System.Drawing.Size(192, 26);
            this.btnTailaiGV.Text = "Tải lại";
            this.btnTailaiGV.Click += new System.EventHandler(this.btnTailaiGV_Click);
            // 
            // cmbCoSoKhoa
            // 
            this.cmbCoSoKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSoKhoa.Enabled = false;
            this.cmbCoSoKhoa.FormattingEnabled = true;
            this.cmbCoSoKhoa.Location = new System.Drawing.Point(222, 31);
            this.cmbCoSoKhoa.Name = "cmbCoSoKhoa";
            this.cmbCoSoKhoa.Size = new System.Drawing.Size(261, 28);
            this.cmbCoSoKhoa.TabIndex = 3;
            this.cmbCoSoKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbCoSoKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cơ sở";
            // 
            // srchGV
            // 
            this.srchGV.Client = this.gIAOVIENGridControl;
            this.srchGV.Location = new System.Drawing.Point(954, 35);
            this.srchGV.Name = "srchGV";
            this.srchGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchGV.Properties.Appearance.Options.UseFont = true;
            this.srchGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.srchGV.Properties.Client = this.gIAOVIENGridControl;
            this.srchGV.Properties.FindDelay = 100;
            this.srchGV.Properties.NullValuePrompt = "Nhập để tìm kiếm ";
            this.srchGV.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.srchGV.Size = new System.Drawing.Size(214, 26);
            this.srchGV.TabIndex = 1;
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.ContextMenuStrip = this.ctxKhoa;
            this.gIAOVIENGridControl.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(717, 3);
            this.gIAOVIENGridControl.MainView = this.gridView2;
            this.gIAOVIENGridControl.MenuManager = this.barKhoa;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(731, 268);
            this.gIAOVIENGridControl.TabIndex = 3;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.gIAOVIENBindingSource.DataSource = this.kHOABindingSource;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.TN_DS;
            // 
            // TN_DS
            // 
            this.TN_DS.DataSetName = "TN_DS";
            this.TN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH1});
            this.gridView2.GridControl = this.gIAOVIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 102;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 147;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 89;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 175;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 25;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            this.colMAKH1.Width = 185;
            // 
            // barKhoa
            // 
            this.barKhoa.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barKhoa.DockControls.Add(this.barDockControlTop);
            this.barKhoa.DockControls.Add(this.barDockControlBottom);
            this.barKhoa.DockControls.Add(this.barDockControlLeft);
            this.barKhoa.DockControls.Add(this.barDockControlRight);
            this.barKhoa.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barKhoa.Form = this;
            this.barKhoa.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemKhoa,
            this.btnXoaKhoa,
            this.btnSuaKhoa,
            this.btnGhiKhoa,
            this.btnPhucHoiKhoa,
            this.btnTaiLaiKhoa,
            this.btnThoat});
            this.barKhoa.MainMenu = this.bar2;
            this.barKhoa.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoiKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiLaiKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Caption = "Thêm";
            this.btnThemKhoa.Id = 0;
            this.btnThemKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKhoa.ImageOptions.SvgImage")));
            this.btnThemKhoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKhoa_ItemClick);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Caption = "Xoá";
            this.btnXoaKhoa.Id = 1;
            this.btnXoaKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKhoa.ImageOptions.SvgImage")));
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKhoa_ItemClick);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Caption = "Sửa";
            this.btnSuaKhoa.Id = 2;
            this.btnSuaKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.Image")));
            this.btnSuaKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKhoa.ImageOptions.LargeImage")));
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSuaKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKhoa_ItemClick);
            // 
            // btnGhiKhoa
            // 
            this.btnGhiKhoa.Caption = "Ghi";
            this.btnGhiKhoa.Enabled = false;
            this.btnGhiKhoa.Id = 3;
            this.btnGhiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiKhoa.ImageOptions.SvgImage")));
            this.btnGhiKhoa.Name = "btnGhiKhoa";
            this.btnGhiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhiKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiKhoa_ItemClick);
            // 
            // btnPhucHoiKhoa
            // 
            this.btnPhucHoiKhoa.Caption = "Phục hồi";
            this.btnPhucHoiKhoa.Enabled = false;
            this.btnPhucHoiKhoa.Id = 4;
            this.btnPhucHoiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiKhoa.ImageOptions.SvgImage")));
            this.btnPhucHoiKhoa.Name = "btnPhucHoiKhoa";
            this.btnPhucHoiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoiKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiKhoa_ItemClick);
            // 
            // btnTaiLaiKhoa
            // 
            this.btnTaiLaiKhoa.Caption = "Tải lại";
            this.btnTaiLaiKhoa.Id = 5;
            this.btnTaiLaiKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLaiKhoa.ImageOptions.SvgImage")));
            this.btnTaiLaiKhoa.Name = "btnTaiLaiKhoa";
            this.btnTaiLaiKhoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLaiKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLaiKhoa_ItemClick);
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
            this.barDockControlTop.Manager = this.barKhoa;
            this.barDockControlTop.Size = new System.Drawing.Size(1451, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 629);
            this.barDockControlBottom.Manager = this.barKhoa;
            this.barDockControlBottom.Size = new System.Drawing.Size(1451, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barKhoa;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 597);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1451, 32);
            this.barDockControlRight.Manager = this.barKhoa;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 597);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
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
            // tablePanelKhoa
            // 
            this.tablePanelKhoa.ColumnCount = 2;
            this.tablePanelKhoa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelKhoa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelKhoa.Controls.Add(this.gIAOVIENGridControl, 1, 0);
            this.tablePanelKhoa.Controls.Add(this.panel2, 1, 1);
            this.tablePanelKhoa.Controls.Add(this.kHOAGridControl, 0, 0);
            this.tablePanelKhoa.Controls.Add(this.pnKhoa, 0, 1);
            this.tablePanelKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelKhoa.Location = new System.Drawing.Point(0, 116);
            this.tablePanelKhoa.Name = "tablePanelKhoa";
            this.tablePanelKhoa.RowCount = 2;
            this.tablePanelKhoa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.59223F));
            this.tablePanelKhoa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.40777F));
            this.tablePanelKhoa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelKhoa.Size = new System.Drawing.Size(1451, 513);
            this.tablePanelKhoa.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.ContextMenuStrip = this.ctxKhoa;
            this.panel2.Controls.Add(this.txtMaKhoaGV);
            this.panel2.Controls.Add(mAKHLabel2);
            this.panel2.Controls.Add(this.cmbTenKhoa);
            this.panel2.Controls.Add(mAKHLabel1);
            this.panel2.Controls.Add(dIACHILabel);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(tENLabel);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(hOLabel);
            this.panel2.Controls.Add(this.txtHo);
            this.panel2.Controls.Add(mAGVLabel);
            this.panel2.Controls.Add(this.txtMaGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(717, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 233);
            this.panel2.TabIndex = 3;
            // 
            // txtMaKhoaGV
            // 
            this.txtMaKhoaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAKH", true));
            this.txtMaKhoaGV.Enabled = false;
            this.txtMaKhoaGV.Location = new System.Drawing.Point(494, 78);
            this.txtMaKhoaGV.MenuManager = this.barKhoa;
            this.txtMaKhoaGV.Name = "txtMaKhoaGV";
            this.txtMaKhoaGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoaGV.Size = new System.Drawing.Size(198, 26);
            this.txtMaKhoaGV.TabIndex = 13;
            // 
            // cmbTenKhoa
            // 
            this.cmbTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kHOABindingSource, "MAKH", true));
            this.cmbTenKhoa.DataSource = this.dsKHOABindingSource;
            this.cmbTenKhoa.DisplayMember = "TENKH";
            this.cmbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKhoa.Enabled = false;
            this.cmbTenKhoa.FormattingEnabled = true;
            this.cmbTenKhoa.Location = new System.Drawing.Point(494, 31);
            this.cmbTenKhoa.Name = "cmbTenKhoa";
            this.cmbTenKhoa.Size = new System.Drawing.Size(198, 28);
            this.cmbTenKhoa.TabIndex = 12;
            this.cmbTenKhoa.ValueMember = "MAKH";
            this.cmbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbTenKhoa_SelectedIndexChanged);
            // 
            // dsKHOABindingSource
            // 
            this.dsKHOABindingSource.DataMember = "DsKHOA";
            this.dsKHOABindingSource.DataSource = this.TN_DS;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "DIACHI", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(187, 164);
            this.txtDiaChi.MenuManager = this.barKhoa;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(318, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "TEN", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(187, 121);
            this.txtTen.MenuManager = this.barKhoa;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(181, 26);
            this.txtTen.TabIndex = 5;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "HO", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(187, 77);
            this.txtHo.MenuManager = this.barKhoa;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(178, 26);
            this.txtHo.TabIndex = 3;
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "MAGV", true));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(187, 35);
            this.txtMaGV.MenuManager = this.barKhoa;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Size = new System.Drawing.Size(178, 26);
            this.txtMaGV.TabIndex = 1;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.kHOABindingSource;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kHOAGridControl.Location = new System.Drawing.Point(3, 3);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(708, 268);
            this.kHOAGridControl.TabIndex = 0;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.OptionsColumn.ReadOnly = true;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.OptionsColumn.ReadOnly = true;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 94;
            // 
            // pnKhoa
            // 
            this.pnKhoa.ContextMenuStrip = this.ctxKhoa;
            this.pnKhoa.Controls.Add(this.label3);
            this.pnKhoa.Controls.Add(this.cmbThemKhoa);
            this.pnKhoa.Controls.Add(this.txtMaKhoa);
            this.pnKhoa.Controls.Add(mACSLabel);
            this.pnKhoa.Controls.Add(this.txtMaCS);
            this.pnKhoa.Controls.Add(this.tENKHLabel);
            this.pnKhoa.Controls.Add(this.txtTenKhoa);
            this.pnKhoa.Controls.Add(this.mAKHLabel);
            this.pnKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnKhoa.Location = new System.Drawing.Point(3, 277);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(708, 233);
            this.pnKhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên cơ sở:";
            // 
            // cmbThemKhoa
            // 
            this.cmbThemKhoa.DataSource = this.cOSOBindingSource;
            this.cmbThemKhoa.DisplayMember = "TENCS";
            this.cmbThemKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThemKhoa.Enabled = false;
            this.cmbThemKhoa.FormattingEnabled = true;
            this.cmbThemKhoa.Location = new System.Drawing.Point(260, 35);
            this.cmbThemKhoa.Name = "cmbThemKhoa";
            this.cmbThemKhoa.Size = new System.Drawing.Size(220, 28);
            this.cmbThemKhoa.TabIndex = 9;
            this.cmbThemKhoa.ValueMember = "MACS";
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.TN_DS;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MAKH", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(260, 77);
            this.txtMaKhoa.MenuManager = this.barKhoa;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(220, 26);
            this.txtMaKhoa.TabIndex = 8;
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOSOBindingSource, "MACS", true));
            this.txtMaCS.Enabled = false;
            this.txtMaCS.Location = new System.Drawing.Point(260, 121);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCS.Properties.Appearance.Options.UseFont = true;
            this.txtMaCS.Size = new System.Drawing.Size(220, 26);
            this.txtMaCS.TabIndex = 7;
            // 
            // tENKHLabel
            // 
            this.tENKHLabel.AutoSize = true;
            this.tENKHLabel.Location = new System.Drawing.Point(160, 167);
            this.tENKHLabel.Name = "tENKHLabel";
            this.tENKHLabel.Size = new System.Drawing.Size(84, 21);
            this.tENKHLabel.TabIndex = 2;
            this.tENKHLabel.Text = "Tên khoa:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "TENKH", true));
            this.txtTenKhoa.Enabled = false;
            this.txtTenKhoa.Location = new System.Drawing.Point(260, 166);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(220, 26);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // mAKHLabel
            // 
            this.mAKHLabel.AutoSize = true;
            this.mAKHLabel.Location = new System.Drawing.Point(160, 80);
            this.mAKHLabel.Name = "mAKHLabel";
            this.mAKHLabel.Size = new System.Drawing.Size(79, 21);
            this.mAKHLabel.TabIndex = 0;
            this.mAKHLabel.Text = "Mã khoa:";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
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
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.gIAOVIENBindingSource;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "FK_BODE_GIAOVIEN";
            this.bODEBindingSource.DataSource = this.gIAOVIENBindingSource;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // dsKHOATableAdapter
            // 
            this.dsKHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 629);
            this.Controls.Add(this.tablePanelKhoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctxKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srchGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barKhoa)).EndInit();
            this.tablePanelKhoa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCoSoKhoa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchControl srchGV;
        private System.Windows.Forms.Label label1;
        private TN_DS TN_DS;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tablePanelKhoa;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.Panel pnKhoa;
        private System.Windows.Forms.Label tENKHLabel;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private System.Windows.Forms.Label mAKHLabel;
        private System.Windows.Forms.ContextMenuStrip ctxKhoa;
        private System.Windows.Forms.ToolStripMenuItem btnThemGV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private TN_DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private System.Windows.Forms.ToolStripMenuItem btnXoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnPhuchoiGV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiGV;
        private System.Windows.Forms.ToolStripMenuItem btnTailaiGV;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btnChuyenKhoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaGV;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barKhoa;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemKhoa;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnSuaKhoa;
        private DevExpress.XtraBars.BarButtonItem btnGhiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnTaiLaiKhoa;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private TN_DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TN_DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource dsKHOABindingSource;
        private TN_DSTableAdapters.DsKHOATableAdapter dsKHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoaGV;
        private System.Windows.Forms.ComboBox cmbThemKhoa;
        private System.Windows.Forms.Label label3;
    }
}