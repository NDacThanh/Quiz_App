using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraReports.UI;

namespace THITN
{
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_DS.DsMONHOC' table. You can move, or remove it, as needed.
            this.dsMONHOCTableAdapter.Fill(this.tN_DS.DsMONHOC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textEdit3.Text = "";
            textEdit1.Text = "";
            textEdit5.Text = "";
            textEdit2.Text = "";
            textEdit4.Text = "";
            String lenh = "";
            this.sP_Xem_Ket_QuaTableAdapter.Fill(this.tN_DS.SP_Xem_Ket_Qua, null, null,null) ;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            lenh = "SELECT HO + ' '+ TEN as hoten,MALOP FROM SINHVIEN WHERE MASV = '" + textBox1.Text + "'";
            try
            {

                Program.myreader = Program.ExecSqlDataReader(lenh);
                if (Program.myreader == null) return;
                Program.myreader.Read();
                textEdit3.Text = Program.myreader.GetString(0);
                textEdit1.Text = Program.myreader.GetString(1);
                Program.myreader.Close();
            }
            catch (Exception ex)
            {
                Program.myreader.Close();
                MessageBox.Show("Không thể tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                lenh = "SELECT NGAYTHI,DIEM FROM BANGDIEM WHERE MASV='" + textBox1.Text + "' AND MAMH='" + mAMHComboBox.SelectedValue.ToString() + "' AND LAN=" + comboBox1.Text;
                Program.myreader = Program.ExecSqlDataReader(lenh);
                if (Program.myreader == null) return;
                Program.myreader.Read();
                textEdit5.Text = Program.myreader.GetDateTime(0).ToString();
                textEdit2.Text = mAMHComboBox.Text;
                textEdit4.Text = comboBox1.Text;
                Program.myreader.Close();

                // diem =Program.myreader.GetString(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tìm thấy môn thi và lần thi đã chọn!", "Thông báo", MessageBoxButtons.OK);
                Program.myreader.Close();
                return;
            }

            try
            {

                this.sP_Xem_Ket_QuaTableAdapter.Fill(this.tN_DS.SP_Xem_Ket_Qua, textBox1.Text, mAMHComboBox.SelectedValue.ToString(), new System.Nullable<short>(((short)(System.Convert.ChangeType(comboBox1.Text, typeof(short))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mAMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mAMHComboBox.SelectedValue == null)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masv = textBox1.Text.Trim();
            string mamonhoc = mAMHComboBox.SelectedValue.ToString();
            int lan = int.Parse(comboBox1.Text.ToString());
            this.sP_Xem_Ket_QuaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_Xem_Ket_QuaTableAdapter.Fill(this.tN_DS.SP_Xem_Ket_Qua,masv,mamonhoc, new System.Nullable<short>(((short)(System.Convert.ChangeType(comboBox1.Text, typeof(short))))));
            
            if(sP_Xem_Ket_QuaBindingSource.Count == 0)
            {
                MessageBox.Show("Không có sinh viên thi nên chưa có điểm thi", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                rpXemKetQua kq = new rpXemKetQua(masv,mamonhoc,lan);
                ReportPrintTool print = new ReportPrintTool(kq);
                print.ShowPreviewDialog();

            }


        }
    }
}
