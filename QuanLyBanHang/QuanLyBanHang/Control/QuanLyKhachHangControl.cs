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
    class QuanLyKhachHangControl
    {
        DatabaseSonGaming db;
        public QuanLyKhachHangControl()
        {
            db = new DatabaseSonGaming();
        }
        public DataTable LayDSKhachHang()
        {
            string sqlQuery = "select * from KHACHHANG";
            DataTable tbKhachHang = db.Execute(sqlQuery);
            return tbKhachHang;
        }
       
    }
}
