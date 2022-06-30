namespace QuanLySV_BTL
{
    partial class FrmDanhSachGiaoVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(456, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh Sách Giáo Viên";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themmoi.Location = new System.Drawing.Point(1005, 72);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themmoi.TabIndex = 10;
            this.btn_themmoi.Text = "Thêm Mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(898, 72);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(726, 72);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(152, 20);
            this.txt_tukhoa.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ Khóa";
            // 
            // dgv_DanhSachGiaoVien
            // 
            this.dgv_DanhSachGiaoVien.AllowUserToAddRows = false;
            this.dgv_DanhSachGiaoVien.AllowUserToDeleteRows = false;
            this.dgv_DanhSachGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.hoten,
            this.nsinh,
            this.GioiTinh,
            this.DiaChi,
            this.SoDienThoai,
            this.Email,
            this.btnDelete});
            this.dgv_DanhSachGiaoVien.Location = new System.Drawing.Point(0, 136);
            this.dgv_DanhSachGiaoVien.MultiSelect = false;
            this.dgv_DanhSachGiaoVien.Name = "dgv_DanhSachGiaoVien";
            this.dgv_DanhSachGiaoVien.ReadOnly = true;
            this.dgv_DanhSachGiaoVien.Size = new System.Drawing.Size(1208, 486);
            this.dgv_DanhSachGiaoVien.TabIndex = 6;
            this.dgv_DanhSachGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachGiaoVien_CellClick);
            this.dgv_DanhSachGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaoVien_CellDoubleClick);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Và Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // nsinh
            // 
            this.nsinh.DataPropertyName = "nsinh";
            this.nsinh.HeaderText = "Ngày Sinh";
            this.nsinh.Name = "nsinh";
            this.nsinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmDanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 622);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachGiaoVien);
            this.Name = "FrmDanhSachGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachGiaoVien";
            this.Load += new System.EventHandler(this.FrmDanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSachGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}