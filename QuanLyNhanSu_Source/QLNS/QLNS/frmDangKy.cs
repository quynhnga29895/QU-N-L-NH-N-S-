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
using DTO;
namespace QLNS
{
    public partial class frmDangKy : Form
    {

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát???","Thông Báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

            cbMaNV.DataSource = NhanVien_DAO.LoadDuLieu();
            cbMaNV.DisplayMember = "MaNV";
        }

        private void frmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_DAO.KiemTra(txtTenDangNhap.Text) == false)
            {
                lbThongBao.Text = "Tên này đã được sử dụng!!!";
                return;
            }
            if (txtTenDangNhap.Text == ""||txtMatKhau.Text==""||txtNhapLaiPass.Text=="")
            {
                lbThongBao.Text = "Bạn chưa điền đủ thông tin!!!";
                return;
            }
            if (txtMatKhau.Text != txtNhapLaiPass.Text)
            {
                lbThongBao.Text = "Bạn nhập lại mật khẩu không khớp!!!";
                return;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.UserName = txtTenDangNhap.Text;
            tk.Password = txtMatKhau.Text;
            tk.MaNV = cbMaNV.SelectedValue.ToString();
            tk.MaPQ = "1";
            TaiKhoan_DAO.Them(tk);
            MessageBox.Show("Chúc mừng bạn đã đăng ký thành công !!!");
            this.Close();
            Application.Restart();
        }

        private void frmDangKy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }
    }
}
