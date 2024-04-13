
namespace QuanLyNhaThuoc.View
{
    partial class frmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gtnu = new System.Windows.Forms.RadioButton();
            this.gtnam = new System.Windows.Forms.RadioButton();
            this.dtnamsinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gtnu);
            this.groupBox1.Controls.Add(this.gtnam);
            this.groupBox1.Controls.Add(this.dtnamsinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // gtnu
            // 
            this.gtnu.AutoSize = true;
            this.gtnu.Location = new System.Drawing.Point(149, 138);
            this.gtnu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtnu.Name = "gtnu";
            this.gtnu.Size = new System.Drawing.Size(45, 20);
            this.gtnu.TabIndex = 16;
            this.gtnu.TabStop = true;
            this.gtnu.Text = "Nữ";
            this.gtnu.UseVisualStyleBackColor = true;
            // 
            // gtnam
            // 
            this.gtnam.AutoSize = true;
            this.gtnam.Location = new System.Drawing.Point(149, 102);
            this.gtnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtnam.Name = "gtnam";
            this.gtnam.Size = new System.Drawing.Size(57, 20);
            this.gtnam.TabIndex = 15;
            this.gtnam.TabStop = true;
            this.gtnam.Tag = "";
            this.gtnam.Text = "Nam";
            this.gtnam.UseVisualStyleBackColor = true;
            // 
            // dtnamsinh
            // 
            this.dtnamsinh.Enabled = false;
            this.dtnamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnamsinh.Location = new System.Drawing.Point(855, 37);
            this.dtnamsinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtnamsinh.Name = "dtnamsinh";
            this.dtnamsinh.Size = new System.Drawing.Size(147, 22);
            this.dtnamsinh.TabIndex = 13;
            this.dtnamsinh.Value = new System.DateTime(2021, 1, 6, 10, 16, 40, 0);
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(855, 98);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(147, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.Location = new System.Drawing.Point(459, 98);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(248, 22);
            this.txtdiachi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(459, 37);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(147, 22);
            this.txtten.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giới Tính";
            // 
            // txtma
            // 
            this.txtma.HideSelection = false;
            this.txtma.Location = new System.Drawing.Point(149, 37);
            this.txtma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(147, 22);
            this.txtma.TabIndex = 2;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(16, 314);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1035, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(4, 19);
            this.dgvDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(1027, 202);
            this.dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnquaylai);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(16, 212);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1035, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Enabled = false;
            this.btnquaylai.Location = new System.Drawing.Point(888, 34);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(99, 34);
            this.btnquaylai.TabIndex = 6;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(725, 34);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 34);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(556, 34);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(397, 34);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(235, 34);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(61, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtnamsinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton gtnu;
        private System.Windows.Forms.RadioButton gtnam;
        private System.Windows.Forms.Button btnquaylai;
    }
}