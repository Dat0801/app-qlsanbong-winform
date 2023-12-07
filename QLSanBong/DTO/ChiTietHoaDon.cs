using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    public class ChiTietHoaDon
    {
        public int MaDV { get; set; }
        public int MaHD { get; set; }
        public int SoLuong { get; set; }

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(DataRow row)
        {
            this.MaDV = (int)row["MaDV"];
            this.MaHD = (int)row["MaHD"];
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
