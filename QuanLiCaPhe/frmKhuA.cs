﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QLCP;
using QuanLiCaPhe.BanCoKhachService;
using QuanLiCaPhe.CTOrderService;
using QuanLiCaPhe.OrderService;

namespace QuanLiCaPhe
{
    public partial class frmKhuA : Form
    {
        BanCoKhachServiceClient bancokhach = new BanCoKhachServiceClient();
        OrderServiceClient order = new OrderServiceClient();
        CTOrderServiceClient ctorder = new CTOrderServiceClient();
        
        public frmKhuA()
        {
            InitializeComponent();            
        }

        public void frmKhuA_Load(object sender, EventArgs e)
        {
            if (bancokhach.kiemTraBanCoKhach("A01"))
                btnBan1.Text = "1(CK)";
            else
                btnBan1.Text = "BÀN 1";

            if (bancokhach.kiemTraBanCoKhach("A02"))
                btnBan2.Text = "2(CK)";
            else
                btnBan2.Text = "BÀN 2";

            if (bancokhach.kiemTraBanCoKhach("A03"))
                btnBan3.Text = "3(CK)";
            else
                btnBan3.Text = "BÀN 3";

            if (bancokhach.kiemTraBanCoKhach("A04"))
                btnBan4.Text = "4(CK)";
            else
                btnBan4.Text = "BÀN 4";

            if (bancokhach.kiemTraBanCoKhach("A05"))
                btnBan5.Text = "5(CK)";
            else
                btnBan5.Text = "BÀN 5";

            if (bancokhach.kiemTraBanCoKhach("A06"))
                btnBan6.Text = "6(CK)";
            else
                btnBan6.Text = "BÀN 6";

            if (bancokhach.kiemTraBanCoKhach("A07"))
                btnBan7.Text = "7(CK)";
            else
                btnBan7.Text = "BÀN 7";

            if (bancokhach.kiemTraBanCoKhach("A08"))
                btnBan8.Text = "8(CK)";
            else
                btnBan8.Text = "BÀN 8";

            if (bancokhach.kiemTraBanCoKhach("A09"))
                btnBan9.Text = "9(CK)";
            else
                btnBan9.Text = "BÀN 9";

            if (bancokhach.kiemTraBanCoKhach("A10"))
                btnBan10.Text = "10(CK)";
            else
                btnBan10.Text = "BÀN 10";

            if (bancokhach.kiemTraBanCoKhach("A11"))
                btnBan11.Text = "11(CK)";
            else
                btnBan11.Text = "BÀN 11";

            if (bancokhach.kiemTraBanCoKhach("A12"))
                btnBan12.Text = "12(CK)";
            else
                btnBan12.Text = "BÀN 12";

            if (bancokhach.kiemTraBanCoKhach("A13"))
                btnBan13.Text = "13(CK)";
            else
                btnBan13.Text = "BÀN 13";

            if (bancokhach.kiemTraBanCoKhach("A14"))
                btnBan14.Text = "14(CK)";
            else
                btnBan14.Text = "BÀN 14";

            if (bancokhach.kiemTraBanCoKhach("A15"))
                btnBan15.Text = "15(CK)";
            else
                btnBan15.Text = "BÀN 15";

            if (bancokhach.kiemTraBanCoKhach("A16"))
                btnBan16.Text = "16(CK)";
            else
                btnBan16.Text = "BÀN 16";

            if (bancokhach.kiemTraBanCoKhach("A17"))
                btnBan17.Text = "17(CK)";
            else
                btnBan17.Text = "BÀN 17";

            if (bancokhach.kiemTraBanCoKhach("A18"))
                btnBan18.Text = "18(CK)";
            else
                btnBan18.Text = "BÀN 18";

            if (bancokhach.kiemTraBanCoKhach("A19"))
                btnBan19.Text = "19(CK)";
            else
                btnBan19.Text = "BÀN 19";

            if (bancokhach.kiemTraBanCoKhach("A20"))
                btnBan20.Text = "20(CK)";
            else
                btnBan20.Text = "BÀN 20";

            if (bancokhach.kiemTraBanCoKhach("A21"))
                btnBan21.Text = "21(CK)";
            else
                btnBan21.Text = "BÀN 21";

            if (bancokhach.kiemTraBanCoKhach("A22"))
                btnBan22.Text = "22(CK)";
            else
                btnBan22.Text = "BÀN 22";

            if (bancokhach.kiemTraBanCoKhach("A23"))
                btnBan23.Text = "23(CK)";
            else
                btnBan23.Text = "BÀN 23";

            if (bancokhach.kiemTraBanCoKhach("A24"))
                btnBan24.Text = "24(CK)";
            else
                btnBan24.Text = "BÀN 24";

            if (bancokhach.kiemTraBanCoKhach("A25"))
                btnBan25.Text = "25(CK)";
            else
                btnBan25.Text = "BÀN 25";

            if (bancokhach.kiemTraBanCoKhach("A26"))
                btnBan26.Text = "26(CK)";
            else
                btnBan26.Text = "BÀN 26";

            if (bancokhach.kiemTraBanCoKhach("A27"))
                btnBan27.Text = "27(CK)";
            else
                btnBan27.Text = "BÀN 27";

            if (bancokhach.kiemTraBanCoKhach("A28"))
                btnBan28.Text = "28(CK)";
            else
                btnBan28.Text = "BÀN 28";

            if (bancokhach.kiemTraBanCoKhach("A29"))
                btnBan29.Text = "29(CK)";
            else
                btnBan29.Text = "BÀN 29";

            if (bancokhach.kiemTraBanCoKhach("A30"))
                btnBan30.Text = "30(CK)";
            else
                btnBan30.Text = "BÀN 30";

        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            int i = 1;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            int i = 2;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            int i = 3;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            int i = 4;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            int i = 5;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void tbnBan6_Click(object sender, EventArgs e)
        {
            int i = 6;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            int i = 7;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            int i = 8;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            int i = 9;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            int i = 10;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            int i = 11;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            int i = 12;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            int i = 13;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan14_Click(object sender, EventArgs e)
        {
            int i = 14;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan15_Click(object sender, EventArgs e)
        {
            int i = 15;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan16_Click(object sender, EventArgs e)
        {
            int i = 16;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan17_Click(object sender, EventArgs e)
        {
            int i = 17;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan18_Click(object sender, EventArgs e)
        {
            int i = 18;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan19_Click(object sender, EventArgs e)
        {
            int i = 19;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan20_Click(object sender, EventArgs e)
        {
            int i = 20;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan21_Click(object sender, EventArgs e)
        {
            int i = 21;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan22_Click(object sender, EventArgs e)
        {
            int i = 22;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan23_Click(object sender, EventArgs e)
        {
            int i = 23;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan24_Click(object sender, EventArgs e)
        {
            int i = 24;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan25_Click(object sender, EventArgs e)
        {
            int i = 25;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan26_Click(object sender, EventArgs e)
        {
            int i = 26;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan27_Click(object sender, EventArgs e)
        {
            int i = 27;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan28_Click(object sender, EventArgs e)
        {
            int i = 28;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan29_Click(object sender, EventArgs e)
        {
            int i = 29;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan30_Click(object sender, EventArgs e)
        {
            int i = 30;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }
    }
}
