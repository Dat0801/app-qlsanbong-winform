using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    class LichDatSan
    {
        public int MaLich { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }
        public int MaKH { get; set; }
        public int MaSan { get; set; }
        public decimal ThanhTien { get; set; }
        public LichDatSan(DataRow row)
        {
            this.MaLich = (int)row["MaLich"];
            this.ThoiGianBD = (DateTime)row["ThoiGianBD"];
            this.ThoiGianKT = (DateTime)row["ThoiGianKT"];
            this.MaKH = (int)row["MaKH"];
            this.MaSan = (int)row["MaSan"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }
        public LichDatSan() { }
    }
}
