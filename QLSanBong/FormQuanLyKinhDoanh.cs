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
    public partial class FormQuanLyKinhDoanh : Form
    {
        DichVu dv = new DichVu();
        public FormQuanLyKinhDoanh()
        {

            InitializeComponent();
            loaddicvu();
            loadHoaDon();
            loadKhachHang();
            loadCTHD();

        }
        private void loadCTHD()
        {
            List<ChiTietHoaDon> listCTHD = ChiTietHDDAO.Instance.LoadListLoadCTHD();
            dgv_CTHD.DataSource = listCTHD;


            List<DichVu> listDV = DichVuDAO.Instance.LoadListDichVu();
            cbo_MaDV.DataSource = listDV;
            cbo_MaDV.DisplayMember = "TenDV";
            cbo_MaDV.ValueMember = "MaDV";

            List<HoaDon> listHD = HoaDonDAO.Instance.LoadListHoaDon();
            cbo_MaHD.DataSource = listHD;
            cbo_MaHD.DisplayMember = "MaHD";
            cbo_MaHD.ValueMember = "MaHD";

        }
        private void loaddicvu()
        {
            List<DichVu> listKH = DichVuDAO.Instance.LoadListDichVu();
            dgv_DichVu.DataSource = listKH;
        }

        private void btn_timDV_Click(object sender, EventArgs e)
        {
            string tendv = txt_NameDV.Text;
            List<DichVu> ListLoaiSan = DichVuDAO.Instance.TimKiemdicvu(tendv);
            dgv_DichVu.DataSource = ListLoaiSan;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string tenDV = txt_tenDV.Text;
            if (tenDV == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại!");
            }
            else
            {
                int giaDV = 0;
                try
                {
                    giaDV = int.Parse(txt_dongiaDV.Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá");
                }
                if (giaDV != 0)
                {
                    if (KiemTraTrungTenDV(tenDV))
                        MessageBox.Show("Dịch vụ đã tồn tại!");
                    else
                        DichVuDAO.Instance.ThemDV(tenDV, giaDV);
                    txt_dongiaDV.Clear();
                    txt_tenDV.Clear();

                }

            }
            loaddicvu();
        }
        public bool KiemTraTrungTenDV(string tenDV)
        {
            string query = "SP_KiemTraTrungTenDichVu @TenDV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenDV });
            return result.Rows.Count > 0;
        }


        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgv_DichVu.Rows[e.RowIndex];
                txt_MaDV.Text = Convert.ToString(row.Cells["MaDV"].Value);
                txt_tenDV.Text = Convert.ToString(row.Cells["TenDV"].Value);
                txt_dongiaDV.Text = Convert.ToString(row.Cells["DonGia"].Value);

            }
            catch
            {
                txt_dongiaDV.Clear();
                txt_tenDV.Clear();

            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDV = "";
                try
                {
                    tenDV = txt_tenDV.Text;
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!");
                }
                if (tenDV != "")
                {
                    DichVuDAO.Instance.XoaDichVu(tenDV);
                    txt_tenDV.Clear();
                    txt_dongiaDV.Clear();

                }
            }
            catch 
            {
                int maDV = int.Parse(cbo_MaDV.SelectedValue.ToString());
                int maHD = int.Parse(cbo_MaHD.SelectedValue.ToString());
                int result = ChiTietHDDAO.Instance.XoaCTHD(maHD, maDV);
                if (result > 0)
                {
                    MessageBox.Show("Bạn Sẽ Xóa Chi tiết Hóa đơn trước!");
                    loaddicvu();
                }
                else
                {
                    MessageBox.Show("Không thể xóa chi tiết hóa đơn. Vui lòng thử lại!");
                }
            }
            loaddicvu();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int maDV = 0;
            try
            {
                maDV = int.Parse(txt_MaDV.Text);

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sân muốn sửa!");
            }
            if (maDV != 0)
            {
                string tenDV = txt_tenDV.Text;
                int gia = int.Parse(txt_dongiaDV.Text);
                DichVuDAO.Instance.SuaDicVu(maDV, tenDV, gia);
                MessageBox.Show("Sua thanh cong");
            }
            loaddicvu();

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
                List<San> listSan = SanDAO.Instance.LoadListSan();
                cbo_MAKH.DataSource = listKH;
                cbo_MAKH.DisplayMember = "TenKH";
                cbo_MAKH.ValueMember = "MaKH";

                cbo_MaSan.DataSource = listSan;
                cbo_MaSan.DisplayMember = "TenSan";
                cbo_MaSan.ValueMember = "MaSan";



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
        private void dataGridView_DSKH_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_DSKH.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView_DSKH.Rows[rowIndex];
            txt_TenKH.Text = row.Cells["TenKH"].Value.ToString();
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = row.Cells["SDT"].Value.ToString();
            txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txt_tkTenKH.Text;
            List<KhachHang> ListKhachHang = KhachHangDAO.Instance.timKiemKhachHang(tenKhachHang);
            dataGridView_DSKH.DataSource = ListKhachHang;
        }

        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = dgv_CTHD.Rows[e.RowIndex];
                txt_SoLuong.Text = Convert.ToString(row.Cells["SoLuong"].Value);
                int maDV = Convert.ToInt32(row.Cells["MaDV"].Value);
                int maHD = Convert.ToInt32(row.Cells["MaHD"].Value);
                cbo_MaDV.SelectedValue = maDV;
                cbo_MaHD.SelectedValue = maHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

        }
        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            if (dgv_CTHD.SelectedCells.Count > 0)
            {
                int maHD = Convert.ToInt32(cbo_MaHD.SelectedValue);
                int maDV = Convert.ToInt32(cbo_MaDV.SelectedValue);
                int soLuong = Convert.ToInt32(txt_SoLuong.Text);


                int result = ChiTietHDDAO.Instance.ThemCTHD(maHD, maDV, soLuong);

                if (result > 0)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
                    loadCTHD();
                }
                else
                {
                    MessageBox.Show("Không thể thêm chi tiết hóa đơn. Vui lòng thử lại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn và dịch vụ muốn thêm chi tiết.");
            }
            loadHoaDon();
        }

        private void btnTKThang_Click(object sender, EventArgs e)
        {
            if (cbo_Thang.SelectedItem != null && cbo_Thang_Nam.SelectedItem != null)
            {
                int thang = int.Parse(cbo_Thang.SelectedItem.ToString());
                int nam = int.Parse(cbo_Thang_Nam.SelectedItem.ToString());
                List<HoaDon> listHD = HoaDonDAO.Instance.getListHoaDon(thang, nam);
                dgv_Doanhthu.DataSource = listHD;
                decimal TongDT = 0;
                foreach (var item in listHD)
                {
                    TongDT += item.TongTien;
                }
                lbl_TongDT.Text = "Tổng doanh thu: " + TongDT.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng và năm muốn thống kê!");
            }

        }

        private void btn_TKNam_Click(object sender, EventArgs e)
        {
            if (cbo_Nam.SelectedItem != null)
            {
                int nam = int.Parse(cbo_Nam.SelectedItem.ToString());
                List<HoaDon> listHD = HoaDonDAO.Instance.getListHoaDon(nam);
                dgv_Doanhthu.DataSource = listHD;
                decimal TongDT = 0;
                foreach (var item in listHD)
                {
                    TongDT += item.TongTien;
                }
                lbl_TongDT.Text = "Tổng doanh thu: " + TongDT.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm muốn thống kê!");
            }
            loadHoaDon();
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            int maDV = int.Parse(cbo_MaDV.SelectedValue.ToString());
            int maHD = int.Parse(cbo_MaHD.SelectedValue.ToString());
            int result = ChiTietHDDAO.Instance.XoaCTHD(maHD, maDV);
            if (result > 0)
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
                loadCTHD();
            }
            else
            {
                MessageBox.Show("Không thể xóa chi tiết hóa đơn. Vui lòng thử lại!");
            }
            loadHoaDon();
        }
 
        private void btn_SuaCTHD_Click(object sender, EventArgs e)
        {
            int maHD = 0;
            try
            {
                maHD = int.Parse(cbo_MaHD.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }

            if (maHD != 0)
            {
                int madv = 0;
                if (int.TryParse(cbo_MaDV.SelectedValue.ToString(), out madv))
                {
                    int soluong = 0;
                    if (int.TryParse(txt_SoLuong.Text, out soluong))
                    {
                        int result = ChiTietHDDAO.Instance.SuaCTHD(maHD, madv, soluong);
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa chi tiết hóa đơn thành công!");
                            loadCTHD();
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Hóa đơn không tồn tại hoặc không thể sửa!");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi sửa chi tiết hóa đơn!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Mã Dịch vụ.");
                }
            }
            loadHoaDon();
        }
    }
}
