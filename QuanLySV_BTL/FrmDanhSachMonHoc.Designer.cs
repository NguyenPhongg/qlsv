namespace QuanLySV_BTL
{
    partial class FrmDanhSachMonHoc
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
            this.dgv_DanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachMonHoc
            // 
            this.dgv_DanhSachMonHoc.AllowUserToAddRows = false;
            this.dgv_DanhSachMonHoc.AllowUserToDeleteRows = false;
            this.dgv_DanhSachMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonHoc,
            this.TenMonHoc,
            this.SoTinChi,
            this.btnDelete});
            this.dgv_DanhSachMonHoc.Location = new System.Drawing.Point(0, 123);
            this.dgv_DanhSachMonHoc.Name = "dgv_DanhSachMonHoc";
            this.dgv_DanhSachMonHoc.ReadOnly = true;
            this.dgv_DanhSachMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachMonHoc.Size = new System.Drawing.Size(860, 376);
            this.dgv_DanhSachMonHoc.TabIndex = 0;
            this.dgv_DanhSachMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonHoc_CellClick);
            this.dgv_DanhSachMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonHoc_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(286, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh Sách Môn Học";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themmoi.Location = new System.Drawing.Point(753, 68);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themmoi.TabIndex = 9;
            this.btn_themmoi.Text = "Thêm Mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(651, 68);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(479, 68);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(152, 20);
            this.txt_tukhoa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Khóa";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.ReadOnly = true;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn học";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số Tín Chỉ";
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.DataPropertyName = "btnDelete";
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmDanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachMonHoc);
            this.Name = "FrmDanhSachMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.FrmDanhSachMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}