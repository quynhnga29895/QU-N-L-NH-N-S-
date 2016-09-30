using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNgoaiNgu_DTO
    {
        private string _maNN;
        public string MaNN
        {
            get { return _maNN; }
            set { _maNN = value; }
        }

        private string _maNV;
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private string _trinhdo;
        public string TrinhDo
        {
            get { return _trinhdo; }
            set { _trinhdo = value; }
        }

        private DateTime _thoigian;
        public DateTime ThoiGian
        {
            get { return _thoigian; }
            set { _thoigian = value; }
        }

        private string _ghichu;
        public string GhiChu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
