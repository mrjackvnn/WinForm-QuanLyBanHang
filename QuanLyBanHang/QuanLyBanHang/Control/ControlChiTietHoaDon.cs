using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Model;
using System.Data;
namespace QuanLyBanHang.Control
{
    class ControlChiTietHoaDon
    {
        DatabaseSonGaming db; 
        public ControlChiTietHoaDon()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDsChiTietHoaDon(string mahd)
        {
            string sqlQuery = string.Format("select a.masanpham,b.tensanpham,a.soluong,a.dongia,(soluong*dongia) as [thanhtien] from CHITIETHOADON a, SANPHAM b where a.masanpham = b.masanpham and a.mahoadon = '{0}'",mahd);
            return db.Execute(sqlQuery);
        }

        public DataTable LayDsSanPham()
        {
            string sqlQuery = "select * from sanpham";
            return db.Execute(sqlQuery);
        }

        public void XoaSanPham_HoaDon(string masp)
        {
            string sqlQuery = "delete from CHITIETHOADON where masanpham = '" + masp+"'";
            db.ExecuteNonQuery(sqlQuery);
        }

        public void ThemSanPham_HoaDon(string mahd,string masanpham,string soluong,string dongia,int thanhtien)
        {
            thanhtien = int.Parse(dongia) * int.Parse(soluong);
            string sqlQuery = string.Format("insert into CHITIETHOADON values('{0}','{1}','{2}','{3}','{4}')",mahd,masanpham,soluong,dongia,thanhtien.ToString());
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaSanPham_HoaDon(string mahd,string masanpham, string soluong)
        {
            string sqlQuery = string.Format("update CHITIETHOADON set soluong = '{0}',thanhtien = dongia*soluong where mahoadon = '{1}' and masanpham = '{2}'",soluong,mahd,masanpham);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void CapNhatLaiHoaDon()
        {
            string sqlQuery = "update HOADON set tongtien = (select sum(thanhtien) from CHITIETHOADON a where a.mahoadon = b.mahoadon) from HOADON b";
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
