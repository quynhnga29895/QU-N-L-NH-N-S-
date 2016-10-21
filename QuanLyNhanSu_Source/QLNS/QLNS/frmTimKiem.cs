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
    public partial class frmTimKiem : Form
    {
        TimKiem dao_timkiem = new TimKiem();
        NhanVien_DTO nv_dto = new NhanVien_DTO();
        ChucVu_DTO cv_dto = new ChucVu_DTO();
        PhongBan_DTO pb_dto = new PhongBan_DTO();

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //cho vao ec
            nv_dto.HoTen = txtHoTen.Text;
            pb_dto.TenPB = cboTenPB.Text;
            cv_dto.TenCV = cboTenChucVu.Text;
           dgvDanhSach.DataSource = dao_timkiem.TimKiemDuLieu(@"and( HoTen like N'%" + nv_dto.HoTen +
                    "%') and (tblPhongBan.TenPB like N'%" + pb_dto.TenPB+ "%') and (tblChucVu.TenChucVu like N'%" + cv_dto.TenCV+ "%')");

            
           
        }
       void DoDuLieuTenPB()//đổ dữ liệu lên cboMaPh
        {

            cboTenPB.DataSource = dao_timkiem.TruyVanRaTenPB();
            cboTenPB.DisplayMember = "TenPb";
        }
       void DoDuLieuTenCV()//đổ dữ liệu lên cboMaPh
       {

           cboTenChucVu.DataSource = dao_timkiem.TruyVanRaTenChucVu();
           cboTenChucVu.DisplayMember = "TenChucVu";
       }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            DoDuLieuTenPB();
            DoDuLieuTenCV();
            cboNgoaiNgu.DataSource = dao_timkiem.NgoaiNgu("");
            cboNgoaiNgu.DisplayMember = "TenNN";
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaNV.Text = dgvDanhSach.Rows[dong].Cells["colMaNV"].Value.ToString();
                HoTen.Text = dgvDanhSach.Rows[dong].Cells["colHoTen"].Value.ToString();
                if (dgvDanhSach.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString() == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                txtTenPB.Text = dgvDanhSach.Rows[dong].Cells["colTenPB"].Value.ToString();
                txtTenChucVu.Text = dgvDanhSach.Rows[dong].Cells["colTenChucVu"].Value.ToString();
                //đổ dữ liệu
                //group ThongTinCaNhan
                DataTable tblNV = dao_timkiem.NhanVien("where MaNV=N'"+txtMaNV.Text+"'");
                txtDiaChiNV.Text = tblNV.Rows[0]["DiaChi"].ToString();
                dtpNgaySinh.Text = tblNV.Rows[0]["NgaySinh"].ToString();
                //----chuyenmon
                DataTable tblChuyenMon = dao_timkiem.ChuyenMon("and MaNV=N'" + txtMaNV.Text + "'");
                txtTenChuyenMon.Text = tblChuyenMon.Rows[0]["TenChuyenMon"].ToString();
                //--ngoaingu
                cboNgoaiNgu.DataSource = dao_timkiem.NgoaiNgu("and tblNhanVien.MaNV=N'" + txtMaNV.Text + "'");
                cboNgoaiNgu.DisplayMember = "TenNN";
                //group PhongBan
                DataTable tblPhongBan = dao_timkiem.PhongBan("and MaNV=N'" + txtMaNV.Text + "'");
                txtMaPB.Text = tblPhongBan.Rows[0]["MaPB"].ToString();
                txtDiaDiemPB.Text = tblPhongBan.Rows[0]["DiaDiem"].ToString();
                txtSDT.Text = tblPhongBan.Rows[0]["SDT"].ToString();

                //group ChucVu
                DataTable tblChucVu = dao_timkiem.ChucVu("and MaNV=N'" + txtMaNV.Text + "'");
                txtMaChucVu.Text = tblChucVu.Rows[0]["MaChucVu"].ToString();
                txtPhuCap.Text = tblChucVu.Rows[0]["PhuCap"].ToString();

                //group PhieuLuong
                DataTable tblPhieuLuong= dao_timkiem.PhieuLuong("and tblNhanVien.MaNV=N'" + txtMaNV.Text + "'");
                txtLuongCoBan.Text = tblPhieuLuong.Rows[0]["LuongCoBan"].ToString();
                txtHeSoLuong.Text = tblPhieuLuong.Rows[0]["HeSoLuong"].ToString();
                txtTienThuong.Text = tblPhieuLuong.Rows[0]["TienThuong"].ToString();
                txtTongLinh.Text = tblPhieuLuong.Rows[0]["TongLinh"].ToString();

                //group KhenThuong
                DataTable tblKhenThuong = dao_timkiem.KhenThuong("and tblNhanVien.MaNV=N'" + txtMaNV.Text + "'");
                txtTienKhenThuong.Text = tblKhenThuong.Rows[0]["TienKhenThuong"].ToString();
                dtpNgayKhenThuong.Text = tblKhenThuong.Rows[0]["NgayKhenThuong"].ToString();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNgoaiNgu_TextChanged(object sender, EventArgs e)
        {
            DataTable trinhdo= dao_timkiem.NgoaiNgu("and TenNN=N'" + cboNgoaiNgu.Text + "'");
            txtTrinhDo.DataBindings.Clear();
            txtTrinhDo.DataBindings.Add("Text", trinhdo, "TrinhDo", true);
        }

        

        

       
    }
}
