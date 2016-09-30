using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan_DTO
    {
        private string _maPB;
        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }

        private string _tenPB;
        public string TenPB
        {
            get { return _tenPB; }
            set { _tenPB = value; }
        }

        private string _diadiem;
        public string DiaDiem
        {
            get { return _diadiem; }
            set { _diadiem = value; }
        }

        private string _sdt;
        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
    }
}
