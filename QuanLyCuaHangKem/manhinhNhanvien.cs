using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyCuaHangKem
{
    public partial class manhinhNhanvien : UserControl
    {
        public manhinhNhanvien()
        {
            InitializeComponent();
        }
        NHANVIEN_BLL nvbll = new NHANVIEN_BLL();
        TAIKHOAN_BLL tkbll = new TAIKHOAN_BLL();
        private void manhinhNhanvien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadTaiKhoan();
            LoadTenNV();
        }

        private void LoadTenNV()
        {
            cbmMaNV.DataSource = nvbll.nhanvien_select();
            cbmMaNV.ValueMember = "MaNV";
            cbmMaNV.DisplayMember = "TenNV";
        }

        private void loadTaiKhoan()
        {
            dataGridView2.DataSource = tkbll.taikhoan_select();
        }

        private void loadNhanVien()
        {
            dataGridView1.DataSource = nvbll.nhanvien_select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nvbll.nhanvien_insert(txtMaNV.Text, txtTenNV.Text, dptNgaySinh.Value, radNam.Checked ? true : false, txtSDT.Text);
            loadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nvbll.nhanvien_update(txtMaNV.Text, txtTenNV.Text, dptNgaySinh.Value, radNam.Checked ? true : false, txtSDT.Text);
            loadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nvbll.nhanvien_delete(txtMaNV.Text);
            loadNhanVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            dptNgaySinh.Value = (DateTime)row.Cells[2].Value;
            bool gt = (bool)row.Cells[3].Value;
            if (gt == true) radNam.Checked = true; else radNu.Checked = true;
            txtSDT.Text = row.Cells[4].Value.ToString();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = matusinh(nvbll.nhanvien_select());
            txtTenNV.Text = "";
            txtSDT.Text = "";
            

        }
        public string matusinh(DataTable dt)
        {

            string ma = dt.Rows[dt.Rows.Count - 1][0].ToString();
            string ma2 = ma.Substring(2, 2);
            string id = ma.Substring(0, 2);
            if (int.Parse(ma2) < 9)
            {
                return id +"0"+ (int.Parse(ma2) + 1);
            }
            else return id + (int.Parse(ma2) + 1);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            txtMaTK.Text = row.Cells[0].Value.ToString();
            txtTenTK.Text = row.Cells[1].Value.ToString();
            txtMatKhau.Text = row.Cells[2].Value.ToString();
            cbmChucvu.Text= row.Cells[3].Value.ToString();
            cbmMaNV.Text = row.Cells[4].Value.ToString();
        }

        private void btnThemmoi2_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = matusinh(tkbll.taikhoan_select());
            txtTenNV.Text = "";
            txtMatKhau.Text = "";
         

        }
        
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            tkbll.taikhoan_insert(txtMaTK.Text, txtTenTK.Text, txtMatKhau.Text, cbmChucvu.Text, cbmMaNV.SelectedValue.ToString());
            loadTaiKhoan();
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            tkbll.taikhoan_update(txtMaTK.Text, txtTenTK.Text, txtMatKhau.Text, cbmChucvu.Text, cbmMaNV.SelectedValue.ToString());
            loadTaiKhoan();
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            tkbll.taikhoan_delete(txtMaTK.Text);
            loadTaiKhoan();
        }

        private void txtSearchTen_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nvbll.select_nhanvien_searchTenNV(txtSearchTen.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = tkbll.select_taikhoan_searchTenTK(txtSearchTenTK.Text);
        }
    }
}
