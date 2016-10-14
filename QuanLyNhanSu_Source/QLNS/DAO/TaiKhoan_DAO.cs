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
    public class TaiKhoan_DAO
    {
        public static SqlConnection con;
        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select UserName from tblTaiKhoan";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Sua(TaiKhoan_DTO tk)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Update tblTaiKhoan set UserName = '{0}',Password = '{1}' ",tk.UserName,tk.Password);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(TaiKhoan_DTO tk)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format("Delete from tblKhenThuong where UserName = '{0}'", tk.UserName);
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Them(TaiKhoan_DTO tk) 
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format(@"INSERT INTO tblTaiKhoan	(UserName, Password, MaNV,MaPQ)	VALUES('" + tk.UserName + "','" + tk.Password + "','" + tk.MaNV + "', '" + tk.MaPQ + "')");
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool KiemTra(string Username)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format(@"Select Username from tblTaiKhoan	where Username = '{}'", Username);
                DataTable tb = DataProvider.Get_DataTable(sTruyVan, con);
                if (tb.Rows.Count < 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
