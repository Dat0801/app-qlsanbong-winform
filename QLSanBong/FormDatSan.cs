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
            List<KhachHang> listKH = KhachHangDAO.Instance.LoadListKH();
            cbo_TenKH.DataSource = listKH;
            cbo_TenKH.DisplayMember = "TenKH";
            cbo_TenKH.ValueMember = "MaKH";
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
            }
        }

        private void btn_DatSan_Click(object sender, EventArgs e)
        {
            string thoiGianBD = dateTimePicker_NgayBD.Value.ToString();
            string thoiGianKT = dateTimePicker_NgayKT.Value.ToString();
            int maKH = int.Parse(cbo_TenKH.SelectedValue.ToString());
            int maSan = int.Parse(cbo_TenSan.SelectedValue.ToString());
            List<LichDatSan> listLDS = LichDatSanDAO.Instance.LoadListLoaiSan();
            int flag = 0;
            DateTime TGBD = DateTime.Parse(thoiGianBD);
            DateTime TGKT = DateTime.Parse(thoiGianKT);
            if (TGBD > TGKT)
                MessageBox.Show("Vui lòng nhập ngày bắt đầu nhỏ hơn hoặc bằng ngày kết thúc!");
            else
            {
                if (TGBD == TGKT)
                    flag = 1;
                foreach (var item in listLDS)
                {
                    if (item.MaSan == maSan && ((TGBD < item.ThoiGianBD && item.ThoiGianBD < TGKT) || (TGBD > item.ThoiGianBD && TGBD < item.ThoiGianKT)
                        || (TGBD == item.ThoiGianBD && TGKT == item.ThoiGianKT) || (TGBD == TGKT || TGBD == item.ThoiGianBD)))
                        flag = 1;
                }
                if (flag == 1)
                    MessageBox.Show("Sân đã được đặt trong thời gian trên!");
                else
                    LichDatSanDAO.Instance.ThemLichDatSan(thoiGianBD, thoiGianKT, maKH, maSan);
                loadLichDatSan();
            }
        }

        private void btn_TraSan_Click(object sender, EventArgs e)
        {
            int maLich = 0;
            try
            {
                 maLich = int.Parse(txtMaLich.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lịch muốn xóa!");
            }
            if(maLich != 0)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn trả sân?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    LichDatSanDAO.Instance.XoaLichDatSan(maLich);
                    txtMaLich.Clear();
                    cbo_TenSan.SelectedIndex = 0;
                    cbo_TenKH.SelectedIndex = 0;
                    TimeSpan timeDiff = dateTimePicker_NgayKT.Value - dateTimePicker_NgayBD.Value;
                    int TongPhut = (int)timeDiff.TotalMinutes;
                    MessageBox.Show("Tổng phút là: " + TongPhut);
                }
                
            }
            loadLichDatSan();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string thoiGianBD = dateTimePicker_NgayBD.Value.ToString();
            string thoiGianKT = dateTimePicker_NgayKT.Value.ToString();
            
            int maLich = 0;
            try
            {
                maLich = int.Parse(txtMaLich.Text);
            } 
            catch
            {
                MessageBox.Show("Vui lòng chọn lịch muốn sửa!");
            }
            if(maLich != 0)
            {
                int maKH = int.Parse(cbo_TenKH.SelectedValue.ToString());
                int maSan = int.Parse(cbo_TenSan.SelectedValue.ToString());
                List<LichDatSan> listLDS = LichDatSanDAO.Instance.LoadListLoaiSan();
                int flag = 0;
                DateTime TGBD = DateTime.Parse(thoiGianBD);
                DateTime TGKT = DateTime.Parse(thoiGianKT);
                if (TGBD > TGKT)
                    MessageBox.Show("Vui lòng nhập ngày bắt đầu nhỏ hơn hoặc bằng ngày kết thúc!");
                else
                {
                    if (TGBD == TGKT)
                        flag = 1;
                    foreach (var item in listLDS)
                    {
                        if (item.MaLich != maLich && item.MaSan == maSan && ((TGBD < item.ThoiGianBD && item.ThoiGianBD < TGKT) || (TGBD > item.ThoiGianBD && TGBD < item.ThoiGianKT)
                            || (TGBD == item.ThoiGianBD && TGKT == item.ThoiGianKT) || (TGBD == TGKT || TGBD == item.ThoiGianBD)))
                            flag = 1;
                    }
                    if (flag == 1)
                        MessageBox.Show("Sân đã được đặt trong thời gian trên!");
                    else
                        LichDatSanDAO.Instance.SuaLichDatSan(maLich, thoiGianBD, thoiGianKT, maKH, maSan);
                }
            }
            loadLichDatSan();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_TraSan_Click(sender,e);
        }
    }
}
