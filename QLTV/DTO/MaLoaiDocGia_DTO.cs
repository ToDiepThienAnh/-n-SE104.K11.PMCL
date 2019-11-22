using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MaLoaiDocGia_DTO
    {
        private string _MaLoaiDocGia;
        private string _TenLoaiDocGia;
        public string MaLoaiDocGia
        {
            get { return _MaLoaiDocGia; }
            set { _MaLoaiDocGia = value; }
        }

        public string TenLoaiDocGia
        {
            get { return _TenLoaiDocGia; }
            set { _TenLoaiDocGia = value; }
        }

        public MaLoaiDocGia_DTO()
        {

        }
        public MaLoaiDocGia_DTO(string maloaidocgia, string tenloaidocgia)
        {
            this.MaLoaiDocGia = maloaidocgia;
            this.TenLoaiDocGia = tenloaidocgia;
        }
    }
}
