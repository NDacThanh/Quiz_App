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
    public partial class frmChonMonThi : Form
    {
        public frmChonMonThi()
        {
            InitializeComponent();
        }

        private void frmChonMonThi_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'tN_DS.DsLopDKThi' table. You can move, or remove it, as needed.
            this.dsLopDKThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsLopDKThiTableAdapter.Fill(this.tN_DS.DsLopDKThi);
            if (Program.checkThiGV == true)
            {
                groupBox1.Hide();
                groupBox2.Hide();
                sP_Chon_Mon_ThiGridControl.Hide();
                textBox4.Text = Program.username;
                textBox3.Text = Program.mHoten;
            }
            else
            {
                groupBox3.Hide();
                groupBox4.Hide();
                textBox1.Text = Program.username;
                textBox2.Text = Program.mHoten;
                sP_Chon_Mon_Thi_GVGridControl.Hide();
                try
                {
                    this.sP_Ma_LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_Ma_LopTableAdapter.Fill(this.tN_DS.SP_Ma_Lop, Program.username);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                try
                {
                    this.sP_Chon_Mon_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_Chon_Mon_ThiTableAdapter.Fill(this.tN_DS.SP_Chon_Mon_Thi, Program.username, mALOPTextEdit.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.checkThiGV == false)
                {
                    Program.mMalop = mALOPTextEdit.Text;
                    Program.mMaMH = mAMHTextEdit.Text;
                    Program.mLan = int.Parse(lANTextEdit1.Text);
                    Program.mSoCauThi = int.Parse(sOCAUTHITextEdit1.Text);
                    Program.mThoiGian = tHOIGIANTextEdit1.Text;
                    Program.mNgayThi = nGAYTHIDateEdit.DateTime;

                }
                else
                {
                    Program.mMalop = comboBox1.Text;
                    Program.mMaMH = mAMHTextEdit1.Text;
                    Program.mLan = int.Parse(lANTextEdit.Text);
                    Program.mSoCauThi = int.Parse(sOCAUTHITextEdit.Text);
                    Program.mThoiGian = tHOIGIANTextEdit.Text;
                    Program.mNgayThi = nGAYTHIDateEdit1.DateTime;
                }
                Program.frmChinh.btnThi.Enabled = false;
                this.Close();     
                frmThi f = new frmThi();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có môn thi nào vào ngày hôm nay!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_Chon_Mon_Thi_GVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_Chon_Mon_Thi_GVTableAdapter.Fill(this.tN_DS.SP_Chon_Mon_Thi_GV, comboBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
