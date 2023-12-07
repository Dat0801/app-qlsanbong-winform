using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime NgayTao { get; set; }
        public int MaSan { get; set; }
        public int MaKH { get; set; }
        public int TongPhut { get; set; }
        public decimal DonGia { get; set; }
        public decimal TongTien { get; set; }

        public HoaDon(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.NgayTao = (DateTime)row["NgayTao"];
            this.MaSan = (int)row["MaSan"];
            this.MaKH = (int)row["MaKH"];
            this.TongPhut = (int)row["TongPhut"];
            this.DonGia = (decimal)row["DonGia"];
            this.TongTien = (decimal)row["TongTien"];
        }

        public HoaDon() { }
    }

}
