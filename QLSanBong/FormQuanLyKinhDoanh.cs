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
        public FormQuanLyKinhDoanh()
        {
            
            InitializeComponent();
            loaddicvu();
            loadHoaDon();
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
            loaddicvu();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (dgv_DichVu.SelectedRows.Count > 0)
            {
                DichVu selectedDV = dgv_DichVu.SelectedRows[0].DataBoundItem as DichVu;

                // Các thao tác khác ở đây
                if (selectedDV != null)
                {
                    string tenDV = txt_tenDV.Text.Trim();
                    if (string.IsNullOrEmpty(tenDV))
                    {
                        MessageBox.Show("Vui lòng chọn dịch vụ muốn sửa!");
                        return;
                    }

                    int dongia;
                    if (!int.TryParse(txt_dongiaDV.Text, out dongia))
                    {
                        MessageBox.Show("Đơn giá không hợp lệ!");
                        return;
                    }

                    // Thực hiện sửa thông tin
                    int result = DichVuDAO.Instance.SuaDicVu(selectedDV.MaDV, tenDV, dongia);

                    // Kiểm tra và hiển thị kết quả
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin dịch vụ thành công!");
                        loaddicvu();
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa thông tin dịch vụ. Vui lòng thử lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ muốn sửa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn sửa!");
            }
            

            
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
        

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgv_HoaDon.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_HoaDon.Rows[selectedRowIndex];

                    int maHD = Convert.ToInt32(selectedRow.Cells["MaHD"].Value);

                    bool canEdit =HoaDonDAO.Instance.CanEditMaHD(maHD);

                    if (canEdit==true)
                    {
                        DateTime ngayTao = dateTimePicker_NgayBD.Value;
                        decimal tongTien;

                        if (!decimal.TryParse(txt_Tongtien.Text, out tongTien))
                        {
                            MessageBox.Show("Tổng tiền không hợp lệ!");
                            return;
                        }

                        int maKH = Convert.ToInt32(cbo_MAKH.SelectedValue);

                        // Thực hiện sửa thông tin
                        int result = HoaDonDAO.Instance.SuaHoaDon(maHD, ngayTao, tongTien, maKH);

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
                    if(canEdit==false)
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
    }
}
