using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DTO
{
    public class DichVu
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public int DonGia { get; set; }
        public DichVu(DataRow row)
        {
            this.MaDV = (int)row["MaDV"];
            this.TenDV = row["TenDV"].ToString();
            this.DonGia = (int)row["DonGia"];
        }

        public DichVu() { }
    }
}
