using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO_QLCP;
using QuanLiCaPhe.RPService;

namespace QuanLiCaPhe
{
    public partial class frmReport_DT : Form
    {
        RPServiceClient rp = new RPServiceClient ();
        public frmReport_DT()
        {
            InitializeComponent();
        }

        private void frmReport_DT_Load(object sender, EventArgs e)
        {
           
            Report_DT objRpt = new Report_DT();
            objRpt.SetDataSource(rp.report_DT().Tables[1]);
            crystalReportViewer_DT.ReportSource = objRpt;
            crystalReportViewer_DT.Refresh();        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmBaoCao BaoCao = new frmBaoCao();
            this.Close();
            BaoCao.Show();
        }
    }
}
