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
    public class KhenThuong_DAO
    {
        public static SqlConnection con;
        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblKhenThuong";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(KhenThuong_DTO kt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblKhenThuong set MaNV = '{0}',MaPB = '{1}' where MaKT = '{2}'",kt.MaNV,kt.MaPB,kt.MaKhenThuong);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(KhenThuong_DTO kt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblKhenThuong where MaKT = '{0}'", kt.MaKhenThuong);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(KhenThuong_DTO kt)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblKhenThuong values (MaKT,MaNV,MaPB) values ('{0}','{1}','{2}'')", kt.MaKhenThuong,kt.MaNV,kt.MaPB);
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
