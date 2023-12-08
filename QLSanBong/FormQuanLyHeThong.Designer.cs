
namespace QLSanBong
{
    partial class FormQuanLyHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHeThong));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_QLTK = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cb_Quyen = new System.Windows.Forms.ComboBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenHT = new System.Windows.Forms.TextBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn__Sua = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimkiemTK = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_QLTK.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage_QLTK);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(56, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 764);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_QLTK
            // 
            this.tabPage_QLTK.Controls.Add(this.groupBox7);
            this.tabPage_QLTK.Controls.Add(this.groupBox8);
            this.tabPage_QLTK.Controls.Add(this.groupBox10);
            this.tabPage_QLTK.Location = new System.Drawing.Point(4, 29);
            this.tabPage_QLTK.Name = "tabPage_QLTK";
            this.tabPage_QLTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_QLTK.Size = new System.Drawing.Size(1244, 731);
            this.tabPage_QLTK.TabIndex = 0;
            this.tabPage_QLTK.Text = "Quản lý tài khoản";
            this.tabPage_QLTK.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView4);
            this.groupBox7.Location = new System.Drawing.Point(21, 93);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(682, 615);
            this.groupBox7.TabIndex = 61;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh sách";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 21);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(682, 594);
            this.dataGridView4.TabIndex = 4;
            this.dataGridView4.Click += new System.EventHandler(this.dataGridView4_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cb_Quyen);
            this.groupBox8.Controls.Add(this.txt_MK);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.txt_tenHT);
            this.groupBox8.Controls.Add(this.txt_TK);
            this.groupBox8.Controls.Add(this.btn_Them);
            this.groupBox8.Controls.Add(this.btn__Sua);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(720, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(504, 686);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin";
            // 
            // cb_Quyen
            // 
            this.cb_Quyen.FormattingEnabled = true;
            this.cb_Quyen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cb_Quyen.Location = new System.Drawing.Point(215, 330);
            this.cb_Quyen.Name = "cb_Quyen";
            this.cb_Quyen.Size = new System.Drawing.Size(210, 28);
            this.cb_Quyen.TabIndex = 62;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(215, 229);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(210, 28);
            this.txt_MK.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên hiển thị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tài khoản:";
            // 
            // txt_tenHT
            // 
            this.txt_tenHT.Location = new System.Drawing.Point(215, 281);
            this.txt_tenHT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenHT.Name = "txt_tenHT";
            this.txt_tenHT.Size = new System.Drawing.Size(210, 28);
            this.txt_tenHT.TabIndex = 56;
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(215, 169);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(210, 28);
            this.txt_TK.TabIndex = 55;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(70, 417);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(134, 69);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn__Sua
            // 
            this.btn__Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn__Sua.Image")));
            this.btn__Sua.Location = new System.Drawing.Point(291, 417);
            this.btn__Sua.Name = "btn__Sua";
            this.btn__Sua.Size = new System.Drawing.Size(134, 69);
            this.btn__Sua.TabIndex = 45;
            this.btn__Sua.Text = "Sửa";
            this.btn__Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn__Sua.UseVisualStyleBackColor = true;
            this.btn__Sua.Click += new System.EventHandler(this.btn__Sua_Click);
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
            this.groupBox10.Controls.Add(this.btn_TimKiem);
            this.groupBox10.Controls.Add(this.txt_TimkiemTK);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Location = new System.Drawing.Point(21, 22);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(682, 65);
            this.groupBox10.TabIndex = 59;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(470, 11);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(187, 54);
            this.btn_TimKiem.TabIndex = 15;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimkiemTK
            // 
            this.txt_TimkiemTK.Location = new System.Drawing.Point(226, 21);
            this.txt_TimkiemTK.Name = "txt_TimkiemTK";
            this.txt_TimkiemTK.Size = new System.Drawing.Size(215, 28);
            this.txt_TimkiemTK.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tài khoản";
            // 
            // FormQuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 774);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormQuanLyHeThong";
            this.Text = "FormQuanLyHeThong";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_QLTK.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_QLTK;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn__Sua;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimkiemTK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_Quyen;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenHT;
        private System.Windows.Forms.TextBox txt_TK;
    }
}