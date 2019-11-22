using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class The_DTO
    {
        private string _maThe;
        private string _maDocGia;
        private string _maLoaiThe;
        private DateTime _ngayCapThe;
        private DateTime _ngayHetHan;
        private int _soSachDuocMuon;
        private int _soSachDangMuon;
        public string MaThe
        {
            get { return _maThe; }
            set { _maThe = value; }
        }

        public string MaDocGia
        {
            get { return _maDocGia; }
            set { _maDocGia = value; }
        }

        public string MaLoaiThe
        {
            get { return _maLoaiThe; }
            set { _maLoaiThe = value; }
        }
 
        public DateTime NgayCapThe
        {
            get { return _ngayCapThe; }
            set { _ngayCapThe = value; }
        }

        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }

        public int SoSachDuocMuon
        {
            get { return _soSachDuocMuon; }
            set { _soSachDuocMuon = value; }
        }

        public int SoSachDangMuon
        {
            get { return _soSachDangMuon; }
            set { _soSachDangMuon = value; }
        }
        public The_DTO()
        {
            MaThe = "";
            MaDocGia = "";
            MaLoaiThe = "";
            NgayCapThe = DateTime.Today;
            NgayHetHan = DateTime.Today;
            SoSachDuocMuon = 0;
            SoSachDangMuon = 0;
        }
        public The_DTO(string maThe, string maDocGia, string maLoaiThe, DateTime ngayCapThe, DateTime ngayHetHan, int soSachDuocMuon, int soSachDangMuon)
        {
            MaThe = maThe;
            MaDocGia = maDocGia;
            MaLoaiThe = maLoaiThe;
            NgayCapThe = ngayCapThe;
            NgayHetHan = ngayHetHan;
            SoSachDuocMuon = soSachDuocMuon;
            SoSachDangMuon = soSachDangMuon;
        }

    }
}
