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
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc(string MaLopHoc)
        {
            this.MaLopHoc = MaLopHoc;
            InitializeComponent();
        }
        private string MaLopHoc;
        private database db;
        private string nguoithuchien = "admin";
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            db = new database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };

            //load dữ liệu ch0o 3 combobox

            cbb_monhoc.DataSource = db.SelectData("selectAllMH", lst);
            cbb_monhoc.DisplayMember = "TenMonHoc";  //thuộc tính hiển thị của cbb
            cbb_monhoc.ValueMember = "MaMonHoc"; // giá trị (key) của cbb
            cbb_monhoc.SelectedIndex = -1;

            cbb_giaovien.DataSource = db.SelectData("selectAllGV", lst);
            cbb_giaovien.DisplayMember = "hoten";
            cbb_giaovien.ValueMember = "MaGiaoVien";
            cbb_giaovien.SelectedIndex = -1; // set cbb không chọn giá trị nào

            if(string.IsNullOrEmpty(MaLopHoc))
            {
                this.Text = "Thêm Mới Lớp Học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLH '"+ MaLopHoc + "'");
                cbb_giaovien.SelectedValue = r["MaGiaoVien"].ToString();
                cbb_monhoc.SelectedValue = r["MaMonHoc"].ToString();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            if(cbb_monhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if(cbb_giaovien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(MaLopHoc))
            {
                sql = "ThemMoiLH";
                lst.Add(new CustomParameter()
                {
                    key = "@NguoiTao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLH";
                lst.Add(new CustomParameter()
                {
                    key = "@NguoiCapNhat",
                    value = nguoithuchien
                });

                lst.Add(new CustomParameter()
                {
                    key = "@MaLopHoc",
                    value = MaLopHoc
                });
            }

            lst.Add(new CustomParameter()
            {
                key = "@MaMonHoc",
                value = cbb_monhoc.SelectedValue.ToString()
            });

            lst.Add(new CustomParameter()
            {
                key = "@MaGiaoVien",
                value = cbb_giaovien.SelectedValue.ToString()
            });

            var kq = db.Execute(sql, lst);
                if(kq == 1)
            {
                if (string.IsNullOrEmpty(MaLopHoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }
    }
}
