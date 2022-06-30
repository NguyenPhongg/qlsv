namespace QuanLySV_BTL
{
    partial class FrmDangKyMonHoc
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
            this.dgv_DSLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSLH
            // 
            this.dgv_DSLH.AllowUserToAddRows = false;
            this.dgv_DSLH.AllowUserToDeleteRows = false;
            this.dgv_DSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSLH.Location = new System.Drawing.Point(0, 0);
            this.dgv_DSLH.Name = "dgv_DSLH";
            this.dgv_DSLH.ReadOnly = true;
            this.dgv_DSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSLH.Size = new System.Drawing.Size(800, 450);
            this.dgv_DSLH.TabIndex = 0;
            this.dgv_DSLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLH_CellContentClick);
            this.dgv_DSLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLH_CellDoubleClick);
            // 
            // FrmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_DSLH);
            this.Name = "FrmDangKyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.FrmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSLH;
    }
}