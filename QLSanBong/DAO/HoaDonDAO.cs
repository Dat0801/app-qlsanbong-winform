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
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }

        public List<HoaDon> LoadListHoaDon()
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetListHoaDon");
            foreach (DataRow row in data.Rows)
            {
                HoaDon hoaDon = new HoaDon(row);
                listHoaDon.Add(hoaDon);
            }
            return listHoaDon;
        }
        public int XoaHoaDon(int maHD)
        {
            string query = "SP_XoaHoaDon @MaHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD });
            return result;
        }
        public int SuaHoaDon(int maHD, DateTime ngayTao, decimal tongTien, int maKH, int maSan, int TongPhut)
        {
            string query = "SP_SuaHoaDon5 @MaHD , @NgayTao , @TongTien , @MaKH , @MaSan , @TongPhut";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, ngayTao, tongTien, maKH, maSan, TongPhut });
            return result;
        }

        public bool CanEditMaHD(int maHD)
        {
            try
            {
                string query = "SP_CanEditMaHD @MaHD";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maHD });

                if (result.Rows.Count > 0)
                {
                    bool canEdit = Convert.ToBoolean(result.Rows[0]["CanEdit"]);
                    return canEdit;
                }
                return false; // Nếu không có dữ liệu, mặc định không thể sửa.
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in CanEditMaHD: {ex.Message}");
            }
        }
        public List<HoaDon> getListHoaDon(int Thang, int Nam)
        {
            try
            {
                string query = "Select * from HoaDon where Month(NgayTao) = '"+ Thang +"' AND Year(NgayTao) = '" + Nam + "'";
                List<HoaDon> listHoaDon = new List<HoaDon>();
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    HoaDon hoaDon = new HoaDon(row);
                    listHoaDon.Add(hoaDon);
                }
                return listHoaDon;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getListHoaDon: {ex.Message}");
            }
        }

        public List<HoaDon> getListHoaDon(int Nam)
        {
            try
            {
                string query = "Select * from HoaDon where Year(NgayTao) = '" + Nam + "'";
                List<HoaDon> listHoaDon = new List<HoaDon>();
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    HoaDon hoaDon = new HoaDon(row);
                    listHoaDon.Add(hoaDon);
                }
                return listHoaDon;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getListHoaDon: {ex.Message}");
            }
        }
    }
}
