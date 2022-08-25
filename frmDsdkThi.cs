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
    public partial class frmDsdkThi : Form
    {
        public frmDsdkThi()
        {
            InitializeComponent();

        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            
            DateTime FromDate = dateFrom.Value;
            DateTime ToDate = dateTo.Value;
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "", MessageBoxButtons.OK);
                dateFrom.Focus();
                return;
            }
            try
            {
                this.sP_In_DSDK_ThiTableAdapter.Fill(this.tN_DS.SP_In_DSDK_Thi, FromDate, ToDate);
                if (sP_In_DSDK_ThiBindingSource.Count == 0)
                {
                    MessageBox.Show("Không có danh sách thi từ " + dateFrom.Value.ToString("dd/MM/yyyy") + " đến " + dateTo.Value.ToString("dd/MM/yyyy") + "!", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    this.sP_In_DSDK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                }
            }
            catch (Exception) { }
        }

        private void frmDsdkThi_Load(object sender, EventArgs e)
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
            this.sP_In_DSDK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            DateTime FromDate = dateFrom.Value;
            DateTime ToDate = dateTo.Value;
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "", MessageBoxButtons.OK);
                dateFrom.Focus();
                return;
            } else
            {
                this.sP_In_DSDK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_In_DSDK_ThiTableAdapter.Fill(this.tN_DS.SP_In_DSDK_Thi, FromDate, ToDate);
                if (sP_In_DSDK_ThiBindingSource.Count == 0)
                {
                    MessageBox.Show("Không có danh sách thi từ " + dateFrom.Value.ToString("dd/MM/yyyy") + " đến " + dateTo.Value.ToString("dd/MM/yyyy") + "!", "", MessageBoxButtons.OK);
                    return;
                } else
                {
                    rpDsdkThi rp = new rpDsdkThi(FromDate, ToDate);
                    rp.lbCoSo.Text = cmbCoSo.Text.Trim().ToUpper();
                    rp.lbDateFrom.Text = FromDate.ToString("dd/MM/yyyy");
                    rp.lbToDate.Text = ToDate.ToString("dd/MM/yyyy");
                    ReportPrintTool print = new ReportPrintTool(rp);
                    print.ShowPreviewDialog();
                }
            }
            
        }
    }
}
