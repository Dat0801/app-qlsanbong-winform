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
        public float TongTien { get; set; }
        public int MaLich { get; set; }
        public int MaKH { get; set; }

        public HoaDon(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.NgayTao = (DateTime)row["NgayTao"];
            this.TongTien = Convert.ToSingle(row["TongTien"]);
            this.MaLich = (int)row["MaLich"];
            this.MaKH = (int)row["MaKH"];
        }

        public HoaDon() { }
    }

}
