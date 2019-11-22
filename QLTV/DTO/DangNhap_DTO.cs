using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DangNhap_DTO
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private int _LoaiTaiKhoan;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        public int LoaiTaiKhoan
        {
            get { return _LoaiTaiKhoan; }
            set { _LoaiTaiKhoan = value; }
        }
        public DangNhap_DTO()
        {

        }

        public DangNhap_DTO( string tendangnhap, string matkhau, int loaitk)
        {
            this.TenDangNhap = tendangnhap;
            this.LoaiTaiKhoan = loaitk;
            this.MatKhau = matkhau;
        }

    }
}
