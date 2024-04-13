using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaThuoc.Object;
using QuanLyNhaThuoc.Control;
namespace QuanLyNhaThuoc.View
{
    public partial class frmhd : Form
    {

        HoaDonCtr hdCtr = new HoaDonCtr();
        ChiTietCrt ctCtr = new ChiTietCrt();
        thuocctr hhctr = new thuocctr();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;
        public frmhd()
        {
            InitializeComponent();
        }

        private void frmhd_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            Dis_Enl(false);
            txtNgayLap.Enabled = false;

        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
            cmbnv.DataBindings.Clear();
            cmbnv.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
        }


        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            cmbnv.Enabled = e;
            cmbKhachHang.Enabled = e;
            btnAdd.Enabled = !e;
            btnDel.Enabled = !e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btncham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbHH.Enabled = e;
            txtSL.Enabled = e;
            button1.Enabled = !e;
            btnquaylai.Enabled = !e;
        }

        private void LoadcmbKhachHang()
        {
            KhachHangCtr khctr = new KhachHangCtr();
            cmbKhachHang.DataSource = khctr.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.SelectedIndex = 0;
        }
        private void loadcmbnv()
        {
            NhanVienCtr nvcrt = new NhanVienCtr();
            cmbnv.DataSource = nvcrt.GetData();
            cmbnv.DisplayMember = "TenNV";
            cmbnv.ValueMember = "MaNV";
            cmbnv.SelectedIndex = 0;
        }
        private void LoadcmbHH()
        {
            thuocctr hhctr = new thuocctr();
            cmbHH.DataSource = hhctr.GetData();
            cmbHH.DisplayMember = "TenThuoc";
            cmbHH.ValueMember = "MaThuoc";

        }

        private void clearData()
        {
          
            loadcmbnv();
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();   
            LoadcmbKhachHang();
            txtDonGia.Text = "0";
        }


        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = cmbnv.SelectedValue.ToString();
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }

        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        private void capnhatSL(string mahh, int sl)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + sl;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }
        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaThuoc = '" + cmbHH.SelectedValue.ToString() + "' and SoLuong>= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        private void dtgvDSHH_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random ra = new Random();
            int ra1 = ra.Next(1, 50);         
            int count = dtgvDSHD.Rows.Count;
            if (count > 9)
            {
                txtMa.Text = "HD" +"-"+ count++ +"-" + ra1;
            }
            else
            {
                txtMa.Text = "HD01" +"-" + count++ +"-" + ra1;
            }
            button1.Enabled = false;
            Dis_Enl(true);
            clearData();
            LoadcmbHH();
            LoadcmbKhachHang();
            dtgvDSHH.Columns.Clear();
            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("HangHoa");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
            
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ctCtr.DelData(txtMa.Text.Trim()) && hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtDSCT.Clear();
            frmhd_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            
            if (hdCtr.AddData(hdObj))
            {
                if (ctCtr.AddData(dtDSCT)&&hhctr.UpdSL(dtDSCT))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết  thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmhd_Load(sender, e);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmhd_Load(sender, e);
            else
                return;
        }
    
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMa.Text))
            {
                if (kiemtraSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text.Trim())))
                {
                    if (!checktrung(cmbHH.SelectedValue.ToString()))
                    {
                        DataRow dr = dtDSCT.NewRow();
                        dr[0] = txtMa.Text.Trim();
                        dr[1] = cmbHH.SelectedValue.ToString();
                        dr[2] = txtDonGia.Text;
                        dr[3] = txtSL.Text;
                        dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
                        dtDSCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text));
                    }
                    dtgvDSHH.DataSource = dtDSCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSL.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMa.Focus();
            }
        }

        private void cmbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable ddt = new DataTable();
            dt = hhctr.GetData("Where MaThuoc = '" + cmbHH.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {

                double gia = double.Parse(dt.Rows[0][2].ToString());

                txtDonGia.Text = (gia * 1.2).ToString();
              
                 
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSHH.DataSource = dtDSCT;
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSHH.DataSource = dt;

            }
            catch
            {
                dtgvDSHH.DataSource = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang frmkh = new frmKhachHang();
            frmkh.ShowDialog();
            
          
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
