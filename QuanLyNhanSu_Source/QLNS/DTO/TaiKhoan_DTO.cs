using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string _UserName;
        public string UserName
        {
             get { return _UserName; }
             set { _UserName = value; }
        }

        private string _Pass;
        public string Password
        {
             get { return _Pass; }
             set { _Pass = value; }
        }

        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MaPQ;
        public string MaPQ
        {
            get { return _MaPQ; }
            set { _MaPQ = value; }
        }
    }
}

