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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDatSan());
        }

        private void btnQuanLySan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLySan());
        }

        private void btnQLKinhDoanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKinhDoanh());
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyHeThong());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
