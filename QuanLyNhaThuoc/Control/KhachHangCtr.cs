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
    class KhachHangCtr
    {
        KhachHangMod khMod = new KhachHangMod();
        public DataTable GetData()
        {
            return khMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return khMod.UpdData(khObj);
        }
        
        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
