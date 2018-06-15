using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.Model;
namespace QuanLyBanHang.Control
{
    class QuanLySanPhamControl
    {
        DatabaseSonGaming db;
        public QuanLySanPhamControl()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDanhSachSanPham()
        {
            string sqlQuery = "select a.masanpham,a.tensanpham,b.tenloai,c.tennsx,a.giaban,a.ngaycapnhat,a.hinhsanpham,a.thongtin from SANPHAM a,LOAISANPHAM b, NHASANXUAT c where a.maloai = b.maloai and a.mansx = c.mansx";
            DataTable tbSanPham = db.Execute(sqlQuery);
            return tbSanPham;
        }

        public DataTable LayLoaiSanPham()
        {
            string sqlQuery = "select * from LOAISANPHAM";
            DataTable tbLoaiSanPham = db.Execute(sqlQuery);
            return tbLoaiSanPham;
        }

        public DataTable LayNhaSanXuat()
        {
            string sqlQuery = "select * from NHASANXUAT";
            DataTable tbNhaSanXuat = db.Execute(sqlQuery);
            return tbNhaSanXuat;
        }
        public void XoaSanPham(String masanpham)
        {
            string sqlQuery = "Delete from SanPham where masanpham = "+masanpham;
            db.ExecuteNonQuery(sqlQuery);
        }
        
        public void ThemSanPham(string nhasanxuat,string loaisanpham,string tensanpham,string giaban,string ngaycapnhat,string hinhsanpham,string thongtin)
        {
            string sqlQuery = string.Format("Insert Into SanPham Values('{0}','{1}',N'{2}','{3}','{4}','{5}',N'{6}')",nhasanxuat,loaisanpham, tensanpham, giaban,ngaycapnhat,hinhsanpham,thongtin);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void CapNhatSanPham(string tensp, string nhasanxuat, string loaisanpham, string giaban, string ngaycapnhat,string hinhsanpham, string thongtin,string masanpham)
        {
            string sqlQuery = string.Format("update SANPHAM set tensanpham = N'{0}',maloai='{1}',mansx='{2}',giaban='{3}',ngaycapnhat='{4}',hinhsanpham='{5}',thongtin=N'{6}' where masanpham='{7}'",tensp,loaisanpham,nhasanxuat,giaban,ngaycapnhat,hinhsanpham,thongtin,masanpham);
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
