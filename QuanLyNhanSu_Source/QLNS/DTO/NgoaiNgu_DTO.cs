using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NgoaiNgu_DTO
    {
        private string _maNN;
        public string MaNN
        {
            get { return _maNN; }
            set { _maNN = value; }
        }

        private string _tenNN;
        public string TenNN
        {
            get { return _tenNN; }
            set { _tenNN = value; }
        }
    }
}
