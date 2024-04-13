using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc.Object
{
    class NhanVienObj
    {
        
        string ma, ten, gioitinh, diachi, sdt;
        string namsinh;

        public string NamSinh { get => namsinh; set => namsinh = value; }

        public string SDT { get => sdt; set => sdt = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string TenNhanVien { get => ten; set => ten = value; }
        public string MaNhanVien { get => ma; set => ma = value; }

        public NhanVienObj() { }

        public NhanVienObj(string ma,string ten,string gioitinh,string namsinh,string diachi,string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.namsinh = namsinh;
            this.sdt = sdt;
           

        }
    }
}
