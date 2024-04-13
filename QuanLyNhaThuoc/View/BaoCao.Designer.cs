
namespace QuanLyNhaThuoc.View
{
    partial class BaoCao
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
            this.rpvbaocao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvbaocao
            // 
            this.rpvbaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvbaocao.Location = new System.Drawing.Point(3, 16);
            this.rpvbaocao.Name = "rpvbaocao";
            this.rpvbaocao.ServerReport.BearerToken = null;
            this.rpvbaocao.Size = new System.Drawing.Size(656, 395);
            this.rpvbaocao.TabIndex = 0;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(175, 24);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(102, 20);
            this.dtpNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Ngày";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(364, 25);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Tạo Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rpvbaocao);
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 414);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Enabled = false;
            this.btnquaylai.Location = new System.Drawing.Point(487, 22);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(74, 28);
            this.btnquaylai.TabIndex = 7;
            this.btnquaylai.Text = "Quay Lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 485);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgay);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvbaocao;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnquaylai;
    }
}