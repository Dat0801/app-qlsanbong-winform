using MyClass.DAO;
using QLSanBong.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DAO
{
    class ChiTietHDDAO
    {
        private static ChiTietHDDAO instance;

        public static ChiTietHDDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHDDAO(); return ChiTietHDDAO.instance; }
            private set { ChiTietHDDAO.instance = value; }
        }

        private ChiTietHDDAO() { }

        public List<ChiTietHoaDon> LoadListLoadCTHD()
        {
            List<ChiTietHoaDon> ListHD = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListCTHoaDon");
            foreach (DataRow row in data.Rows)
            {
                ChiTietHoaDon hd = new ChiTietHoaDon(row);
                ListHD.Add(hd);
            }
            return ListHD;
        }
        public int ThemCTHD(int maHD, int maDV, int soLuong)
        {
            string query = "EXEC SP_ThemChiTietHoaDon @MaHD , @MaDV , @SoLuong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maDV, soLuong });
            return result;
        }
    }
}
