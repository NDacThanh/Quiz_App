using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmDangNhap : Form
    {
        

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn_publisher.State == ConnectionState.Closed)
                Program.conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn_publisher);
            da.Fill(dt);
            Program.conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoso.DataSource = Program.bds_dspm;
            cmbCoso.DisplayMember = "TENCS";
            cmbCoso.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

     
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM dbo.Get_Subscribes");
            cmbCoso.SelectedIndex = 1; cmbCoso.SelectedIndex = 0;
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoso.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được để trống", "", MessageBoxButtons.OK);
                return;
            }

            if (rdoSinhVien.Checked)
            {
                Program.mlogin = Program.loginSV;
                Program.password = Program.passwordSV;
            } else
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
            }
            
            if (Program.KetNoi() == 0) return;
            
            Program.mChinhanh = cmbCoso.SelectedIndex;
            
            string strLenh = "";
            string strCheck = "";
            if (rdoSinhVien.Checked)
            {
                strCheck = "EXEC [dbo].[SP_Kt_Dang_Nhap_SV] '" + txtLogin.Text.Trim() + "', '" + txtPassword.Text.Trim() + "'";
                if (Program.ExecSqlNonQuery(strCheck) == 1)
                {
                    txtLogin.Focus();
                    return;
                }
                else
                {
                    strLenh = "EXEC SP_Lay_Thong_Tin_SV_Tu_Login '" + txtLogin.Text.Trim() + "'";
                }
            } else 
            {
                strLenh = "EXEC SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
            } 

            Program.myreader = Program.ExecSqlDataReader(strLenh);
            
            if (Program.myreader == null) return;
            
            Program.myreader.Read();
            Program.username = Program.myreader.GetString(0).Trim();
            
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            
            Program.mHoten = Program.myreader.GetString(1);
            Program.mGroup = Program.myreader.GetString(2);
            Program.myreader.Close();
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            lbLogin.Text = "Mã sinh viên";
        }

        private void rdoGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            lbLogin.Text = "Tài khoản";
        }
    }
}
