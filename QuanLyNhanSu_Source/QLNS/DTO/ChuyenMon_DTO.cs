using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenMon_DTO
    {
        private string _maCM;
        public string MaChuyenMon
        {
            get { return _maCM; }
            set { _maCM = value; }
        }

        private string _tenCM;
        public string TenChuyenMon
        {
            get { return _tenCM; }
            set { _tenCM = value; }
        }
    }
}
