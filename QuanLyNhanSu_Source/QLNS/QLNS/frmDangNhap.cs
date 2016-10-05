using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (txtuser.Text != "")
            {
                string command = string.Format("select * from tblTaiKhoan where UserName = '{0}'", txtuser.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    //MessageBox.Show("Sai tên tài kho?n");
                    lbThongBao.Text = "Sai tài Khoản!!!";
                }
                else if (dt.Rows[0][1].ToString().Trim() != txtpass.Text)
                {
                    // MessageBox.Show("Sai tên m?t kh?u ");
                    lbThongBao.Text = "Sai mật khẩu!!!";
                }
                else
                {
                    MaNV = dt.Rows[0][2].ToString();
                    UserName = txtuser.Text;
                    Password = txtpass.Text;
                    frmMain1 frm = new frmMain1();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                lbThongBao.Text = "Bạn chưa nhập dữ liệu!!!";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = DataProvider.KetNoi();
        }

        private void checBox_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
                txtpass.UseSystemPasswordChar = true;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }

        private void linklable_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Close();
            frmDangKy frm1 = new frmDangKy();
            frm1.Show();
        }
    }
}
