using QuanLySV_BTL;
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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitaikhoan;

        private void Frmmain_Load(object sender, EventArgs e)
        {
            var fn = new FrmDangNhap();
            fn.ShowDialog();  // cho load form đăng nhập khi formmain được gọi

            // sau khi form đăng nhập đc tắt, lấy tài khoản đã đăng nhập
            taikhoan = fn.tendangnhap;
            loaitaikhoan = fn.loaitaikhoan;
            if (loaitaikhoan.Equals("admin"))
            {
                // nếu là admin
                // ấn 2 menu chấm điểm và đăng ký môn học
                // chỉ để lại menu quản lý
                menu_quanlylop.Visible = false;
                menu_dangkymonhoc.Visible = false;
            }
            else
            {
                // nếu không phải admin thì ẩn menu quản lý
                menu_quanly.Visible = false;
                if (loaitaikhoan.Equals("gv")) // nếu là giáo viên
                {
                    // ấn menu đăng ký học -> cái này chỉ dành riêng cho sinh viên
                    menu_dangkymonhoc.Visible = false;
                }
                else // là sinh viên
                {
                    // ấn menu chấm điểm -> chức năng của giáo viên
                    menu_quanlylop.Visible = false;
                }

            }




            FrmWelcome f = new FrmWelcome();
            AddForm(f);
        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void menu_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_sinhvien_Click(object sender, EventArgs e)
        {
            FrmDanhSachSinhVien f = new FrmDanhSachSinhVien();
            AddForm(f);
        }

        private void menu_monhoc_Click(object sender, EventArgs e)
        {
            FrmDanhSachMonHoc f = new FrmDanhSachMonHoc();
            AddForm(f);
        }

        private void menu_giaovien_Click(object sender, EventArgs e)
        {
            FrmDanhSachGiaoVien f = new FrmDanhSachGiaoVien();
            AddForm(f);
        }

        private void menu_diemthi_Click(object sender, EventArgs e)  // menu_lopHoc
        {
            FrmDanhSachLopHoc f = new FrmDanhSachLopHoc();
            AddForm(f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_dangkymonhoc_Click(object sender, EventArgs e)
        {
        }

        private void menu_dkymonhoc_Click(object sender, EventArgs e)
        {
            var f = new FrmDSMonHocDangKy(taikhoan);
            AddForm(f);
        }

        private void menu_tracuudiem_Click(object sender, EventArgs e)
        {
            var f = new FrmKetQuaHocTap(taikhoan);
            AddForm(f);
        }

        private void menu_quanlylop_Click(object sender, EventArgs e)
        {
            var f = new Frm_QuanLyLop(taikhoan);
            AddForm(f);
        }
    }
}
