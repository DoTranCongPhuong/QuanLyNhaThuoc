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
    public partial class frmthuoc : Form
    {
        thuocctr hhCtr = new thuocctr();
        private int flagLuu = 0;
        public frmthuoc()
        {
            InitializeComponent();
        }

        private void frmthuoc_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dtgvDS.DataSource, "MaThuoc");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dtgvDS.DataSource, "TenThuoc");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dtgvDS.DataSource, "DonGia");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dtgvDS.DataSource, "SoLuong");
        }

        private void clearData()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtDonGia.Text = "";
            txtSL.Text = "0";
        }

        private void addData(thuocobj hh)
        {
            hh.MaHangHoa = txtma.Text.Trim();
            hh.DonGia = int.Parse(txtDonGia.Text.Trim());
            hh.SoLuong = int.Parse(txtSL.Text.Trim());
            hh.TenHangHoa = txtten.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtma.Enabled = e;
            txtten.Enabled = e;
            txtDonGia.Enabled = e;
            txtSL.Enabled = false;
            btnNhapHang.Enabled = !e;
            btnquaylai.Enabled = !e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhCtr.DelData(txtma.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmthuoc_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            thuocobj hhObj = new thuocobj();
            addData(hhObj);
            if (flagLuu == 0)
            {
                if (hhCtr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flagLuu == 1)
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmthuoc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmthuoc_Load(sender, e);
            else
                return;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            flagLuu = 2;
            btnNhapHang.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtSL.Enabled = true;

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
