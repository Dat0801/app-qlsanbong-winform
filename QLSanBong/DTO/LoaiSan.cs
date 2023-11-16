using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    class LoaiSan
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public double GiaThue { get; set; }
        public LoaiSan(DataRow row)
        {
            this.MaLoai = (int)row["MaLoai"];
            this.TenLoai = row["TenLoai"].ToString();
            this.GiaThue = (double)row["GiaThue"];
        }

        public LoaiSan() { }
    }
}
