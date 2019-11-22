using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TacGia_DTO
    {
        private string _maTacGia;
        private string _tenTacGia;
        private string _ghiChu;
        public string MaTacGia
        {
            get { return _maTacGia; }
            set { _maTacGia = value; }
        }

        public string TenTacGia
        {
            get { return _tenTacGia; }
            set { _tenTacGia = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public TacGia_DTO() { }
        public TacGia_DTO(string maTacGia, string tenTacGia, string ghiChu)
        {
            MaTacGia = maTacGia;
            TenTacGia = tenTacGia;
            GhiChu = ghiChu;
        }
    }
}
