using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhenThuong_DTO
    {
        private string _maKT;
        public string MaKT
        {
            get { return _maKT; }
            set { _maKT = value; }
        }

        private string _maNV;
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private DateTime _ngaykhenthuong;
        public DateTime NgayKhenThuong
        {
            get { return _ngaykhenthuong; }
            set { _ngaykhenthuong = value; }
        }

        private long _tienKT;
        public long TienKT
        {
            get { return _tienKT; }
            set { _tienKT = value; }
        }

        private string _ghichu;
        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
