using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuMuon_DTO
    {
        private int _soPhieu;
        private string _maThe;
        private string _maSach;
        private DateTime _ngayMuon;
        private DateTime _ngayTra;
        private string _tinhTrang;
        private string _ghiChu;
        public int SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }

        public string MaThe
        {
            get { return _maThe; }
            set { _maThe = value; }
        }

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public DateTime NgayMuon
        {
            get { return _ngayMuon; }
            set { _ngayMuon = value; }
        }

        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public PhieuMuon_DTO() { }
        public PhieuMuon_DTO(int soPhieu, string maThe, string maSach, DateTime ngayMuon, DateTime ngayTra, string tinhTrang, string ghiChu)
        {
            SoPhieu = soPhieu;
            MaThe = maThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            TinhTrang = tinhTrang;
            GhiChu = ghiChu;
        }
        public PhieuMuon_DTO(string maThe, string maSach, DateTime ngayMuon, DateTime ngayTra, string tinhTrang, string ghiChu)
        {
            MaThe = maThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            TinhTrang = tinhTrang;
            GhiChu = ghiChu;
        }
    }
}
