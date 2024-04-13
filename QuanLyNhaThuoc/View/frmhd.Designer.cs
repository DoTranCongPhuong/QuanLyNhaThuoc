
namespace QuanLyNhaThuoc.View
{
    partial class frmhd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbnv = new System.Windows.Forms.ComboBox();
            this.btncham = new System.Windows.Forms.Button();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbHH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHH = new System.Windows.Forms.DataGridView();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(246, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(365, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu Hóa Đơn";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(365, 28);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Xóa hóa đơn";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(246, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Tạo mới hóa đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDSHD);
            this.groupBox2.Location = new System.Drawing.Point(472, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 212);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.AllowUserToAddRows = false;
            this.dtgvDSHD.AllowUserToDeleteRows = false;
            this.dtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD.Location = new System.Drawing.Point(3, 16);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.ReadOnly = true;
            this.dtgvDSHD.Size = new System.Drawing.Size(446, 193);
            this.dtgvDSHD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbnv);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btncham);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(246, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm Khách Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbnv
            // 
            this.cmbnv.FormattingEnabled = true;
            this.cmbnv.Location = new System.Drawing.Point(102, 115);
            this.cmbnv.Name = "cmbnv";
            this.cmbnv.Size = new System.Drawing.Size(104, 21);
            this.cmbnv.TabIndex = 4;
            // 
            // btncham
            // 
            this.btncham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncham.Location = new System.Drawing.Point(213, 75);
            this.btncham.Name = "btncham";
            this.btncham.Size = new System.Drawing.Size(16, 19);
            this.btncham.TabIndex = 3;
            this.btncham.Text = "...";
            this.btncham.UseVisualStyleBackColor = true;
            this.btncham.Click += new System.EventHandler(this.btncham_Click);
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(102, 156);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(104, 21);
            this.cmbKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(102, 74);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(104, 20);
            this.txtNgayLap.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Location = new System.Drawing.Point(102, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(104, 20);
            this.txtMa.TabIndex = 0;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbHH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBot);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(14, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // cmbHH
            // 
            this.cmbHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.Location = new System.Drawing.Point(102, 54);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(104, 21);
            this.cmbHH.TabIndex = 2;
            this.cmbHH.SelectedIndexChanged += new System.EventHandler(this.cmbHH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thuốc";
            // 
            // btnBot
            // 
            this.btnBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot.Location = new System.Drawing.Point(316, 118);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(75, 21);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "Làm Mới";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(317, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 21);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Chọn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.Location = new System.Drawing.Point(102, 126);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(104, 20);
            this.txtSL.TabIndex = 0;
            this.txtSL.Text = "1";
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(102, 87);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(104, 20);
            this.txtDonGia.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "(VNĐ)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox4.Controls.Add(this.dtgvDSHH);
            this.groupBox4.Location = new System.Drawing.Point(472, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 199);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dtgvDSHH
            // 
            this.dtgvDSHH.AllowUserToAddRows = false;
            this.dtgvDSHH.AllowUserToDeleteRows = false;
            this.dtgvDSHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHH.Location = new System.Drawing.Point(6, 15);
            this.dtgvDSHH.Name = "dtgvDSHH";
            this.dtgvDSHH.ReadOnly = true;
            this.dtgvDSHH.Size = new System.Drawing.Size(443, 178);
            this.dtgvDSHH.TabIndex = 0;
            this.dtgvDSHH.DataSourceChanged += new System.EventHandler(this.dtgvDSHH_DataSourceChanged);
            this.dtgvDSHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHH_CellClick);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Enabled = false;
            this.btnquaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquaylai.Location = new System.Drawing.Point(365, 154);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(81, 25);
            this.btnquaylai.TabIndex = 11;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // frmhd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmhd";
            this.Text = "frmhd";
            this.Load += new System.EventHandler(this.frmhd_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDSHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncham;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDSHH;
        private System.Windows.Forms.ComboBox cmbHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbnv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnquaylai;
    }
}