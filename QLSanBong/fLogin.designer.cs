namespace QL_SanBong
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.lb_MK = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lb_TenDN = new System.Windows.Forms.Label();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MK
            // 
            this.lb_MK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MK.AutoSize = true;
            this.lb_MK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MK.ForeColor = System.Drawing.Color.White;
            this.lb_MK.Location = new System.Drawing.Point(58, 445);
            this.lb_MK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MK.Name = "lb_MK";
            this.lb_MK.Size = new System.Drawing.Size(93, 22);
            this.lb_MK.TabIndex = 3;
            this.lb_MK.Text = "Mật Khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(227, 381);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 22);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(227, 445);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lb_TenDN
            // 
            this.lb_TenDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenDN.AutoSize = true;
            this.lb_TenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDN.ForeColor = System.Drawing.Color.White;
            this.lb_TenDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_TenDN.Location = new System.Drawing.Point(58, 381);
            this.lb_TenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenDN.Name = "lb_TenDN";
            this.lb_TenDN.Size = new System.Drawing.Size(130, 22);
            this.lb_TenDN.TabIndex = 2;
            this.lb_TenDN.Text = "Tên đăng nhập:";
            // 
            // chk_remember
            // 
            this.chk_remember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_remember.AutoSize = true;
            this.chk_remember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_remember.ForeColor = System.Drawing.Color.White;
            this.chk_remember.Location = new System.Drawing.Point(62, 490);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(100, 26);
            this.chk_remember.TabIndex = 21;
            this.chk_remember.Text = "Ghi nhớ ";
            this.chk_remember.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.Location = new System.Drawing.Point(358, 534);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(166, 50);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.Image")));
            this.btn_DangNhap.Location = new System.Drawing.Point(62, 534);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(166, 50);
            this.btn_DangNhap.TabIndex = 19;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QLSanBong.Properties.Resources.chan_thuong_bong_da_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(595, 594);
            this.Controls.Add(this.chk_remember);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_MK);
            this.Controls.Add(this.lb_TenDN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_TenDN;
        private System.Windows.Forms.Label lb_MK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.CheckBox chk_remember;
    }
}