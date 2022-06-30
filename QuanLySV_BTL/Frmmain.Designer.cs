namespace QuanLySV_BTL
{
    partial class Frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_doimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_monhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_giaovien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_lophoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dangkymonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dkymonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tracuudiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanlylop = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.menu_quanly,
            this.menu_dangkymonhoc,
            this.menu_quanlylop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_doimatkhau,
            this.menu_thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // menu_doimatkhau
            // 
            this.menu_doimatkhau.Name = "menu_doimatkhau";
            this.menu_doimatkhau.Size = new System.Drawing.Size(146, 22);
            this.menu_doimatkhau.Text = "Đổi Mật Khẩu";
            // 
            // menu_thoat
            // 
            this.menu_thoat.Name = "menu_thoat";
            this.menu_thoat.Size = new System.Drawing.Size(146, 22);
            this.menu_thoat.Text = "Thoát";
            this.menu_thoat.Click += new System.EventHandler(this.menu_thoat_Click);
            // 
            // menu_quanly
            // 
            this.menu_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sinhvien,
            this.menu_monhoc,
            this.menu_giaovien,
            this.menu_lophoc});
            this.menu_quanly.Name = "menu_quanly";
            this.menu_quanly.Size = new System.Drawing.Size(62, 20);
            this.menu_quanly.Text = "Quản Lý";
            // 
            // menu_sinhvien
            // 
            this.menu_sinhvien.Name = "menu_sinhvien";
            this.menu_sinhvien.Size = new System.Drawing.Size(124, 22);
            this.menu_sinhvien.Text = "Sinh Viên";
            this.menu_sinhvien.Click += new System.EventHandler(this.menu_sinhvien_Click);
            // 
            // menu_monhoc
            // 
            this.menu_monhoc.Name = "menu_monhoc";
            this.menu_monhoc.Size = new System.Drawing.Size(124, 22);
            this.menu_monhoc.Text = "Môn Học";
            this.menu_monhoc.Click += new System.EventHandler(this.menu_monhoc_Click);
            // 
            // menu_giaovien
            // 
            this.menu_giaovien.Name = "menu_giaovien";
            this.menu_giaovien.Size = new System.Drawing.Size(124, 22);
            this.menu_giaovien.Text = "Giáo Viên";
            this.menu_giaovien.Click += new System.EventHandler(this.menu_giaovien_Click);
            // 
            // menu_lophoc
            // 
            this.menu_lophoc.Name = "menu_lophoc";
            this.menu_lophoc.Size = new System.Drawing.Size(124, 22);
            this.menu_lophoc.Text = "Lớp Học";
            this.menu_lophoc.Click += new System.EventHandler(this.menu_diemthi_Click);
            // 
            // menu_dangkymonhoc
            // 
            this.menu_dangkymonhoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dkymonhoc,
            this.menu_tracuudiem});
            this.menu_dangkymonhoc.Name = "menu_dangkymonhoc";
            this.menu_dangkymonhoc.Size = new System.Drawing.Size(79, 20);
            this.menu_dangkymonhoc.Text = "Chức Năng";
            this.menu_dangkymonhoc.Click += new System.EventHandler(this.menu_dangkymonhoc_Click);
            // 
            // menu_dkymonhoc
            // 
            this.menu_dkymonhoc.Name = "menu_dkymonhoc";
            this.menu_dkymonhoc.Size = new System.Drawing.Size(170, 22);
            this.menu_dkymonhoc.Text = "Đăng Ký Môn Học";
            this.menu_dkymonhoc.Click += new System.EventHandler(this.menu_dkymonhoc_Click);
            // 
            // menu_tracuudiem
            // 
            this.menu_tracuudiem.Name = "menu_tracuudiem";
            this.menu_tracuudiem.Size = new System.Drawing.Size(170, 22);
            this.menu_tracuudiem.Text = "Tra Cứu Điểm";
            this.menu_tracuudiem.Click += new System.EventHandler(this.menu_tracuudiem_Click);
            // 
            // menu_quanlylop
            // 
            this.menu_quanlylop.Name = "menu_quanlylop";
            this.menu_quanlylop.Size = new System.Drawing.Size(85, 20);
            this.menu_quanlylop.Text = "Quản Lý Lớp";
            this.menu_quanlylop.Click += new System.EventHandler(this.menu_quanlylop_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1146, 531);
            this.pnlContent.TabIndex = 1;
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Admin";
            this.Load += new System.EventHandler(this.Frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_doimatkhau;
        private System.Windows.Forms.ToolStripMenuItem menu_thoat;
        private System.Windows.Forms.ToolStripMenuItem menu_quanly;
        private System.Windows.Forms.ToolStripMenuItem menu_sinhvien;
        private System.Windows.Forms.ToolStripMenuItem menu_monhoc;
        private System.Windows.Forms.ToolStripMenuItem menu_giaovien;
        private System.Windows.Forms.ToolStripMenuItem menu_lophoc;
        private System.Windows.Forms.ToolStripMenuItem menu_dangkymonhoc;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem menu_quanlylop;
        private System.Windows.Forms.ToolStripMenuItem menu_dkymonhoc;
        private System.Windows.Forms.ToolStripMenuItem menu_tracuudiem;
    }
}

