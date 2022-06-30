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
    public partial class FrmDangKyMonHoc : Form
    {
        public FrmDangKyMonHoc(string masv)
        {
            this.masv = masv; ;
            InitializeComponent();
        }
        public string masv;
        private void FrmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();

            dgv_DSLH.Columns["MaLopHoc"].HeaderText = "Mã Lớp Học";
            dgv_DSLH.Columns["maMonHoc"].HeaderText = "Mã Môn Học";
            dgv_DSLH.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dgv_DSLH.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
            dgv_DSLH.Columns["gvien"].HeaderText = "Giáo Viên";
        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MaSinhVien",
                value = masv
            });
            dgv_DSLH.DataSource = new database().SelectData("DsLopChuaDky",lstPara);
        }

        private void dgv_DSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // ý tưởng
            // khi double click vào 1 dòng sẽ hiện lên hộp thọai xác nhận đăng ký môn học
            if (dgv_DSLH.Rows[e.RowIndex].Index > 0)
            {
                if (DialogResult.Yes ==
                MessageBox.Show("Bạn muốn đăng ký học phần [" + dgv_DSLH.Rows[e.RowIndex].Cells["TenMonHoc"].Value.ToString() + "]", "Xác nhận đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MaSinhVien",
                        value = masv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MaLopHoc",
                        value = dgv_DSLH.Rows[e.RowIndex].Cells["MaLopHoc"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MaMonHoc",
                        value = dgv_DSLH.Rows[e.RowIndex].Cells["MaMonHoc"].Value.ToString()
                    });
                    var rs = new database().Execute("dkyhocMoi", lstPara);
                    if(rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký","Thông báo !!!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đã đăng ký học phần thành công", "Success !!!");
                        LoadDSLH();
                    }
                }
            
            }        
        }

        private void dgv_DSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
