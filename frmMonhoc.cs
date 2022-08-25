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
    public partial class frmMonhoc : Form
    {
        int vitri = 0;
        bool checksua = false; 
        public frmMonhoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_DS);

        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            this.tN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_DS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.tN_DS.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_DS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.tN_DS.BODE);
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_DS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);

            mONHOCGridControl.ShowOnlyPredefinedDetails = true;
            if (Program.mGroup == "TRUONG")
            {
                btnTailaiMon.Enabled = btnThoat.Enabled = true;
                btnThemMon.Enabled = btnXoaMon.Enabled = BtnSuaMon.Enabled = txtMaMH.Enabled = txtTenMH.Enabled = false;
            }    
        }

        private void btnThemMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            mONHOCBindingSource.AddNew();
            ((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["MAMH"] = txtMaMH.Text;

            btnGhiMon.Enabled = btnPhucHoiMon.Enabled = true;
            mONHOCGridControl.Enabled = false;
            txtTenMH.Enabled = txtMaMH.Enabled = true;
            btnXoaMon.Enabled = BtnSuaMon.Enabled = btnTailaiMon.Enabled = btnThoat.Enabled = false;
            btnThemMon.Enabled = false;
            srcControlMH.Enabled = false;
        }

        private void btnTailaiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {   
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải lại:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            if (btnThemMon.Enabled == false)
                 mONHOCBindingSource.Position = vitri;
            mONHOCGridControl.Enabled = true;
            btnXoaMon.Enabled = btnThemMon.Enabled = BtnSuaMon.Enabled = btnTailaiMon.Enabled = btnThoat.Enabled = true;
            btnGhiMon.Enabled = btnPhucHoiMon.Enabled = false;
            txtMaMH.Enabled = txtTenMH.Enabled = false;
            this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
        }

        private void BtnSuaMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mONHOCBindingSource.Count == 0)
            {
                MessageBox.Show("Không thể sửa khi chưa có môn học!", "", MessageBoxButtons.OK);
                return;
            }    
            vitri = mONHOCBindingSource.Position;

            mONHOCGridControl.Enabled = false;
            txtMaMH.Enabled = txtTenMH.Enabled = true;
            btnThemMon.Enabled = btnXoaMon.Enabled = btnTailaiMon.Enabled = BtnSuaMon.Enabled = btnThoat.Enabled = false;
            btnGhiMon.Enabled = btnPhucHoiMon.Enabled = true;
            srcControlMH.Enabled = false;
            txtMaMH.Enabled = true;
            checksua = true;
            
        }

        private void btnXoaMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maMH = "";
            if(bODEBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá môn học này vì đã có đề của môn này!", "", MessageBoxButtons.OK);
                return;
            } 
            if(gIAOVIEN_DANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá môn học này vì đã có giảng viên đăng kí môn này!", "", MessageBoxButtons.OK);
                return;
            }    
            if(bANGDIEMBindingSource.Count > 0)
            {
                MessageBox.Show("không thể xoá môn học này vì đã có điểm của môn này!", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có thật sự muốn xoá môn học này!","Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = (((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["MAMH"].ToString());
                    vitri = mONHOCBindingSource.Position;
                    mONHOCBindingSource.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(tN_DS.MONHOC);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể xoá môn học, hãy xoá lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
                    mONHOCBindingSource.Position = mONHOCBindingSource.Find("MAMH", maMH);
                    return;
                }              
            }
            if(mONHOCBindingSource.Count == 0)
            {

                btnXoaMon.Enabled = false;
            }    
        }
        private void ghi_Mon()
        {
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCBindingSource.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.tN_DS.MONHOC);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học\n" + ex.Message,"", MessageBoxButtons.OK);
                return;
            }
            mONHOCGridControl.Enabled = true;
            txtMaMH.Enabled = txtTenMH.Enabled = false;
            btnGhiMon.Enabled = btnPhucHoiMon.Enabled = false;
            btnThemMon.Enabled = BtnSuaMon.Enabled = btnXoaMon.Enabled = btnTailaiMon.Enabled = btnThoat.Enabled = true;


        }
        private void btnGhiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string checkexsist = "EXEC [dbo].[sp_TimMonHoc ]" + "'" + txtMaMH.Text + "'";
            if(txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống", "", MessageBoxButtons.OK);
                return;
            }  
            if(txtMaMH.Text.Trim().Length > 5)
            {
                MessageBox.Show("Mã môn học không được vượt quá 5 kí tự!", "", MessageBoxButtons.OK);
                return;
            }    
            if(checksua)
            {
                this.ghi_Mon();
            }  
            else
            {
                if(Program.ExecSqlNonQuery(checkexsist) == 1)
                {
                    txtMaMH.Focus();
                    return;
                }
                else
                {
                    this.ghi_Mon();
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
