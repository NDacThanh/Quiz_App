using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class rpDsdkThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDsdkThi(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.sP_In_DSDK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_In_DSDK_ThiTableAdapter.Fill(this.tN_DS1.SP_In_DSDK_Thi, dateFrom, dateTo);
        }

    }
}
