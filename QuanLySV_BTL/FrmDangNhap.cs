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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitaikhoan;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // kiểm tra ràng buộc
            if(cbb_loaitaikhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txt_tendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản","Tài khoản không được để trống");
                txt_tendangnhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu","Mật khẩu không được để trống");
                txt_matkhau.Select();
                return;
            }

            tendangnhap = txt_tendangnhap.Text;

            loaitaikhoan = "";

            switch (cbb_loaitaikhoan.Text)
            {
                case "Quản Trị Viên":
                    loaitaikhoan = "admin";
                        break;
                case "Giáo Viên":
                    loaitaikhoan = "gv";
                    break;
                case "Sinh Viên":
                    loaitaikhoan = "sv";
                    break;
            }

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@LoaiTaiKhoan",
                    value = loaitaikhoan
                },
                new CustomParameter()
                {
                    key = "@TaiKhoan",
                    value = txt_tendangnhap.Text
                },
                new CustomParameter()
                {
                    key = "@MatKhau",
                    value = txt_matkhau.Text
                },
            };

            var rs = new database().SelectData("DangNhap", lst);
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
