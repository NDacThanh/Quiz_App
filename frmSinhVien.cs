using System;
using System.Data;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        int vitri = 0;
        bool checksua = false;
        bool check_chuyenlop = false;
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            try
            {
               cbbCoSo_SV.DataSource = Program.bds_dspm;
               cbbCoSo_SV.DisplayMember = "TENCS";
               cbbCoSo_SV.ValueMember = "TENSERVER";
            }
            catch(Exception ){ }
          
            TN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'TN_DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
            // TODO: This line of code loads data into the 'TN_DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.TN_DS.LOP);
            // TODO: This line of code loads data into the 'TN_DS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.TN_DS.BANGDIEM);
            this.dS_KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_KhoaTableAdapter.Fill(this.TN_DS.DS_Khoa);
            // TODO: This line of code loads data into the 'TN_DS.DS_Lop' table. You can move, or remove it, as needed.
            this.dS_LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_LopTableAdapter.Fill(this.TN_DS.DS_Lop);
            // TODO: This line of code loads data into the 'TN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.TN_DS.GIAOVIEN_DANGKY);
            lOPGridControl.ShowOnlyPredefinedDetails = true;
            if(Program.mGroup == "TRUONG")
            {
                btnthemsinhvien.Enabled = btnXoasinhvien.Enabled = btnSua_sv.Enabled = btnThem_lop.Enabled = btnSua_lop.Enabled = btnXoa_lop.Enabled = btnGhiSv.Enabled = btnGhi_lop.Enabled = false;
                btnchuyenlop_sv.Enabled = txtmalop.Enabled = txtTenlop_lop.Enabled = txtmakhoa_lop.Enabled = tENKHComboBox.Enabled = false;
                txtTenSv.Enabled = txtMaSv.Enabled = txtHoSV.Enabled = deNgaySinhSV.Enabled = txtdiachi.Enabled = cbbTenlop.Enabled = false;

            }   
            if(Program.mGroup == "COSO")
            {
                cbbCoSo_SV.Enabled = false;
                btnthemsinhvien.Enabled = btnXoasinhvien.Enabled = btnSua_sv.Enabled = btnThem_lop.Enabled = btnSua_lop.Enabled = btnXoa_lop.Enabled =  btnchuyenlop_sv.Enabled = true;

                btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
            }

        }

       

        private void btnthemsinhvien_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.AddNew();
            ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MALOP"] = txtmalop.Text;
            txtdiachi.Enabled = txtHoSV.Enabled = txtMaSv.Enabled =  txtTenSv.Enabled = deNgaySinhSV.Enabled  = txtMatKhau.Enabled =true;
            btnGhiSv.Enabled = btnPhuchoiSv.Enabled = true;
            btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = false;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = btnUndo_lop.Enabled = btnGhi_lop.Enabled = btnGhi_lop.Enabled = false;
            btnthemsinhvien.Enabled = false;          
            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = false;
            

        }
        private void ghi_SV()
        {
            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENBindingSource.ResetCurrentItem();
                sINHVIENTableAdapter.Update(this.TN_DS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = true;
            txtHoSV.Enabled = txtMaSv.Enabled = txtTenSv.Enabled = deNgaySinhSV.Enabled = txtdiachi.Enabled = txtMatKhau.Enabled = false;
        }
        private void btnGhiSv_Click(object sender, EventArgs e)
        {
            string checkexist = "EXEC [dbo].[sp_TimSinhVien] " +"'"+ txtMaSv.Text.Trim()+"'";
            if (txtHoSV.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (txtTenSv.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMaSv.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if(txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if ((deNgaySinhSV.Value).Year >= (DateTime.Now).Year )
            {
                MessageBox.Show("Năm sinh của sinh viên không được lớn hơn ngày hiện tại!", "", MessageBoxButtons.OK);
                return;
            }
          
            if(checksua)
            {
                this.ghi_SV();
            }    
            else if(check_chuyenlop)
            {
                string chuyenlop = "exec [dbo].[SP_Chuyen_Lop_SV]" + "'" + txtMaSv.Text + "' " + ",'" + mALOPTextBox1.Text + "'";
                if (txtmalop.Text.Trim() == mALOPTextBox1.Text.Trim())
                {
                    MessageBox.Show("Không thể chuyển lớp, vui lòng chọn khoa khác!", "", MessageBoxButtons.OK);
                    return;
                }
                else if (Program.ExecSqlNonQuery(chuyenlop) == 0)
                {
                      
                    lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
                    txtHoSV.Enabled = txtTenSv.Enabled = deNgaySinhSV.Enabled = txtdiachi.Enabled = false;
                    btnthemsinhvien.Enabled = btnGhiSv.Enabled = btnSua_sv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = true;
                    btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = btnUndo_lop.Enabled = true;
                    btnGhiSv.Enabled = true;
                   
                    this.dS_LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dS_LopTableAdapter.Fill(this.TN_DS.DS_Lop);
                    cbbTenlop.SelectedValue = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString();
                    cbbTenlop.Enabled = false;
                    check_chuyenlop = false;
                    MessageBox.Show("Chuyển lớp thành công!");
                    this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);

                }                
                else
                {
                    MessageBox.Show("Chuyển lớp thất bại!");
                    return;
                }
               
            }
            else 
               {
                    if (Program.ExecSqlNonQuery(checkexist) == 1)
                    { 
                        txtMaSv.Focus();
                         return;
                    }
                    else
                    {
                        this.ghi_SV();
                    }                
                }

            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = true;
            txtHoSV.Enabled = txtMaSv.Enabled = txtTenSv.Enabled = deNgaySinhSV.Enabled = txtdiachi.Enabled = false;
            btnthemsinhvien.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = true;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled =  true;
            btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
            btnGhi_lop.Enabled = btnUndo_lop.Enabled = false;

        }

        private void txtTenlop_lop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoasinhvien_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (sINHVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không thể xoá vì lớp không có sinh viên", "", MessageBoxButtons.OK);
                    return;

            }
            if (bANGDIEMBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá sinh viên này vì có điểm thi!", "", MessageBoxButtons.OK);
                return;
            }    
            
            if (MessageBox.Show("Bạn có thật sự muốn xoá sinh viên này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)sINHVIENBindingSource[sINHVIENBindingSource.Position])["MASV"].ToString();
                    sINHVIENBindingSource.RemoveCurrent();
                    btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
                 //   this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.TN_DS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xoá sinh viên. Bạn hãy xoá lại\n" + ex.Message,"",MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
                    sINHVIENBindingSource.Position = sINHVIENBindingSource.Find("MASV", masv);
                    return;

                }
                

            }
            

        }

        private void cbbCoSo_SV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo_SV.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbCoSo_SV.SelectedValue.ToString();

            if(cbbCoSo_SV.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } 
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }   
            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối cơ sở mới,", "", MessageBoxButtons.OK);
            }   
            else
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.TN_DS.LOP);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.TN_DS.BANGDIEM);
                this.dS_KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dS_KhoaTableAdapter.Fill(this.TN_DS.DS_Khoa);
             
            }    

        }

        private void btnThem_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOPBindingSource.Position;
            lOPBindingSource.AddNew();
            ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MAKH"] = txtmakhoa_lop.Text;
            tENKHComboBox.Enabled = true;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = btnThoat_lop.Enabled = false;
            btnUndo_lop.Enabled = btnGhi_lop.Enabled = true;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
            srcControl_frmSinhvien.Enabled = false;
            txtTenlop_lop.Enabled = txtmalop.Enabled =  true;
            btnthemsinhvien.Enabled = btnXoasinhvien.Enabled = btnSua_sv.Enabled = btnGhiSv.Enabled = btnchuyenlop_sv.Enabled = btnTailaisv.Enabled = btnPhuchoiSv.Enabled = false;
            this.lOPTableAdapter.Fill(this.TN_DS.LOP);
        }

        private void btnUndo_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOPBindingSource.CancelEdit();
            if (btnThem_lop.Enabled = false)
                lOPBindingSource.Position = vitri;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
            txtmalop.Enabled = txtTenlop_lop.Enabled = true;
            btnGhi_lop.Enabled = btnUndo_lop.Enabled = false;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = btnThoat_lop.Enabled = true;
            btnthemsinhvien.Enabled = btnXoasinhvien.Enabled = btnSua_sv.Enabled  = btnchuyenlop_sv.Enabled = btnTailaisv.Enabled  = true;
            btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
            txtmalop.Enabled = txtTenlop_lop.Enabled = false;
            srcControl_frmSinhvien.Enabled = true;
        }

        private void btnSua_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(lOPBindingSource.Count == 0)
            {
                MessageBox.Show("Không thể sửa lớp vì không có lớp", "", MessageBoxButtons.OK);
                return;
            }
            vitri = lOPBindingSource.Position;
            txtmalop.Enabled = txtTenlop_lop.Enabled = true;
            btnthemsinhvien.Enabled = btnPhuchoiSv.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = false;
            txtmalop.Enabled = false;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = btnThoat_lop.Enabled = false;
            btnUndo_lop.Enabled = btnGhi_lop.Enabled = true;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
            checksua = true;
            srcControl_frmSinhvien.Enabled = false;
            
        }
        private void ghi_lop()
        {
            try
            {
                lOPBindingSource.EndEdit(); //ket thuc qt hieu chinh ,them,..
                lOPBindingSource.ResetCurrentItem(); // đưa hiệu chỉnh lên gridview
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(TN_DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
            btnGhi_lop.Enabled = btnUndo_lop.Enabled = false;
            btnThem_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnThoat_lop.Enabled = btnLoad_lop.Enabled = true;
            txtmalop.Enabled = txtTenlop_lop.Enabled = false;
            btnthemsinhvien.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled =  true;
            btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
            srcControl_frmSinhvien.Enabled = true;
        }
        private void btnLoad_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.TN_DS.LOP);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải lại:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string malop = "";
            if(sINHVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp này vì đã có danh sách sinh viên!", "", MessageBoxButtons.OK);
                return;
            }
            if (gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp này vì đã có giảng viên đăng kí thi!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = (((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString());
                    lOPBindingSource.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.TN_DS.LOP);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể xoá lớp này. hãy xoá lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.TN_DS.LOP);
                    lOPBindingSource.Position = lOPBindingSource.Find("MALOP", malop);
                    return;
                }
            }
            if (lOPBindingSource.Count == 0) btnXoa_lop.Enabled = false;
        }

       

        private void btnGhi_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string checkexist = "EXEC [dbo].[sp_TimLop] " + "'" + txtmalop.Text + "'," + "'" + txtTenlop_lop.Text + "'";
            if (txtTenlop_lop.Text.Trim() =="")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (txtmalop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if(checksua)
            {
                this.ghi_lop();
            }    
            else
            {
                if (Program.ExecSqlNonQuery(checkexist) == 1)
                {

                    txtmalop.Focus();
                    return;
                }
                else
                {
                    this.ghi_lop();
                }
            }

        }

        private void btnchuyenlop_sv_Click(object sender, EventArgs e)
        {
            if(sINHVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không thể chuyển lớp khi không có sinh viên!", "", MessageBoxButtons.OK);
                return;
            }
            this.dS_LopTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            this.dS_LopTableAdapter.Fill(this.TN_DS.DS_Lop);
            cbbTenlop.SelectedValue = ((DataRowView)dS_LopBindingSource[dS_LopBindingSource.Position])["MALOP"].ToString();

            cbbTenlop.Enabled = true;
            btnGhiSv.Enabled = true;
            vitri = sINHVIENBindingSource.Position;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
            txtdiachi.Enabled = txtHoSV.Enabled = txtTenSv.Enabled = deNgaySinhSV.Enabled = txtMaSv.Enabled = false;
            btnthemsinhvien.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = false;

            btnGhi_lop.Enabled = btnThem_lop.Enabled = btnUndo_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = false;
            //btnGhi_lop.Enabled = true;
            check_chuyenlop = true;
        }

        private void cbbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbTenlop.SelectedValue == null)
                return;
                 
            mALOPTextBox1.Text = cbbTenlop.SelectedValue.ToString();
        }

        private void btnSua_sv_Click(object sender, EventArgs e)
        {
            if (sINHVIENBindingSource.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để sửa", "", MessageBoxButtons.OK);
                return;
            }
            vitri = sINHVIENBindingSource.Position;
            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = false;
            txtdiachi.Enabled = txtHoSV.Enabled = txtTenSv.Enabled = deNgaySinhSV.Enabled = txtMatKhau.Enabled = true;
            txtMaSv.Enabled = mALOPTextBox1.Enabled = cbbTenlop.Enabled = false;
            srcControl_frmSinhvien.Enabled = false;
            btnGhiSv.Enabled= btnPhuchoiSv.Enabled = true;
            btnthemsinhvien.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = false;
            
            checksua = true;
        }

        private void btnTailaisv_Click(object sender, EventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhuchoiSv_Click(object sender, EventArgs e)
        {
            lOPBindingSource.EndEdit();
            if (btnthemsinhvien.Enabled = false)
                sINHVIENBindingSource.Position = vitri;
            sINHVIENGridControl.Enabled = lOPGridControl.Enabled = true;
            txtdiachi.Enabled = txtHoSV.Enabled = txtTenSv.Enabled = txtMaSv.Enabled = cbbTenlop.Enabled = mALOPTextBox1.Enabled = txtMatKhau.Enabled = deNgaySinhSV.Enabled = false;
            srcControl_frmSinhvien.Enabled = true;
            btnthemsinhvien.Enabled = btnSua_sv.Enabled = btnTailaisv.Enabled = btnXoasinhvien.Enabled = btnchuyenlop_sv.Enabled = true;
            btnGhiSv.Enabled = btnPhuchoiSv.Enabled = false;
            btnThem_lop.Enabled = btnUndo_lop.Enabled = btnXoa_lop.Enabled = btnSua_lop.Enabled = btnLoad_lop.Enabled = true;
            btnGhi_lop.Enabled = btnPhuchoiSv.Enabled = false;
            this.sINHVIENTableAdapter.Fill(this.TN_DS.SINHVIEN);
        }

        private void btnThoat_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
