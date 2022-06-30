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
    public partial class FrmDanhSachSinhVien : Form
    {
        public FrmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void FrmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private string tukhoa = "";
        private void LoadDSSV()
        {
            // load toàn bộ dánh sách sv khi form được load


            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgv_DanhSachSinhVien.DataSource = new database().SelectData("selectAllSV", lstPara);


            // đặt tên cột

            dgv_DanhSachSinhVien.Columns["MaSinhVien"].HeaderText = "Mã Sinh Viên";
            dgv_DanhSachSinhVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgv_DanhSachSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgv_DanhSachSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgv_DanhSachSinhVien.Columns["QueQuan"].HeaderText = "Quê Quán";
            dgv_DanhSachSinhVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgv_DanhSachSinhVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }

        private void dgv_SinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi doubler click vào sinh viên trên dgv
            // sẽ hiện ra form cập nhập thông tin sv
            // để cập nhật đc mã sinh viên
            // ta cần lấy được Mã sinh viên
            if (e.RowIndex >= 0)
            {
                var msv = dgv_DanhSachSinhVien.Rows[e.RowIndex].Cells["MaSinhVien"].Value.ToString();

                //cần truyền msv này vào trong formSinhVien
                new FrmSinhVien(msv).ShowDialog();

                //sau khi form frmSinhVien đc đóng lại 
                //cần lòa lại danh sách sinh viên
                LoadDSSV();
            }
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            new FrmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void dgv_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txt_tukhoa.Text;
            LoadDSSV();
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_DanhSachSinhVien.Columns["btnDelete"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên:" + dgv_DanhSachSinhVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + "?", "Xác nhận xóa !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maSV = dgv_DanhSachSinhVien.Rows[e.RowIndex].Cells["MaSinhVien"].Value.ToString();
                        var sql = "deleteSinhVien";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@MaSinhVien",
                            value = maSV
                        }
                    };
                        var result = new database().Execute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa sinh viên thành công");
                            LoadDSSV();
                        }
                    }

                }
            }
        }
    }
}
