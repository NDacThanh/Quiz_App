using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmKhoa : Form
    {
        public static int vitri;
        public static bool checkSua = false, checkChuyenKhoa = false;
        string maGv = "";
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            
            try
            {
                cmbCoSoKhoa.DataSource = Program.bds_dspm.DataSource;
                cmbCoSoKhoa.ValueMember = "TENSERVER";
                cmbCoSoKhoa.DisplayMember = "TENCS";
                cmbCoSoKhoa.SelectedIndex = Program.mChinhanh;

            }
            catch (Exception) { }
            // phân quyền
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSoKhoa.Enabled = true;
                btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = false;
                btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled =  false;
                btnGhiGV.Enabled = btnPhuchoiGV.Enabled = false;
            }
                
            //
            this.TN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'TN_DS.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.TN_DS.COSO);
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.TN_DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_DS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.TN_DS.KHOA);
            // TODO: This line of code loads data into the 'TN_DS.DsKHOA' table. You can move, or remove it, as needed.
            this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
            // TODO: This line of code loads data into the 'TN_DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.TN_DS.LOP);
            // TODO: This line of code loads data into the 'TN_DS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.TN_DS.BODE);
            // TODO: This line of code loads data into the 'TN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.TN_DS.GIAOVIEN_DANGKY);
            kHOAGridControl.ShowOnlyPredefinedDetails = true;
            //
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_DS);

        }

        private void cmbCoSoKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSoKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSoKhoa.SelectedValue.ToString();
                if (cmbCoSoKhoa.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0) 
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới!","", MessageBoxButtons.OK);
                    return;
                } 
                else
                {
                    this.TN_DS.EnforceConstraints = false;
                    // TODO: This line of code loads data into the 'TN_DS.COSO' table. You can move, or remove it, as needed.
                    this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cOSOTableAdapter.Fill(this.TN_DS.COSO);
                    // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN' table. You can move, or remove it, as needed.
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Fill(this.TN_DS.GIAOVIEN);
                    // TODO: This line of code loads data into the 'tN_DS.KHOA' table. You can move, or remove it, as needed.
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.TN_DS.KHOA);
                    // TODO: This line of code loads data into the 'TN_DS.DsKHOA' table. You can move, or remove it, as needed.
                    this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
                    // TODO: This line of code loads data into the 'TN_DS.LOP' table. You can move, or remove it, as needed.
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.TN_DS.LOP);
                    // TODO: This line of code loads data into the 'TN_DS.BODE' table. You can move, or remove it, as needed.
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.TN_DS.BODE);
                    // TODO: This line of code loads data into the 'TN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.TN_DS.GIAOVIEN_DANGKY);
                    kHOAGridControl.ShowOnlyPredefinedDetails = true;
                    gIAOVIENGridControl.ShowOnlyPredefinedDetails = true;
                }
            } catch (Exception) { }
        }
        private void btnThemGVItem_Click(object sender, EventArgs e)
        {
            vitri = gIAOVIENBindingSource.Position;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = true;
            btnGhiGV.Enabled = btnPhuchoiGV.Enabled = true;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = false;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = false;
            srchGV.Enabled = false;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = false;
            //
            this.gIAOVIENBindingSource.AddNew();
            txtMaKhoaGV.Text = txtMaKhoa.Text;
        }

        private void ghiGV()
        {
            try
            {
                this.gIAOVIENBindingSource.EndEdit();
                this.gIAOVIENBindingSource.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Update(TN_DS.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên. \n" + ex.Message, "", MessageBoxButtons.OK);
            }

            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = true;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = false;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = true;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = true;
            btnGhiGV.Enabled = btnPhuchoiGV.Enabled = false;
            srchGV.Enabled = true;
            checkSua = false;
        }        

        private void btnGhiGV_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (checkSua)
            {
                this.ghiGV();
            }
            else if (checkChuyenKhoa)
            {
                int checkSiteKhoa;
                string cmdChuyenKhoa = "exec [dbo].[SP_Chuyen_Khoa_GV] '" + txtMaGV.Text.Trim() + "', '" + txtMaKhoaGV.Text.Trim() + "'";
                if (kHOABindingSource.Find("MAKH", txtMaKhoaGV.Text.Trim()) == -1)
                {
                    checkSiteKhoa = Program.ExecSqlNonQuerySiteChu(cmdChuyenKhoa);
                    string cmdXoaLogin = "exec [dbo].[Xoa_Login] '" + maGv + "'";
                    Program.ExecSqlNonQuery(cmdXoaLogin);
                } 
                else
                {
                    checkSiteKhoa = Program.ExecSqlNonQuery(cmdChuyenKhoa);
                }

                if (checkSiteKhoa == 1)
                {
                    MessageBox.Show("Chuyển khoa thất bại!", "", MessageBoxButtons.OK);
                    return;
                } 
                else if (txtMaKhoa.Text == txtMaKhoaGV.Text)
                {
                    MessageBox.Show("Khoa không thay đổi, vui lòng chọn khoa khác hoặc nhấn phục hồi!", "", MessageBoxButtons.OK);
                    return;
                } 
                else
                {
                    MessageBox.Show("Chuyển khoa thành công, vui lòng tải lại sau vài phút!", "", MessageBoxButtons.OK);
                    
                    gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = true;
                    txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = false;
                    btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = true;
                    btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = true;
                    btnGhiGV.Enabled = btnPhuchoiGV.Enabled = false;
                    //
                    this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Fill(this.TN_DS.GIAOVIEN);
                    cmbTenKhoa.SelectedValue = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();
                    cmbTenKhoa.Enabled = false;
                    checkChuyenKhoa = false;
                }

            }
            else
            {
                string cmdCheckGV = "Exec [dbo].[SP_Kt_GV_Ton_Tai] '" + txtMaGV.Text.Trim() + "'";
                if (Program.ExecSqlNonQuery(cmdCheckGV) == 1)
                {
                    txtMaGV.Focus();
                    return;
                }
                else
                {
                    this.ghiGV();
                }
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            
            string cmdXoaLogin = "";
            if (gIAOVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không có giảng viên để xoá!", "", MessageBoxButtons.OK);
                return;
            }
            if (this.gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Bạn không thể xoá giảng viên này vì giảng viên đã đăng ký thi!", "", MessageBoxButtons.OK);
                return;
            }
            if (this.bODEBindingSource.Count > 0)
            {
                MessageBox.Show("Bạn không thể xoá giảng viên này vì giảng viên đã nhập để!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xoá giảng viên này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maGv = ((DataRowView)gIAOVIENBindingSource[gIAOVIENBindingSource.Position])["MAGV"].ToString().Trim();
                    this.gIAOVIENBindingSource.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(TN_DS.GIAOVIEN);
                    cmdXoaLogin = "exec [dbo].[Xoa_Login] '" + maGv + "'";
                    Program.ExecSqlNonQuery(cmdXoaLogin);   
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá giảng viên. Bạn hãy xoá lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(TN_DS.GIAOVIEN);
                    this.gIAOVIENBindingSource.Position = gIAOVIENBindingSource.Find("MAGV", maGv);
                    return;
                }

            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (gIAOVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không có giảng viên để sửa!", "", MessageBoxButtons.OK);
                return;
            }
            vitri = gIAOVIENBindingSource.Position;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = false;
            txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = true;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = false;
            btnThemKhoa.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = false;
            srchGV.Enabled = false;
            btnGhiGV.Enabled = btnPhuchoiGV.Enabled = true;
            checkSua = true;
        }

        private void btnPhuchoiGV_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.CancelEdit();
            if (btnThemGV.Enabled == false) gIAOVIENBindingSource.Position = vitri;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = true;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = false;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = true;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = true;
            srchGV.Enabled = true;
            btnPhuchoiGV.Enabled = btnGhiGV.Enabled = false;
            checkSua = checkChuyenKhoa = false;
            this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
            cmbTenKhoa.SelectedValue = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();
            cmbTenKhoa.Enabled = false;
        }

        private void btnTailaiGV_Click(object sender, EventArgs e)
        {
            try
            {
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(TN_DS.GIAOVIEN);
                this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr_publisher;
                this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
                cmbTenKhoa.SelectedValue = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKhoa.SelectedValue == null) return;
            if (checkChuyenKhoa)
            {
                try
                {
                    txtMaKhoaGV.Text = cmbTenKhoa.SelectedValue.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHOABindingSource.Position;
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = true;
            txtMaKhoa.Focus();
            btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = true;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = true;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = false;
            srchGV.Enabled = false;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = false;
            //
            this.kHOABindingSource.AddNew();
            ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MACS"] = cmbThemKhoa.SelectedValue.ToString() ;
            
        }

        private void btnPhucHoiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOABindingSource.CancelEdit();
            if (btnThemKhoa.Enabled == false) kHOABindingSource.Position = vitri;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = true;
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
            btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = false;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = true;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = true;
            srchGV.Enabled = true;
            checkSua = false;
        }

        private void btnXoaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKh = "";
            if (kHOABindingSource.Count == 0)
            {
                MessageBox.Show("Không có khoa để xoá!", "", MessageBoxButtons.OK);
                return;
            }
            if (this.gIAOVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Bạn không thể xoá khoa này vì khoa đã có giảng viên!", "", MessageBoxButtons.OK);
                return;
            }
            if (this.lOPBindingSource.Count > 0)
            {
                MessageBox.Show("Bạn không thể xoá khoa này vì khoa đã có lớp!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xoá khoa này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKh = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString().Trim();
                    this.kHOABindingSource.RemoveCurrent();
                    this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(TN_DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá giảng viên. Bạn hãy xoá lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(TN_DS.KHOA);
                    this.kHOABindingSource.Position = gIAOVIENBindingSource.Find("MAKH", maKh);
                    return;
                }
            }
            if (kHOABindingSource.Count == 0) btnXoaKhoa.Enabled = false;
        }

        private void btnSuaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHOABindingSource.Count == 0)
            {
                MessageBox.Show("Không có khoa để xoá!", "", MessageBoxButtons.OK);
                return;
            }
            
            vitri = kHOABindingSource.Position;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = false;
            txtTenKhoa.Enabled = true;
            btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = true;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnTailaiGV.Enabled = false;
            btnThemKhoa.Enabled = btnXoaKhoa.Enabled = btnSuaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = false;
            srchGV.Enabled = false;
            checkSua = true;
        }

        private void btnTaiLaiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(TN_DS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        public void ghiKH()
        {
            try
            {
                this.kHOABindingSource.EndEdit();
                this.kHOABindingSource.ResetCurrentItem();
                this.kHOATableAdapter.Update(TN_DS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa. \n" + ex.Message, "", MessageBoxButtons.OK);
            }

            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = true;
            txtTenKhoa.Enabled = txtMaKhoa.Enabled = false;
            btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = false;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = true;
            srchGV.Enabled = true;
            checkSua = false;
            //
            this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
            cmbTenKhoa.SelectedValue = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"];
        }
        private void btnGhiKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được để trống!", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }
            if (checkSua)
            {
                this.ghiKH();
            }
            else
            {
                string cmdCheckKH = "Exec [dbo].[SP_Kt_KH_Ton_Tai] '" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "'";
                if (Program.ExecSqlNonQuerySiteChu(cmdCheckKH) == 1)
                {
                    MessageBox.Show("Khoa đã tồn tại, vui lòng nhập khoa khác!", "", MessageBoxButtons.OK);
                    txtMaKhoa.Focus();
                    return;
                }
                else
                {
                    this.ghiKH();
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChuyenKhoaGV_Click(object sender, EventArgs e)
        {
            string cmdcheck = "Exec [dbo].[SP_Kt_KH_Ton_Tai] '" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "'";           
            maGv = ((DataRowView)gIAOVIENBindingSource[gIAOVIENBindingSource.Position])["MAGV"].ToString().Trim();
            if (gIAOVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không có giảng viên để chuyển!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.ExecSqlNonQuerySiteChu(cmdcheck) == 0)
            {
                MessageBox.Show("Chưa tải đủ khoa, vui lòng đợi trong giây lát!", "", MessageBoxButtons.OK);
                return;
            }
            // fill cmb full khoa
            this.dsKHOATableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            this.dsKHOATableAdapter.Fill(this.TN_DS.DsKHOA);
            cmbTenKhoa.SelectedValue = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();
            //
            cmbTenKhoa.Enabled = true;
            vitri = gIAOVIENBindingSource.Position;
            gIAOVIENGridControl.Enabled = kHOAGridControl.Enabled = false;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtMaKhoaGV.Enabled =false;
            btnThemGV.Enabled = btnSuaGV.Enabled = btnXoaGV.Enabled = btnChuyenKhoaGV.Enabled = btnPhuchoiGV.Enabled = btnTailaiGV.Enabled = false;
            btnThemKhoa.Enabled = btnSuaKhoa.Enabled = btnXoaKhoa.Enabled = btnPhucHoiKhoa.Enabled = btnGhiKhoa.Enabled = btnTaiLaiKhoa.Enabled = btnThoat.Enabled = false;
            srchGV.Enabled = false;
            btnGhiGV.Enabled = btnPhuchoiGV.Enabled = true;                     
            checkChuyenKhoa = true;
            

        }
    }
}
