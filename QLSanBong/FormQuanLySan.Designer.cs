
namespace QLSanBong
{
    partial class FormQuanLySan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySan));
            this.tab_QLLoaiSan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_LoaiSan = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_QuanLySan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemLoaiSan = new System.Windows.Forms.Button();
            this.btnSuaLoaiSan = new System.Windows.Forms.Button();
            this.btnXoaLoaiSan = new System.Windows.Forms.Button();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLoaiSan = new System.Windows.Forms.Button();
            this.txtTimKiemLoaiSan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_DSSan = new System.Windows.Forms.GroupBox();
            this.dataGridView_San = new System.Windows.Forms.DataGridView();
            this.groupBox_ThongTinSan = new System.Windows.Forms.GroupBox();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemSan = new System.Windows.Forms.Button();
            this.btn_SuaSan = new System.Windows.Forms.Button();
            this.btn_XoaSan = new System.Windows.Forms.Button();
            this.cbo_LoaiSan = new System.Windows.Forms.ComboBox();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox_TimKiemSan = new System.Windows.Forms.GroupBox();
            this.btn_TimKiemSan = new System.Windows.Forms.Button();
            this.txt_TimKiemTenSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_QLSan = new System.Windows.Forms.TabControl();
            this.tab_QLLoaiSan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiSan)).BeginInit();
            this.contextMenuStrip_QuanLySan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_DSSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_San)).BeginInit();
            this.groupBox_ThongTinSan.SuspendLayout();
            this.groupBox_TimKiemSan.SuspendLayout();
            this.tab_QLSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_QLLoaiSan
            // 
            this.tab_QLLoaiSan.Controls.Add(this.groupBox1);
            this.tab_QLLoaiSan.Controls.Add(this.groupBox2);
            this.tab_QLLoaiSan.Controls.Add(this.groupBox5);
            this.tab_QLLoaiSan.Location = new System.Drawing.Point(4, 29);
            this.tab_QLLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_QLLoaiSan.Name = "tab_QLLoaiSan";
            this.tab_QLLoaiSan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_QLLoaiSan.Size = new System.Drawing.Size(1248, 726);
            this.tab_QLLoaiSan.TabIndex = 1;
            this.tab_QLLoaiSan.Text = "Quản lý loại sân";
            this.tab_QLLoaiSan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_LoaiSan);
            this.groupBox1.Location = new System.Drawing.Point(23, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(683, 615);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dataGridView_LoaiSan
            // 
            this.dataGridView_LoaiSan.AllowUserToAddRows = false;
            this.dataGridView_LoaiSan.AllowUserToDeleteRows = false;
            this.dataGridView_LoaiSan.AllowUserToResizeColumns = false;
            this.dataGridView_LoaiSan.AllowUserToResizeRows = false;
            this.dataGridView_LoaiSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiSan.ContextMenuStrip = this.contextMenuStrip_QuanLySan;
            this.dataGridView_LoaiSan.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_LoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_LoaiSan.Name = "dataGridView_LoaiSan";
            this.dataGridView_LoaiSan.RowHeadersWidth = 51;
            this.dataGridView_LoaiSan.RowTemplate.Height = 24;
            this.dataGridView_LoaiSan.Size = new System.Drawing.Size(683, 594);
            this.dataGridView_LoaiSan.TabIndex = 4;
            this.dataGridView_LoaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LoaiSan_CellClick);
            // 
            // contextMenuStrip_QuanLySan
            // 
            this.contextMenuStrip_QuanLySan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_QuanLySan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip_QuanLySan.Name = "contextMenuStrip_QuanLySan";
            this.contextMenuStrip_QuanLySan.Size = new System.Drawing.Size(105, 28);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaLoai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnThemLoaiSan);
            this.groupBox2.Controls.Add(this.btnSuaLoaiSan);
            this.groupBox2.Controls.Add(this.btnXoaLoaiSan);
            this.groupBox2.Controls.Add(this.txtGiaThue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenLoai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(723, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(504, 686);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(169, 202);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(261, 28);
            this.txtMaLoai.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mã loại:";
            // 
            // btnThemLoaiSan
            // 
            this.btnThemLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSan.Image")));
            this.btnThemLoaiSan.Location = new System.Drawing.Point(23, 418);
            this.btnThemLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemLoaiSan.Name = "btnThemLoaiSan";
            this.btnThemLoaiSan.Size = new System.Drawing.Size(133, 69);
            this.btnThemLoaiSan.TabIndex = 49;
            this.btnThemLoaiSan.Text = "Thêm";
            this.btnThemLoaiSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLoaiSan.UseVisualStyleBackColor = true;
            this.btnThemLoaiSan.Click += new System.EventHandler(this.btnThemLoaiSan_Click);
            // 
            // btnSuaLoaiSan
            // 
            this.btnSuaLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiSan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLoaiSan.Image")));
            this.btnSuaLoaiSan.Location = new System.Drawing.Point(343, 418);
            this.btnSuaLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaLoaiSan.Name = "btnSuaLoaiSan";
            this.btnSuaLoaiSan.Size = new System.Drawing.Size(133, 69);
            this.btnSuaLoaiSan.TabIndex = 48;
            this.btnSuaLoaiSan.Text = "Sửa";
            this.btnSuaLoaiSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaLoaiSan.UseVisualStyleBackColor = true;
            this.btnSuaLoaiSan.Click += new System.EventHandler(this.btnSuaLoaiSan_Click);
            // 
            // btnXoaLoaiSan
            // 
            this.btnXoaLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiSan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLoaiSan.Image")));
            this.btnXoaLoaiSan.Location = new System.Drawing.Point(181, 418);
            this.btnXoaLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaLoaiSan.Name = "btnXoaLoaiSan";
            this.btnXoaLoaiSan.Size = new System.Drawing.Size(133, 69);
            this.btnXoaLoaiSan.TabIndex = 47;
            this.btnXoaLoaiSan.Text = "Xóa";
            this.btnXoaLoaiSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaLoaiSan.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSan.Click += new System.EventHandler(this.btnXoaLoaiSan_Click);
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(169, 329);
            this.txtGiaThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(261, 28);
            this.txtGiaThue.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Giá thuê";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(169, 268);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(261, 28);
            this.txtTenLoai.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên loại:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(587, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(628, 65);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTimKiemLoaiSan);
            this.groupBox5.Controls.Add(this.txtTimKiemLoaiSan);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(23, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(683, 65);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // btnTimKiemLoaiSan
            // 
            this.btnTimKiemLoaiSan.BackColor = System.Drawing.Color.White;
            this.btnTimKiemLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLoaiSan.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemLoaiSan.Image")));
            this.btnTimKiemLoaiSan.Location = new System.Drawing.Point(455, 11);
            this.btnTimKiemLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemLoaiSan.Name = "btnTimKiemLoaiSan";
            this.btnTimKiemLoaiSan.Size = new System.Drawing.Size(187, 54);
            this.btnTimKiemLoaiSan.TabIndex = 15;
            this.btnTimKiemLoaiSan.Text = "Tìm kiếm";
            this.btnTimKiemLoaiSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemLoaiSan.UseVisualStyleBackColor = false;
            this.btnTimKiemLoaiSan.Click += new System.EventHandler(this.btnTimKiemLoaiSan_Click);
            // 
            // txtTimKiemLoaiSan
            // 
            this.txtTimKiemLoaiSan.Location = new System.Drawing.Point(203, 25);
            this.txtTimKiemLoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemLoaiSan.Name = "txtTimKiemLoaiSan";
            this.txtTimKiemLoaiSan.Size = new System.Drawing.Size(215, 28);
            this.txtTimKiemLoaiSan.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên loại sân";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_DSSan);
            this.tabPage1.Controls.Add(this.groupBox_ThongTinSan);
            this.tabPage1.Controls.Add(this.groupBox_TimKiemSan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1248, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_DSSan
            // 
            this.groupBox_DSSan.Controls.Add(this.dataGridView_San);
            this.groupBox_DSSan.Location = new System.Drawing.Point(29, 95);
            this.groupBox_DSSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_DSSan.Name = "groupBox_DSSan";
            this.groupBox_DSSan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_DSSan.Size = new System.Drawing.Size(715, 615);
            this.groupBox_DSSan.TabIndex = 3;
            this.groupBox_DSSan.TabStop = false;
            this.groupBox_DSSan.Text = "Danh sách";
            // 
            // dataGridView_San
            // 
            this.dataGridView_San.AllowUserToAddRows = false;
            this.dataGridView_San.AllowUserToDeleteRows = false;
            this.dataGridView_San.AllowUserToOrderColumns = true;
            this.dataGridView_San.AllowUserToResizeColumns = false;
            this.dataGridView_San.AllowUserToResizeRows = false;
            this.dataGridView_San.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_San.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_San.ContextMenuStrip = this.contextMenuStrip_QuanLySan;
            this.dataGridView_San.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_San.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_San.Name = "dataGridView_San";
            this.dataGridView_San.RowHeadersWidth = 51;
            this.dataGridView_San.RowTemplate.Height = 24;
            this.dataGridView_San.Size = new System.Drawing.Size(715, 594);
            this.dataGridView_San.TabIndex = 4;
            this.dataGridView_San.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_San_CellClick);
            // 
            // groupBox_ThongTinSan
            // 
            this.groupBox_ThongTinSan.Controls.Add(this.txtMaSan);
            this.groupBox_ThongTinSan.Controls.Add(this.label3);
            this.groupBox_ThongTinSan.Controls.Add(this.btn_ThemSan);
            this.groupBox_ThongTinSan.Controls.Add(this.btn_SuaSan);
            this.groupBox_ThongTinSan.Controls.Add(this.btn_XoaSan);
            this.groupBox_ThongTinSan.Controls.Add(this.cbo_LoaiSan);
            this.groupBox_ThongTinSan.Controls.Add(this.txtTenSan);
            this.groupBox_ThongTinSan.Controls.Add(this.label10);
            this.groupBox_ThongTinSan.Controls.Add(this.label11);
            this.groupBox_ThongTinSan.Controls.Add(this.groupBox4);
            this.groupBox_ThongTinSan.Location = new System.Drawing.Point(767, 25);
            this.groupBox_ThongTinSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ThongTinSan.Name = "groupBox_ThongTinSan";
            this.groupBox_ThongTinSan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ThongTinSan.Size = new System.Drawing.Size(453, 686);
            this.groupBox_ThongTinSan.TabIndex = 2;
            this.groupBox_ThongTinSan.TabStop = false;
            this.groupBox_ThongTinSan.Text = "Thông tin";
            // 
            // txtMaSan
            // 
            this.txtMaSan.Location = new System.Drawing.Point(133, 218);
            this.txtMaSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.ReadOnly = true;
            this.txtMaSan.Size = new System.Drawing.Size(261, 28);
            this.txtMaSan.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã sân:";
            // 
            // btn_ThemSan
            // 
            this.btn_ThemSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemSan.Image")));
            this.btn_ThemSan.Location = new System.Drawing.Point(0, 453);
            this.btn_ThemSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemSan.Name = "btn_ThemSan";
            this.btn_ThemSan.Size = new System.Drawing.Size(133, 69);
            this.btn_ThemSan.TabIndex = 49;
            this.btn_ThemSan.Text = "Thêm";
            this.btn_ThemSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemSan.UseVisualStyleBackColor = true;
            this.btn_ThemSan.Click += new System.EventHandler(this.btn_ThemSan_Click);
            // 
            // btn_SuaSan
            // 
            this.btn_SuaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSan.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaSan.Image")));
            this.btn_SuaSan.Location = new System.Drawing.Point(320, 453);
            this.btn_SuaSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaSan.Name = "btn_SuaSan";
            this.btn_SuaSan.Size = new System.Drawing.Size(133, 69);
            this.btn_SuaSan.TabIndex = 48;
            this.btn_SuaSan.Text = "Sửa";
            this.btn_SuaSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SuaSan.UseVisualStyleBackColor = true;
            this.btn_SuaSan.Click += new System.EventHandler(this.btn_SuaSan_Click);
            // 
            // btn_XoaSan
            // 
            this.btn_XoaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSan.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaSan.Image")));
            this.btn_XoaSan.Location = new System.Drawing.Point(157, 453);
            this.btn_XoaSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaSan.Name = "btn_XoaSan";
            this.btn_XoaSan.Size = new System.Drawing.Size(133, 69);
            this.btn_XoaSan.TabIndex = 47;
            this.btn_XoaSan.Text = "Xóa";
            this.btn_XoaSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_XoaSan.UseVisualStyleBackColor = true;
            this.btn_XoaSan.Click += new System.EventHandler(this.btn_XoaSan_Click);
            // 
            // cbo_LoaiSan
            // 
            this.cbo_LoaiSan.FormattingEnabled = true;
            this.cbo_LoaiSan.Location = new System.Drawing.Point(133, 357);
            this.cbo_LoaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LoaiSan.Name = "cbo_LoaiSan";
            this.cbo_LoaiSan.Size = new System.Drawing.Size(261, 28);
            this.cbo_LoaiSan.TabIndex = 39;
            // 
            // txtTenSan
            // 
            this.txtTenSan.Location = new System.Drawing.Point(133, 286);
            this.txtTenSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(261, 28);
            this.txtTenSan.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tên sân:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Loại sân:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(587, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(628, 65);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox_TimKiemSan
            // 
            this.groupBox_TimKiemSan.Controls.Add(this.btn_TimKiemSan);
            this.groupBox_TimKiemSan.Controls.Add(this.txt_TimKiemTenSan);
            this.groupBox_TimKiemSan.Controls.Add(this.label1);
            this.groupBox_TimKiemSan.Location = new System.Drawing.Point(29, 25);
            this.groupBox_TimKiemSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TimKiemSan.Name = "groupBox_TimKiemSan";
            this.groupBox_TimKiemSan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_TimKiemSan.Size = new System.Drawing.Size(715, 65);
            this.groupBox_TimKiemSan.TabIndex = 0;
            this.groupBox_TimKiemSan.TabStop = false;
            this.groupBox_TimKiemSan.Text = "Tìm kiếm";
            // 
            // btn_TimKiemSan
            // 
            this.btn_TimKiemSan.BackColor = System.Drawing.Color.White;
            this.btn_TimKiemSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemSan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemSan.Image")));
            this.btn_TimKiemSan.Location = new System.Drawing.Point(456, 11);
            this.btn_TimKiemSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiemSan.Name = "btn_TimKiemSan";
            this.btn_TimKiemSan.Size = new System.Drawing.Size(187, 54);
            this.btn_TimKiemSan.TabIndex = 14;
            this.btn_TimKiemSan.Text = "Tìm kiếm";
            this.btn_TimKiemSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiemSan.UseVisualStyleBackColor = false;
            this.btn_TimKiemSan.Click += new System.EventHandler(this.btn_TimKiemSan_Click);
            // 
            // txt_TimKiemTenSan
            // 
            this.txt_TimKiemTenSan.Location = new System.Drawing.Point(207, 25);
            this.txt_TimKiemTenSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiemTenSan.Name = "txt_TimKiemTenSan";
            this.txt_TimKiemTenSan.Size = new System.Drawing.Size(215, 28);
            this.txt_TimKiemTenSan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sân";
            // 
            // tab_QLSan
            // 
            this.tab_QLSan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_QLSan.Controls.Add(this.tabPage1);
            this.tab_QLSan.Controls.Add(this.tab_QLLoaiSan);
            this.tab_QLSan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_QLSan.Location = new System.Drawing.Point(37, 10);
            this.tab_QLSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_QLSan.Multiline = true;
            this.tab_QLSan.Name = "tab_QLSan";
            this.tab_QLSan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_QLSan.SelectedIndex = 0;
            this.tab_QLSan.Size = new System.Drawing.Size(1256, 759);
            this.tab_QLSan.TabIndex = 0;
            // 
            // FormQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 750);
            this.Controls.Add(this.tab_QLSan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLySan";
            this.Text = "FormQuanLySan";
            this.tab_QLLoaiSan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiSan)).EndInit();
            this.contextMenuStrip_QuanLySan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox_DSSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_San)).EndInit();
            this.groupBox_ThongTinSan.ResumeLayout(false);
            this.groupBox_ThongTinSan.PerformLayout();
            this.groupBox_TimKiemSan.ResumeLayout(false);
            this.groupBox_TimKiemSan.PerformLayout();
            this.tab_QLSan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_QLLoaiSan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox_ThongTinSan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_TimKiemSan;
        private System.Windows.Forms.TabControl tab_QLSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TimKiemTenSan;
        private System.Windows.Forms.GroupBox groupBox_DSSan;
        private System.Windows.Forms.DataGridView dataGridView_San;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_LoaiSan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimKiemLoaiSan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_LoaiSan;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemLoaiSan;
        private System.Windows.Forms.Button btnSuaLoaiSan;
        private System.Windows.Forms.Button btnXoaLoaiSan;
        private System.Windows.Forms.Button btn_ThemSan;
        private System.Windows.Forms.Button btn_SuaSan;
        private System.Windows.Forms.Button btn_XoaSan;
        private System.Windows.Forms.Button btn_TimKiemSan;
        private System.Windows.Forms.Button btnTimKiemLoaiSan;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_QuanLySan;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}