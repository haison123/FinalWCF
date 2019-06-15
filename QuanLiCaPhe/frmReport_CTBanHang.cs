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
using QuanLiCaPhe.MonAnService;



namespace QuanLiCaPhe
{
    public partial class frmReport_CTBanHang : Form
    {
        MonAnServiceClient masr = new MonAnServiceClient();
        RPServiceClient rp = new RPServiceClient();
        public frmReport_CTBanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBaoCao BaoCao = new frmBaoCao();
            BaoCao.Show();
        }

        private void frmReport_CTBanHang_Load(object sender, EventArgs e)
        {
            DataTable tableMaMon = new DataTable();
            tableMaMon = masr.getDSMon();
            cbMaMon.DataSource = tableMaMon;
            cbMaMon.DisplayMember = "MaMon";
            cbMaMon.ValueMember = "MaMon";
            cbMaMon.SelectedIndex = 0;
               
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query="";
            if (rdXemTheoNgay.Checked == true)
            {
                DateTime ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
                Report_CTBan objRpt = new Report_CTBan();
                objRpt.SetDataSource(rp.report_BH_ngay(ngay).Tables[1]);
                crystalReportViewer_BH.ReportSource = objRpt;
                crystalReportViewer_BH.Refresh();
            }
            if (rdXemTheoMaMon.Checked == true)
            {
                string maMon = cbMaMon.SelectedValue.ToString();
                Report_CTBan objRpt = new Report_CTBan();
                objRpt.SetDataSource(rp.report_BH_mamon(maMon).Tables[1]);
                crystalReportViewer_BH.ReportSource = objRpt;
                crystalReportViewer_BH.Refresh();
            }
            if (rdXemTheoCaHai.Checked == true)
            {
                DateTime ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
                string maMon = cbMaMon.SelectedValue.ToString();
                Report_CTBan objRpt = new Report_CTBan();
                objRpt.SetDataSource(rp.report_BH(ngay,maMon).Tables[1]);
                crystalReportViewer_BH.ReportSource = objRpt;
                crystalReportViewer_BH.Refresh();
            }
             
        }
    }
}
