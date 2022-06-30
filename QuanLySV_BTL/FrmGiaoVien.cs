using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV_BTL
{
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string NguoiThucThi = "admin";
        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv)) // nếu msv không có =)) thêm mới msv
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";
                // lấy thông tin chi tiết của 1 sinh viên dựa vào msv
                // msv là mã sinh viên đã được truyền từ formDSSV (part 4)
                var r = new database().Select("selectGV '" + mgv + "'");
                /*MessageBox.Show(r[0].ToString());*/ // load thành công 

                // set các giá trị vào component của Form

                txt_ho.Text = r["Ho"].ToString();
                txt_tendem.Text = r["TenDem"].ToString();
                txt_ten.Text = r["Ten"].ToString();
                Mastxt_Ngaysinh.Text = r["nsinh"].ToString();
                txt_gioitinh.Text = r["GioiTinh"].ToString();
                txt_diachi.Text = r["DiaChi"].ToString();
                txt_sodienthoai.Text = r["SoDienThoai"].ToString();
                txt_email.Text = r["Email"].ToString();
            }
        }

        private void btn_luusv_Click(object sender, EventArgs e)
        {
            String sql = "";
            string Ho = txt_ho.Text;
            string TenDem = txt_tendem.Text;
            string Ten = txt_ten.Text;
            // vì ngày sinh ở MaskedBox ta xét theo dạng dd/mm/yyy
            // nhưng trong csdl lại lưu dưới dạng yyyy/mm/dd
            // vaajy6 chúng ta cần chuyển từ dd/mm/yyyy sang yyyy/mm/dd
            DateTime NgaySinh;
            try
            {
                NgaySinh = DateTime.ParseExact(Mastxt_Ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                Mastxt_Ngaysinh.Select(); // trỏ chuột về ô ngày sinh
                return; // k thực hiện các câu lệnh phía dưới
            }
            string GioiTinh = txt_gioitinh.Text;
            string DiaChi = txt_diachi.Text;
            string SoDienThoai = txt_sodienthoai.Text;
            string Email = txt_email.Text;


            // Khai báo 1 danh sách tham số bằng classs CustomParameter

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv)) // nếu thêm mới msv
            {
                sql = "ThemMoiGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@NguoiTao",
                    value = NguoiThucThi
                });
            }
            else // nếu cập nhật sinh viên
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@NguoiCapNhat",
                    value = NguoiThucThi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaGiaoVien",
                    value = mgv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = Ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TenDem",
                value = TenDem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = Ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = NgaySinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = GioiTinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = DiaChi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SoDienThoai",
                value = SoDienThoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email
            });


            var rs = new database().Execute(sql, lstPara); //truyền 2 tham số là câu lệnh sql
            // và danh sách các tham số

            if (rs == 1) // nếu thực hiện thành công
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công");
                }
                this.Dispose(); // đóng form sau khi thêm mới hoặc cập nhập thành công
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }
    }
}
