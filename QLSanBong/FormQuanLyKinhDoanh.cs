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
            string tenKhachHang = "";
  
            try
            {
                tenKhachHang = txt_TenKH.Text;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn sửa!");
            }
                if (tenKhachHang != "")
                {
                    
                    string diachi = txt_DiaChi.Text;
                    string sdt = txt_SDT.Text;
                    KhachHangDAO.Instance.SuaDanhSach(tenKhachHang, diachi, sdt);
                }
                loadKhachHang();
            
        }
        private void dataGridView_DSKH_Click(object sender, EventArgs e)
        {   
            int rowIndex = dataGridView_DSKH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView_DSKH.Rows[rowIndex];
            txt_TenKH.Text = row.Cells["TenKH"].Value.ToString();
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = row.Cells["SDT"].Value.ToString();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_tkTenKH.Text;
            List<KhachHang> ListKhachHang = KhachHangDAO.Instance.timKiemKhachHang(tenKhachHang);
            dataGridView_DSKH.DataSource = ListKhachHang;
        }
    }
}
