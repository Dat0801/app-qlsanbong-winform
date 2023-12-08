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
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() {}
        public List<Account> LoadListTK()
        {
            List<Account> listTK = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account");
            foreach (DataRow row in data.Rows)
            {
                Account tk = new Account(row);
                listTK.Add(tk);
            }
            return listTK;
        }
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

        public bool KiemTraTrungTaiKhoan(string username)
        {
            string query = "select * from ACCOUNT where UserName ='"+ username +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool ThemTaiKhoan(string username, string password, string displayname, string role)
        {
            string query = "insert into ACCOUNT values ('" + username + "', '" + password + "', N'" + displayname + "', '" + role + "')";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool XoaTaiKhoan(string username)
        {
            string query = "delete from ACCOUNT where UserName = '"+ username +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool SuaTaiKhoan(string username, string password, string displayname, string role)
        {
            string query = "update ACCOUNT set Password = '" + password + "',DisplayName = '" + displayname + "',Role = '" + role + "' where UserName = '" + username + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public List<Account> timkiemTaiKhoan(string username)
        {
            List<Account> ListTaiKhoan = new List<Account>();
            string query = "SELECT * FROM Account WHERE UserName like '%" + username + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Account account = new Account(row);
                ListTaiKhoan.Add(account);
            }
            return ListTaiKhoan;
        }
    }
}
