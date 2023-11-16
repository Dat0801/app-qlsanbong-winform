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
    }
}
