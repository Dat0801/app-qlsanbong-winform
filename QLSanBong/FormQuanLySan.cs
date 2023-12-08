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
    public partial class FormQuanLySan : Form
    {
        public FormQuanLySan()
        {
            InitializeComponent();
            loadSan();
            loadLoaiSan();
        }

        private void loadSan()
        {
            List<San> ListSan = SanDAO.Instance.LoadListSan();
            dataGridView_San.DataSource = ListSan;
        }

        private void btn_ThemSan_Click(object sender, EventArgs e)
        {
            string tenSan = txtTenSan.Text;
            if(tenSan == "")
            {
                MessageBox.Show("Vui lòng nhập tên sân!");
            } else
            {
                string maLoai = cbo_LoaiSan.SelectedValue.ToString();
                if (KiemTraTrungTenSan(tenSan))
                    MessageBox.Show("Tên sân đã tồn tại!");
                else
                    SanDAO.Instance.ThemSan(tenSan, maLoai);
                txtMaSan.Clear();
                txtTenSan.Clear();
                cbo_LoaiSan.SelectedIndex = 0;
            }
            loadSan();
        }

        private bool KiemTraTrungTenSan(string tenSan)
        {
            return SanDAO.Instance.KiemTraTrungTenSan(tenSan);
        }

        private void dataGridView_San_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dataGridView_San.Rows[e.RowIndex];
                txtMaSan.Text = Convert.ToString(row.Cells["MaSan"].Value);
                txtTenSan.Text = Convert.ToString(row.Cells["TenSan"].Value);
                cbo_LoaiSan.SelectedValue = Convert.ToInt32(row.Cells["MaLoai"].Value);
            }
            catch
            {
                txtMaSan.Clear();
                txtTenSan.Clear();
                cbo_LoaiSan.SelectedIndex = 0;
            }
        }

        private void btn_XoaSan_Click(object sender, EventArgs e)
        {
            int maSan = 0;
            try
            {
                maSan = int.Parse(txtMaSan.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sân muốn xóa!");
            }
            if(maSan != 0)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa sân?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    List<LichDatSan> listLDSan = LichDatSanDAO.Instance.LoadListLoaiSan();
                    List<HoaDon> listHD = HoaDonDAO.Instance.LoadListHoaDon();
                    int flag = 0;
                    foreach (var item in listLDSan)
                    {
                        if (maSan == item.MaSan)
                        {
                            flag = 1;
                        }
                    }
                    foreach (var item in listHD)
                    {
                        if (maSan == item.MaSan)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        MessageBox.Show("Sân không thể xóa do đang có quản lý khác tham chiếu!");
                    } else
                    {
                        SanDAO.Instance.XoaSan(maSan);
                        txtMaSan.Clear();
                        txtTenSan.Clear();
                        cbo_LoaiSan.SelectedIndex = 0;
                    }
                    
                }
            }
            loadSan();
        }

        private void btn_SuaSan_Click(object sender, EventArgs e)
        {
            int maSan = 0;
            try
            {
                maSan = int.Parse(txtMaSan.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sân muốn sửa!");
            }
            if(maSan != 0)
            {
                string tenSan = txtTenSan.Text;
                int maLoai = int.Parse(cbo_LoaiSan.SelectedValue.ToString());
                SanDAO.Instance.SuaSan(maSan, tenSan, maLoai);
            }
            loadSan();
        }

        private void btn_TimKiemSan_Click(object sender, EventArgs e)
        {
            string tenSan = txt_TimKiemTenSan.Text;
            List<San> ListSan = SanDAO.Instance.TimKiemSan(tenSan);
            dataGridView_San.DataSource = ListSan;
        }

        private void loadLoaiSan()
        {
            List<LoaiSan> ListLoaiSan = LoaiSanDAO.Instance.LoadListLoaiSan();
            dataGridView_LoaiSan.DataSource = ListLoaiSan;
            cbo_LoaiSan.DataSource = ListLoaiSan;
            cbo_LoaiSan.DisplayMember = "TenLoai";
            cbo_LoaiSan.ValueMember = "MaLoai";
        }

        private void btnThemLoaiSan_Click(object sender, EventArgs e)
        {
            
            string tenLoai = txtTenLoai.Text;
            if(tenLoai == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại!");
            } else
            {
                double giaThue = 0;
                try
                {
                    giaThue = double.Parse(txtGiaThue.Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá thuê!");
                }
                if(giaThue != 0)
                {
                    if (KiemTraTrungTenLoai(tenLoai))
                        MessageBox.Show("Tên loại sân đã tồn tại!");
                    else
                        LoaiSanDAO.Instance.ThemLoaiSan(tenLoai, giaThue);
                    txtMaLoai.Clear();
                    txtTenLoai.Clear();
                    txtGiaThue.Clear();
                }
            }
            
            loadLoaiSan();
        }

        private bool KiemTraTrungTenLoai(string tenLoai)
        {
            return LoaiSanDAO.Instance.KiemTraTrungTenLoai(tenLoai);
        }

        private void btnXoaLoaiSan_Click(object sender, EventArgs e)
        {
            int maLoai = 0;
            try
            {
                maLoai = int.Parse(txtMaLoai.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại sân muốn xóa!");
            }
            if(maLoai != 0)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa loại sân này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    List<San> listSan = SanDAO.Instance.LoadListSan();
                    int flag = 0;
                    foreach (var item in listSan)
                    {
                        if (maLoai == item.MaLoai)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        MessageBox.Show("Loại sân không thể xóa do đang có quản lý khác tham chiếu!");
                    }
                    else
                    {
                        LoaiSanDAO.Instance.XoaLoaiSan(maLoai);
                        txtMaLoai.Clear();
                        txtTenLoai.Clear();
                        txtGiaThue.Clear();
                    }
                        
                }
                
            }
            loadLoaiSan();
        }

        private void btnSuaLoaiSan_Click(object sender, EventArgs e)
        {
            int maLoai = 0;
            try
            {
                maLoai = int.Parse(txtMaLoai.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại sân muốn sửa!");
            }
            if(maLoai != 0)
            {
                string tenLoai = txtTenLoai.Text;
                double giaThue = double.Parse(txtGiaThue.Text);
                LoaiSanDAO.Instance.SuaLoaiSan(maLoai, tenLoai, giaThue);
            }
            loadLoaiSan();
        }

        private void btnTimKiemLoaiSan_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTimKiemLoaiSan.Text;
            List<LoaiSan> ListLoaiSan = LoaiSanDAO.Instance.TimKiemLoaiSan(tenLoai);
            dataGridView_LoaiSan.DataSource = ListLoaiSan;
        }

        private void dataGridView_LoaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dataGridView_LoaiSan.Rows[e.RowIndex];
                txtMaLoai.Text = Convert.ToString(row.Cells["MaLoai"].Value);
                txtTenLoai.Text = Convert.ToString(row.Cells["TenLoai"].Value);
                txtGiaThue.Text = Convert.ToString(row.Cells["GiaThue"].Value);
            }
            catch
            {
                txtMaLoai.Clear();
                txtTenLoai.Clear();
                txtGiaThue.Clear();
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtMaSan.Text != "")
                btn_XoaSan_Click(sender, e);
            else
                btnXoaLoaiSan_Click(sender, e);
        }
    }
}
