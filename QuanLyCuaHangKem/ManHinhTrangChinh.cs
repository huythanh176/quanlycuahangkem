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
    public partial class ManHinhTrangChinh : UserControl
    {
        public ManHinhTrangChinh()
        {
            InitializeComponent();
        }
        banBLL banBLL= new banBLL();
        CTHD_BLL cthdbll = new CTHD_BLL();
        public void ManHinhTrangChinh_Load(object sender, EventArgs e)
        {

            loadBan();
            
        }

        public void loadBan()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = banBLL.select_ban();

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                Button ban = new Button() { Height = banBLL.bandal.chieudaiban, Width = banBLL.bandal.chieurongban };
                ban.ImageList = imageList1;
                ban.ImageIndex = 0;
                ban.Tag = dt.Rows[i][0].ToString();
                ban.ImageAlign = ContentAlignment.TopCenter;
                ban.Text = dt.Rows[i][1].ToString();
                ban.ForeColor = Color.Red;
                if ((bool)dt.Rows[i][2] == false)
                {
                    ban.ImageIndex = 0;
                    ban.ForeColor = Color.Green;
                }
                else
                {
                    ban.ImageIndex = 1;
                    ban.ForeColor = Color.Red;
                }
                ban.Font = new Font("Arial", 17);
                ban.TextAlign = ContentAlignment.BottomCenter;
                flowLayoutPanel1.Controls.Add(ban);
                ban.ContextMenuStrip = contextMenuStrip1;
                ban.Click += Ban_Click;
            }
        }
        string maban=null;
        private void Ban_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            dtgvHoaDon.DataSource = cthdbll.CTHD_select_theoban_ckt(btn.Tag.ToString());
            lbTongtien.Text = "";
            maban = btn.Tag.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        HOADON_BLL hdbll = new HOADON_BLL();
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0;i<dtgvHoaDon.Rows.Count;i++)
            {
                sum+=int.Parse(dtgvHoaDon.Rows[i].Cells[2].Value.ToString());
            }
            lbTongtien.Text = sum + "";
          
            banBLL.ban_update(maban, false);
            hdbll.hoadon_update_tinhtrang(maban, "kt");
            dtgvHoaDon.Refresh();
            loadBan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt, dt1, dt2,dt3,dt4;
 
            dt = banBLL.ban_select_theomaban(maban);
           
            gopban gopban1 = new gopban();
            gopban1.textBox1.Text = dt.Rows[0][0].ToString();
            gopban1.comboBox1.DataSource= banBLL.ban_select_theotinhtrang(true);
            gopban1.comboBox1.ValueMember = "MaBan";
            gopban1.comboBox1.DisplayMember = "TenBan";
            gopban1.ShowDialog();
            string banmuonchuyentoi = gopban1.comboBox1.SelectedValue.ToString();          
            dt1 = hdbll.select_mahd_theomban(maban);
            dt2 = hdbll.select_mahd_theomban(banmuonchuyentoi); 
            dt3 = cthdbll.CTHD_select_theoMAHD(dt1.Rows[0][0].ToString());
            dt4 = cthdbll.CTHD_select_theoMAHD(dt2.Rows[0][0].ToString());
            for(int i=0;i<dt4.Rows.Count;i++)
            {
                for(int j=0;j<dt3.Rows.Count;j++)
                {
                    if(dt3.Rows[j][1].ToString()== dt4.Rows[i][1].ToString())
                    {
                        cthdbll.cthd_update(dt4.Rows[i][0].ToString(),dt4.Rows[i][1].ToString(), int.Parse(dt4.Rows[i][2].ToString()) + int.Parse(dt3.Rows[i][2].ToString()));
                        cthdbll.cthd_delete(dt3.Rows[j][0].ToString(), dt3.Rows[j][1].ToString());
                    }
                }

            }
            hdbll.hoadon_update_gopban(dt1.Rows[0][0].ToString(), dt2.Rows[0][0].ToString());
            hdbll.hoadon_update_tinhtrang(maban, "kt");
            banBLL.ban_update(maban, false);
            MessageBox.Show("Gộp bàn thành công");
            loadBan();
            

            
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt, dt1;
   
            dt = banBLL.ban_select_theomaban(maban);

            chuyenban chuyenban1 = new chuyenban();
            chuyenban1.textBox1.Text = dt.Rows[0][0].ToString();
            chuyenban1.comboBox1.DataSource = banBLL.ban_select_theotinhtrang(false);
            chuyenban1.comboBox1.ValueMember = "MaBan";
            chuyenban1.comboBox1.DisplayMember = "TenBan";
            chuyenban1.ShowDialog();
            string banmuonchuyentoi = chuyenban1.comboBox1.SelectedValue.ToString();
            dt1 = hdbll.select_mahd_theomban(maban);
          
            hdbll.hoadon_update_chuyenban(dt1.Rows[0][0].ToString(), banmuonchuyentoi);
            hdbll.hoadon_update_tinhtrang(maban, "kt");
            banBLL.ban_update(maban, false);
            banBLL.ban_update(banmuonchuyentoi, true);
            MessageBox.Show("Gộp bàn thành công");
            loadBan();
        }

        private void thêmBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = banBLL.select_ban();
            int row = dt.Rows.Count - 1;
            string maban = "MB" + (row+1);
            string tenban = "Bàn" + " " + (row + 1);
            banBLL.ban_insert(maban, tenban, false);
            loadBan();
        }
 
        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = banBLL.select_ban();
            int row = dt.Rows.Count - 1;
            string maban1 = "MB" + (row);
            banBLL.ban_delete(maban1);
            loadBan();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dt= cthdbll.CTHD_select_theoban_ckt(maban);
            rpInHoaDon rp = new rpInHoaDon();
            rp.SetDataSource(dt);
            Formrpinhoadon frmInhd = new Formrpinhoadon();
            frmInhd.crystalReportViewer1.ReportSource = rp;
            frmInhd.ShowDialog();
        }
        
        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
