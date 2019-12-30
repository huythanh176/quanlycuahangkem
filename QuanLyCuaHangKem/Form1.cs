using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace QuanLyCuaHangKem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            pnthanhdichuyen.Height = btnNhanvien.Height;
            pnthanhdichuyen.Top = btnNhanvien.Top;
            manhinhNhanvien1.BringToFront();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            pnthanhdichuyen.Height = btnThemMon.Height;
            pnthanhdichuyen.Top = btnThemMon.Top;
            manhinhthemmon1.BringToFront();

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            pnthanhdichuyen.Height = btnBaocao.Height;
            pnthanhdichuyen.Top = btnBaocao.Top;
            manhinhThongke1.BringToFront();
        }

        private void manHinhTrangChinh1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void manHinhOrder1_Load(object sender, EventArgs e)
        {
            
        }

        private void manHinhTrangChinh2_Load(object sender, EventArgs e)
        {

        }

        private void manHinhTrangChinh1_Load_1(object sender, EventArgs e)
        {

        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnthanhdichuyen.Height = btnOrder.Height;
            pnthanhdichuyen.Top = btnOrder.Top;
            manHinhOrder1.BringToFront();
            manHinhOrder1.loadHanghoa();
            manHinhOrder1.loadLoaihang();
            
        }

        private void btnTrangchinh_Click(object sender, EventArgs e)
        {
            pnthanhdichuyen.Height = btnTrangchinh.Height;
            pnthanhdichuyen.Top = btnTrangchinh.Top;
            manHinhTrangChinh1.BringToFront();
            manHinhTrangChinh1.loadBan();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        TAIKHOAN_BLL tkbll = new TAIKHOAN_BLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = tkbll.select_chucvu_theoTenNV(lbtenNV.Text);
            if (dt.Rows[0][0].ToString() == "nhanvien")
            {
                pnthanhdichuyen.Top = btnTrangchinh.Top;
                btnBaocao.Text = "";
                btnBaocao.Image = null;
                btnBaocao.Enabled = false;
                btnNhanvien.Text = "";
                btnNhanvien.Image = null;
                btnNhanvien.Enabled = false;
                btnThemMon.Text = "";
                btnThemMon.Image = null;
                btnThemMon.Enabled = false;
            }
            manHinhOrder1.tennv = lbtenNV.Text;

        }

        private void manhinhNhanvien1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog=MessageBox.Show("Bạn Muốn Đổi Tài Khoản", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                Close();       
            }
            
        }

        private void manHinhOrder1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnTurnoff_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
