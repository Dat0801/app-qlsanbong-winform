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
        private void loadLoaiSan()
        {
            List<LoaiSan> ListLoaiSan = LoaiSanDAO.Instance.LoadListLoaiSan();
            dataGridView_LoaiSan.DataSource = ListLoaiSan;
            cbo_LoaiSan.DataSource = ListLoaiSan;
            cbo_LoaiSan.DisplayMember = "TenLoai";
            cbo_LoaiSan.ValueMember = "MaLoai";
        }

        private void btn_ThemSan_Click(object sender, EventArgs e)
        {
            string tenSan = txtTenSan.Text;
            string maLoai = cbo_LoaiSan.SelectedValue.ToString();
            if (KiemTraTrungTenSan(tenSan))
                MessageBox.Show("Tên sân đã tồn tại!");
            else
                SanDAO.Instance.ThemSan(tenSan, maLoai);
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
            int maSan = int.Parse(txtMaSan.Text);
            SanDAO.Instance.XoaSan(maSan);
            loadSan();
        }

        private void btn_SuaSan_Click(object sender, EventArgs e)
        {
            int maSan = int.Parse(txtMaSan.Text);
            string tenSan = txtTenSan.Text;
            string maLoai = cbo_LoaiSan.SelectedValue.ToString();
            SanDAO.Instance.SuaSan(maSan, tenSan, maLoai);
            loadSan();
        }

        private void btn_TimKiemSan_Click(object sender, EventArgs e)
        {
            string tenSan = txt_TimKiemTenSan.Text;
            List<San> ListSan = SanDAO.Instance.TimKiemSan(tenSan);
            dataGridView_San.DataSource = ListSan;
        }
    }
}
