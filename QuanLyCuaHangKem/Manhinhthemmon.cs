using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;

namespace QuanLyCuaHangKem
{
    public partial class Manhinhthemmon : UserControl
    {
        public Manhinhthemmon()
        {
            InitializeComponent();
        }
        LOAIHANG_BLL lhbll = new LOAIHANG_BLL();
        HANGHOA_BLL hhbll = new HANGHOA_BLL();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string image = null;
        string image2 = null;
        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All File (*.*)|*.*";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                image = openFile.FileName.ToString();
                pbAnhloaihang.ImageLocation = image;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                lhbll.insert_loaihang(txtMaLH.Text, txtTenLH.Text, txtGhichu.Text, img);
                loadLoaiHang();
            }
            catch
            {
                MessageBox.Show("Ban phải tải hình ảnh lên");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Manhinhthemmon_Load(object sender, EventArgs e)
        {
            loadLoaiHang();
            cbmTenLoaiHang.DataSource = lhbll.select_loaihang();
            cbmTenLoaiHang.ValueMember = "MaLoaiHang";
            cbmTenLoaiHang.DisplayMember = "TenLoaiHang";
            loadHangHoa();
            
        }

        private void loadHangHoa()
        {
            dataGridView2.DataSource = hhbll.select_hanghoa();
        }

        private void loadLoaiHang()
        {
            dataGridView1.DataSource = lhbll.select_loaihang();
        }
        byte[] img;
        byte[] img2;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtMaLH.Text= row.Cells[0].Value.ToString();
            txtTenLH.Text = row.Cells[1].Value.ToString();
            txtGhichu.Text = row.Cells[2].Value.ToString();
             img = (byte[])row.Cells[3].Value;

              MemoryStream ms = new MemoryStream(img);
              pbAnhloaihang.Image = Image.FromStream(ms);

            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                lhbll.loaihang_update(txtMaLH.Text, txtTenLH.Text, txtGhichu.Text, img);
                loadLoaiHang();
            }
            catch
            {
                lhbll.loaihang_update_kohinh(txtMaLH.Text, txtTenLH.Text, txtGhichu.Text);
                loadLoaiHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lhbll.loaihang_delete(txtMaLH.Text);
            loadLoaiHang();
        }

        private void txtSoluongcon_Click(object sender, EventArgs e)
        {

        }

        private void btnMoanh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All File (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image2 = openFile.FileName.ToString();
                pbAnhHangHoa.ImageLocation = image2;
            }
        }
        ManHinhOrder mho = new ManHinhOrder();
        private void btnThemHH_Click(object sender, EventArgs e)
        {
           try
            {
                byte[] img2 = null;
                FileStream fs = new FileStream(image2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img2 = br.ReadBytes((int)fs.Length);
                hhbll.insert_hanghoa(txtMaHang.Text, txtTenHang.Text, float.Parse(txtDongia.Text), int.Parse(txtSlcon.Text), cbmTenLoaiHang.SelectedValue.ToString(), img2);
                loadHangHoa();
           }
            catch 
           {
                MessageBox.Show("Ban phải tải hình ảnh lên");
            }
           
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img2 = null;
                FileStream fs = new FileStream(image2, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img2 = br.ReadBytes((int)fs.Length);
                hhbll.update_hanghoa(txtMaHang.Text, txtTenHang.Text, float.Parse(txtDongia.Text), int.Parse(txtSlcon.Text), cbmTenLoaiHang.SelectedValue.ToString(), img2);
                loadHangHoa();
            }
            catch
            {
                hhbll.update_hanghoa_kohinh(txtMaHang.Text, txtTenHang.Text, float.Parse(txtDongia.Text), int.Parse(txtSlcon.Text), cbmTenLoaiHang.SelectedValue.ToString());
                loadHangHoa();
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            txtMaHang.Text = row.Cells[0].Value.ToString();
            txtTenHang.Text = row.Cells[1].Value.ToString();
            txtDongia.Text = row.Cells[2].Value.ToString();
            txtSlcon.Text = row.Cells[3].Value.ToString();
            cbmTenLoaiHang.Text = row.Cells[4].Value.ToString();
            img2 = (byte[])row.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img2);
            pbAnhHangHoa.Image = Image.FromStream(ms);



        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            hhbll.delete_hanghoa(txtMaHang.Text);
            loadHangHoa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string matusinh(DataTable dt)
        {

            string ma = dt.Rows[dt.Rows.Count - 1][0].ToString();
            string ma2 = ma.Substring(2, 2);
            string id = ma.Substring(0, 2);
            if (int.Parse(ma2) < 9)
            {
                return id + "0" + (int.Parse(ma2) + 1);
            }
            else return id + (int.Parse(ma2) + 1);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaLH.Text = matusinh(lhbll.select_loaihang());
            txtTenLH.Text = "";
            txtGhichu.Text = "";
        }

        private void btntaomoi2_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = matusinh(hhbll.select_hanghoa());
            txtTenHang.Text = "";
            txtDongia.Text = "";
            txtSlcon.Text = "";
            
        }
    }
}
