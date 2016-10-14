using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QLNS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy dk = new frmDangKy();
            dk.Show();
        }

        private void chkBoxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát???", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == ""||txtMatKhau.Text=="")
            {
                lbThongBao.Text = "Bạn chưa nhập đủ thông tin!!!";
                return;
            }
            else if (TaiKhoan_DAO.DangNhap(txtUser.Text, txtMatKhau.Text) == false)
            {
                lbThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng !!!";
                return;
            }
            else
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }

        private void lkLabelQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }
    }
}
