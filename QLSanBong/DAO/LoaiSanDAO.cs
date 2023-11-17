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
    class LoaiSanDAO
    {
        private static LoaiSanDAO instance;

        public static LoaiSanDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanDAO(); return LoaiSanDAO.instance; }
            private set { LoaiSanDAO.instance = value; }
        }

        private LoaiSanDAO() { }

        public List<LoaiSan> LoadListLoaiSan()
        {
            List<LoaiSan> ListSan = new List<LoaiSan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListLoaiSan");
            foreach (DataRow row in data.Rows)
            {
                LoaiSan loaisan = new LoaiSan(row);
                ListSan.Add(loaisan);
            }
            return ListSan;
        }

        public int ThemLoaiSan(string tenLoai, double giaThue)
        {
            string query = "SP_ThemLoaiSan @TenLoai , @GiaThue";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoai, giaThue });
            return result;
        }

        public bool KiemTraTrungTenLoai(string tenLoai)
        {
            string query = "SP_KiemTraTrungTenLoai @TenLoai";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLoai });
            return result.Rows.Count > 0;
        }

        public int XoaLoaiSan(int maLoai)
        {
            string query = "SP_XoaLoaiSan @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai });
            return result;
        }

        public int SuaLoaiSan(int maLoai, string tenLoai, double giaThue)
        {
            string query = "SP_SuaLoaiSan @MaLoai , @TenLoai , @GiaThue";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai, tenLoai, giaThue });
            return result;
        }

        public List<LoaiSan> TimKiemLoaiSan(string tenLoai)
        {
            List<LoaiSan> ListLoaiSan = new List<LoaiSan>();
            string query = "SP_TimKiemLoaiSan @TenLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLoai });
            foreach (DataRow row in data.Rows)
            {
                LoaiSan loaiSan = new LoaiSan(row);
                ListLoaiSan.Add(loaiSan);
            }
            return ListLoaiSan;
        }
    }
}
