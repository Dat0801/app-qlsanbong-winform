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
    class LichDatSanDAO
    {
        private static LichDatSanDAO instance;

        public static LichDatSanDAO Instance
        {
            get { if (instance == null) instance = new LichDatSanDAO(); return LichDatSanDAO.instance; }
            private set { LichDatSanDAO.instance = value; }
        }

        private LichDatSanDAO() { }

        public List<LichDatSan> LoadListLoaiSan()
        {
            List<LichDatSan> ListLichDatSan = new List<LichDatSan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListLichDatSan");
            foreach (DataRow row in data.Rows)
            {
                LichDatSan LichDatSan = new LichDatSan(row);
                ListLichDatSan.Add(LichDatSan);
            }
            return ListLichDatSan;
        }

        public int ThemLichDatSan(string thoiGianBD, string thoiGianKT, int maKH, int maSan)
        {
            string query = "SP_ThemLichDatSan @ThoiGianBD , @ThoiGianKT , @MaKH , @MaSan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { thoiGianBD, thoiGianKT, maKH, maSan });
            return result;
        }

        public int XoaLichDatSan(int maLich)
        {
            string query = "SP_XoaLichDatSan @MaLich";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLich });
            return result;
        }

        public int SuaLichDatSan(int maLich, string thoiGianBD, string thoiGianKT, int maKH, int maSan)
        {
            string query = "SP_SuaLichDatSan @MaLich , @ThoiGianBD , @ThoiGianKT , @MaKH , @MaSan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLich, thoiGianBD, thoiGianKT, maKH, maSan });
            return result;
        }

    }
}
