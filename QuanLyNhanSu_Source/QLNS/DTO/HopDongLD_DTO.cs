using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongLD_DTO
    {
        private string _maHD;
        public string MaHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }

        private string _tenHD;
        public string TenHD
        {
            get { return _tenHD; }
            set { _tenHD = value; }
        }

        private string _loaiHD;
        public string LoaiHD
        {
            get { return _loaiHD; }
            set { _loaiHD = value; }
        }
    }
}
