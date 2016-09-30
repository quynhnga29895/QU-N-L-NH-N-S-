using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu_DTO
    {
        private string _maCV;
        public string MaCV
        {
            get { return _maCV; }
            set { _maCV = value; }
        }

        private string _tenCV;
        public string TenCV
        {
            get { return _tenCV; }
            set { _tenCV = value; }
        }

        private long _phucap;
        public long PhuCap
        {
            get { return _phucap; }
            set { _phucap = value; }
        }
    }
}
