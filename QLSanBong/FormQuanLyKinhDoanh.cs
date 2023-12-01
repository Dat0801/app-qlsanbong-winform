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
    public partial class FormQuanLyKinhDoanh : Form
    {
        private object ListKhachHang;
        public FormQuanLyKinhDoanh()
        {
            InitializeComponent();
            loadKhachHang();
        }
        private void loadKhachHang()
        {
            List<KhachHang> listKH = KhachHangDAO.Instance.LoadListKH();
            dataGridView_DSKH.DataSource = listKH;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_TenKH.Text;
            if (tenKhachHang == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
            }
            else
            {
                string diachi = txt_DiaChi.Text;
                string sdt = txt_SDT.Text;
                KhachHangDAO.Instance.ThemKhachHang(tenKhachHang, diachi, sdt);
                txt_TenKH.Clear();
                txt_DiaChi.Clear();
                txt_SDT.Clear();
            }
            loadKhachHang();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            {
                string tenKhachHang = txt_TenKH.Text;
                try
                {

                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn khách hàng muốn sửa!");
                }
                if (tenKhachHang == "")
                {
                    string diachi = txt_DiaChi.Text;
                    string sdt = txt_SDT.Text;
                    KhachHangDAO.Instance.SuaDanhSach(tenKhachHang, diachi, sdt);
                }
                loadKhachHang();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_tkTenKH.Text;
            List<KhachHang> ListSan = KhachHangDAO.Instance.timKiemKhachHang(tenKhachHang);
            dataGridView_DSKH.DataSource = ListKhachHang;
        }
    }
}
