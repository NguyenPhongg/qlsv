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
    public partial class FrmDanhSachLopHoc : Form
    {
        public FrmDanhSachLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";

        private void FrmDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();

            dgv_danhsachlophoc.Columns["MaLopHoc"].HeaderText = "Mã Lớp Học";
            dgv_danhsachlophoc.Columns["giaovien"].HeaderText = "Giáo Viên";
            dgv_danhsachlophoc.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
        }
        private void LoadDSLH()
        {
            string sql = "selectAllLH";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgv_danhsachlophoc.DataSource = new database().SelectData(sql,lstPara);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txt_tukhoa.Text;
            LoadDSLH();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            new FrmLopHoc(null).ShowDialog();
            LoadDSLH();
        }

        private void dgv_danhsachlophoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                new FrmLopHoc(dgv_danhsachlophoc.Rows[e.RowIndex].Cells["MaLop"].Value.ToString());
                LoadDSLH();
            }
        }

        private void dgv_danhsachlophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_danhsachlophoc.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp học:" + dgv_danhsachlophoc.Rows[e.RowIndex].Cells["MaLopHoc"].Value.ToString() + "?", "Xác nhận xóa !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maLH = dgv_danhsachlophoc.Rows[e.RowIndex].Cells["MaLopHoc"].Value.ToString();
                        var sql = "deleteLopHoc";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@MaLopHoc",
                            value = maLH
                        }
                    };
                        var result = new database().Execute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa lớp học thành công");
                            LoadDSLH();
                        }
                    }

                }
            }
        }
    }
}
