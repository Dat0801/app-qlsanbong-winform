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
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }
        public List<KhachHang> LoadListKH()
        {
            List<KhachHang> listKH = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from KhachHang");
            foreach (DataRow row in data.Rows)
            {
                KhachHang kh = new KhachHang(row);
                listKH.Add(kh);
            }
            return listKH;
        }
        public bool ThemKhachHang(string tenKhachHang, string diachi,  string sdt)
        {
            string query = "insert into KHACHHANG values ('" + tenKhachHang + "', '" + diachi + "', '" + sdt + "')";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool SuaDanhSach(string tenKhachHang, string diachi,  string sdt)
        {
            string query = "insert into KHACHHANG values ('" + tenKhachHang + "', '" + diachi + "', '" + sdt + "')";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public List<KhachHang> timKiemKhachHang(string tenKhachHang)
        {
            List<KhachHang> ListKhachHang = new List<KhachHang>();
            string query = "insert into KHACHHANG values ('" + tenKhachHang + "')";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                KhachHang khachhang = new KhachHang(row);
                ListKhachHang.Add(khachhang);
            }
            return ListKhachHang;
        }
    }
}
