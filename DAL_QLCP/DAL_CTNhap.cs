﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QLCP;

namespace DAL_QLCP
{
    public class DAL_CTNhap
    {
        DBAccess db = new DBAccess();

        public DataTable Search_DSNhapNL(int maPN)
        {
            string query = "Select * from tblCTNhapNL where MaPhieuNhap='" + maPN + "'";
            return db.getDS(query);
        }

        public DataTable search(int mapn)
        {
            string query = "Select * from tblCTNhapNL where MaPhieuNhap like "+ mapn +"";
            return db.getDS(query);
        }

        public DataTable DSCTPN()
        {
            string query = "Select * from tblCTNhapNL";
            return db.getDS(query);
        }

        public bool kiemTraNhapNL(int maPN)
        {
            return db.kiemTraTonTai4(maPN);
        }

        public bool kiemTraTonTai(int maPN, string maNL)
        {
            return db.kiemTraTonTai7(maPN, maNL);
        }

        public DataTable getMaNL()
        {
            return db.getDS("Select MaNL from tblNguyenLieu");
        }

        public string getTenNL(string maNL)
        {
            return db.layTenNL(maNL);
        }

        public string getDVTNL(string maNL)
        {
            return db.layDonViTinhNL(maNL);
        }

        public string getDonGia(string maNL)
        {
            return db.layDonGia(maNL);
        }

        public bool ThemCTNhap(CTNhapNL ct)
        {
            string[] param = { "@MaPN", "@MaNL", "@TenNL", "@SoLuong", "@DonViTinh", "@DonGia", "@ThanhTien" };
            object[] values = { ct.MaPhieuNhap, ct.MaNL, ct.TenNL, ct.SoLuong, ct.DonViTinh, ct.DonGia, ct.ThanhTien };
            string query = "Insert into tblCTNhapNL(MaPhieuNhap,MaNL,TenNL,SoLuong,DonViTinh,DonGia,ThanhTien) values (@MaPN,@MaNL,@TenNL,@SoLuong,@DonViTinh,@DonGia,@ThanhTien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCTNhap(CTNhapNL ct)
        {
            string[] param = { "@MaPN", "@MaNL", "@SoLuong", "@DonGia", "@ThanhTien" };
            object[] values = { ct.MaPhieuNhap, ct.MaNL, ct.SoLuong, ct.DonGia, ct.ThanhTien };
            string query = "Update tblCTNhapNL set SoLuong=@SoLuong, DonGia=@DonGia,ThanhTien=@ThanhTien where MaPhieuNhap=@MaPN and MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaCTNhap(CTNhapNL ct)
        {
            string[] param = { "@MaPN", "@MaNL" };
            object[] values = { ct.MaPhieuNhap, ct.MaNL };
            string query = "Delete from tblCTNhapNL where MaPhieuNhap=@MaPN and MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
