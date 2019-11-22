using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Sach_DTO
    {
        private string _maSach;
        private string _tenSach;
        private string _maTacGia;
        private string _maTheLoai;
        private string _maNXB;
        private int _namXuatBan;
        private int _soTrang;
        private int _gia;
        private int _soBan;
        private int _soBanTon;
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }

        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }

        public string MaTacGia
        {
            get { return _maTacGia; }
            set { _maTacGia = value; }
        }

        public string MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }

        public string MaNXB
        {
            get { return _maNXB; }
            set { _maNXB = value; }
        }

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set { _namXuatBan = value; }
        }

        public int SoTrang
        {
            get { return _soTrang; }
            set { _soTrang = value; }
        }

        public int Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public int SoBan
        {
            get { return _soBan; }
            set { _soBan = value; }
        }

        public int SoBanTon
        {
            get { return _soBanTon; }
            set { _soBanTon = value; }
        }
        public Sach_DTO() { }

        public Sach_DTO(string maSach, string tenSach, string maTacGia, string maTheLoai, string maNXB, int namXuatBan, int soTrang, int gia, int soBan, int soBanTon)
        {
            MaSach = maSach;
            TenSach = tenSach;
            MaTacGia = maTacGia;
            MaTheLoai = maTheLoai;
            MaNXB = maNXB;
            NamXuatBan = namXuatBan;
            SoTrang = soTrang;
            Gia = gia;
            SoBan = soBan;
            SoBanTon = soBanTon;
        }
    }
}
