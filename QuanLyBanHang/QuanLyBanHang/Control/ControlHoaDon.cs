using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Model;
using System.Data;
namespace QuanLyBanHang.Control
{
    class ControlHoaDon
    {
        DatabaseSonGaming db;
        public ControlHoaDon()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDsHoaDon()
        {
            string sqlQuery = "select a.mahoadon,c.tennv,b.tenkhachhang,a.ngaydat,a.tongtien from HOADON a,KHACHHANG b, NHANVIEN c where a.makh = b.makh and a.manv = c.manv ";
            DataTable tbHoaDon = db.Execute(sqlQuery);
            return tbHoaDon;
        }

        public DataTable LayDsNhanVien()
        {
            string sqlQuery = "select manv,tennv from NHANVIEN";
            DataTable tbNhanVien = db.Execute(sqlQuery);
            return tbNhanVien;
        }

        public DataTable LayDsKhachHang()
        {
            string sqlQuery = "select makh,tenkhachhang,sodienthoai,diachi from KHACHHANG";
            DataTable tbKhachHang = db.Execute(sqlQuery);
            return tbKhachHang;
        }

        public void ThemHoaDon(string manv,string makh,string ngayban)
        {
            string sqlQuery = string.Format("insert into HOADON values('','{0}','{1}','{2}','')", manv, makh, ngayban);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void XoaHoaDon(string mahd)
        {
            string sqlQuery = string.Format("delete from HOADON where mahoadon = '{0}'", mahd);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaHoaDon(string mahd,string manv,string makh,string ngayban)
        {
            string sqlQuery = string.Format("update HOADON set manv = '{0}',makh='{1}',ngaydat ='{2}' where mahoadon = '{3}'", manv, makh, ngayban,mahd);
            db.ExecuteNonQuery(sqlQuery);
        }

        public DataTable TimKiem(string timkiem)
        {
            string sqlQuery = string.Format("select a.mahoadon,c.tennv,b.tenkhachhang,a.ngaydat,a.tongtien from HOADON a,KHACHHANG b, NHANVIEN c where a.makh = b.makh and a.manv = c.manv and mahoadon = '{0}' or tennv=N'{1}' or tenkhachhang = N'{2}' or ngaydat = '' ", timkiem, timkiem, timkiem, timkiem);
            return db.Execute(sqlQuery);
        }
    }
}
