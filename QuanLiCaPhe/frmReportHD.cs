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
using Microsoft.Reporting.WinForms;
using QuanLiCaPhe.HoaDonService;
using QuanLiCaPhe.CTHoadonService;

namespace QuanLiCaPhe
{
    public partial class frmReportHD : Form
    {
        HoaDonServiceClient hoadon = new HoaDonServiceClient();
        CTHoaDonServiceClient cthoadon = new CTHoaDonServiceClient();
        RPServiceClient rp = new RPServiceClient();
        public frmReportHD(string text1,string text2)
        {
            InitializeComponent();
            txtMaOder.Text = text1;
            txtMaBan.Text = text2;
        }

        //private void btnXem_Click(object sender, EventArgs e)
        //{
        //    int maod = int.Parse(txtMaOder.Text); ;
        //    string mahd = cthdBO.layMaHD(maod);
        //    int i = 0;
        //    Int32.TryParse(mahd, out i);
            
        //    Report_HD objRpt = new Report_HD();
        //    objRpt.SetDataSource(rp.report_HD(i).Tables[1]);
        //    crystalReportViewer_HD.ReportSource = objRpt;
        //    crystalReportViewer_HD.Refresh();        
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSoDoChinh SoDoChinh = new frmSoDoChinh();
            SoDoChinh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maod = int.Parse(txtMaOder.Text);
            string mahd = cthoadon.layMaHD(maod);


            DataTable dt = new DataTable();
            dt = cthoadon.LayDSCTHD(Convert.ToInt32(mahd));

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "HoaDonReport.rdlc";
            ReportDataSource source = new ReportDataSource();
            source.Name = "DataSet1";
            source.Value = dt;
            //
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
        }
    }
}
