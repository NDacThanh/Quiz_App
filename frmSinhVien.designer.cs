
namespace THITN
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label tENLOPLabel1;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menushipcontact = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnthemsinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiSv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua_sv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoasinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnchuyenlop_sv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTailaisv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhuchoiSv = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmakhoa_lop = new DevExpress.XtraEditors.TextEdit();
            this.dSKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_DS = new THITN.TN_DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat_lop = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tENKHComboBox = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenlop_lop = new System.Windows.Forms.TextBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mALOPTextBox1 = new System.Windows.Forms.TextBox();
            this.cbbTenlop = new System.Windows.Forms.ComboBox();
            this.dS_LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deNgaySinhSV = new System.Windows.Forms.DateTimePicker();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtTenSv = new System.Windows.Forms.TextBox();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fKKHOACOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSinhvien_Lop_FK = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new THITN.TN_DSTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new THITN.TN_DSTableAdapters.SINHVIENTableAdapter();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHOATableAdapter = new THITN.TN_DSTableAdapters.KHOATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCoSo_SV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srcControl_frmSinhvien = new DevExpress.XtraEditors.SearchControl();
            this.label2 = new System.Windows.Forms.Label();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new THITN.TN_DSTableAdapters.BANGDIEMTableAdapter();
            this.cOSOTableAdapter = new THITN.TN_DSTableAdapters.COSOTableAdapter();
            this.dS_KhoaTableAdapter = new THITN.TN_DSTableAdapters.DS_KhoaTableAdapter();
            this.fKLOPKHOA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THITN.TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.dS_LopTableAdapter = new THITN.TN_DSTableAdapters.DS_LopTableAdapter();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            tENLOPLabel1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menushipcontact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhoa_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKHOACOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien_Lop_FK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcControl_frmSinhvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPKHOA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(34, 32);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(108, 21);
            mASVLabel.TabIndex = 13;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(88, 114);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(37, 21);
            hOLabel.TabIndex = 14;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(453, 37);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 21);
            tENLabel.TabIndex = 15;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(48, 185);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(88, 21);
            nGAYSINHLabel.TabIndex = 16;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(65, 268);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 21);
            dIACHILabel.TabIndex = 17;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel1.Location = new System.Drawing.Point(437, 111);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(67, 21);
            mALOPLabel1.TabIndex = 18;
            mALOPLabel1.Text = "Mã lớp:";
            // 
            // tENLOPLabel1
            // 
            tENLOPLabel1.AutoSize = true;
            tENLOPLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel1.Location = new System.Drawing.Point(431, 194);
            tENLOPLabel1.Name = "tENLOPLabel1";
            tENLOPLabel1.Size = new System.Drawing.Size(72, 21);
            tENLOPLabel1.TabIndex = 19;
            tENLOPLabel1.Text = "Tên lớp:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(109, 34);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 21);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(104, 116);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(72, 21);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(98, 187);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(79, 21);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "Mã khoa:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(92, 248);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(84, 21);
            tENKHLabel.TabIndex = 6;
            tENKHLabel.Text = "Tên khoa:";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(431, 267);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(79, 21);
            mATKHAULabel.TabIndex = 33;
            mATKHAULabel.Text = "Mật khẩu";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.24F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.76F)});
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.sINHVIENGridControl);
            this.tablePanel1.Controls.Add(this.lOPGridControl);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 141);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 198.8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1633, 519);
            this.tablePanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.ContextMenuStrip = this.menushipcontact;
            this.panel1.Controls.Add(this.txtmakhoa_lop);
            this.panel1.Controls.Add(this.tENKHComboBox);
            this.panel1.Controls.Add(tENKHLabel);
            this.panel1.Controls.Add(mAKHLabel);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.txtTenlop_lop);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.txtmalop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 202);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 1);
            this.panel1.Size = new System.Drawing.Size(790, 314);
            this.panel1.TabIndex = 10;
            // 
            // menushipcontact
            // 
            this.menushipcontact.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menushipcontact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemsinhvien,
            this.btnGhiSv,
            this.btnSua_sv,
            this.btnXoasinhvien,
            this.btnchuyenlop_sv,
            this.btnTailaisv,
            this.btnPhuchoiSv});
            this.menushipcontact.Name = "contextMenuStrip1";
            this.menushipcontact.Size = new System.Drawing.Size(242, 172);
            this.menushipcontact.Text = "menushipcontact";
            // 
            // btnthemsinhvien
            // 
            this.btnthemsinhvien.Name = "btnthemsinhvien";
            this.btnthemsinhvien.Size = new System.Drawing.Size(241, 24);
            this.btnthemsinhvien.Text = "Thêm sinh viên";
            this.btnthemsinhvien.Click += new System.EventHandler(this.btnthemsinhvien_Click);
            // 
            // btnGhiSv
            // 
            this.btnGhiSv.Enabled = false;
            this.btnGhiSv.Name = "btnGhiSv";
            this.btnGhiSv.Size = new System.Drawing.Size(241, 24);
            this.btnGhiSv.Text = "Ghi sinh viên";
            this.btnGhiSv.Click += new System.EventHandler(this.btnGhiSv_Click);
            // 
            // btnSua_sv
            // 
            this.btnSua_sv.Name = "btnSua_sv";
            this.btnSua_sv.Size = new System.Drawing.Size(241, 24);
            this.btnSua_sv.Text = "Sửa sinh viên";
            this.btnSua_sv.Click += new System.EventHandler(this.btnSua_sv_Click);
            // 
            // btnXoasinhvien
            // 
            this.btnXoasinhvien.Name = "btnXoasinhvien";
            this.btnXoasinhvien.Size = new System.Drawing.Size(241, 24);
            this.btnXoasinhvien.Text = "Xoá sinh viên";
            this.btnXoasinhvien.Click += new System.EventHandler(this.btnXoasinhvien_Click);
            // 
            // btnchuyenlop_sv
            // 
            this.btnchuyenlop_sv.Name = "btnchuyenlop_sv";
            this.btnchuyenlop_sv.Size = new System.Drawing.Size(241, 24);
            this.btnchuyenlop_sv.Text = "Chuyển lớp cho sinh viên";
            this.btnchuyenlop_sv.Click += new System.EventHandler(this.btnchuyenlop_sv_Click);
            // 
            // btnTailaisv
            // 
            this.btnTailaisv.Name = "btnTailaisv";
            this.btnTailaisv.Size = new System.Drawing.Size(241, 24);
            this.btnTailaisv.Text = "Tải lại ";
            this.btnTailaisv.Click += new System.EventHandler(this.btnTailaisv_Click);
            // 
            // btnPhuchoiSv
            // 
            this.btnPhuchoiSv.Enabled = false;
            this.btnPhuchoiSv.Name = "btnPhuchoiSv";
            this.btnPhuchoiSv.Size = new System.Drawing.Size(241, 24);
            this.btnPhuchoiSv.Text = "Phục Hồi Sinh viên";
            this.btnPhuchoiSv.Click += new System.EventHandler(this.btnPhuchoiSv_Click);
            // 
            // txtmakhoa_lop
            // 
            this.txtmakhoa_lop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dSKhoaBindingSource, "MAKH", true));
            this.txtmakhoa_lop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSKhoaBindingSource, "MAKH", true));
            this.txtmakhoa_lop.Enabled = false;
            this.txtmakhoa_lop.Location = new System.Drawing.Point(206, 185);
            this.txtmakhoa_lop.MenuManager = this.barManager1;
            this.txtmakhoa_lop.Name = "txtmakhoa_lop";
            this.txtmakhoa_lop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakhoa_lop.Properties.Appearance.Options.UseFont = true;
            this.txtmakhoa_lop.Size = new System.Drawing.Size(304, 26);
            this.txtmakhoa_lop.TabIndex = 12;
            // 
            // dSKhoaBindingSource
            // 
            this.dSKhoaBindingSource.DataMember = "DS_Khoa";
            this.dSKhoaBindingSource.DataSource = this.TN_DS;
            // 
            // TN_DS
            // 
            this.TN_DS.DataSetName = "TN_DS";
            this.TN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnThem_lop,
            this.btnXoa_lop,
            this.btnSua_lop,
            this.btnGhi_lop,
            this.btnLoad_lop,
            this.btnUndo_lop,
            this.btnThoat_lop});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatSize = new System.Drawing.Size(0, 30);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat_lop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem_lop
            // 
            this.btnThem_lop.Caption = "Thêm";
            this.btnThem_lop.Id = 0;
            this.btnThem_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_lop.ImageOptions.Image")));
            this.btnThem_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem_lop.ImageOptions.LargeImage")));
            this.btnThem_lop.Name = "btnThem_lop";
            this.btnThem_lop.Size = new System.Drawing.Size(60, 30);
            this.btnThem_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_lop_ItemClick);
            // 
            // btnXoa_lop
            // 
            this.btnXoa_lop.Caption = "Xoá";
            this.btnXoa_lop.Id = 1;
            this.btnXoa_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_lop.ImageOptions.Image")));
            this.btnXoa_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa_lop.ImageOptions.LargeImage")));
            this.btnXoa_lop.Name = "btnXoa_lop";
            this.btnXoa_lop.Size = new System.Drawing.Size(60, 30);
            this.btnXoa_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_lop_ItemClick);
            // 
            // btnSua_lop
            // 
            this.btnSua_lop.Caption = "Sửa";
            this.btnSua_lop.Id = 2;
            this.btnSua_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_lop.ImageOptions.Image")));
            this.btnSua_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua_lop.ImageOptions.LargeImage")));
            this.btnSua_lop.Name = "btnSua_lop";
            this.btnSua_lop.Size = new System.Drawing.Size(60, 30);
            this.btnSua_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_lop_ItemClick);
            // 
            // btnGhi_lop
            // 
            this.btnGhi_lop.Caption = "Ghi";
            this.btnGhi_lop.Enabled = false;
            this.btnGhi_lop.Id = 3;
            this.btnGhi_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi_lop.ImageOptions.Image")));
            this.btnGhi_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi_lop.ImageOptions.LargeImage")));
            this.btnGhi_lop.Name = "btnGhi_lop";
            this.btnGhi_lop.Size = new System.Drawing.Size(60, 30);
            this.btnGhi_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_lop_ItemClick);
            // 
            // btnLoad_lop
            // 
            this.btnLoad_lop.Caption = "Tải lại";
            this.btnLoad_lop.Id = 4;
            this.btnLoad_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad_lop.ImageOptions.Image")));
            this.btnLoad_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad_lop.ImageOptions.LargeImage")));
            this.btnLoad_lop.Name = "btnLoad_lop";
            this.btnLoad_lop.Size = new System.Drawing.Size(70, 30);
            this.btnLoad_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_lop_ItemClick);
            // 
            // btnUndo_lop
            // 
            this.btnUndo_lop.Caption = "Phục hồi";
            this.btnUndo_lop.Enabled = false;
            this.btnUndo_lop.Id = 5;
            this.btnUndo_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo_lop.ImageOptions.Image")));
            this.btnUndo_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo_lop.ImageOptions.LargeImage")));
            this.btnUndo_lop.Name = "btnUndo_lop";
            this.btnUndo_lop.Size = new System.Drawing.Size(90, 30);
            this.btnUndo_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_lop_ItemClick);
            // 
            // btnThoat_lop
            // 
            this.btnThoat_lop.Caption = "Thoát";
            this.btnThoat_lop.Id = 6;
            this.btnThoat_lop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat_lop.ImageOptions.Image")));
            this.btnThoat_lop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat_lop.ImageOptions.LargeImage")));
            this.btnThoat_lop.Name = "btnThoat_lop";
            this.btnThoat_lop.Size = new System.Drawing.Size(0, 30);
            this.btnThoat_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_lop_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1633, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 660);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1633, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 619);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1633, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 619);
            // 
            // tENKHComboBox
            // 
            this.tENKHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "TENKH", true));
            this.tENKHComboBox.DataSource = this.dSKhoaBindingSource;
            this.tENKHComboBox.DisplayMember = "TENKH";
            this.tENKHComboBox.Enabled = false;
            this.tENKHComboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENKHComboBox.FormattingEnabled = true;
            this.tENKHComboBox.Location = new System.Drawing.Point(206, 245);
            this.tENKHComboBox.Name = "tENKHComboBox";
            this.tENKHComboBox.Size = new System.Drawing.Size(304, 28);
            this.tENKHComboBox.TabIndex = 11;
            this.tENKHComboBox.ValueMember = "MAKH";
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.TN_DS;
            // 
            // txtTenlop_lop
            // 
            this.txtTenlop_lop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.txtTenlop_lop.Enabled = false;
            this.txtTenlop_lop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenlop_lop.Location = new System.Drawing.Point(206, 110);
            this.txtTenlop_lop.Name = "txtTenlop_lop";
            this.txtTenlop_lop.Size = new System.Drawing.Size(304, 28);
            this.txtTenlop_lop.TabIndex = 3;
            this.txtTenlop_lop.TextChanged += new System.EventHandler(this.txtTenlop_lop_TextChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.TN_DS;
            // 
            // txtmalop
            // 
            this.txtmalop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtmalop.Enabled = false;
            this.txtmalop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop.Location = new System.Drawing.Point(206, 34);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(304, 28);
            this.txtmalop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.tablePanel1.SetColumn(this.panel2, 1);
            this.panel2.ContextMenuStrip = this.menushipcontact;
            this.panel2.Controls.Add(mATKHAULabel);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.mALOPTextBox1);
            this.panel2.Controls.Add(this.cbbTenlop);
            this.panel2.Controls.Add(this.deNgaySinhSV);
            this.panel2.Controls.Add(this.txtdiachi);
            this.panel2.Controls.Add(this.txtTenSv);
            this.panel2.Controls.Add(this.txtHoSV);
            this.panel2.Controls.Add(this.txtMaSv);
            this.panel2.Controls.Add(tENLOPLabel1);
            this.panel2.Controls.Add(mALOPLabel1);
            this.panel2.Controls.Add(dIACHILabel);
            this.panel2.Controls.Add(nGAYSINHLabel);
            this.panel2.Controls.Add(tENLabel);
            this.panel2.Controls.Add(hOLabel);
            this.panel2.Controls.Add(mASVLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(801, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 1);
            this.panel2.Size = new System.Drawing.Size(827, 310);
            this.panel2.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MATKHAU", true));
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(532, 262);
            this.txtMatKhau.MenuManager = this.barManager1;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(205, 26);
            this.txtMatKhau.TabIndex = 34;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_LOP_SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.lOPBindingSource;
            // 
            // mALOPTextBox1
            // 
            this.mALOPTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextBox1.Enabled = false;
            this.mALOPTextBox1.Location = new System.Drawing.Point(532, 111);
            this.mALOPTextBox1.Name = "mALOPTextBox1";
            this.mALOPTextBox1.Size = new System.Drawing.Size(154, 28);
            this.mALOPTextBox1.TabIndex = 33;
            // 
            // cbbTenlop
            // 
            this.cbbTenlop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sINHVIENBindingSource, "MALOP", true));
            this.cbbTenlop.DataSource = this.dS_LopBindingSource;
            this.cbbTenlop.DisplayMember = "TENLOP";
            this.cbbTenlop.Enabled = false;
            this.cbbTenlop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenlop.FormattingEnabled = true;
            this.cbbTenlop.Location = new System.Drawing.Point(532, 187);
            this.cbbTenlop.Name = "cbbTenlop";
            this.cbbTenlop.Size = new System.Drawing.Size(205, 28);
            this.cbbTenlop.TabIndex = 32;
            this.cbbTenlop.ValueMember = "MALOP";
            this.cbbTenlop.SelectedIndexChanged += new System.EventHandler(this.cbbTenlop_SelectedIndexChanged);
            // 
            // dS_LopBindingSource
            // 
            this.dS_LopBindingSource.DataMember = "DS_Lop";
            this.dS_LopBindingSource.DataSource = this.TN_DS;
            // 
            // deNgaySinhSV
            // 
            this.deNgaySinhSV.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sINHVIENBindingSource, "NGAYSINH", true));
            this.deNgaySinhSV.Enabled = false;
            this.deNgaySinhSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgaySinhSV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deNgaySinhSV.Location = new System.Drawing.Point(155, 185);
            this.deNgaySinhSV.Name = "deNgaySinhSV";
            this.deNgaySinhSV.Size = new System.Drawing.Size(224, 28);
            this.deNgaySinhSV.TabIndex = 30;
            // 
            // txtdiachi
            // 
            this.txtdiachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "DIACHI", true));
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(155, 265);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(224, 28);
            this.txtdiachi.TabIndex = 26;
            // 
            // txtTenSv
            // 
            this.txtTenSv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "TEN", true));
            this.txtTenSv.Enabled = false;
            this.txtTenSv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSv.Location = new System.Drawing.Point(532, 34);
            this.txtTenSv.Name = "txtTenSv";
            this.txtTenSv.Size = new System.Drawing.Size(205, 28);
            this.txtTenSv.TabIndex = 24;
            // 
            // txtHoSV
            // 
            this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HO", true));
            this.txtHoSV.Enabled = false;
            this.txtHoSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoSV.Location = new System.Drawing.Point(155, 108);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(224, 28);
            this.txtHoSV.TabIndex = 23;
            // 
            // txtMaSv
            // 
            this.txtMaSv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.txtMaSv.Enabled = false;
            this.txtMaSv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSv.Location = new System.Drawing.Point(155, 32);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(224, 28);
            this.txtMaSv.TabIndex = 22;
            // 
            // sINHVIENGridControl
            // 
            this.tablePanel1.SetColumn(this.sINHVIENGridControl, 1);
            this.sINHVIENGridControl.ContextMenuStrip = this.menushipcontact;
            this.sINHVIENGridControl.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sINHVIENGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.sINHVIENGridControl.Location = new System.Drawing.Point(802, 6);
            this.sINHVIENGridControl.MainView = this.gridView2;
            this.sINHVIENGridControl.Margin = new System.Windows.Forms.Padding(6);
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.tablePanel1.SetRow(this.sINHVIENGridControl, 0);
            this.sINHVIENGridControl.Size = new System.Drawing.Size(825, 187);
            this.sINHVIENGridControl.TabIndex = 1;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP1,
            this.colNGAYSINH,
            this.colDIACHI});
            this.gridView2.DetailHeight = 682;
            this.gridView2.GridControl = this.sINHVIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 39;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 146;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 39;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 146;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 39;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 146;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 39;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.OptionsColumn.AllowEdit = false;
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 3;
            this.colMALOP1.Width = 146;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 39;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 146;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 39;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 146;
            // 
            // lOPGridControl
            // 
            this.tablePanel1.SetColumn(this.lOPGridControl, 0);
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.lOPGridControl.Location = new System.Drawing.Point(6, 6);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.Margin = new System.Windows.Forms.Padding(6);
            this.lOPGridControl.Name = "lOPGridControl";
            this.tablePanel1.SetRow(this.lOPGridControl, 0);
            this.lOPGridControl.Size = new System.Drawing.Size(784, 187);
            this.lOPGridControl.TabIndex = 0;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 25;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            this.colMAKH1.Width = 94;
            // 
            // fKKHOACOSOBindingSource
            // 
            this.fKKHOACOSOBindingSource.DataSource = this.cOSOBindingSource;
            // 
            // bdsSinhvien_Lop_FK
            // 
            this.bdsSinhvien_Lop_FK.DataMember = "FK_SINHVIEN_LOP";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = THITN.TN_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cơ cở";
            // 
            // cbbCoSo_SV
            // 
            this.cbbCoSo_SV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo_SV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCoSo_SV.FormattingEnabled = true;
            this.cbbCoSo_SV.Location = new System.Drawing.Point(280, 57);
            this.cbbCoSo_SV.Name = "cbbCoSo_SV";
            this.cbbCoSo_SV.Size = new System.Drawing.Size(248, 28);
            this.cbbCoSo_SV.TabIndex = 1;
            this.cbbCoSo_SV.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SV_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.menushipcontact;
            this.groupBox1.Controls.Add(this.srcControl_frmSinhvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbCoSo_SV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1633, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // srcControl_frmSinhvien
            // 
            this.srcControl_frmSinhvien.Client = this.sINHVIENGridControl;
            this.srcControl_frmSinhvien.Location = new System.Drawing.Point(903, 61);
            this.srcControl_frmSinhvien.Name = "srcControl_frmSinhvien";
            this.srcControl_frmSinhvien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcControl_frmSinhvien.Properties.Appearance.Options.UseFont = true;
            this.srcControl_frmSinhvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.srcControl_frmSinhvien.Properties.Client = this.sINHVIENGridControl;
            this.srcControl_frmSinhvien.Properties.FindDelay = 100;
            this.srcControl_frmSinhvien.Size = new System.Drawing.Size(243, 26);
            this.srcControl_frmSinhvien.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.TN_DS;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // dS_KhoaTableAdapter
            // 
            this.dS_KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // fKLOPKHOA1BindingSource
            // 
            this.fKLOPKHOA1BindingSource.DataMember = "FK_LOP_KHOA1";
            this.fKLOPKHOA1BindingSource.DataSource = this.dSKhoaBindingSource;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.lOPBindingSource;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // dS_LopTableAdapter
            // 
            this.dS_LopTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 660);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menushipcontact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhoa_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKHOACOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhvien_Lop_FK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcControl_frmSinhvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPKHOA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private TN_DS TN_DS;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TN_DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCoSo_SV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsSinhvien_Lop_FK;
        private System.Windows.Forms.ContextMenuStrip menushipcontact;
        private System.Windows.Forms.ToolStripMenuItem btnthemsinhvien;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtTenSv;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.DateTimePicker deNgaySinhSV;
        private System.Windows.Forms.ToolStripMenuItem btnGhiSv;
        private System.Windows.Forms.ToolStripMenuItem btnSua_sv;
        private System.Windows.Forms.ToolStripMenuItem btnXoasinhvien;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private TN_DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private DevExpress.XtraEditors.SearchControl srcControl_frmSinhvien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem_lop;
        private DevExpress.XtraBars.BarButtonItem btnXoa_lop;
        private DevExpress.XtraBars.BarButtonItem btnSua_lop;
        private DevExpress.XtraBars.BarButtonItem btnGhi_lop;
        private DevExpress.XtraBars.BarButtonItem btnLoad_lop;
        private DevExpress.XtraBars.BarButtonItem btnUndo_lop;
        private DevExpress.XtraBars.BarButtonItem btnThoat_lop;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenlop_lop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private TN_DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private System.Windows.Forms.BindingSource fKKHOACOSOBindingSource;
        private System.Windows.Forms.BindingSource dSKhoaBindingSource;
        private TN_DSTableAdapters.DS_KhoaTableAdapter dS_KhoaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.BindingSource fKLOPKHOA1BindingSource;
        private DevExpress.XtraEditors.TextEdit txtmakhoa_lop;
        private System.Windows.Forms.ComboBox tENKHComboBox;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btnchuyenlop_sv;
        private System.Windows.Forms.ComboBox cbbTenlop;
        private System.Windows.Forms.BindingSource dS_LopBindingSource;
        private TN_DSTableAdapters.DS_LopTableAdapter dS_LopTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btnTailaisv;
        private System.Windows.Forms.ToolStripMenuItem btnPhuchoiSv;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.TextBox mALOPTextBox1;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
    }
}