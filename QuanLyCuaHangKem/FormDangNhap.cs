using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.Sql;
namespace QuanLyCuaHangKem
{
    
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        TAIKHOAN_BLL tkbll = new TAIKHOAN_BLL();
       
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = tkbll.select_taikhoan_searchTenTK(txtTenDangNhap.Text);
            if(dt.Rows.Count==0)
            {
                txtThongbao.Text = "Tên Đăng Nhập Không Tồn Tại";
                return;
            }
            if(dt.Rows[0][2].ToString()!=txtMatKhau.Text)
            {
                txtThongbao.Text = "Mật khẩu không chính xác";
                return;
                
            }
            else
            {
                string tennv = txtTenDangNhap.Text;
                Form1 form1 = new Form1();
                DataTable dt1;
               
                dt1 = tkbll.select_tennhanvien_theoTenTK(tennv);
                form1.lbtenNV.Text = dt1.Rows[0][0].ToString();
                
                form1.Show();
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else txtMatKhau.PasswordChar = '*';
        }
    }
}
