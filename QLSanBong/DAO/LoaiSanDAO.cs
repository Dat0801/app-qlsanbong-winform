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
    }
}
