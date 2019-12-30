namespace QuanLyCuaHangKem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnthanhdichuyen = new System.Windows.Forms.Panel();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnTrangchinh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbtenNV = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manHinhTrangChinh1 = new QuanLyCuaHangKem.ManHinhTrangChinh();
            this.manhinhThongke1 = new QuanLyCuaHangKem.manhinhThongke();
            this.manhinhthemmon1 = new QuanLyCuaHangKem.Manhinhthemmon();
            this.manHinhOrder1 = new QuanLyCuaHangKem.ManHinhOrder();
            this.manhinhNhanvien1 = new QuanLyCuaHangKem.manhinhNhanvien();
            this.btnTurnoff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnthanhdichuyen);
            this.panel1.Controls.Add(this.btnBaocao);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnTrangchinh);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 658);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCuaHangKem.Properties.Resources.iceshop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnthanhdichuyen
            // 
            this.pnthanhdichuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnthanhdichuyen.Location = new System.Drawing.Point(186, 95);
            this.pnthanhdichuyen.Name = "pnthanhdichuyen";
            this.pnthanhdichuyen.Size = new System.Drawing.Size(10, 51);
            this.pnthanhdichuyen.TabIndex = 2;
            this.pnthanhdichuyen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnBaocao
            // 
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBaocao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBaocao.Image = global::QuanLyCuaHangKem.Properties.Resources.currency;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(3, 323);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(190, 51);
            this.btnBaocao.TabIndex = 2;
            this.btnBaocao.Text = "     Thống Kê";
            this.btnBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.FlatAppearance.BorderSize = 0;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemMon.Image = global::QuanLyCuaHangKem.Properties.Resources.libra;
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(3, 266);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(190, 51);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "     Thêm Món";
            this.btnThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhanvien.Image = global::QuanLyCuaHangKem.Properties.Resources.manager;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(3, 209);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(190, 51);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "     Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Image = global::QuanLyCuaHangKem.Properties.Resources.wishlist;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(3, 152);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(190, 51);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "     Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnTrangchinh
            // 
            this.btnTrangchinh.FlatAppearance.BorderSize = 0;
            this.btnTrangchinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangchinh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangchinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrangchinh.Image = global::QuanLyCuaHangKem.Properties.Resources.shop;
            this.btnTrangchinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangchinh.Location = new System.Drawing.Point(3, 95);
            this.btnTrangchinh.Name = "btnTrangchinh";
            this.btnTrangchinh.Size = new System.Drawing.Size(190, 51);
            this.btnTrangchinh.TabIndex = 2;
            this.btnTrangchinh.Text = "     Trang chính";
            this.btnTrangchinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangchinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangchinh.UseVisualStyleBackColor = true;
            this.btnTrangchinh.Click += new System.EventHandler(this.btnTrangchinh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(196, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 18);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnTurnoff);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lbtenNV);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(196, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 81);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyCuaHangKem.Properties.Resources.log_out;
            this.button1.Location = new System.Drawing.Point(958, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtenNV
            // 
            this.lbtenNV.Location = new System.Drawing.Point(867, 3);
            this.lbtenNV.Name = "lbtenNV";
            this.lbtenNV.Size = new System.Drawing.Size(76, 23);
            this.lbtenNV.TabIndex = 3;
            this.lbtenNV.Text = "Huy Thành";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(806, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Welcome,";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyCuaHangKem.Properties.Resources.ice_cream_PNG5114;
            this.pictureBox2.Location = new System.Drawing.Point(361, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(287, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 64);
            this.label9.TabIndex = 0;
            this.label9.Text = "E";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(266, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 64);
            this.label8.TabIndex = 0;
            this.label8.Text = "R";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(331, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 64);
            this.label7.TabIndex = 0;
            this.label7.Text = "M";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(307, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 64);
            this.label6.TabIndex = 0;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(247, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 64);
            this.label5.TabIndex = 0;
            this.label5.Text = "C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(201, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "E";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(181, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(162, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "I";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "HayTee ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // manHinhTrangChinh1
            // 
            this.manHinhTrangChinh1.Location = new System.Drawing.Point(196, 93);
            this.manHinhTrangChinh1.Name = "manHinhTrangChinh1";
            this.manHinhTrangChinh1.Size = new System.Drawing.Size(1032, 600);
            this.manHinhTrangChinh1.TabIndex = 7;
            // 
            // manhinhThongke1
            // 
            this.manhinhThongke1.BackColor = System.Drawing.Color.White;
            this.manhinhThongke1.Location = new System.Drawing.Point(195, 94);
            this.manhinhThongke1.Name = "manhinhThongke1";
            this.manhinhThongke1.Size = new System.Drawing.Size(1033, 531);
            this.manhinhThongke1.TabIndex = 6;
            // 
            // manhinhthemmon1
            // 
            this.manhinhthemmon1.BackColor = System.Drawing.Color.White;
            this.manhinhthemmon1.Location = new System.Drawing.Point(196, 93);
            this.manhinhthemmon1.Name = "manhinhthemmon1";
            this.manhinhthemmon1.Size = new System.Drawing.Size(1032, 532);
            this.manhinhthemmon1.TabIndex = 5;
            // 
            // manHinhOrder1
            // 
            this.manHinhOrder1.Location = new System.Drawing.Point(196, 94);
            this.manHinhOrder1.Name = "manHinhOrder1";
            this.manHinhOrder1.Size = new System.Drawing.Size(1044, 553);
            this.manHinhOrder1.TabIndex = 4;
            this.manHinhOrder1.Load += new System.EventHandler(this.manHinhOrder1_Load_1);
            // 
            // manhinhNhanvien1
            // 
            this.manhinhNhanvien1.BackColor = System.Drawing.Color.White;
            this.manhinhNhanvien1.Location = new System.Drawing.Point(196, 94);
            this.manhinhNhanvien1.Name = "manhinhNhanvien1";
            this.manhinhNhanvien1.Size = new System.Drawing.Size(1035, 518);
            this.manhinhNhanvien1.TabIndex = 3;
            // 
            // btnTurnoff
            // 
            this.btnTurnoff.Image = global::QuanLyCuaHangKem.Properties.Resources.turnoff;
            this.btnTurnoff.Location = new System.Drawing.Point(995, 0);
            this.btnTurnoff.Name = "btnTurnoff";
            this.btnTurnoff.Size = new System.Drawing.Size(37, 33);
            this.btnTurnoff.TabIndex = 5;
            this.btnTurnoff.UseVisualStyleBackColor = true;
            this.btnTurnoff.Click += new System.EventHandler(this.btnTurnoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1230, 627);
            this.Controls.Add(this.manHinhTrangChinh1);
            this.Controls.Add(this.manhinhThongke1);
            this.Controls.Add(this.manhinhthemmon1);
            this.Controls.Add(this.manHinhOrder1);
            this.Controls.Add(this.manhinhNhanvien1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTrangchinh;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnthanhdichuyen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private manhinhNhanvien manhinhNhanvien1;
        private ManHinhOrder manHinhOrder1;
        private Manhinhthemmon manhinhthemmon1;
        private manhinhThongke manhinhThongke1;
        private ManHinhTrangChinh manHinhTrangChinh1;
        public System.Windows.Forms.Label lbtenNV;
        private System.Windows.Forms.Button btnTurnoff;
    }
}

