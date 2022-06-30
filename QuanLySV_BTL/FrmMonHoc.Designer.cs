namespace QuanLySV_BTL
{
    partial class FrmMonHoc
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
            this.label10 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.txt_sotinchi = new System.Windows.Forms.TextBox();
            this.txt_tenmonhoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_luumh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(145, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "Thêm Mới Môn Học";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(287, 163);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 60;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_sotinchi
            // 
            this.txt_sotinchi.Location = new System.Drawing.Point(115, 118);
            this.txt_sotinchi.Name = "txt_sotinchi";
            this.txt_sotinchi.Size = new System.Drawing.Size(76, 20);
            this.txt_sotinchi.TabIndex = 2;
            // 
            // txt_tenmonhoc
            // 
            this.txt_tenmonhoc.Location = new System.Drawing.Point(115, 80);
            this.txt_tenmonhoc.Name = "txt_tenmonhoc";
            this.txt_tenmonhoc.Size = new System.Drawing.Size(370, 20);
            this.txt_tenmonhoc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Số Tín Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tên Môn Học";
            // 
            // btn_luumh
            // 
            this.btn_luumh.Location = new System.Drawing.Point(167, 163);
            this.btn_luumh.Name = "btn_luumh";
            this.btn_luumh.Size = new System.Drawing.Size(75, 23);
            this.btn_luumh.TabIndex = 47;
            this.btn_luumh.Text = "Lưu";
            this.btn_luumh.UseVisualStyleBackColor = true;
            this.btn_luumh.Click += new System.EventHandler(this.btn_luusv_Click);
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 240);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_sotinchi);
            this.Controls.Add(this.txt_tenmonhoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_luumh);
            this.Name = "FrmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMonHoc";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.TextBox txt_sotinchi;
        private System.Windows.Forms.TextBox txt_tenmonhoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_luumh;
    }
}