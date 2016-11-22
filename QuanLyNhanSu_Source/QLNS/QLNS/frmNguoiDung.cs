using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QLNS
{
    public partial class frmNguoiDung : Form
    {
        public void SetNull()
        {
            txtUser.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtMaPQ.ReadOnly = true;
            txtTenQuyen.ReadOnly = true;
        }
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            SetNull();
            DataTable dt = new DataTable();
            dgv_user.DataSource = TaiKhoan_DAO.GetThongTinUser();
            
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtUser.Text = dgv_user.Rows[dong].Cells[0].Value.ToString();
            txtMaNV.Text = dgv_user.Rows[dong].Cells[1].Value.ToString();
            txtHoTen.Text = dgv_user.Rows[dong].Cells[2].Value.ToString();
            txtMaPQ.Text = dgv_user.Rows[dong].Cells[3].Value.ToString();
            txtTenQuyen.Text = dgv_user.Rows[dong].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát?","Thông Báo",MessageBoxButtons.OKCancel);
            if(traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            txtMaPQ.ReadOnly = false;
            txtTenQuyen.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO user = new TaiKhoan_DTO();
            user.UserName = txtUser.Text;
            user.MaPQ = txtMaPQ.Text;
            if (TaiKhoan_DAO.SuaAdmin(user) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            dgv_user.DataSource = TaiKhoan_DAO.GetThongTinUser();
        }
    }
}
