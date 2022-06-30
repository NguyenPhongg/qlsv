namespace QuanLySV_BTL
{
    partial class FrmDanhSachSinhVien
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
            this.dgv_DanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachSinhVien
            // 
            this.dgv_DanhSachSinhVien.AllowUserToAddRows = false;
            this.dgv_DanhSachSinhVien.AllowUserToDeleteRows = false;
            this.dgv_DanhSachSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.hoten,
            this.nsinh,
            this.GioiTinh,
            this.QueQuan,
            this.DiaChi,
            this.SoDienThoai,
            this.Email,
            this.btnDelete});
            this.dgv_DanhSachSinhVien.Location = new System.Drawing.Point(0, 146);
            this.dgv_DanhSachSinhVien.MultiSelect = false;
            this.dgv_DanhSachSinhVien.Name = "dgv_DanhSachSinhVien";
            this.dgv_DanhSachSinhVien.ReadOnly = true;
            this.dgv_DanhSachSinhVien.Size = new System.Drawing.Size(1128, 438);
            this.dgv_DanhSachSinhVien.TabIndex = 0;
            this.dgv_DanhSachSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellClick);
            this.dgv_DanhSachSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellContentClick);
            this.dgv_DanhSachSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellDoubleClick);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "Mã Sinh Viên";
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.ReadOnly = true;
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
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
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
            this.btnDelete.DataPropertyName = "btnDelete";
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Khóa";
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(677, 79);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(152, 20);
            this.txt_tukhoa.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(849, 79);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themmoi.Location = new System.Drawing.Point(951, 79);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themmoi.TabIndex = 4;
            this.btn_themmoi.Text = "Thêm Mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(429, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh Sách Sinh Viên";
            // 
            // FrmDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachSinhVien);
            this.Name = "FrmDanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.FrmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}