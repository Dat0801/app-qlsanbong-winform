using MyClass.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() {}

        public bool Login(string username, string password)
        {
            string query = "SP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public int getRole(string username, string password)
        {
            string query = "SP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            DataRow role = result.Rows[0];
            return (int) role["Role"];
        }
    }
}
