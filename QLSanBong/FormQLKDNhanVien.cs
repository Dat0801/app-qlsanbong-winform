using MyClass.DAO;
using QLSanBong.DAO;
using QLSanBong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong
{
    public partial class FormQLKDNhanVien : Form
    {
        public FormQLKDNhanVien()
        {
            InitializeComponent();
            loadKhachHang();
        }

        private void loadKhachHang()
        {
            List<KhachHang> listKH = KhachHangDAO.Instance.LoadListKH();
            dataGridView_KhachHang.DataSource = listKH;
        }

        private void FormQLKDNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
