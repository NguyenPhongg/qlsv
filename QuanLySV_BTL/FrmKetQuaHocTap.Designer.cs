namespace QuanLySV_BTL
{
    partial class FrmKetQuaHocTap
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
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.btn_tracuu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_ketquahoctap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketquahoctap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tukhoa.Location = new System.Drawing.Point(453, 57);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(264, 20);
            this.txt_tukhoa.TabIndex = 2;
            // 
            // btn_tracuu
            // 
            this.btn_tracuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tracuu.Location = new System.Drawing.Point(736, 55);
            this.btn_tracuu.Name = "btn_tracuu";
            this.btn_tracuu.Size = new System.Drawing.Size(75, 23);
            this.btn_tracuu.TabIndex = 3;
            this.btn_tracuu.Text = "Tra Cứu";
            this.btn_tracuu.UseVisualStyleBackColor = true;
            this.btn_tracuu.Click += new System.EventHandler(this.btn_tracuu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(291, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 25);
            this.label10.TabIndex = 64;
            this.label10.Text = "Kết Quả Học Tập";
            // 
            // dgv_ketquahoctap
            // 
            this.dgv_ketquahoctap.AllowUserToAddRows = false;
            this.dgv_ketquahoctap.AllowUserToDeleteRows = false;
            this.dgv_ketquahoctap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ketquahoctap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ketquahoctap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ketquahoctap.Location = new System.Drawing.Point(0, 99);
            this.dgv_ketquahoctap.Name = "dgv_ketquahoctap";
            this.dgv_ketquahoctap.ReadOnly = true;
            this.dgv_ketquahoctap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ketquahoctap.Size = new System.Drawing.Size(858, 342);
            this.dgv_ketquahoctap.TabIndex = 65;
            // 
            // FrmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 441);
            this.Controls.Add(this.dgv_ketquahoctap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_tracuu);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label1);
            this.Name = "FrmKetQuaHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.FrmKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketquahoctap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Button btn_tracuu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_ketquahoctap;
    }
}