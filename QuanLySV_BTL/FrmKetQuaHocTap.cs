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
    public partial class FrmKetQuaHocTap : Form
    {
        public FrmKetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void FrmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();

            dgv_ketquahoctap.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
            dgv_ketquahoctap.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dgv_ketquahoctap.Columns["LanHoc"].HeaderText = "Lần Học";
            dgv_ketquahoctap.Columns["gvien"].HeaderText = "Giáo Viên";
            dgv_ketquahoctap.Columns["Diemthilan1"].HeaderText = "Điểm Thi Lần 1";
            dgv_ketquahoctap.Columns["Diemthilan2"].HeaderText = "Điểm Thi Lần 2";
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MaSinhVien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txt_tukhoa.Text
            });
            dgv_ketquahoctap.DataSource = new database().SelectData("tracuudiem", lstPara);
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();

        }
    }
}
