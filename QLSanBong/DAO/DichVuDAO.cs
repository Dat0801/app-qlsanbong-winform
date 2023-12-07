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
    public class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return DichVuDAO.instance; }
            private set { DichVuDAO.instance = value; }

        }
        private DichVuDAO() { }
        public List<DichVu> LoadListDichVu()
        {
            List<DichVu> listDichVu = new List<DichVu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListDichVu");
            foreach (DataRow row in data.Rows)
            {
                DichVu dichvu = new DichVu(row);
                listDichVu.Add(dichvu);
            }
            return listDichVu;

        }
        public List<DichVu> TimKiemdicvu(string tenDV)
        {
            List<DichVu> ListDV = new List<DichVu>();
            string query = "SP_TimDV @TenDV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDV });
            foreach (DataRow row in data.Rows)
            {
                DichVu dv = new DichVu(row);
                ListDV.Add(dv);
            }
            return ListDV;
        }
        public int ThemDV(string tenDV, int DonGia)
        {
            string query = "SP_ThemDichVu @TenDV , @Gia";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDV, DonGia });
            return result;
        }
        public int XoaDichVu(string tenDV)
        {
            string query = "SP_XoaDV1 @TenDV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDV });
            return result;
        }
        public int SuaDicVu(int maDV, string tenDV, int dongia)
        {
            string query = "SP_SuaDichVu1 @MaDV , @TenDV , @Gia";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDV, tenDV, dongia });
            return result;
        }

    }
}
