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
    public partial class Frm_QuanLyLop : Form
    {
        public Frm_QuanLyLop(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private void Frm_QuanLyLop_Load(object sender, EventArgs e)
        {
            QuanLyLop();

            dgv_quanlylophoc.Columns["MaLopHoc"].HeaderText = "Mã Lớp Học";
            dgv_quanlylophoc.Columns["maMonHoc"].HeaderText = "Mã Môn Học";
            dgv_quanlylophoc.Columns["TenMonHoc"].HeaderText = "Tên Môn Hoc";
            dgv_quanlylophoc.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
        }
        private void QuanLyLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MaGiaoVien",
                value = mgv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txt_tukhoa.Text
            });
            dgv_quanlylophoc.DataSource = new database().SelectData("tracuulop",lstPara);
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            QuanLyLop();
        }
    }
}
