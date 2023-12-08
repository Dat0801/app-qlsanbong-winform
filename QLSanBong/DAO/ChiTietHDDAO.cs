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
            List<ChiTietHoaDon> listCTHD = LoadListLoadCTHD();
            int flag = 0;
            foreach (var item in listCTHD)
            {
                if(maHD == item.MaHD && maDV == item.MaDV)
                {
                    flag = 1;
                    soLuong += item.SoLuong;
                }
            }
            if(flag == 1)
            {
                string query = "Update ChiTietHD set SoLuong = '"+ soLuong +"' where MaHD = '" + maHD + "' and MaDV = '" + maDV + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maDV, soLuong });
                return result;
            } else
            {
                string query = "EXEC SP_ThemChiTietHoaDon @MaHD , @MaDV , @SoLuong";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maDV, soLuong });
                return result;
            }
        }

        public int XoaCTHD(int maHD, int maDV)
        {
            string query = "Delete from CHITIETHD where MaHD = '" + maHD +"' AND MaDV = '"+ maDV +"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public int SuaCTHD(int maHD, int maDV, int soLuongMoi)
        {
                int resultXoa = XoaCTHD(maHD, maDV);
                if (resultXoa > 0)
                {
                    // Nếu xóa thành công, thêm chi tiết hóa đơn mới với số lượng mới
                    int resultThem = ThemCTHD(maHD, maDV, soLuongMoi);

                    return resultThem;
                }
                else
                {
                    return resultXoa;
                }
            
        }
        
    }
}
