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
    public class ChiTietKhenThuong_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblChiTietKhenThuong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(ChiTietKhenThuong_DTO ctkt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblChiTietKhenThuong set MaNV = '{0}', NgayKhenThuong = '{1}',TienKhenThuong = '{2}' where MaKT = '{3}'",ctkt.MaNV,ctkt.NgayKhenThuong,ctkt.TienKT,ctkt.MaKT);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(ChiTietKhenThuong_DTO ctkt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblChiTietKhenThuong where MaKT = '{0}'", ctkt.MaKT);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(ChiTietKhenThuong_DTO ctkt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblChiTietKhenThuong values (MaKT,MaNV,NgayKhenThuong,TienKhenThuong) values ('{0}','{1}','{2}','{3}',)", ctkt.MaKT,ctkt.MaNV,ctkt.NgayKhenThuong,ctkt.TienKT);
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
