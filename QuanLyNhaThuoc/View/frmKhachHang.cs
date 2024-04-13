using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.Control;
using QuanLyNhaThuoc.Object;
namespace QuanLyNhaThuoc.View
{
    public partial class frmKhachHang : Form
    {
        KhachHangCtr khctr = new KhachHangCtr();
        KhachHangObj khobj = new KhachHangObj();
        
        private int flagLuu=0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtkhachhang = new DataTable();
            dtkhachhang = khctr.GetData();
            dgvkhachhang.DataSource = dtkhachhang;
            binhding();
            DisEnl(false);

        }
        private void binhding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvkhachhang.DataSource, "MAKH");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvkhachhang.DataSource, "TenKH");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvkhachhang.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvkhachhang.DataSource, "SDT");
            dtnamsinh.DataBindings.Clear();
            dtnamsinh.DataBindings.Add("Text", dgvkhachhang.DataSource, "NamSinh");
        }
        private void DisEnl(bool e)
        {
            txtma.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtSDT.Enabled = e;
            gtnam.Enabled = e;
            dtnamsinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnquaylai.Enabled = !e;
      
        }
        void ganDuLieu(KhachHangObj khobj)
        {


            khobj.MaKhachHang = txtma.Text.Trim();
            khobj.TenKhachHang = txtten.Text.Trim();
            khobj.NamSinh = dtnamsinh.Text.Trim();
            if (gtnam.Checked)
            {
                khobj.GioiTinh = gtnam.Checked.ToString();
            }
            else
            {
                khobj.GioiTinh = "false";
            }
            khobj.DiaChi = txtdiachi.Text.Trim();
            khobj.SDT = txtSDT.Text.Trim();

        }
        void cleardata()
        {

            txtten.Text = "";
            dtnamsinh.Text = DateTime.Now.Date.ToShortDateString();
            txtdiachi.Text = "";
            txtSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            int ra1 = ra.Next(1, 50);
            int count = dgvkhachhang.Rows.Count;
            if (count > 9)
            {
                txtma.Text = "KH" + count++ + "-" + ra1;
            }
            else
            {
                txtma.Text = "KH01" + count++ + "-" + ra1;
            }
            flagLuu = 0;
            DisEnl(true);
            dtnamsinh.Text = DateTime.Now.Date.ToShortDateString();
            cleardata();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khctr.DelData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmKhachHang_Load(sender, e);
            DisEnl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(khobj);
            if (flagLuu == 0)
            {
                if (khctr.AddData(khobj))
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khctr.UpdData(khobj))
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
            DisEnl(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            DisEnl(false);
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
           
            this.Close();
             
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
