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
    public class ChuyenMon_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblChuyenMon";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(ChuyenMon_DTO cm)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblChucVu set TenChuyenMon = '{0}' where MaChuyenMon = '{1}'", cm.TenChuyenMon);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(ChuyenMon_DTO cm)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblChuyenMon where MaChuyenMon = '{0}'", cm.MaChuyenMon);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(ChuyenMon_DTO cm)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblChuyenMon values (MaChuyenMon, TenChuyenMon) values ('{0}','{1}')",cm.MaChuyenMon,cm.TenChuyenMon);
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
