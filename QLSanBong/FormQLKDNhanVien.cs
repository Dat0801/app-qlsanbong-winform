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
            loadHoaDon();
        }

        private void loadHoaDon()
        {
            List<HoaDon> listHD = HoaDonDAO.Instance.LoadListHoaDon();
            dgv_HoaDon.DataSource = listHD;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.SelectedCells.Count > 0)
                {

                    int selectedRowIndex = dgv_HoaDon.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_HoaDon.Rows[selectedRowIndex];
                    int maHD = Convert.ToInt32(selectedRow.Cells["MaHD"].Value);
                    int result = HoaDonDAO.Instance.XoaHoaDon(maHD);

                    if (result > 0)
                    {
                        loadHoaDon();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<KhachHang> listKH = KhachHangDAO.Instance.LoadListKH();

                cbo_MAKH.DataSource = listKH;
                cbo_MAKH.DisplayMember = "TenKH";
                cbo_MAKH.ValueMember = "MaKH";
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
                txt_MaHD.Text = Convert.ToString(row.Cells["MaHD"].Value);
                dateTimePicker_NgayBD.Text = Convert.ToString(row.Cells["NgayTao"].Value);
                txt_Tongtien.Text = Convert.ToString(row.Cells["TongTien"].Value);
                int maKHFromDGV = Convert.ToInt32(row.Cells["MaKH"].Value);
                txt_PhutDa.Text = (row.Cells["TongPhut"].Value).ToString();
                txt_MaSan.Text = row.Cells["MaSan"].Value.ToString();
                txt_Dongia.Text = row.Cells["DonGia"].Value.ToString();
                // Tìm tên khách hàng tương ứng trong danh sách listKH
                KhachHang khachHang = listKH.Find(kh => kh.MaKH == maKHFromDGV);

                if (khachHang != null)
                {
                    cbo_MAKH.SelectedValue = khachHang.MaKH;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

        }
        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgv_HoaDon.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_HoaDon.Rows[selectedRowIndex];

                    int maHD = Convert.ToInt32(selectedRow.Cells["MaHD"].Value);

                    bool canEdit = HoaDonDAO.Instance.CanEditMaHD(maHD);

                    if (canEdit == true)
                    {
                        DateTime ngayTao = dateTimePicker_NgayBD.Value;
                        decimal tongTien;

                        if (!decimal.TryParse(txt_Tongtien.Text, out tongTien))
                        {
                            MessageBox.Show("Tổng tiền không hợp lệ!");
                            return;
                        }

                        int maKH = Convert.ToInt32(cbo_MAKH.SelectedValue);
                        int maSan = Convert.ToInt32(txt_MaSan.Text);
                        int tongPhut = Convert.ToInt32(txt_PhutDa.Text);

                        // Thực hiện sửa thông tin
                        int result = HoaDonDAO.Instance.SuaHoaDon(maHD, ngayTao, tongTien, maKH, maSan, tongPhut);

                        // Kiểm tra và hiển thị kết quả
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa thông tin hóa đơn thành công!");
                            loadHoaDon();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa thông tin hóa đơn. Vui lòng thử lại!");
                        }
                    }
                    if (canEdit == false)
                    {
                        MessageBox.Show("Không thể sửa mã hóa đơn!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn muốn sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
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
                int makh = int.Parse(txtMaKH.Text);
                KhachHangDAO.Instance.SuaDanhSach(tenKhachHang, diachi, sdt, makh);
            }
            loadKhachHang();

        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTimKiemTenKH.Text;
            List<KhachHang> ListKhachHang = KhachHangDAO.Instance.timKiemKhachHang(tenKhachHang);
            dataGridView_DSKH.DataSource = ListKhachHang;
        }

        private void dataGridView_DSKH_Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView_DSKH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView_DSKH.Rows[rowIndex];
            txt_TenKH.Text = row.Cells["TenKH"].Value.ToString();
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = row.Cells["SDT"].Value.ToString();
            txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
        }
    }
}
