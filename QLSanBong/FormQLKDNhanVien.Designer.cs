
namespace QLSanBong
{
    partial class FormQLKDNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKDNhanVien));
            this.tab_QLKH = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView_DSKH = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemTenKH = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tab_HoaDon = new System.Windows.Forms.TabPage();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.txt_Dongia = new System.Windows.Forms.TextBox();
            this.txt_PhutDa = new System.Windows.Forms.TextBox();
            this.txt_MaSan = new System.Windows.Forms.TextBox();
            this.cbo_MAKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_hoadon = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.tab_QLKinhDoanh = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.tab_QLKH.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSKH)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tab_HoaDon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.tab_QLKinhDoanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_QLKH
            // 
            this.tab_QLKH.Controls.Add(this.groupBox7);
            this.tab_QLKH.Controls.Add(this.groupBox8);
            this.tab_QLKH.Controls.Add(this.groupBox10);
            this.tab_QLKH.Location = new System.Drawing.Point(4, 29);
            this.tab_QLKH.Name = "tab_QLKH";
            this.tab_QLKH.Size = new System.Drawing.Size(1253, 727);
            this.tab_QLKH.TabIndex = 3;
            this.tab_QLKH.Text = "Quản lý khách hàng";
            this.tab_QLKH.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView_DSKH);
            this.groupBox7.Location = new System.Drawing.Point(25, 91);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(682, 615);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh sách";
            // 
            // dataGridView_DSKH
            // 
            this.dataGridView_DSKH.AllowUserToAddRows = false;
            this.dataGridView_DSKH.AllowUserToDeleteRows = false;
            this.dataGridView_DSKH.AllowUserToResizeColumns = false;
            this.dataGridView_DSKH.AllowUserToResizeRows = false;
            this.dataGridView_DSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSKH.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_DSKH.Name = "dataGridView_DSKH";
            this.dataGridView_DSKH.RowHeadersWidth = 51;
            this.dataGridView_DSKH.RowTemplate.Height = 24;
            this.dataGridView_DSKH.Size = new System.Drawing.Size(682, 594);
            this.dataGridView_DSKH.TabIndex = 4;
            this.dataGridView_DSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSKH_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.txtMaKH);
            this.groupBox8.Controls.Add(this.txt_SDT);
            this.groupBox8.Controls.Add(this.txt_DiaChi);
            this.groupBox8.Controls.Add(this.lb_SDT);
            this.groupBox8.Controls.Add(this.lb_DiaChi);
            this.groupBox8.Controls.Add(this.lb_TenKH);
            this.groupBox8.Controls.Add(this.txt_TenKH);
            this.groupBox8.Controls.Add(this.btnThem);
            this.groupBox8.Controls.Add(this.btnSua);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(724, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(504, 686);
            this.groupBox8.TabIndex = 57;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(222, 348);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(210, 28);
            this.txt_SDT.TabIndex = 62;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(222, 302);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(210, 28);
            this.txt_DiaChi.TabIndex = 61;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(73, 357);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(123, 21);
            this.lb_SDT.TabIndex = 60;
            this.lb_SDT.Text = "Số Điện Thoại:";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(73, 305);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(69, 21);
            this.lb_DiaChi.TabIndex = 59;
            this.lb_DiaChi.Text = "Địa chỉ:";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(73, 252);
            this.lb_TenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(140, 21);
            this.lb_TenKH.TabIndex = 58;
            this.lb_TenKH.Text = "Tên Khách Hàng:";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(222, 249);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(210, 28);
            this.txt_TenKH.TabIndex = 56;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(79, 408);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 69);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(298, 408);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 69);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(587, 11);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(628, 65);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnTimKiem);
            this.groupBox10.Controls.Add(this.txtTimKiemTenKH);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Location = new System.Drawing.Point(25, 20);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(682, 65);
            this.groupBox10.TabIndex = 56;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(470, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(187, 54);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txtTimKiemTenKH
            // 
            this.txtTimKiemTenKH.Location = new System.Drawing.Point(226, 21);
            this.txtTimKiemTenKH.Name = "txtTimKiemTenKH";
            this.txtTimKiemTenKH.Size = new System.Drawing.Size(215, 28);
            this.txtTimKiemTenKH.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên khách hàng";
            // 
            // tab_HoaDon
            // 
            this.tab_HoaDon.Controls.Add(this.txt_MaHD);
            this.tab_HoaDon.Controls.Add(this.label14);
            this.tab_HoaDon.Controls.Add(this.button3);
            this.tab_HoaDon.Controls.Add(this.btnXoa);
            this.tab_HoaDon.Controls.Add(this.dateTimePicker_NgayBD);
            this.tab_HoaDon.Controls.Add(this.txt_Tongtien);
            this.tab_HoaDon.Controls.Add(this.txt_Dongia);
            this.tab_HoaDon.Controls.Add(this.txt_PhutDa);
            this.tab_HoaDon.Controls.Add(this.txt_MaSan);
            this.tab_HoaDon.Controls.Add(this.cbo_MAKH);
            this.tab_HoaDon.Controls.Add(this.label7);
            this.tab_HoaDon.Controls.Add(this.label8);
            this.tab_HoaDon.Controls.Add(this.label9);
            this.tab_HoaDon.Controls.Add(this.label10);
            this.tab_HoaDon.Controls.Add(this.label11);
            this.tab_HoaDon.Controls.Add(this.label12);
            this.tab_HoaDon.Controls.Add(this.panel1);
            this.tab_HoaDon.Controls.Add(this.dgv_HoaDon);
            this.tab_HoaDon.Location = new System.Drawing.Point(4, 29);
            this.tab_HoaDon.Name = "tab_HoaDon";
            this.tab_HoaDon.Size = new System.Drawing.Size(1253, 727);
            this.tab_HoaDon.TabIndex = 2;
            this.tab_HoaDon.Text = "Hóa đơn";
            this.tab_HoaDon.UseVisualStyleBackColor = true;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHD.Location = new System.Drawing.Point(409, 126);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(178, 28);
            this.txt_MaHD.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(267, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Mã Hóa đơn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(997, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 70);
            this.button3.TabIndex = 43;
            this.button3.Text = "Sửa";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_SuaHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(997, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 61);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dateTimePicker_NgayBD
            // 
            this.dateTimePicker_NgayBD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_NgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayBD.Location = new System.Drawing.Point(409, 160);
            this.dateTimePicker_NgayBD.Name = "dateTimePicker_NgayBD";
            this.dateTimePicker_NgayBD.Size = new System.Drawing.Size(178, 28);
            this.dateTimePicker_NgayBD.TabIndex = 41;
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Tongtien.Location = new System.Drawing.Point(812, 151);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(100, 28);
            this.txt_Tongtien.TabIndex = 24;
            // 
            // txt_Dongia
            // 
            this.txt_Dongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dongia.Location = new System.Drawing.Point(812, 110);
            this.txt_Dongia.Name = "txt_Dongia";
            this.txt_Dongia.ReadOnly = true;
            this.txt_Dongia.Size = new System.Drawing.Size(100, 28);
            this.txt_Dongia.TabIndex = 23;
            // 
            // txt_PhutDa
            // 
            this.txt_PhutDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhutDa.Location = new System.Drawing.Point(812, 71);
            this.txt_PhutDa.Name = "txt_PhutDa";
            this.txt_PhutDa.Size = new System.Drawing.Size(100, 28);
            this.txt_PhutDa.TabIndex = 22;
            // 
            // txt_MaSan
            // 
            this.txt_MaSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaSan.Location = new System.Drawing.Point(409, 92);
            this.txt_MaSan.Name = "txt_MaSan";
            this.txt_MaSan.Size = new System.Drawing.Size(178, 28);
            this.txt_MaSan.TabIndex = 20;
            // 
            // cbo_MAKH
            // 
            this.cbo_MAKH.FormattingEnabled = true;
            this.cbo_MAKH.Location = new System.Drawing.Point(409, 55);
            this.cbo_MAKH.Name = "cbo_MAKH";
            this.cbo_MAKH.Size = new System.Drawing.Size(178, 28);
            this.cbo_MAKH.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(678, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng tiền HĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(678, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(678, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng phút đá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ngày lập HĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(266, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mã sân";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(266, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lb_hoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 49);
            this.panel1.TabIndex = 10;
            // 
            // lb_hoadon
            // 
            this.lb_hoadon.AutoSize = true;
            this.lb_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoadon.ForeColor = System.Drawing.Color.White;
            this.lb_hoadon.Location = new System.Drawing.Point(537, 10);
            this.lb_hoadon.Name = "lb_hoadon";
            this.lb_hoadon.Size = new System.Drawing.Size(219, 29);
            this.lb_hoadon.TabIndex = 9;
            this.lb_hoadon.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lb_hoadon.UseCompatibleTextRendering = true;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.AllowUserToDeleteRows = false;
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(28, 202);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1196, 504);
            this.dgv_HoaDon.TabIndex = 7;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // tab_QLKinhDoanh
            // 
            this.tab_QLKinhDoanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_QLKinhDoanh.Controls.Add(this.tab_HoaDon);
            this.tab_QLKinhDoanh.Controls.Add(this.tab_QLKH);
            this.tab_QLKinhDoanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_QLKinhDoanh.Location = new System.Drawing.Point(66, -2);
            this.tab_QLKinhDoanh.Multiline = true;
            this.tab_QLKinhDoanh.Name = "tab_QLKinhDoanh";
            this.tab_QLKinhDoanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_QLKinhDoanh.SelectedIndex = 0;
            this.tab_QLKinhDoanh.Size = new System.Drawing.Size(1261, 760);
            this.tab_QLKinhDoanh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(223, 203);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(209, 28);
            this.txtMaKH.TabIndex = 66;
            // 
            // FormQLKDNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 756);
            this.Controls.Add(this.tab_QLKinhDoanh);
            this.Name = "FormQLKDNhanVien";
            this.Text = "FormQLKDNhanVien";
            this.tab_QLKH.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSKH)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tab_HoaDon.ResumeLayout(false);
            this.tab_HoaDon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.tab_QLKinhDoanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_QLKH;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView_DSKH;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemTenKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tab_HoaDon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBD;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.TextBox txt_Dongia;
        private System.Windows.Forms.TextBox txt_PhutDa;
        private System.Windows.Forms.TextBox txt_MaSan;
        private System.Windows.Forms.ComboBox cbo_MAKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_hoadon;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.TabControl tab_QLKinhDoanh;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}