namespace QuanLySV_BTL
{
    partial class FrmDSMonHocDangKy
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
            this.dgv_dsmhDaDangKy = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_dangkymonmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmhDaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dsmhDaDangKy
            // 
            this.dgv_dsmhDaDangKy.AllowUserToAddRows = false;
            this.dgv_dsmhDaDangKy.AllowUserToDeleteRows = false;
            this.dgv_dsmhDaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsmhDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsmhDaDangKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dsmhDaDangKy.Location = new System.Drawing.Point(0, 105);
            this.dgv_dsmhDaDangKy.Name = "dgv_dsmhDaDangKy";
            this.dgv_dsmhDaDangKy.ReadOnly = true;
            this.dgv_dsmhDaDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsmhDaDangKy.Size = new System.Drawing.Size(800, 345);
            this.dgv_dsmhDaDangKy.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(195, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Danh Sách Môn Học Đã Đăng Ký";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(386, 56);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(168, 20);
            this.txt_tukhoa.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Từ Khóa";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Location = new System.Drawing.Point(569, 53);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 66;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_dangkymonmoi
            // 
            this.btn_dangkymonmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dangkymonmoi.Location = new System.Drawing.Point(660, 53);
            this.btn_dangkymonmoi.Name = "btn_dangkymonmoi";
            this.btn_dangkymonmoi.Size = new System.Drawing.Size(119, 23);
            this.btn_dangkymonmoi.TabIndex = 67;
            this.btn_dangkymonmoi.Text = "Đăng Ký Môn Mới";
            this.btn_dangkymonmoi.UseVisualStyleBackColor = true;
            this.btn_dangkymonmoi.Click += new System.EventHandler(this.btn_dangkymonmoi_Click);
            // 
            // FrmDSMonHocDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dangkymonmoi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_dsmhDaDangKy);
            this.Name = "FrmDSMonHocDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.FrmDSMonHocDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmhDaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsmhDaDangKy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_dangkymonmoi;
    }
}