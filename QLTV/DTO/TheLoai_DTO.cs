using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TheLoai_DTO
    {
        private string _maTheLoai;
        private string _tenTheLoai;
        public string MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }

        public string TenTheLoai
        {
            get { return _tenTheLoai; }
            set { _tenTheLoai = value; }
        }
        public TheLoai_DTO() { }
        public TheLoai_DTO(string maTheLoai, string tenTheLoai)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
        }
    }
}
