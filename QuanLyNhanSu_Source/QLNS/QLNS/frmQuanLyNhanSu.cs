using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmQuanLyNhanSu : Form
    {
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }
        NhanVien_DAO NvDao = new NhanVien_DAO();
        NhanVien_DTO NvDto = new NhanVien_DTO();
        int chon = 0;
        void KhoaDieuKhien()
        {
            txtMaNV.Enabled = txtHoTen.Enabled = txtGT.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = cboMaPB.Enabled = cboMaChucVu.Enabled = cboMaChuyenMon.Enabled = txtGhiChu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtMaNV.Enabled = txtHoTen.Enabled = txtGT.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = cboMaPB.Enabled = cboMaChucVu.Enabled = cboMaChuyenMon.Enabled = txtGhiChu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {          
            txtMaNV.Text = txtHoTen.Text =  txtGT.Text = txtDiaChi.Text = txtGhiChu.Text = "";            
            dtpNgaySinh.Text = DateTime.Now.ToShortDateString();            
        }
        public void KhoiTao()
        {
            txtMaNV.Text = dgvThongTinNhanVien.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvThongTinNhanVien.Rows[1].Cells[1].Value.ToString();
            txtGT.Text = dgvThongTinNhanVien.Rows[2].Cells[2].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvThongTinNhanVien.Rows[3].Cells[3].Value.ToString());
            txtDiaChi.Text = dgvThongTinNhanVien.Rows[4].Cells[4].Value.ToString();
            cboMaPB.Text = dgvThongTinNhanVien.Rows[5].Cells[5].Value.ToString();
            cboMaChucVu.Text = dgvThongTinNhanVien.Rows[6].Cells[6].Value.ToString();
            cboMaChuyenMon.Text = dgvThongTinNhanVien.Rows[7].Cells[7].Value.ToString();
            txtGhiChu.Text = dgvThongTinNhanVien.Rows[8].Cells[8].Value.ToString();
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();            
            SetNull();
            chon = 1;
        }

        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVien_DAO.LoadDuLieu();
            dgvThongTinNhanVien.DataSource = dt;
        }

        private void dgvThongTinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGT.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvThongTinNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtDiaChi.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboMaPB.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboMaChucVu.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cboMaChuyenMon.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtGhiChu.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            chon = 2;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanSu_Load(sender, e);
            SetNull();
            chon = 0;
            MoDieuKhien();
            btnThem.Enabled = btnSua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtHoTen.Text == "" || txtGT.Text == "" || txtDiaChi.Text == "" || cboMaChucVu.Text == "" || cboMaPB.Text == "" || cboMaChuyenMon.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    NvDto.MaNV = txtMaNV.Text;
                    NvDto.HoTen = txtHoTen.Text;
                    NvDto.GioiTinh = txtGT.Text;
                    NvDto.NgaySinh = dtpNgaySinh.Value;
                    NvDto.DiaChi = txtDiaChi.Text;
                    NvDto.MaPB = cboMaPB.Text;
                    NvDto.MaChucVu = cboMaChucVu.Text;
                    NvDto.MaChuyenMon = cboMaChuyenMon.Text;
                    NvDto.GhiChu = txtGhiChu.Text;                    
                    NhanVien_DAO.Them(NvDto);                  
                    MessageBox.Show("Thêm thành công!");
                    SetNull();
                    frmQuanLyNhanSu_Load(sender, e);
                }
            }
            else if (chon == 2)
            {
                if (txtHoTen.Text == "" || txtGT.Text == "" || txtDiaChi.Text == "" || cboMaChucVu.Text == "" || cboMaPB.Text == "" || cboMaChuyenMon.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    NvDto.MaNV = txtMaNV.Text;
                    NvDto.HoTen = txtHoTen.Text;
                    NvDto.GioiTinh = txtGT.Text;
                    NvDto.NgaySinh = dtpNgaySinh.Value;
                    NvDto.DiaChi = txtDiaChi.Text;
                    NvDto.MaPB = cboMaPB.Text;
                    NvDto.MaChucVu = cboMaChucVu.Text;
                    NvDto.MaChuyenMon = cboMaChuyenMon.Text;
                    NvDto.GhiChu = txtGhiChu.Text;                    
                    NhanVien_DAO.Sua(NvDto);
                    MessageBox.Show("Sửa thành công!");
                    SetNull();
                    frmQuanLyNhanSu_Load(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien delnv = new frmXoaNhanVien();
            delnv.Show();
        }
    }
}