using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QuanLyNhaThuoc.View
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

            this.rpvbaocao.RefreshReport();
            btnquaylai.Enabled = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QL_NTConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCDT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayLap", dtpNgay.Value.Date));
            //khai báo dataset 
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //thiết lập báo cáo     
            rpvbaocao.ProcessingMode = ProcessingMode.Local;
            rpvbaocao.LocalReport.ReportPath = "BaoCao.rdlc";
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            if (ds.Tables[0].Rows.Count>0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BCDT";
                rds.Value = ds.Tables[0];

                rpvbaocao.LocalReport.DataSources.Clear();
                rpvbaocao.LocalReport.DataSources.Add(rds);
                rpvbaocao.RefreshReport();
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
