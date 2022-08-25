using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class rpBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangDiem(string tenLop, string tenMonHoc, Int16 lanthi)
        {
            InitializeComponent();
            this.sP_In_Bang_DiemTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_In_Bang_DiemTableAdapter.Fill(this.tN_DS1.SP_In_Bang_Diem, tenLop, tenMonHoc, lanthi);

        }

    }
}
