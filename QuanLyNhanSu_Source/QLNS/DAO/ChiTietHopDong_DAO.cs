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
    public class ChiTietHopDong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblChiTietHopDong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(ChiTietHopDong_DTO cthd)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblChiTietHopDong set MaNV = '{0}',NgayBatDau = '{1}',NgayKetThuc = '{2}' where MaHD = '{3}'",cthd.MaNV,cthd.NgayBatDau,cthd.NgayKetThuc,cthd.MaHD);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(ChiTietHopDong_DTO cthd)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblChiTietHopDong where MaHD = '{0}'", cthd.MaHD);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(ChiTietHopDong_DTO cthd)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblChiTietHopDong values (MaHD,MaNV,NgayBatDau,NgayKetThuc) values ('{0}','{1}','{2}','{3}')", cthd.MaHD, cthd.MaNV, cthd.NgayBatDau, cthd.NgayKetThuc);
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
