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
    public partial class frmKhenThuong : Form
    {
        ChiTietKhenThuong_DTO khenthuong = new ChiTietKhenThuong_DTO();
        string action;
        int dong = -1;
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            cmbName.DataSource = NhanVien_DAO.LoadDuLieu();
            cmbName.DisplayMember = "HoTen";
            dgvKhenthuong.DataSource = ChiTietKhenThuong_DAO.LoadDuLieuChiTiet();
            dtpNgaythuong.Value = DateTime.Now;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void dgvKhenthuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong < 0) return;
            khenthuong.MaKT = dgvKhenthuong.Rows[dong].Cells["MaKT"].Value.ToString();
            dtpNgaythuong.Text = dgvKhenthuong.Rows[dong].Cells["NgayKhenThuong"].Value.ToString();
            if(dtpNgaythuong.Text.Trim()!="")
                khenthuong.NgayKhenThuong = DateTime.Parse(dgvKhenthuong.Rows[dong].Cells["NgayKhenThuong"].Value.ToString());
            khenthuong.TienKT = long.Parse(dgvKhenthuong.Rows[dong].Cells["TienKhenThuong"].Value.ToString());
            khenthuong.GhiChu = dgvKhenthuong.Rows[dong].Cells["GhiChu"].Value.ToString();
            cmbName.Text = dgvKhenthuong.Rows[dong].Cells["HoTen"].Value.ToString();
            txtMoney.Text = dgvKhenthuong.Rows[dong].Cells["TienKhenThuong"].Value.ToString();
            txtNote.Text = dgvKhenthuong.Rows[dong].Cells["GhiChu"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;

            action = "Add";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmKhenThuong_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên!");
                return;
            }
            if (txtMoney.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thưởng!");
                return;
            }
            if (dtpNgaythuong.Text == "")
            {
                MessageBox.Show("Chưa chọn ngày thưởng!");
                return;
            }

            DataTable tb = NhanVien_DAO.LoadDuLieu(" where HoTen =N'" + cmbName.Text+"'");
            if (tb != null)
                if (tb.Rows.Count > 0)
                    khenthuong.MaNV = tb.Rows[0]["MaNV"].ToString();
            switch(action)
            {
                case "Add":
                    Random rand = new Random();
                    khenthuong.MaKT = "KT"+rand.Next(0,999999);
                    khenthuong.NgayKhenThuong = dtpNgaythuong.Value;
                    khenthuong.TienKT = long.Parse(txtMoney.Text);
                    khenthuong.GhiChu = txtNote.Text;
                    ChiTietKhenThuong_DAO.Them(khenthuong);
                    break;
                case "Edit":
                    khenthuong.MaKT = dgvKhenthuong.Rows[dong].Cells["MaKT"].Value.ToString();
                    khenthuong.NgayKhenThuong = dtpNgaythuong.Value;
                    khenthuong.TienKT = long.Parse(txtMoney.Text);
                    khenthuong.GhiChu = txtNote.Text;
                    ChiTietKhenThuong_DAO.Sua(khenthuong);
                    break;
                default :
                    MessageBox.Show("Không có thao tác nào!");
                    break;
            }
            frmKhenThuong_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;

            action = "Edit";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn thông tin cần xóa!");
                return;
            }
            khenthuong.MaKT = dgvKhenthuong.Rows[dong].Cells["MaKT"].Value.ToString();
            ChiTietKhenThuong_DAO.Xoa(khenthuong);
            frmKhenThuong_Load(sender, e);

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = NhanVien_DAO.LoadDuLieu(" where HoTen =" + cmbName.Text);
            if (tb!=null )
                if(tb.Rows.Count > 0)
                khenthuong.MaNV = tb.Rows[0]["HoTen"].ToString();
        }
    }
}
