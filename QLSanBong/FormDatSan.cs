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
    public partial class FormDatSan : Form
    {
        public FormDatSan()
        {
            InitializeComponent();
            loadSan();
            loadLichDatSan();
        }
        private void loadSan()
        {
            List<San> ListSan = SanDAO.Instance.LoadListSan();
            cbo_TenSan.DataSource = ListSan;
            cbo_TenSan.DisplayMember = "TenSan";
            cbo_TenSan.ValueMember = "MaSan";
            foreach (San item in ListSan)
            {
                Button btn = new Button() { Width = SanDAO.SanWidth, Height = SanDAO.SanHeight };
                btn.Text = item.TenSan;
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.Font = new System.Drawing.Font("Times New Roman",14,FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.BackgroundImage = QLSanBong.Properties.Resources.san;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                flpSan.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            San san = (sender as Button).Tag as San;
            cbo_TenSan.SelectedValue = san.MaSan;
            List<LoaiSan> ListLoaiSan = LoaiSanDAO.Instance.LoadListLoaiSan();
            foreach (var item in ListLoaiSan) 
            {
                if (san.MaLoai == item.MaLoai)
                    txt_DonGia.Text = item.GiaThue.ToString();
            }
        }

        private void cbo_TenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_TenSan.ValueMember = "MaSan";
            List<San> ListSan = SanDAO.Instance.LoadListSan();
            int maSan = int.Parse(cbo_TenSan.SelectedValue.ToString());
            San san = new San(); 
            foreach (var item in ListSan)
            {
                if (maSan == item.MaSan)
                    san = item;
            }
            List<LoaiSan> ListLoaiSan = LoaiSanDAO.Instance.LoadListLoaiSan();
            foreach (var item in ListLoaiSan)
            {
                if (san.MaLoai == item.MaLoai)
                    txt_DonGia.Text = item.GiaThue.ToString();
            }
        }

        private void loadLichDatSan()
        {
            List<LichDatSan> ListLichDatSan = LichDatSanDAO.Instance.LoadListLoaiSan();
            dataGridView_LichDatSan.DataSource = ListLichDatSan;
        }

        private void dataGridView_LichDatSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dataGridView_LichDatSan.Rows[e.RowIndex];
                txtMaLich.Text = Convert.ToString(row.Cells["MaLich"].Value);
                dateTimePicker_NgayBD.Value = Convert.ToDateTime(row.Cells["ThoiGianBD"].Value);
                dateTimePicker_NgayKT.Value = Convert.ToDateTime(row.Cells["ThoiGianKT"].Value);
                cbo_TenSan.SelectedValue = Convert.ToInt32(row.Cells["MaSan"].Value);
                cbo_TenKH.SelectedValue = Convert.ToInt32(row.Cells["MaKH"].Value);
            }
            catch
            {
                txtMaLich.Clear();
                cbo_TenSan.SelectedIndex = 0;
                txt_DonGia.Clear();
            }
        }

        private void btn_DatSan_Click(object sender, EventArgs e)
        {
            string thoiGianBD = dateTimePicker_NgayBD.Value.ToString();
            string thoiGianKT = dateTimePicker_NgayKT.Value.ToString();
            int maKH = int.Parse(cbo_TenKH.SelectedValue.ToString());
            int maSan = int.Parse(cbo_TenSan.SelectedValue.ToString());
            LichDatSanDAO.Instance.ThemLichDatSan(thoiGianBD, thoiGianKT, maKH, maSan);
            loadLichDatSan();
        }

        private void FormDatSan_Load(object sender, EventArgs e)
        {

        }
    }
}
