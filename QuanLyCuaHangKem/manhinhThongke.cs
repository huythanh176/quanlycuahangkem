using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace QuanLyCuaHangKem
{
    public partial class manhinhThongke : UserControl
    {
        public manhinhThongke()
        {
            InitializeComponent();
        }
        HOADON_BLL hdbll = new HOADON_BLL();
        CTHD_BLL cthdbll = new CTHD_BLL();
        private void btnXemHD_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = hdbll.select_hoadon();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtMaHD.Text = row.Cells[0].Value.ToString();
            dtpNgayHD.Text = row.Cells[1].Value.ToString();
            cbmNV.Text = row.Cells[2].Value.ToString();
            txtMaban.Text = row.Cells[3].Value.ToString();
            txttinhtrang.Text = row.Cells[4].Value.ToString();
            dataGridView2.DataSource = cthdbll.CTHD_select_chitiet(txtMaHD.Text);
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            cbmLoaiHang.Text = row.Cells[0].Value.ToString();
            cbmTenHang.Text = row.Cells[1].Value.ToString();
            txtSoluong.Text = row.Cells[2].Value.ToString();
            txtDongia.Text = row.Cells[3].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hdbll.loaihang_delete(txtMaHD.Text);
            btnXemHD.PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdbll.select_hoadon_search(txtSearch.Text);
        }

        private void btnThongkeHD_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            dataGridView1.DataSource = hdbll.select_hoadon_giua2ngay(dptNgaybatdau.Value, dptNgaykethuc.Value);
            chart1.DataSource = hdbll.select_hoadon_tenhangvssl(dptNgaybatdau.Value, dptNgaykethuc.Value);
            chart1.Series["SL"].XValueMember = "TenHang";
            chart1.Series["SL"].YValueMembers = "SL";
            chart1.Titles.Add("Biểu đồ số lượng sản phẩm đã bán theo mặt hàng" +
                "");
        }

        private void manhinhThongke_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = hdbll.select_hoadon_tenhangvssl(dptNgaybatdau.Value, dptNgaykethuc.Value);
            rpthongkerpt rp = new rpthongkerpt();
            rp.SetDataSource(dt);
            Form2Thongke frmTK = new Form2Thongke();
            frmTK.crystalReportViewer1.ReportSource = rp;
            frmTK.ShowDialog();
        }
    }
}
