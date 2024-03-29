﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DTO_QLCP;
using QuanLiCaPhe.NXNguyenLieuService;
using QuanLiCaPhe.CTXuatService;

namespace QuanLiCaPhe
{
    public partial class frmCTXuatNL : Form
    {
        CTXuatServiceClient ctxsr = new CTXuatServiceClient();
        NXNguyenLieuServiceClient nxsr = new NXNguyenLieuServiceClient();
        public frmCTXuatNL(string text)
        {
            InitializeComponent();
            txtMaPX.Text = text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int maPX = int.Parse(txtMaPX.Text);
            NXNguyenLieu nl = getXuatNL();
            if (ctxsr.kiemTraXuatNL(maPX) == false)
                nxsr.XoaXuatNL(nl);
            this.Close();
            frmNhapXuatNguyenLieu FromNhapXuatNL;
            FromNhapXuatNL = new frmNhapXuatNguyenLieu();
            FromNhapXuatNL.Show();
        }

        private void frmCTXuatNL_Load(object sender, EventArgs e)
        {
            DataTable tableMaNL = new DataTable();
            tableMaNL = ctxsr.getMaNL();
            cbMaNL.DataSource = tableMaNL;
            cbMaNL.DisplayMember = "MaNL";
            cbMaNL.ValueMember = "MaNL";
            cbMaNL.SelectedIndex = 0;
            //DataTable tableXuatNL = new DataTable();
            //tableXuatNL = ctxBO.getDSXuatNL();
            //dgCTXuatNL.DataSource = tableXuatNL;
            binData();
        }

        public void binData()
        {
            BindingSource bindinCTNhap = new BindingSource();
            int maPX = int.Parse(txtMaPX.Text);
            bindinCTNhap.DataSource = ctxsr.getDSXuatNL(maPX);
            clearBind();
            //cbMaNL.DataBindings.Add("Text", bindinCTNhap, "MaNL");
            //txtTenNL.DataBindings.Add("Text", bindinCTNhap, "TenNL");
            //txtSoLuong.DataBindings.Add("Text", bindinCTNhap, "SoLuong");
            //txtDonViTinh.DataBindings.Add("Text", bindinCTNhap, "DonViTinh");
            dgCTXuatNL.DataSource = bindinCTNhap;

        }

        public void clearBind()
        { 
            txtDonViTinh.DataBindings.Clear();
            txtMaPX.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtTenNL.DataBindings.Clear();
            dgCTXuatNL.DataBindings.Clear();
        }

        private CTXuatNL getCTXuat()
        {
            CTXuatNL ct = new CTXuatNL();
            ct.MaPhieuXuat = int.Parse(txtMaPX.Text);
            ct.MaNL = cbMaNL.SelectedValue.ToString();
            ct.TenNL = txtTenNL.Text;
            ct.SoLuong = int.Parse(txtSoLuong.Text);
            ct.DonViTinh = txtDonViTinh.Text;
            return ct;
        }

        private NXNguyenLieu getXuatNL()
        {
            NXNguyenLieu nl = new NXNguyenLieu();
            nl.MaPhieuXuat = int.Parse(txtMaPX.Text);
            return nl;
        }

        private void tbnThem_Click(object sender, EventArgs e)
        {
            frmDanhSachCTPX ct = new frmDanhSachCTPX();
            ct.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CTXuatNL xuat = getCTXuat();
            int maPX=int.Parse(txtMaPX.Text);
            string maNL=cbMaNL.Text;
            string slc = ctxsr.laySLCon(cbMaNL.Text);
            int i = int.Parse(slc);
            int j = int.Parse(txtSoLuong.Text);
            if (ctxsr.kiemTraTonTai(maPX, maNL))
            {
                if (j > i)
                    MessageBox.Show("Số lượng còn không đủ để xuất, vui lòng kiểm tra lại");
                else
                    if (ctxsr.SuaCTXuat(xuat))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Không thể sửa dữ liệu");
            }
            else
            {
                if (txtDonViTinh.Text == "" || txtSoLuong.Text == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (j > i)
                        MessageBox.Show("Số lượng còn không đủ để xuất, vui lòng kiểm tra lại");
                    else
                        if (ctxsr.ThemCTXuat(xuat))
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Không thể thêm dữ liệu");
            }
            binData();
        }

        private void cbMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNL.Text = ctxsr.getTenNL(cbMaNL.SelectedValue.ToString());
            txtDonViTinh.Text = ctxsr.getDVTNL(cbMaNL.SelectedValue.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTXuatNL ct = getCTXuat();
            if(MessageBox.Show("Bạn chắc muốn xóa xuất nguyên liệu: "+txtTenNL.Text+" ?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if(ctxsr.XoaCTXuat(ct))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không thể xóa");
            }
            binData();
        }

        private void dgCTXuatNL_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            txtMaPX.Text = dgCTXuatNL.Rows[rowSelect].Cells[0].Value.ToString();
            cbMaNL.Text = dgCTXuatNL.Rows[rowSelect].Cells[1].Value.ToString();
            txtTenNL.Text = dgCTXuatNL.Rows[rowSelect].Cells[2].Value.ToString();
            txtSoLuong.Text = dgCTXuatNL.Rows[rowSelect].Cells[3].Value.ToString();
            txtDonViTinh.Text = dgCTXuatNL.Rows[rowSelect].Cells[4].Value.ToString();
        }

    }
}
