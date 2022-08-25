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
    public partial class frmBoDe : Form
    {
        public int vitri;
        public bool checkSua = false;
        public string cauHoi = "";
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_DS);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_DS.DsMONHOC' table. You can move, or remove it, as needed.
            this.dsMONHOCTableAdapter.Fill(this.tN_DS.DsMONHOC);
            // TODO: This line of code loads data into the 'tN_DS.DsTRINHDO' table. You can move, or remove it, as needed.
            this.dsTRINHDOTableAdapter.Fill(this.tN_DS.DsTRINHDO);
            // TODO: This line of code loads data into the 'tN_DS.DsTRINHDO' table. You can move, or remove it, as needed.
            this.dsTRINHDOTableAdapter.Fill(this.tN_DS.DsTRINHDO);
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            }

            tN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_DS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.tN_DS.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_DS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_DS.MONHOC);
            // TODO: This line of code loads data into the 'tN_DS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.tN_DS.BODE);
            // TODO: This line of code loads data into the 'tN_DS.DsDAPAN' table. You can move, or remove it, as needed.
            this.dsDAPANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsDAPANTableAdapter.Fill(this.tN_DS.DsDAPAN);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            vitri = bODEBindingSource.Position;
            cmbMonHoc.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = srch.Enabled = false;
            txtNoiDung.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = txtCauHoi.Enabled = cmbMaGV.Enabled = true;
            txtNoiDung.Focus();
            bODEGridControl.Enabled = false;

            this.bODEBindingSource.AddNew();
            if (Program.mGroup == "GIANGVIEN")
            {
                cmbMaGV.Enabled = false;
                cmbMaGV.SelectedValue = Program.username.Trim();
            } 
            else
            {
                cmbMaGV.SelectedValue = Program.username.Trim();
            }
            
            cmbMaMH.SelectedValue = cmbMonHoc.SelectedValue.ToString().Trim();
            ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["MAGV"] = cmbMaGV.Text;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count == 0)
            {
                MessageBox.Show("Không có đề để xoá!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.username != ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["MAGV"].ToString().Trim() && Program.mGroup != "COSO")
            {
                MessageBox.Show("Không thể xoá câu hỏi của giảng viên khác, vui lòng chọn lại!", "", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có chắc chắn xoá câu hỏi này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cauHoi = ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["CAUHOI"].ToString().Trim();
                    this.bODEBindingSource.RemoveCurrent();
                    this.bODETableAdapter.Update(tN_DS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá giảng viên. Bạn hãy xoá lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(tN_DS.BODE);
                    this.bODEBindingSource.Position = gIAOVIENBindingSource.Find("CAUHOI", cauHoi);
                    return;
                }
            }
            if (bODEBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để sửa!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.username != ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["MAGV"].ToString().Trim() && Program.mGroup != "COSO")
            {
                MessageBox.Show("Không thể sửa câu hỏi của giảng viên khác, vui lòng chọn lại!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mGroup == "COSO")
            {
                cmbMaGV.Enabled = true;
                cmbMaMH.Enabled = true;
            }
            vitri = bODEBindingSource.Position;
            cauHoi = ((DataRowView)bODEBindingSource[bODEBindingSource.Position])["CAUHOI"].ToString().Trim();
            bODEGridControl.Enabled = false;
            cmbMonHoc.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = srch.Enabled = false;
            txtNoiDung.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = txtCauHoi.Enabled = cmbMaMH.Enabled = true;
            checkSua = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bODEBindingSource.CancelEdit();
            if (btnThem.Enabled == false)  bODEBindingSource.Position = vitri;
            bODEGridControl.Enabled = true;
            txtNoiDung.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = txtCauHoi.Enabled = cmbMaMH.Enabled = cmbMaGV.Enabled = false; 
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = srch.Enabled = true;
            cmbMonHoc.Enabled = true;
            checkSua = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(tN_DS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ghiDe()
        {          
            try
            {
                this.bODEBindingSource.EndEdit();
                this.bODEBindingSource.ResetCurrentItem();
                this.bODETableAdapter.Update(this.tN_DS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đề. \n" + ex.Message, "", MessageBoxButtons.OK);
            }

            bODEGridControl.Enabled= true;
            btnPhucHoi.Enabled = btnGhi.Enabled = cmbMaGV.Enabled = cmbMaMH.Enabled = false;
            txtNoiDung.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = cmbTrinhDo.Enabled = cmbDapAn.Enabled = txtCauHoi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = srch.Enabled = true;
            cmbMonHoc.Enabled = true;
            checkSua = false;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCauHoi.Text.Trim() == "")
            {
                MessageBox.Show("Câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                txtNoiDung.Focus();
                return;
            }
            if (cmbTrinhDo.SelectedValue == null)
            {
                MessageBox.Show("Trình độ không được để trống!", "", MessageBoxButtons.OK);
                cmbTrinhDo.Focus();
                return;
            }
            if (cmbDapAn.SelectedValue == null)
            {
                MessageBox.Show("Đáp án không được để trống!", "", MessageBoxButtons.OK);
                cmbDapAn.Focus();
                return;
            }
            if (cmbMaGV.SelectedValue  == null)
            {
                MessageBox.Show("Mã giảng viên không được để trống!", "", MessageBoxButtons.OK);
                cmbMaGV.Focus();
                return;
            }
            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung không được để trống!", "", MessageBoxButtons.OK);
                txtNoiDung.Focus();
                return;
            }
            if (txtA.Text == "")
            {
                MessageBox.Show("Nội dung đáp án A không được để trống!", "", MessageBoxButtons.OK);
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Nội dung đáp án B không được để trống!", "", MessageBoxButtons.OK);
                txtB.Focus();
                return;
            }
            if (txtC.Text == "")
            {
                MessageBox.Show("Nội dung đáp án C không được để trống!", "", MessageBoxButtons.OK);
                txtC.Focus();
                return;
            }
            if (txtD.Text == "")
            {
                MessageBox.Show("Nội dung đáp án D không được để trống!", "", MessageBoxButtons.OK);
                txtD.Focus();
                return;
            }
            string cmdCheckKH = "Exec [dbo].[SP_Kt_De_Ton_Tai] '" + txtCauHoi.Text.Trim() + "'";
            if ((checkSua && cauHoi == txtCauHoi.Text.Trim()))
            {
                this.ghiDe();
            } 
            else if (Program.ExecSqlNonQuery(cmdCheckKH) == 1)
            {
                txtCauHoi.Focus();
                return;
            }
            else
            {
                this.ghiDe();
            }
        }

        private void cmbTrinhDo_SelectedIndexChanged(object sender, EventArgs ex)
        {
            if (cmbTrinhDo.SelectedValue == null) return;
        }
    }
}
