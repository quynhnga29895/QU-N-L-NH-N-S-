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
    public class PhanQuyen_DAO
    {
        public static SqlConnection con;
        public static DataTable LoadDuLieu()
        {
            string sTruyVan = "Select * from tblPhanQuyen";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.Get_DataTable(sTruyVan, con);
            DataProvider.Close_KetNoi(con);
            return dt;
        }
    }
}
