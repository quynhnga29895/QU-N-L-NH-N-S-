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
        TaiKhoan_DAO tk = new TaiKhoan_DAO();
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

        private void btnOK_Click(object sender, EventArgs e)
        {


            if (TaiKhoan_DAO.KiemTra(txtTenDangNhap.Text)==false)
            {
                lbThongBao.Text = "Tên đăng nhập đã có!!!";
                return;
            }
            if (txtTenDangNhap.Text == "")
            {
                lbThongBao.Text = "Bạn chưa đăng ký tên đăng nhập!!!";
                return;
            }
            
            else
            {
                if (txtMatKhau.Text != txtNhapLaiPass.Text)
                {
                    lbThongBao.Text = "Bạn nhập không trùng với mật khẩu!!!";
                }
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.UserName = txtTenDangNhap.Text;
            tk.Password = txtMatKhau.Text;
            tk.MaNV = cbBoxMaNV.Text;
            tk.MaPQ = "1";
            TaiKhoan_DAO.Them(tk);

            MessageBox.Show("Chúc mừng bạn đã đăng kí thành công!!!", "Thông Báo");
            this.Close();
            Application.Restart();

        }
        public void KiemTra(TaiKhoan_DAO tk)
        {
            
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYNHANSUDataSet2.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.qUANLYNHANSUDataSet2.tblNhanVien);
            // TODO: This line of code loads data into the 'qUANLYNHANSUDataSet1.tblTaiKhoan' table. You can move, or remove it, as needed.
            this.tblTaiKhoanTableAdapter.Fill(this.qUANLYNHANSUDataSet1.tblTaiKhoan);

        }
    }
}
