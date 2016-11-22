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
    public partial class frmXoaNhanVien : Form
    {
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }

        private NhanVien_DTO EC_NV = new NhanVien_DTO();
        private string _MaNV;

        private void frmXoaNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = NhanVien_DAO.LoadDSXoa();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien_Load(null,null);
            txtTimTen.Clear();
            txtTimMa.Clear();
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            string dk = "MaNV like '%" + txtTimMa.Text + "%' and HoTen like '%" + txtTimTen.Text + "%'";
            dgvDanhSach.DataSource = NhanVien_DAO.LoadDSXoa(dk);
        }

        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _MaNV = dgvDanhSach.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show(_MaNV + "\nChắc chắn xóa???", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                EC_NV.MaNV = _MaNV;
                if (NhanVien_DAO.Xoa(EC_NV)) MessageBox.Show("Nhân viên " + _MaNV + " đã xóa");
                else MessageBox.Show("Có lỗi!!!");
                btnReset_Click(null, null);
            }
        }
    }
}
