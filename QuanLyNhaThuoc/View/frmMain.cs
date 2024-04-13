using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            View.frmKhachHang frmkh = new View.frmKhachHang();
            frmkh.ShowDialog();
        }
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            View.frmNhanVien frmnv = new View.frmNhanVien();
            frmnv.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            View.frmhd frmhd = new View.frmhd();
            frmhd.ShowDialog();
        }

        private void mnuThuoc_Click(object sender, EventArgs e)
        {
            View.frmthuoc frmt = new View.frmthuoc();
            frmt.ShowDialog();
        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {
            View.BaoCao baocao = new View.BaoCao();
            baocao.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
