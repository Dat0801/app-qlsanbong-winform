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
        }

        private void loadSan()
        {
            List<San> ListSan = SanDAO.Instance.LoadListSan();
            dataGridView_San.DataSource = ListSan;
        }

    }
}
