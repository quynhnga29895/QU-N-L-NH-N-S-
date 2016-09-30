using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhenThuong_DTO
    {
        private string _maKT;
        public string MaKhenThuong
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

        private string _maPB;
        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }
    }
}
