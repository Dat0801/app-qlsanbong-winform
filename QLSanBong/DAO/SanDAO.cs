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
    class SanDAO
    {
        private static SanDAO instance;

        public static SanDAO Instance
        {
            get { if (instance == null) instance = new SanDAO(); return SanDAO.instance; }
            private set { SanDAO.instance = value; }
        }

        public static int SanWidth = 100;
        public static int SanHeight = 100;

        private SanDAO() { }

        public List<San> LoadListSan()
        {
            List<San> ListSan = new List<San>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListSan");
            foreach (DataRow row in data.Rows)
            {
                San san = new San(row);
                ListSan.Add(san);
            }
            return ListSan;
        }

        public int ThemSan(string tenSan, string maLoai)
        {
            string query = "SP_ThemSan @TenSan , @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenSan, maLoai });
            return result;
        } 

        public bool KiemTraTrungTenSan(string tenSan)
        {
            string query = "SP_KiemTraTrungTenSan @TenSan";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenSan});
            return result.Rows.Count > 0;
        }

        public int XoaSan(int maSan)
        {
            
            string query = "SP_XoaSan @MaSan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSan });
            return result;
        }

        public int SuaSan(int maSan, string tenSan, int maLoai)
        {
            string query = "SP_SuaSan @MaSan , @TenSan , @MaLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSan, tenSan, maLoai });
            return result;
        }

        public List<San> TimKiemSan(string tenSan)
        {
            List<San> ListSan = new List<San>();
            string query = "SP_TimKiemSan @TenSan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {tenSan});
            foreach (DataRow row in data.Rows)
            {
                San san = new San(row);
                ListSan.Add(san);
            }
            return ListSan;
        }
    }
}
