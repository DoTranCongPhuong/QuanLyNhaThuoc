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
    
    public partial class frmNhanVien : Form
    {
        NhanVienCtr nvctrl = new NhanVienCtr();
        NhanVienObj nvObj = new NhanVienObj();
        private int flagLuu = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctrl.GetData();
            dgvDanhSachNhanVien.DataSource = dtNhanVien;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "MaNV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "TenNV");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "SDT");
            dtnamsinh.DataBindings.Clear();
            dtnamsinh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "NamSinh");
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
        void ganDuLieu(NhanVienObj nvObj)
        {
           
            
            nvObj.MaNhanVien = txtma.Text.Trim();
            nvObj.TenNhanVien = txtten.Text.Trim();
            nvObj.NamSinh = dtnamsinh.Text.Trim();
            if (gtnam.Checked)
            {              
                nvObj.GioiTinh = gtnam.Checked.ToString();
            }
            else
            {
                nvObj.GioiTinh = "false";
            }
            nvObj.DiaChi = txtdiachi.Text.Trim();
            nvObj.SDT = txtSDT.Text.Trim();

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
            int count = dgvDanhSachNhanVien.Rows.Count;
            if (count > 9)
            {
                txtma.Text = "NV" + count++ + "-" + ra1;
            }
            else
            {
                txtma.Text = "NV0" + count++ + "-" + ra1;
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
                if (nvctrl.DelData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmNhanVien_Load(sender, e);
            DisEnl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
      
            ganDuLieu(nvObj);
            if(flagLuu==0)
            {
                if (nvctrl.AddData(nvObj))
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvctrl.UpdData(nvObj))
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
            DisEnl(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            DisEnl(false);

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
