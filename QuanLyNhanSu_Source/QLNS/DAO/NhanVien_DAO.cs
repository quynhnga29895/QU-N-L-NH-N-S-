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
                string sTruyVan = string.Format("Update tblNhanVien set HoTen = '{0}', GioiTinh = '{1}', NgaySinh = '{2}', DiaChi = '{3}', MaPB = '{4}', MaChucVu = '{5}', MaChuyenMon = '{6}', GhiChu = '{7}' where MaNV = '{8}'",nv.HoTen, nv.GioiTinh ,nv.NgaySinh, nv.DiaChi, nv.MaPB, nv.MaChucVu,nv.MaChuyenMon,nv.GhiChu, nv.MaNV);
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
                string sTruyVan = string.Format("Insert into tblNhanVien values (MaNV,HoTen,MaPB,MaChucVu,MaChuyenMon) values ('{0}','{1}','{2}','{3}','{4}')",nv.MaNV,nv.HoTen,nv.MaPB,nv.MaChucVu,nv.MaChuyenMon);
                DataProvider.ThucThiTruyVan(sTruyVan,con);
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
