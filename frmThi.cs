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
    public partial class frmThi : Form
    {
        DataTable dtTN = new DataTable();
        string[] DaChon = new string[Program.mSoCauThi];
        string DapAn = "";
        int CauDung = 0;
        float diem = 0;
        int i;
        public frmThi()
        {
            InitializeComponent();
            LoadListView();
        }
        private void LoadCauHoi(int i)
        {
            label1.Text = "Cau " + (i + 1).ToString() + " :";
            richTextBox1.Text = ((DataRowView)bindingSource1[i])["NoiDung"].ToString();
            memoEdit1.Text = ((DataRowView)bindingSource1[i])["A"].ToString();
            memoEdit2.Text = ((DataRowView)bindingSource1[i])["B"].ToString();
            memoEdit3.Text = ((DataRowView)bindingSource1[i])["C"].ToString();
            memoEdit4.Text = ((DataRowView)bindingSource1[i])["D"].ToString();
            memoEdit1.BackColor = SystemColors.Control;
            memoEdit2.BackColor = SystemColors.Control;
            memoEdit3.BackColor = SystemColors.Control;
            memoEdit4.BackColor = SystemColors.Control;

            if (DaChon[i] == "A")
            {
                radioButton1.Checked = true;
                memoEdit1.BackColor = Color.Yellow;
            }

            else if (DaChon[i] == "B")
            {
                radioButton2.Checked = true;
                memoEdit2.BackColor = Color.Yellow;
            }

            else if (DaChon[i] == "C")
            {
                radioButton3.Checked = true;
                memoEdit3.BackColor = Color.Yellow;
            }

            else if (DaChon[i] == "D")
            {
                radioButton4.Checked = true;
                memoEdit4.BackColor = Color.Yellow;
            }

            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
        }
        void LoadListView()
        {
            for (int i = 1; i < Program.mSoCauThi + 1; i++)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(" ");
                listView1.Items.Add(lvi);

            }

        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            textBox2.Text = Program.mHoten;
            textBox3.Text = Program.mMaMH;

            String sql = "";
            if (Program.checkThiGV == false)
            {
                sql = "exec SP_BAITHI '"
                    + Program.mMalop + "','"
                    + Program.username + "','"
                    + Program.mMaMH + "', "
                    + Program.mLan;
            }
            else
            {
                sql = "exec SP_Thi_Thu '"
                    + Program.mMalop + "','"
                    + Program.mMaMH + "', "
                    + Program.mLan;
            }


            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy được đề thi, thiếu đề", "Thông báo", MessageBoxButtons.OK);
                Program.frmChinh.btnThi.Enabled = true;
                this.BeginInvoke(new MethodInvoker(Close));
                return;
                
            }
            if (Program.checkThiGV == false)
            {
                try
                {
                    String themDiem = "INSERT INTO BANGDIEM(MASV, MAMH, LAN, NGAYTHI) VALUES('" + Program.username + "','" + Program.mMaMH + "'," + Program.mLan + ",'" + Program.mNgayThi.ToString("MM/dd/yyyy") + "')";
                    Program.ExecSqlNonQuery(themDiem);
                }
                catch
                {
                    MessageBox.Show("Không thể thêm điểm", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }


            bindingSource1.DataSource = dt;
            i = 0;
            LoadCauHoi(i);
            label2.Text = Program.mThoiGian;
            timer1.Start();
        }

        private void NopBai()
        {
            timer1.Stop();
            if (Program.checkThiGV == false)
            {
                try
                {
                    String UpdateCauDaChon;
                    for (int i = 0; i < Program.mSoCauThi; i++)
                    {
                        UpdateCauDaChon = " UPDATE BAITHI SET DACHON = '" + DaChon[i] + "' WHERE CAUSO = " + ((DataRowView)bindingSource1[i])["CAUSO"].ToString() + " AND MABD='"
                                        + Program.username.Trim() + Program.mMaMH.Trim() + Program.mLan.ToString() + "'";
                        Program.ExecSqlNonQuery(UpdateCauDaChon);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể update câu đã chọn ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            CauDung = 0;
            for (int i = 0; i < Program.mSoCauThi; i++)
            {

                DapAn = ((DataRowView)bindingSource1[i])["DAP_AN"].ToString().Trim();
                if (DapAn == DaChon[i])
                    CauDung++;

            }
            diem = (float)Math.Round((double)(CauDung * 10) / Program.mSoCauThi, 2);
            MessageBox.Show("Bạn đã hoàn thành bài thi!" +
                            "\nBạn được " + diem + " điểm!", "Thông báo");
            if (Program.checkThiGV == false)
            {
                try
                {
                    String UpdateDiem = "update BANGDIEM SET DIEM =" + diem.ToString().Replace(",",".") + " WHERE MASV = '" + Program.username + "' AND MAMH = '" + Program.mMaMH + "' AND LAN =" + Program.mLan;
                    Program.ExecSqlNonQuery(UpdateDiem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể update điểm", "Thông báo", MessageBoxButtons.OK);
                }
            }
            this.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn nộp bài?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                NopBai();
                Program.frmChinh.btnThi.Enabled = true;
            } else
            {
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ListViewItem lvi = listView1.Items[i];
                lvi.SubItems[1].Text = "A";
                DaChon[i] = "A";
                memoEdit1.BackColor = Color.Yellow;
                memoEdit2.BackColor = SystemColors.Control;
                memoEdit3.BackColor = SystemColors.Control;
                memoEdit4.BackColor = SystemColors.Control;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                ListViewItem lvi = listView1.Items[i];
                lvi.SubItems[1].Text = "B";
                DaChon[i] = "B";
                memoEdit2.BackColor = Color.Yellow;
                memoEdit1.BackColor = SystemColors.Control;
                memoEdit3.BackColor = SystemColors.Control;
                memoEdit4.BackColor = SystemColors.Control;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                ListViewItem lvi = listView1.Items[i];
                lvi.SubItems[1].Text = "C";
                DaChon[i] = "C";
                memoEdit3.BackColor = Color.Yellow;
                memoEdit1.BackColor = SystemColors.Control;
                memoEdit2.BackColor = SystemColors.Control;
                memoEdit4.BackColor = SystemColors.Control;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                ListViewItem lvi = listView1.Items[i];
                lvi.SubItems[1].Text = "D";
                DaChon[i] = "D";
                memoEdit4.BackColor = Color.Yellow;
                memoEdit1.BackColor = SystemColors.Control;
                memoEdit2.BackColor = SystemColors.Control;
                memoEdit3.BackColor = SystemColors.Control;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(label3.Text);
            int b = Int32.Parse(label2.Text);
            a--;
            if (a < 0)
            {
                a = 59;
                b--;
            }
            if (a < 10)
            {
                label3.Text = "0" + a;
            }
            else
                label3.Text = a + "";
            if (b < 10)
            {
                label2.Text = "0" + b;
            }
            else
                label2.Text = b + "";

            if (a == 0 && b == 0)
            {
                NopBai();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (i > 0)
                i--;
            LoadCauHoi(i);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (i < Program.mSoCauThi - 1)
                i++;
            LoadCauHoi(i);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                i = int.Parse(lvi.SubItems[0].Text) - 1;
                LoadCauHoi(i);
            }
        }
    }
}
