namespace QuanLySV_BTL
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_loaitaikhoan = new System.Windows.Forms.ComboBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Tài Khoản";
            // 
            // cbb_loaitaikhoan
            // 
            this.cbb_loaitaikhoan.FormattingEnabled = true;
            this.cbb_loaitaikhoan.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Giáo Viên",
            "Sinh Viên"});
            this.cbb_loaitaikhoan.Location = new System.Drawing.Point(124, 35);
            this.cbb_loaitaikhoan.Name = "cbb_loaitaikhoan";
            this.cbb_loaitaikhoan.Size = new System.Drawing.Size(194, 21);
            this.cbb_loaitaikhoan.TabIndex = 1;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(98, 196);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(124, 83);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(194, 20);
            this.txt_tendangnhap.TabIndex = 7;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(124, 133);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(194, 20);
            this.txt_matkhau.TabIndex = 8;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(202, 196);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 274);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.cbb_loaitaikhoan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_loaitaikhoan;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_thoat;
    }
}