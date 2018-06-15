using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Model;
namespace QuanLyBanHang.Control
{
    class ThongKeControl
    {
        DatabaseSonGaming db;
        public ThongKeControl()
        {
            db = new DatabaseSonGaming();
        }
        public DataTable LayBangThongKe()
        {
            DataTable tbThongKe = db.Execute("select CONVERT(date,a.ngaydat,103),sum(b.soluong*b.dongia) from HOADON a, CHITIETHOADON b where a.mahoadon = b.mahoadon group by CONVERT(date, a.ngaydat, 103)");
            return tbThongKe;
        }
    }
}
