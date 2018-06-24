using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Model;
namespace QuanLyBanHang.Control
{
    class ControlDanhMucNSXvsLSP
    {
        DatabaseSonGaming db;
        public ControlDanhMucNSXvsLSP()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDanhSachNSX()
        {
            string sqlQuery = "select * from NHASANXUAT";
            DataTable tbNhaSanXuat = db.Execute(sqlQuery);
            return tbNhaSanXuat;
        }

        public DataTable LayDanhSachLSP()
        {
            string sqlQuery = "select * from LOAISANPHAM";
            DataTable tbLoaiSanPham = db.Execute(sqlQuery);
            return tbLoaiSanPham;
        }
        
        public void ThemNSX(string tennsx)
        {
            string sqlQuery = string.Format("Insert into NHASANXUAT values (N'{0}')",tennsx);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void XoaNSX(string mansx)
        {
            string sqlQuery = "Delete from NHASANXUAT where mansx = " + mansx;
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaNSX(string mansx,string tennsx)
        {
            string sqlQuery = string.Format("update NHASANXUAT set tennsx=N'{0}' where mansx='{1}'", tennsx, mansx);
            db.ExecuteNonQuery(sqlQuery);
        }



        public void ThemLSP(string tenlsp)
        {
            string sqlQuery = string.Format("Insert into LOAISANPHAM values (N'{0}')", tenlsp);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void XoaLSP(string malsp)
        {
            string sqlQuery = "Delete from LOAISANPHAM where maloai = " + malsp;
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaLSP(string malsp, string tenlsp)
        {
            string sqlQuery = string.Format("update NHASANXUAT set tennsx=N'{0}' where mansx='{1}'", tenlsp, malsp);
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
