using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DocGia_DTO
    {
        private string _MaDocGia;
        private string _DiaChi;
        private string _TenDocGia;
        private string _GioiTinh;
        private string _SoCMT;
        private string _MaLoaiDocGia;
        private DateTime _NgaySinh;
        private string _MatKhau;

        public string MaDocGia
        {
            get { return _MaDocGia; }
            set { _MaDocGia = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string TenDocGia
        {
            get { return _TenDocGia; }
            set { _TenDocGia = value; }
        }

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        public string SoCMT
        {
            get { return _SoCMT; }
            set { _SoCMT = value; }
        }

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        public string MaLoaiDocGia
        {
            get { return _MaLoaiDocGia; }
            set { _MaLoaiDocGia = value; }
        }

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        public DocGia_DTO()
        {
            MaDocGia = "";
            TenDocGia = "";
            GioiTinh = "";
            NgaySinh = DateTime.Today;
            SoCMT = "";
            MaLoaiDocGia = "";
            DiaChi = "";
            MatKhau = "";
        }

        public DocGia_DTO(string madocgia, string tendocgia, string gioitinh, DateTime ngaysinh, string socmt, string maloaidocgia, string diachi, string matkhau)
        {
            this.MaDocGia = madocgia;
            this.TenDocGia = tendocgia;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.SoCMT = socmt;
            this.MaLoaiDocGia = maloaidocgia;
            this.DiaChi = diachi;
            this.MatKhau = matkhau;
        }
    }
}
