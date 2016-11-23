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
    public class NhanVien_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblNhanVien";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(NhanVien_DTO nv)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblNhanVien set HoTen = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', DiaChi = N'{3}', MaPB = '{4}', MaChucVu = '{5}', MaChuyenMon = '{6}', GhiChu = N'{7}' where MaNV = '{8}'",nv.HoTen, nv.GioiTinh ,nv.NgaySinh, nv.DiaChi, nv.MaPB, nv.MaChucVu,nv.MaChuyenMon,nv.GhiChu, nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan,con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(NhanVien_DTO nv)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblNhanVien where MaNV = '{0}'",nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan,con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(NhanVien_DTO nv)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblNhanVien (MaNV,HoTen,GioiTinh,NgaySinh,DiaChi,MaPB,MaChucVu,MaChuyenMon,GhiChu) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", nv.MaNV, nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.MaPB, nv.MaChucVu, nv.MaChuyenMon, nv.GhiChu);                
                DataProvider.ThucThiTruyVan(sTruyVan,con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public static DataTable LoadDSXoa()
        {
            string sTruyVan = "Select MaNV, HoTen, GioiTinh from tblNhanVien";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public static DataTable LoadDSXoa(string dk)
        {
            string sTruyVan = "Select MaNV, HoTen, GioiTinh from tblNhanVien where " + dk;
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
        public static bool XoaNV(NhanVien_DTO nv)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan;
                //xoa cac thanh phan phu thuoc
                //bang phieu luong
                sTruyVan = string.Format("Delete from tblPhieuLuong where MaNV = '{0}'", nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                //bang chi tiet ngoai ngu
                sTruyVan = string.Format("Delete from tblChiTietNgoaiNgu where MaNV = '{0}'", nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                //bang ChiTietKhienThuong
                sTruyVan = string.Format("Delete from tblChiTietKhenThuong where MaNV = '{0}'", nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                //xoa HopDong
                sTruyVan = string.Format("Delete from tblChiTietHopDong where MaNV = '{0}'", nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                //xoa nv
                sTruyVan = string.Format("Delete from tblNhanVien where MaNV = '{0}'", nv.MaNV);
                DataProvider.ThucThiTruyVan(sTruyVan, con);

                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
