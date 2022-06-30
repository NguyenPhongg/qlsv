namespace QuanLySV_BTL
{
    partial class FrmLopHoc
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
            this.cbb_monhoc = new System.Windows.Forms.ComboBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_giaovien = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học";
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.FormattingEnabled = true;
            this.cbb_monhoc.Location = new System.Drawing.Point(122, 79);
            this.cbb_monhoc.Name = "cbb_monhoc";
            this.cbb_monhoc.Size = new System.Drawing.Size(295, 21);
            this.cbb_monhoc.TabIndex = 1;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(122, 210);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giáo Viên";
            // 
            // cbb_giaovien
            // 
            this.cbb_giaovien.FormattingEnabled = true;
            this.cbb_giaovien.Location = new System.Drawing.Point(122, 134);
            this.cbb_giaovien.Name = "cbb_giaovien";
            this.cbb_giaovien.Size = new System.Drawing.Size(295, 21);
            this.cbb_giaovien.TabIndex = 4;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(243, 210);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 5;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(123, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thêm Mới Lớp Học";
            // 
            // FrmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.cbb_giaovien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.cbb_monhoc);
            this.Controls.Add(this.label1);
            this.Name = "FrmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLopHoc";
            this.Load += new System.EventHandler(this.FrmLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_monhoc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_giaovien;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label3;
    }
}