using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiThe_DTO
    {
        private string _maLoaiThe;
        private string _tenLoaiThe;
        public string MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
        public string TenLoaiThe
        {
            get { return _tenLoaiThe; }
            set { _tenLoaiThe = value; }
        }
        public LoaiThe_DTO() { }
        public LoaiThe_DTO(string maLoaiThe, string tenLoaiThe)
        {
            this.MaLoaiThe = maLoaiThe;
            this.TenLoaiThe = tenLoaiThe;
        }
    }
}
