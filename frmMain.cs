using System;
using System.Data;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }        

        public void HienThiMenu()
        {
            MaSo.Text = "Mã GV: " + Program.username;
            HoTen.Text = "Họ và tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
            btn_DangNhap.Enabled = false;
            if (Program.mGroup == "SINHVIEN")
                rib_SinhVien.Visible = true;
            if (Program.mGroup == "GIANGVIEN")
            {
                rib_QuanLy.Visible = true;
                btn_TaoTaiKhoan.Enabled = false;
                btnKhoa.Enabled = btnLop.Enabled = btnMonHoc.Enabled = btnGVDK.Enabled = false;
            }
                
            if (Program.mGroup == "COSO" || Program.mGroup == "TRUONG")
            {
                btn_TaoTaiKhoan.Enabled = true;
                rib_QuanLy.Visible = true;
                rib_BaoCao.Visible = true;
            }    
            if (Program.mGroup == "TRUONG")
            {
                btnThiThu.Enabled = false;
            }
            btn_DangXuat.Enabled = true;
        }

        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBoDe));
            if (frm != null) frm.Activate();
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_TaoTaiKhoan.Enabled = btn_DangXuat.Enabled = false;
            rib_QuanLy.Visible = rib_SinhVien.Visible = rib_BaoCao.Visible = false;
            btn_DangNhap.Enabled = btnKhoa.Enabled = btnLop.Enabled = btnMonHoc.Enabled = btnGVDK.Enabled = true;
            MaSo.Text = HoTen.Text = Nhom.Text = "";
            if (Program.conn.State == ConnectionState.Open) Program.conn.Close();
            foreach (Form f in this.MdiChildren)
                if (f.IsDisposed == false)
                    f.Close();
            btn_DangNhap_ItemClick(sender, e);
        }

        private void btnDsdkThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDsdkThi));
            if (frm != null) frm.Activate();
            else
            {
                frmDsdkThi f = new frmDsdkThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiem f = new frmBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.conn.Close();
            Program.conn_publisher.Close();
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.checkThiGV = false;
            Form frm = this.CheckExists(typeof(frmChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                frmChonMonThi f = new frmChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemKetQua));
            if (frm != null) frm.Activate();
            else
            {
                frmXemKetQua f = new frmXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.checkThiGV = true;
            Form frm = this.CheckExists(typeof(frmChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                frmChonMonThi f = new frmChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonhoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonhoc f = new frmMonhoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiangvien_Dangki));
            if (frm != null) frm.Activate();
            else
            {
                frmGiangvien_Dangki f = new frmGiangvien_Dangki();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
