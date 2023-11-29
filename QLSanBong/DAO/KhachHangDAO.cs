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
        public List<KhachHang> LoadListSan()
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
    }
}
