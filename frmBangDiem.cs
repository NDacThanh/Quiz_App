using DevExpress.XtraReports.UI;
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
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCoSo.DataSource = Program.bds_dspm.DataSource;
                cmbCoSo.ValueMember = "TENSERVER";
                cmbCoSo.DisplayMember = "TENCS";
                cmbCoSo.SelectedIndex = Program.mChinhanh;

            }
            catch (Exception) { }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
            }
            this.tN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_DS.DsLopDKThi' table. You can move, or remove it, as needed.
            this.dsLopDKThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsLopDKThiTableAdapter.Fill(this.tN_DS.DsLopDKThi);
            if (dsLopDKThiBindingSource.Count > 0)
            {
                this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Mon_Hoc_DK_Thi, cmbLop.SelectedValue.ToString());
                if (sP_Ds_Mon_Hoc_DK_ThiBindingSource.Count > 0)
                {
                    this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                    if (this.sP_Ds_Lan_ThiBindingSource.Count > 0)
                    {
                        this.sP_In_Bang_DiemTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS.SP_In_Bang_Diem, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.SelectedValue.ToString()));
                    }
                }
                else
                {
                    this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, null, null);
                }
            }
            else
            {
                this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Mon_Hoc_DK_Thi, null);
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbLop.SelectedValue != null)
            {
                try
                {
                    this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Mon_Hoc_DK_Thi, cmbLop.SelectedValue.ToString());
                    if (this.sP_Ds_Mon_Hoc_DK_ThiBindingSource.Count > 0)
                    {
                        cmbMonHoc_SelectedIndexChanged(sender, e);
                    }
                    if (this.sP_Ds_Mon_Hoc_DK_ThiBindingSource.Count > 0)
                    {
                        this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                        cmbLanThi_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, null, null);
                    }
                }
                catch (Exception) { }
            }
            
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
                if (cmbCoSo.SelectedIndex != Program.mChinhanh)
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
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    this.dsLopDKThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dsLopDKThiTableAdapter.Fill(this.tN_DS.DsLopDKThi);
                    if (dsLopDKThiBindingSource.Count == 0)
                    {
                        this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Mon_Hoc_DK_Thi, null);
                        this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, null, null);
                        this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS.SP_In_Bang_Diem, null, null, null);
                        return;
                    } else
                    {
                        this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_Ds_Mon_Hoc_DK_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Mon_Hoc_DK_Thi, cmbLop.SelectedValue.ToString());
                        this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                        this.sP_In_Bang_DiemTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS.SP_In_Bang_Diem, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.SelectedValue.ToString()));
                    }
                    
                }
            }
            catch (Exception) { }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbLop.SelectedValue != null)
            {
                if (cmbMonHoc.SelectedValue != null)
                {
                    try
                    {
                        this.sP_Ds_Lan_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_Ds_Lan_ThiTableAdapter.Fill(this.tN_DS.SP_Ds_Lan_Thi, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString());
                        if (sP_Ds_Lan_ThiBindingSource.Count > 0)
                        {
                            cmbLanThi_SelectedIndexChanged(sender, e);
                        }
                    }
                    catch (Exception) { }
                }
                
            } 
        }

        private void cmbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null)
            {
                if (cmbMonHoc.SelectedValue != null)
                {
                    if (cmbLanThi.SelectedValue != null)
                    {
                        this.sP_In_Bang_DiemTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS.SP_In_Bang_Diem, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.SelectedValue.ToString()));
                    }
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sP_In_Bang_DiemTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS.SP_In_Bang_Diem, cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.SelectedValue.ToString()));

            rpBangDiem rp = new rpBangDiem(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.SelectedValue.ToString()));
            rp.lbLop.Text = cmbLop.Text.Trim();
            rp.lbMH.Text = cmbMonHoc.Text.Trim();
            rp.lbLanThi.Text = cmbLanThi.Text.Trim();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
