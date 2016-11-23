using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TimKiem
    {
        public static SqlConnection con;
        public DataTable TimKiemDuLieu(string DieuKien)
        {
            string sTruyVan = @"SELECT tblNhanVien.MaNV,HoTen,GioiTinh,TenChucVu,TenPB FROM 
            tblNhanVien,tblChucVu,tblPhongBan WHERE tblChucVu.MaChucVu = tblNhanVien.MaChucVu and tblNhanVien.MaPB = tblPhongBan.MaPB " +DieuKien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable TruyVanRaTenPB()
        {
            string sTruyVan = @"SELECT TenPB FROM tblPhongBan " ;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable TruyVanRaTenChucVu()
        {
            string sTruyVan = @"SELECT TenChucVu FROM tblChucVu ";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable NhanVien(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblNhanVien " +dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable ChuyenMon(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblChuyenMon,tblNhanVien where tblChuyenMon.MaChuyenMon=tblNhanVien.MaChuyenMon " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable PhongBan(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblPhongBan,tblNhanVien where tblPhongBan.MaPB=tblNhanVien.MaPB " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable ChucVu(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblChucVu,tblNhanVien where tblChucVu.MaChucVu=tblNhanVien.MaChucVu " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable PhieuLuong(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblPhieuLuong,tblNhanVien where tblPhieuLuong.MaNV=tblNhanVien.MaNV " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable KhenThuong(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblChiTietKhenThuong,tblNhanVien where tblChiTietKhenThuong.MaNV=tblNhanVien.MaNV " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public DataTable NgoaiNgu(string dieukien)
        {
            string sTruyVan = @"SELECT * FROM tblChiTietNgoaiNgu,tblNgoaiNgu,tblNhanVien where 
                tblChiTietNgoaiNgu.MaNV=tblNhanVien.MaNV and tblChiTietNgoaiNgu.MaNN=tblNgoaiNgu.MaNN " + dieukien;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
    }
}
