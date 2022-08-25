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
    public partial class frmGiangvien_Dangki : Form
    {
        int vitri = 0;
        bool checksua = false;
        public frmGiangvien_Dangki()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_DS);

        }

        private void frmGiangvien_Dangki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_DS.DsGiAOVIEN' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN' table. You can move, or remove it, as needed.

            this.tN_DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_DS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.tN_DS.LOP);
            // TODO: This line of code loads data into the 'tN_DS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);
            this.dsGiAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsGiAOVIENTableAdapter.Fill(this.tN_DS.DsGiAOVIEN);
            this.gIAOVIENTableAdapter.Fill(this.tN_DS.GIAOVIEN);

            gIAOVIEN_DANGKYGridControl.ShowOnlyPredefinedDetails = true;
            try
            {
                cbbCoso_GVDK.DataSource = Program.bds_dspm;
                cbbCoso_GVDK.DisplayMember = "TENCS";
                cbbCoso_GVDK.ValueMember = "TENSERVER";
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if(Program.mGroup == "TRUONG")
            {
                btnTaiLai_GVDK.Enabled = btnThoat_GVDK.Enabled = true;
                btnThem_GVDK.Enabled = btnXoa_GVDK.Enabled = btnSua_GVDK.Enabled = btnGhi_GVDK.Enabled = false;
                 cbbmaGV_GVDK.Enabled = cbbMaMH_GVDK.Enabled = cbbMaLop_GVDK.Enabled = cbbTrinhdo_DVDK.Enabled = deNgaythi_GVDK.Enabled = cbbLanthi_GVDK.Enabled = socauthi_GVDK.Enabled = txtThoigian_GVDK.Enabled = false;
                cbbCoso_GVDK.Enabled = true;
            }    
            if(Program.mGroup =="COSO")
            {
                cbbCoso_GVDK.Enabled = false; 
            }    
             
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.trinhDoTableAdapter.FillBy(this.tN_DS.TrinhDo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbbCoso_GVDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoso_GVDK.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbCoso_GVDK.SelectedValue.ToString();
            if(cbbCoso_GVDK.SelectedIndex != Program.mChinhanh)
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
                MessageBox.Show("Lỗi kết nối cơ sở mới: ", "", MessageBoxButtons.OK); // trường hợp lỗi khi site đo chưa mở
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(tN_DS.LOP);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.tN_DS.GIAOVIEN);
                this.dsGiAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dsGiAOVIENTableAdapter.Fill(this.tN_DS.DsGiAOVIEN);
            }
        }

        private void btnThem_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gIAOVIEN_DANGKYBindingSource.Position;
            gIAOVIEN_DANGKYBindingSource.AddNew();

           
            gIAOVIEN_DANGKYGridControl.Enabled = false;
            cbbmaGV_GVDK.Enabled = cbbMaLop_GVDK.Enabled = cbbMaMH_GVDK.Enabled = cbbTrinhdo_DVDK.Enabled = cbbLanthi_GVDK.Enabled = deNgaythi_GVDK.Enabled = txtThoigian_GVDK.Enabled = socauthi_GVDK.Enabled = true;
            btnThem_GVDK.Enabled = btnXoa_GVDK.Enabled = btnSua_GVDK.Enabled = btnTaiLai_GVDK.Enabled = false;
            btnGhi_GVDK.Enabled = btnPhucHoi_GVDK.Enabled = true;
            srcControlGVDK.Enabled = false;
        }

        private void btnTaiLai_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gIAOVIEN_DANGKYTableAdapter.Fill(tN_DS.GIAOVIEN_DANGKY);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải lại:" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSua_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gIAOVIENBindingSource.Position;
            string checkexists_diemsv = "exec [dbo].[SP_check_TonTai_Diem] '" + cbbMaMH_GVDK.SelectedValue + "','" + cbbMaLop_GVDK.SelectedValue + "'," + cbbLanthi_GVDK.Text  ;
           
            if (Program.ExecSqlNonQuery(checkexists_diemsv) == 1)
            {
                return;
            }
            gIAOVIEN_DANGKYGridControl.Enabled = false;
            btnGhi_GVDK.Enabled = btnPhucHoi_GVDK.Enabled = true;
            btnThem_GVDK.Enabled = btnXoa_GVDK.Enabled = btnSua_GVDK.Enabled = btnTaiLai_GVDK.Enabled = btnXoa_GVDK.Enabled = false;
            cbbLanthi_GVDK.Enabled = cbbmaGV_GVDK.Enabled = cbbMaLop_GVDK.Enabled = cbbMaMH_GVDK.Enabled = false;
            cbbTrinhdo_DVDK.Enabled = socauthi_GVDK.Enabled = deNgaythi_GVDK.Enabled = txtThoigian_GVDK.Enabled = true;
            srcControlGVDK.Enabled = false;
            checksua = true;
            
        }

        private void btnPhucHoi_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIENBindingSource.EndEdit();
            if (btnThem_GVDK.Enabled = false)
                gIAOVIEN_DANGKYBindingSource.Position = vitri;
            gIAOVIEN_DANGKYGridControl.Enabled = true;
            btnThem_GVDK.Enabled = btnXoa_GVDK.Enabled = btnSua_GVDK.Enabled = btnTaiLai_GVDK.Enabled = btnXoa_GVDK.Enabled = true;
            btnGhi_GVDK.Enabled = btnPhucHoi_GVDK.Enabled = false;
            srcControlGVDK.Enabled = true;
            cbbTrinhdo_DVDK.Enabled = socauthi_GVDK.Enabled = deNgaythi_GVDK.Enabled = txtThoigian_GVDK.Enabled = false;
            cbbmaGV_GVDK.Enabled = cbbMaLop_GVDK.Enabled = cbbMaMH_GVDK.Enabled = cbbLanthi_GVDK.Enabled = false;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);

        }

        private void btnThoat_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string checkexists_diemsv = "exec [dbo].[SP_check_TonTai_Diem] '" + cbbMaMH_GVDK.SelectedValue + "','" + cbbMaLop_GVDK.SelectedValue + "'," + cbbLanthi_GVDK.Text;
            string GVDK = "";
            if (Program.ExecSqlNonQuery(checkexists_diemsv) == 1)
            {
                return;
            }           
            if (MessageBox.Show("Bạn có thật sự muốn xoá lớp này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    GVDK = (((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MALOP"].ToString());
                    gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.tN_DS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xoá lớp này. hãy xoá lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);
                    gIAOVIEN_DANGKYBindingSource.Position = gIAOVIEN_DANGKYBindingSource.Find("MALOP", GVDK);
                    return;
                }
            }
            if (gIAOVIEN_DANGKYBindingSource.Count == 0) btnXoa_GVDK.Enabled = false;
        }
        private void ghi_gvdk()
        {
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MAGV"] = cbbmaGV_GVDK.SelectedValue.ToString();
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MALOP"] = cbbMaLop_GVDK.SelectedValue.ToString();
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["MAMH"] = cbbMaMH_GVDK.SelectedValue.ToString();
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["LAN"] = cbbLanthi_GVDK.Text;
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["NGAYTHI"] = deNgaythi_GVDK.Value;
            ((DataRowView)gIAOVIEN_DANGKYBindingSource[gIAOVIEN_DANGKYBindingSource.Position])["TRINHDO"] = cbbTrinhdo_DVDK.Text;
            
            try
            {
                gIAOVIEN_DANGKYBindingSource.EndEdit(); //ket thuc qt hieu chinh ,them,..
                gIAOVIEN_DANGKYBindingSource.ResetCurrentItem(); // đưa hiệu chỉnh lên gridview              
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.tN_DS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Giảng viên đăng kí thi.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gIAOVIEN_DANGKYGridControl.Enabled = true;
            btnThem_GVDK.Enabled = btnXoa_GVDK.Enabled = btnSua_GVDK.Enabled = btnTaiLai_GVDK.Enabled = btnXoa_GVDK.Enabled = true;
            btnGhi_GVDK.Enabled = btnPhucHoi_GVDK.Enabled = false;
            srcControlGVDK.Enabled = true;
            cbbTrinhdo_DVDK.Enabled = socauthi_GVDK.Enabled = deNgaythi_GVDK.Enabled = txtThoigian_GVDK.Enabled = false;
            cbbmaGV_GVDK.Enabled = cbbMaLop_GVDK.Enabled = cbbMaMH_GVDK.Enabled = cbbLanthi_GVDK.Enabled = false;

        }
        private void btnGhi_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string checkexsist = "exec [dbo].[sp_Tim_GVDK]'" + cbbMaLop_GVDK.SelectedValue +"','" + cbbMaMH_GVDK.SelectedValue + "','" + cbbLanthi_GVDK.Text + "'";
            int tgThi = 0;
            int socauthi = 0;
            if (socauthi_GVDK.Text.Trim() == "")
            {
                MessageBox.Show("Câu thi không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            if (txtThoigian_GVDK.Text.Trim() == "")
            {
                MessageBox.Show("Thời gian thi không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            if (deNgaythi_GVDK.Text == null)
            {
                this.deNgaythi_GVDK.Value = DateTime.Now;
            }
            if (deNgaythi_GVDK.Value >= DateTime.Now)
            {
                MessageBox.Show("Thời gian đăng ký thi phải lớn hơn hoặc bằng thời gian hiện tại", "", MessageBoxButtons.OK);
                return;
            }
            tgThi = int.Parse(txtThoigian_GVDK.Text);
            if (tgThi < 15 || tgThi > 60)
            {
                MessageBox.Show("Thời gian thi phải lớn hơn 15 phút và nhỏ hơn 60 phút" ,"", MessageBoxButtons.OK);
                return;
            }                       
            
            try
            {              
                socauthi = int.Parse(socauthi_GVDK.Text);                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nhập số câu thi sai, số câu thi phải là số!", "", MessageBoxButtons.OK);
                return;
            }
            if (socauthi < 10 || socauthi > 100)
            {
                MessageBox.Show("Số câu thi không được nhỏ hơn 10 và lớn hơn 100 câu", "", MessageBoxButtons.OK);
                return;
            }

            if (checksua)
            {
                this.ghi_gvdk();
            }
            else
            {
                if(Program.ExecSqlNonQuery(checkexsist) == 1)
                {
                    
                    return;
                }    
                else
                {
                    this.ghi_gvdk();
                }   
            }
        }

        private void socauthi_GVDK_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
