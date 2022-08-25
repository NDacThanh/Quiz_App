using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class rpXemKetQua : DevExpress.XtraReports.UI.XtraReport
    {
        public rpXemKetQua(string masv, string mamh, int lan)
        {
            InitializeComponent();
            this.sP_Xem_Ket_QuaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_Xem_Ket_QuaTableAdapter.Fill(tN_DS1.SP_Xem_Ket_Qua, masv, mamh, new System.Nullable<short>(((short)(System.Convert.ChangeType(lan, typeof(short))))));
        }

    }
}
