using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace QLNS
{
    public partial class frmDangNhap : Form
    {
        public static string MaNV;
        public static string UserName;
        public static string Password;
        private SqlConnection conn;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát?","Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = DataPro
        }
    }
}
