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
    public class DataProvider
    {
        public static SqlConnection KetNoi()
        {
            string ChuoiKetNoi = @"DataSource = .\SQLEXPRESS;Initial Catalog = QUANLINHANSU; Integrated Security=True";
            SqlConnection con = new SqlConnection(ChuoiKetNoi);
            con.Open();
            return con;
        }
        public static void Close_KetNoi(SqlConnection con)
        {
            con.Close();
        }
        public static DataTable Get_DataTable(string sTruyVan, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sTruyVan,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void ThucThiTruyVan(string sTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(sTruyVan, con);
            com.ExecuteNonQuery();
        }
    }
}
