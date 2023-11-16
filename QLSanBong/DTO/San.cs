using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    class San
    {
        public int MaSan { get; set; }
        public string TenSan { get; set; }
        public int LoaiSan { get; set; }

        public San(DataRow row)
        {
            this.MaSan = (int)row["MaSan"];
            this.TenSan = row["TenSan"].ToString();
            this.LoaiSan = (int)row["LoaiSan"];
        }

        public San() { }
    }
}
