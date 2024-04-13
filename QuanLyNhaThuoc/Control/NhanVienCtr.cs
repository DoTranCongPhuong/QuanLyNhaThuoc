using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaThuoc.Object;
using QuanLyNhaThuoc.Model;

namespace QuanLyNhaThuoc.Control
{
    class NhanVienCtr
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool UpdMK(NhanVienObj nvObj)
        {
            return nvMod.UpdMK(nvObj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
