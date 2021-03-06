﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class PhongBan_DAO
    {
        public static SqlConnection con;
        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblPhongBan";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan,con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }

        public static bool Them(PhongBan_DTO pb)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format(@"Insert into tblPhongBan (MaPB,TenPB,DiaDiem,SDT) values ('{0}',N'{1}',N'{2}','{3}')",pb.MaPB,pb.TenPB,pb.DiaDiem,pb.SDT);
                DataProvider.ThucThiTruyVan(sTruyVan,con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Sua(PhongBan_DTO pb)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format(@"update tblPhongBan set TenPB = N'{0}', DiaDiem = N'{1}',SDT = '{2}' where MaPB = '{3}'", pb.TenPB, pb.DiaDiem, pb.SDT, pb.MaPB);
                DataProvider.ThucThiTruyVan(sTruyVan,con);
                DataProvider.Close_KetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Xoa(PhongBan_DTO pb)
        {
            try
            {
                con = DataProvider.KetNoi();
                string sTruyVan = string.Format(@"Delete from tblPhongBan where MaPB = '{0}'",pb.MaPB);
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
