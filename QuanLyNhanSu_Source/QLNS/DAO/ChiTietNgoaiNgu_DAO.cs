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
    public class ChiTietNgoaiNgu_DAO
    {
        public static SqlConnection con;

        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblChiTietNgoaiNgu";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(ChiTietNgoaiNgu_DTO ctnn)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblChiTietNgoaiNgu set MaNV = '{0}',ThoiGian = '{1}',TrinhDo = N'{2}' where MaNN = '{3}'", ctnn.MaNV,ctnn.ThoiGian,ctnn.TrinhDo,ctnn.MaNN);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(ChiTietNgoaiNgu_DTO ctnn)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblChiTietNgoaiNgu where MaNN = '{0}'", ctnn.MaNN);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(ChiTietNgoaiNgu_DTO ctnn)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Insert into tblChiTietNgoaiNgu values (MaNN,MaNV,ThoiGian,TrinhDo) values ('{0}','{1}','{2}',N'{3}')", ctnn.MaNN,ctnn.MaNV,ctnn.ThoiGian,ctnn.TrinhDo);
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
