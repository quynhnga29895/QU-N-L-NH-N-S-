using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuLuong_DTO
    {
        private string _maPL;
        public string MaPhieuLuong
        {
            get { return _maPL; }
            set { _maPL = value; }
        }

        private string _maNV;
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private long _luongCB;
        public long LuongCB
        {
            get { return _luongCB; }
            set { _luongCB = value; }
        }

        private float _hesoluong;
        public float HeSoLuong
        {
            get { return _hesoluong; }
            set { _hesoluong = value; }
        }

        private long _tienthuong;
        public long TienThuong
        {
            get { return _tienthuong; }
            set { _tienthuong = value; }
        }

        private long _phucap;
        public long PhuCap
        {
            get { return _phucap; }
            set { _phucap = value; }
        }

        private long _tong;
        public long TongLinh
        {
            get { return _tong; }
            set { _tong = value; }
        }

        private DateTime _ngaylinh;
        public DateTime NgayLinh
        {
            get { return _ngaylinh; }
            set { _ngaylinh = value; }
        }
    }
}
