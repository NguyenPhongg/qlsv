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
    public partial class FrmDanhSachMonHoc : Form
    {
        public FrmDanhSachMonHoc()
        {
            InitializeComponent();
        }

        private void dgv_DanhSachMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgv_DanhSachMonHoc.Rows[e.RowIndex].Cells["MaMonHoc"].Value.ToString();

                //cần truyền msv này vào trong formSinhVien
                new FrmMonHoc(mamh).ShowDialog();

                //sau khi form frmSinhVien đc đóng lại 
                //cần lòa lại danh sách sinh viên
                LoadDSMH();
            }
        }
        private string tukhoa = "";

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            new FrmMonHoc(null).ShowDialog();
            LoadDSMH();
        }
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgv_DanhSachMonHoc.DataSource = new database().SelectData("selectAllMH", lstPara);
            dgv_DanhSachMonHoc.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
            dgv_DanhSachMonHoc.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dgv_DanhSachMonHoc.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
        }

        private void FrmDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            
            
            LoadDSMH();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txt_tukhoa.Text;
            LoadDSMH();
        }

        private void dgv_DanhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_DanhSachMonHoc.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa môn học:" + dgv_DanhSachMonHoc.Rows[e.RowIndex].Cells["TenMonHoc"].Value.ToString() + "?", "Xác nhận xóa !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maMH = dgv_DanhSachMonHoc.Rows[e.RowIndex].Cells["MaMonHoc"].Value.ToString();
                        var sql = "deleteMonHoc";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@MaMonHoc",
                            value = maMH
                        }
                    };
                        var result = new database().Execute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa môn học thành công");
                            LoadDSMH();
                        }
                    }

                }
            }
        }
    }
}
