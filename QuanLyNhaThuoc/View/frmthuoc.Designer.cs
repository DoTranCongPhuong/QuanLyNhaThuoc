
namespace QuanLyNhaThuoc.View
{
    partial class frmthuoc
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(548, 186);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 40);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(212, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 40);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(436, 186);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 40);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDS);
            this.groupBox2.Location = new System.Drawing.Point(10, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 165);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            this.dtgvDS.AllowUserToOrderColumns = true;
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.Location = new System.Drawing.Point(3, 16);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.Size = new System.Drawing.Size(772, 146);
            this.dtgvDS.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNhapHang);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(10, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 137);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Location = new System.Drawing.Point(137, 103);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(99, 28);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(137, 59);
            this.txtSL.MaxLength = 50;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(132, 20);
            this.txtSL.TabIndex = 2;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "(VNĐ)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng hóa";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(490, 58);
            this.txtDonGia.MaxLength = 50;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(175, 20);
            this.txtDonGia.TabIndex = 0;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(490, 26);
            this.txtten.MaxLength = 30;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(256, 20);
            this.txtten.TabIndex = 0;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(137, 30);
            this.txtma.MaxLength = 10;
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 20);
            this.txtma.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(324, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 40);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(100, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 40);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Enabled = false;
            this.btnquaylai.Location = new System.Drawing.Point(662, 186);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(84, 40);
            this.btnquaylai.TabIndex = 31;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // frmthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmthuoc";
            this.Text = "frmthuoc";
            this.Load += new System.EventHandler(this.frmthuoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnquaylai;
    }
}