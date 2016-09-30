using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHopDong_DTO
    {
        private string _maHD;
        public string MaHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }

        private string _maNV;
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private DateTime _ngaybatdau;
        public DateTime NgayBatDau
        {
            get { return _ngaybatdau; }
            set { _ngaybatdau = value; }
        }

        private DateTime _ngayketthuc;
        public DateTime NgayKetThuc
        {
            get { return _ngayketthuc; }
            set { _ngayketthuc = value; }
        }

        private string _ghichu;
        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
