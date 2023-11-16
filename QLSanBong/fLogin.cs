using QLSanBong;
using QLSanBong.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SanBong
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if(Login(username, password))
            {
                this.Hide();
                if (getRole(username,password) == 1)
                {
                    FormAdmin fAdmin = new FormAdmin();
                    fAdmin.ShowDialog();
                } else
                {
                    FormNhanVien fNhanVien = new FormNhanVien();
                    fNhanVien.ShowDialog();
                }
                txtUserName.Clear();
                txtPassword.Clear();
                this.Show();
            } else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private int getRole(string username, string password)
        {
            return AccountDAO.Instance.getRole(username, password);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
