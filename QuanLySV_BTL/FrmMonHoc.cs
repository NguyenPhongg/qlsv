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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string nguoithuchien = "admin";
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new database().Select("exec selectMH '"+mamh+"'");
                txt_tenmonhoc.Text = r["TenMonHoc"].ToString();
                txt_sotinchi.Text = r["SoTinChi"].ToString();
            }
        }

        private void btn_luusv_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txt_sotinchi.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txt_sotinchi.Select();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txt_sotinchi.Select();
                return;
            }
            if (string.IsNullOrEmpty(txt_tenmonhoc.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txt_tenmonhoc.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "ThemMoiMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@NguoiTao",
                    value = nguoithuchien
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMonHoc",
                    value = mamh
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@NguoiCapNhat",
                    value = nguoithuchien
                });
                sql = "updateMH";
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenMonHoc",
                value = txt_tenmonhoc.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@SoTinChi",
                value = txt_sotinchi.Text
            });

            var rs = new database().Execute(sql, lstPara);

            if(rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thông tin môn học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
