using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private string _hoten;
        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        private string _gioitinh;

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        private DateTime _ngaysinh;
        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }

        private string _diachi;
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        private string _maPB;
        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }

        private string _maChuyenMon;

        public string MaChuyenMon
        {
            get { return _maChuyenMon; }
            set { _maChuyenMon = value; }
        }

        private string _maChucVu;

        public string MaChucVu
        {
            get { return _maChucVu; }
            set { _maChucVu = value; }
        }

        private string _ghichu;

        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
