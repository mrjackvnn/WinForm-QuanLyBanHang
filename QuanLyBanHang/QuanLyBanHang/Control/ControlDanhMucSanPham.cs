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
    class ControlDanhMucSanPham
    {
        DatabaseSonGaming db;
        public ControlDanhMucSanPham()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDanhSachSanPham()
        {
            string sqlQuery = "select a.masanpham,a.tensanpham,b.tenloai,c.tennsx,a.giamua,a.giaban,a.soluongton,a.ngaycapnhat,a.hinhsanpham,a.thongtin from SANPHAM a,LOAISANPHAM b, NHASANXUAT c where a.maloai = b.maloai and a.mansx = c.mansx";
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

        public DataTable TimKiem(string timkiem)
        {
            string sqlQuery = string.Format("select * from DSSanPham where masanpham = '{0}' or tennsx=N'{1}' or tenloai = N'{2}' or tensanpham = N'{3}' ", timkiem, timkiem, timkiem, timkiem);
            return db.Execute(sqlQuery);
        }

        public void XoaSanPham(String masanpham)
        {
            string sqlQuery = "Delete from SanPham where masanpham = '"+masanpham+"'";
            db.ExecuteNonQuery(sqlQuery);
        }
        
        public void ThemSanPham(string nhasanxuat,string loaisanpham,string tensanpham,string giamua,string giaban,string slton,string ngaycapnhat,string hinhsanpham,string thongtin)
        {
            string sqlQuery = string.Format("Insert Into SanPham Values(' ','{0}','{1}',N'{2}','{3}','{4}','{5}','{6}','{7}',N'{8}')",nhasanxuat,loaisanpham, tensanpham,giamua,giaban,slton,ngaycapnhat,hinhsanpham,thongtin);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void CapNhatSanPham(string tensp, string nhasanxuat, string loaisanpham,string giamua ,string giaban,string slton, string ngaycapnhat,string hinhsanpham, string thongtin,string masanpham)
        {
            string sqlQuery = string.Format("update SANPHAM set tensanpham = N'{0}',maloai='{1}',mansx='{2}',giamua='{3}',giaban='{4}',soluongton='{5}',ngaycapnhat='{6}',hinhsanpham='{7}',thongtin=N'{8}' where masanpham='{9}'",tensp,loaisanpham,nhasanxuat,giamua,giaban,slton,ngaycapnhat,hinhsanpham,thongtin,masanpham);
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
