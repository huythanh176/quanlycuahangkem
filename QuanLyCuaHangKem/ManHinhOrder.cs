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
using System.IO;
using BLL;

namespace QuanLyCuaHangKem
{
     public partial class ManHinhOrder : UserControl
    {
        public ManHinhOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        LOAIHANG_BLL lhbb = new LOAIHANG_BLL();
        HANGHOA_BLL hhbll = new HANGHOA_BLL();
        HOADON_BLL hdbll = new HOADON_BLL();
        CTHD_BLL cthdbll = new CTHD_BLL();
        banBLL banbll = new banBLL();
        public void ManHinhOrder_Load(object sender, EventArgs e)
        {
            loadLoaihang();
            loadHanghoa();
        }

        public void loadHanghoa()
        {
            DataTable dt;
            dt = hhbll.select_hanghoa();
            Loadmenuhh(dt);
            
        }
        public void Loadmenuhh(DataTable dt)
        {
            flowLayoutPanel2.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel pn = new Panel() { Width = 156, Height = 170 };
                Panel pn2 = new Panel() { Width = 60 };
                PictureBox pb = new PictureBox() { Width = 181, Height = 79, Location = new Point(0, 41) };
                Button btn = new Button() { Tag=dt.Rows[i][0],Text = "Thêm", Location = new Point(3, 130) };
                NumericUpDown nup = new NumericUpDown() { Tag=dt.Rows[i][0],Location = new Point(90, 131), Width = 40, Height = 30 , Minimum=-100, Maximum=100};
                Label lb = new Label() {  Width = 124, Height = 18, Location = new Point(15, 15), Text = dt.Rows[i][1].ToString(), BackColor = Color.Black, ForeColor = Color.White, Font = new Font("Arial", 11), BorderStyle = BorderStyle.Fixed3D, TextAlign = ContentAlignment.MiddleCenter };
                byte[] img = (byte[])dt.Rows[i][5];
                MemoryStream ms = new MemoryStream(img);
                pb.Image = Image.FromStream(ms);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pn.Controls.Add(pb);
                pn.Controls.Add(lb);
                pn.Controls.Add(nup);
                pn.Controls.Add(btn);
                flowLayoutPanel2.Controls.Add(pn);
                flowLayoutPanel2.Controls.Add(pn2);
                btn.Click += Btn_Click;
                

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string i = int.Parse(listView1.Items.Count.ToString())+1+"";

            Button btn = (Button)sender;
            DataTable dt;
            dt = hhbll.select_hanghoa_theomh(btn.Tag.ToString());
            string sl = null;
            foreach (Control pn in this.flowLayoutPanel2.Controls)
            {
                foreach (Control nm in pn.Controls)
                {
                    if (nm.Tag == btn.Tag && nm is NumericUpDown)
                    {
                        sl = nm.Text;
                    }
                }
            }
            if (listView1.Items.Count == 0)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = i;
                lvi.SubItems.Add(dt.Rows[0][1].ToString());
                lvi.SubItems.Add(dt.Rows[0][2].ToString());
                lvi.SubItems.Add(sl);
                lvi.SubItems.Add(dt.Rows[0][0].ToString());
                listView1.Items.Add(lvi);
                sl = null;
            }
            else if (listView1.Items.Count != 0)
            {
                int dem = 0;
                for (int j = 0; j < listView1.Items.Count; j++)
                {

                    if (listView1.Items[j].SubItems[1].Text == dt.Rows[0][1].ToString())
                    {
                        listView1.Items[j].SubItems[3].Text = int.Parse(listView1.Items[j].SubItems[3].Text.ToString()) + int.Parse(sl) + "";
                        break;
                    }
                    dem++;
                    if (dem == listView1.Items.Count)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems[0].Text = i;
                        lvi.SubItems.Add(dt.Rows[0][1].ToString());
                        lvi.SubItems.Add(dt.Rows[0][2].ToString());
                        lvi.SubItems.Add(sl);
                        lvi.SubItems.Add(dt.Rows[0][0].ToString());
                        listView1.Items.Add(lvi);
                        sl = null;
                        break;
                    }
                }
            }
            int sum = 0;
            for (int k = 0; k < listView1.Items.Count; k++)
            {
                if (int.Parse(listView1.Items[k].SubItems[3].Text) <= 0)
                {
                    listView1.Items[k].Remove();
                }
                
            }
            for(int k = 0; k < listView1.Items.Count; k++)
            {
                sum += int.Parse(listView1.Items[k].SubItems[3].Text) * int.Parse(listView1.Items[k].SubItems[2].Text);
            }
            label2.Text = sum + "";
        } 

        public void loadLoaihang()
        {
            DataTable dt;
            dt = lhbb.select_loaihang();
            Loadmenulh(dt);
        }
        public void Loadmenulh(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel pn = new Panel() { Width = 200, Height = 140 };
                pn.BackColor = Color.Brown;
                Label lb = new Label() { Width = 124, Height = 18, Location = new Point(35, 15), Text = dt.Rows[i][1].ToString(), BackColor = Color.Black, ForeColor = Color.White, Font = new Font("Arial", 11), BorderStyle = BorderStyle.Fixed3D, TextAlign = ContentAlignment.MiddleCenter };
                PictureBox pb = new PictureBox() { Tag = dt.Rows[i][0], Width = 155, Height = 86, Location = new Point(20, 44) };
                pn.Controls.Add(pb);
                pn.Controls.Add(lb);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pn);
                byte[] img = (byte[])dt.Rows[i][3];
                MemoryStream ms = new MemoryStream(img);
                pb.Image = Image.FromStream(ms);
                pb.Click += Pb_Click;
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            DataTable dt;
            PictureBox pb =(PictureBox) sender;
            dt = hhbll.select_hanghoa_theomlq(pb.Tag.ToString());
            Loadmenuhh(dt);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (listView1.SelectedItems.Count == 0) return;
            listView1.SelectedItems[0].Remove();
            for (int k = 0; k < listView1.Items.Count; k++)
            {
                sum += int.Parse(listView1.Items[k].SubItems[3].Text) * int.Parse(listView1.Items[k].SubItems[2].Text);
            }
            label2.Text = sum + "";
        }

        private void radMangve_CheckedChanged(object sender, EventArgs e)
        {
            if(radMangve.Checked==true)
            {
                cbmdsban.Text = "Mang về";

            }
        }

        private void radTaiban_CheckedChanged(object sender, EventArgs e)
        {
            if(radTaiban.Checked==true)
            {
                
                cbmdsban.DataSource = banbll.ban_select_theotinhtrang(false);
                cbmdsban.ValueMember = "MaBan";
                cbmdsban.DisplayMember = "TenBan";

            }
        }
        public string tennv;
        TAIKHOAN_BLL tkbll = new TAIKHOAN_BLL();
        private void btnDatmon_Click(object sender, EventArgs e)
        {
            DataTable dt,dt2,dt3;
            dt = hdbll.select_hoadon();
            dt2 = hhbll.select_hanghoa();
            dt3 = tkbll.select_chucvu_theoTenNV(tennv);
            DateTime date = DateTime.Now;
            if (radTaiban.Checked)
                { hdbll.insert_noadon(matusinh(dt), date, dt3.Rows[0][1].ToString(), cbmdsban.SelectedValue.ToString(),"ckt"); }
            else hdbll.insert_noadon(matusinh(dt), date, dt3.Rows[0][1].ToString(), "Mangve","kt");
            
         
            for(int i=0;i<listView1.Items.Count ;i++)

            {
                
                cthdbll.insert_cthd(matusinh(dt), listView1.Items[i].SubItems[4].Text, int.Parse(listView1.Items[i].SubItems[3].Text));
                hhbll.hanghoa_update_soluong(listView1.Items[i].SubItems[4].Text, int.Parse(dt2.Rows[i][3].ToString()) - int.Parse(listView1.Items[i].SubItems[3].Text));
            }
            banbll.ban_update(cbmdsban.SelectedValue.ToString(), true);
          
            MessageBox.Show("Dat Mon Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listView1.Items.Clear();

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
    }
}
