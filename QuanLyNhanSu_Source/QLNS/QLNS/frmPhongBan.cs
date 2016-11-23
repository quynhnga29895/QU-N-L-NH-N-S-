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
    public partial class frmPhongBan : Form
    {
        PhongBan_DTO pb = new PhongBan_DTO();
        bool themmoi = false;
        public void SetNull()
        {
            txtMaPB.Text = "";
            txtTen.Text = "";
            txtDiaDiem.Text = "";
            txtSDT.Text = "";
            txtTongNV.Text = "";
        }
        public void MoDieuKhien()
        {
            txtMaPB.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaDiem.ReadOnly = false;
            txtTongNV.ReadOnly = false;
        }
        public void KhoaDieuKhien()
        {
            txtMaPB.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaDiem.ReadOnly = true;
            txtTongNV.ReadOnly = true;
        }
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            dgvPhongBan.DataSource = PhongBan_DAO.LoadDuLieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPB.Text = dgvPhongBan.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgvPhongBan.Rows[dong].Cells[1].Value.ToString();
            txtDiaDiem.Text = dgvPhongBan.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dgvPhongBan.Rows[dong].Cells[3].Value.ToString();
            txtTongNV.Text = dgvPhongBan.Rows[dong].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien();
            SetNull();
            txtTongNV.ReadOnly = true;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(themmoi == true)
            {
                if (txtMaPB.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!!!");
                    return;
                }
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTen.Text;
                pb.DiaDiem = txtDiaDiem.Text;
                pb.SDT = txtSDT.Text;
                PhongBan_DAO.Them(pb);
                MessageBox.Show("Thêm Mới Thành Công!!!","Thông Báo",MessageBoxButtons.OK);
                dgvPhongBan.DataSource = PhongBan_DAO.LoadDuLieu();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
            }
            else
            {
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTen.Text;
                pb.DiaDiem = txtDiaDiem.Text;
                pb.SDT = txtSDT.Text;
                PhongBan_DAO.Sua(pb);
                MessageBox.Show("Sửa Dữ Liệu Thành Công!!!", "Thông Báo", MessageBoxButtons.OK);
                dgvPhongBan.DataSource = PhongBan_DAO.LoadDuLieu();
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            themmoi = false;
            btnAdd.Enabled = false;
            MoDieuKhien();
            txtTongNV.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa??","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi== DialogResult.OK)
            {
                pb.MaPB = txtMaPB.Text;
                PhongBan_DAO.Xoa(pb);
                dgvPhongBan.DataSource = PhongBan_DAO.LoadDuLieu();
            }
        }
    }
}
