using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV_BTL
{
    public partial class FrmDSMonHocDangKy : Form
    {
        private string masv;
        public FrmDSMonHocDangKy(string msv)
        {
            this.masv = msv;
            InitializeComponent();
        }

        private void FrmDSMonHocDangKy_Load(object sender, EventArgs e)
        {
            LoadMonDangKy();

        }
        private void LoadMonDangKy()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter
                {
                    key = "@MaSinhVien",
                    value = masv
                }
            };
            dgv_dsmhDaDangKy.DataSource = new database().SelectData("monDaDangKy", lst);
        }

        private void btn_dangkymonmoi_Click(object sender, EventArgs e)
        {
            new FrmDangKyMonHoc(masv).ShowDialog();
        }
    }
}
