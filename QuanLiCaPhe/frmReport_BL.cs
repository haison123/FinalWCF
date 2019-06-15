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
    public partial class frmReport_BL : Form
    {
        RPServiceClient rpt_srv = new RPServiceClient();
        public frmReport_BL()
        {
            InitializeComponent();
        }

        private void frmReport_BL_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int t= 0;
            string thang = cbThang.Text;
            Int32.TryParse(thang, out t);
           
            Report_BL objRpt = new Report_BL();
            objRpt.SetDataSource(rpt_srv.report_BL(t).Tables[1]);
            crystalReportViewer_BL.ReportSource = objRpt;   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNV QuanLiNV = new frmQuanLiNV();
            QuanLiNV.Show();
        }
    }
}
