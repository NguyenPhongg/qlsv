namespace QuanLySV_BTL
{
    partial class FrmDanhSachLopHoc
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
            this.dgv_danhsachlophoc = new System.Windows.Forms.DataGridView();
            this.MaLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachlophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh Sách Lớp Học";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themmoi.Location = new System.Drawing.Point(870, 74);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themmoi.TabIndex = 15;
            this.btn_themmoi.Text = "Thêm Mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(763, 74);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 14;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(591, 74);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(152, 20);
            this.txt_tukhoa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ Khóa";
            // 
            // dgv_danhsachlophoc
            // 
            this.dgv_danhsachlophoc.AllowUserToAddRows = false;
            this.dgv_danhsachlophoc.AllowUserToDeleteRows = false;
            this.dgv_danhsachlophoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhsachlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopHoc,
            this.giaovien,
            this.TenMonHoc,
            this.btndelete});
            this.dgv_danhsachlophoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_danhsachlophoc.Location = new System.Drawing.Point(0, 133);
            this.dgv_danhsachlophoc.Name = "dgv_danhsachlophoc";
            this.dgv_danhsachlophoc.ReadOnly = true;
            this.dgv_danhsachlophoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachlophoc.Size = new System.Drawing.Size(983, 409);
            this.dgv_danhsachlophoc.TabIndex = 17;
            this.dgv_danhsachlophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachlophoc_CellClick);
            this.dgv_danhsachlophoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachlophoc_CellDoubleClick);
            // 
            // MaLopHoc
            // 
            this.MaLopHoc.DataPropertyName = "MaLopHoc";
            this.MaLopHoc.HeaderText = "Mã Lớp";
            this.MaLopHoc.Name = "MaLopHoc";
            this.MaLopHoc.ReadOnly = true;
            // 
            // giaovien
            // 
            this.giaovien.DataPropertyName = "giaovien";
            this.giaovien.HeaderText = "Giáo Viên";
            this.giaovien.Name = "giaovien";
            this.giaovien.ReadOnly = true;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            // 
            // btndelete
            // 
            this.btndelete.DataPropertyName = "btndelete";
            this.btndelete.HeaderText = "";
            this.btndelete.Name = "btndelete";
            this.btndelete.ReadOnly = true;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseColumnTextForButtonValue = true;
            // 
            // FrmDanhSachLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 542);
            this.Controls.Add(this.dgv_danhsachlophoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhSachLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachLopHoc";
            this.Load += new System.EventHandler(this.FrmDanhSachLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachlophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_danhsachlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewButtonColumn btndelete;
    }
}