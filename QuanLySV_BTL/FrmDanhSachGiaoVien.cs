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
    public partial class FrmDanhSachGiaoVien : Form
    {
        public FrmDanhSachGiaoVien()
        {
            InitializeComponent();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txt_tukhoa.Text;
            loadDSGV();
        }
        private string tukhoa = "";

        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgv_DanhSachGiaoVien.DataSource = new database().SelectData(sql, lstPara);
        }

        private void FrmDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            new FrmGiaoVien(null).ShowDialog();
            loadDSGV();
        }

        private void dgv_GiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi doubler click vào sinh viên trên dgv
            // sẽ hiện ra form cập nhập thông tin sv
            // để cập nhật đc mã sinh viên
            // ta cần lấy được Mã sinh viên
            if (e.RowIndex >= 0)
            {
                var msv = dgv_DanhSachGiaoVien.Rows[e.RowIndex].Cells["MaGiaoVien"].Value.ToString();

                //cần truyền msv này vào trong formSinhVien
                new FrmSinhVien(msv).ShowDialog();

                //sau khi form frmSinhVien đc đóng lại 
                //cần lòa lại danh sách sinh viên
                loadDSGV();
            }
        }

        private void dgv_DanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgv_DanhSachGiaoVien.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên:" +dgv_DanhSachGiaoVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString()+"?","Xác nhận xóa !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maGV = dgv_DanhSachGiaoVien.Rows[e.RowIndex].Cells["MaGiaoVien"].Value.ToString();
                        var sql = "deleteGiaoVien";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@MaGiaoVien",
                            value = maGV
                        }
                    };
                        var result = new database().Execute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa giáo viên thành công");
                            loadDSGV();
                        }
                    }
                    
                }
            }
        }
    }
}
