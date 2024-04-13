using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaThuoc.Object;
namespace QuanLyNhaThuoc.Model
{
    class KhachHangMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MAKH, TenKH, GioiTinh, NamSinh, DiaChi, SDT  from tb_KhachHang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "Insert into tb_KhachHang values ('" + khObj.MaKhachHang+ "',N'" + khObj.TenKhachHang + "',N'" + khObj.GioiTinh + "',CONVERT(DATE,'" + khObj.NamSinh + "',103),N'" + khObj.DiaChi + "','" + khObj.SDT + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "Update tb_KhachHang set TenKH =  N'" + khObj.TenKhachHang + "', GioiTinh = N'" + khObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + khObj.NamSinh + "',103), DiaChi = N'" + khObj.DiaChi + "',SDT = '" + khObj.SDT + "' Where MaKH = '" + khObj.MaKhachHang + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

       

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_KhachHang Where MaKH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
