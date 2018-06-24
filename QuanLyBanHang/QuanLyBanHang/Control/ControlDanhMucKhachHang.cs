
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Model;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanHang.Control
{
    class ControlDanhMucKhachHang
    {
        DatabaseSonGaming db;
        public ControlDanhMucKhachHang()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDSKhachHang()
        {
            string sqlQuery = "select * from KHACHHANG";
            DataTable tbKhachHang = db.Execute(sqlQuery);
            return tbKhachHang;
        }

        public void XoaKhachHang(String makh)
        {
            string sqlQuery = "Delete from KHACHHANG where makh = " + makh;
            db.ExecuteNonQuery(sqlQuery);
        }

        public void ThemKhachHang(string tenkh, string taikhoan, string matkhau, string dienthoai, string diachi)
        {
            string sqlQuery = string.Format("Insert Into KhachHang Values(N'{0}','{1}','{2}','{3}',N'{4}')", tenkh, taikhoan,matkhau, dienthoai, diachi);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaKhachHang(string makh, string tenkh, string taikhoan, string matkhau, string dienthoai, string diachi)
        {
            string sqlQuery = string.Format("update KHACHHANG set tenkhachhang = N'{0}',taikhoan='{1}',matkhau='{2}',sodienthoai='{3}',diachi=N'{4}' where makh='{5}'", tenkh, taikhoan, matkhau, dienthoai, diachi,makh);
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
