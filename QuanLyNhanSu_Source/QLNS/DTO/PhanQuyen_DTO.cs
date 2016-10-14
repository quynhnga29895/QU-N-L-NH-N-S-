using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen_DTO
    {
        private string _maPQ;
        public string MaChuyenMon
        {
            get { return _maPQ; }
            set { _maPQ = value; }
        }

        private string _tenPQ;
        public string TenPQ
        {
            get { return _tenPQ; }
            set { _tenPQ = value; }
        }
    }
}
