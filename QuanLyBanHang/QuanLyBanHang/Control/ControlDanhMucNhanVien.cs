using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Control
{
    class ControlDanhMucNhanVien
    {
        DatabaseSonGaming db;
        public ControlDanhMucNhanVien()
        {
            db = new DatabaseSonGaming();
        }

        public DataTable LayDSNhanVien()
        {
            string sqlQuery = "select manv,tennv,gioitinh = (case when gioitinh= 1 then 'Nam' when gioitinh=0 then N'Nữ' end),diachi,dienthoai,ngaysinh from NHANVIEN";
            DataTable tbNhanVien = db.Execute(sqlQuery);
            return tbNhanVien;
        }

        public void XoaNhanVien(string manv)
        {
            string sqlQuery = "Delete from Nhanvien where manv = '" + manv+"'";
            db.ExecuteNonQuery(sqlQuery);
        }

        public void ThemNhanVien(string tennv, string gioitinh, string diachi, string dienthoai, string ngaysinh)
        {
            string sqlQuery = string.Format("Insert Into Nhanvien Values('',N'{0}','{1}',N'{2}','{3}','{4}')", tennv, gioitinh, diachi, dienthoai, ngaysinh);
            db.ExecuteNonQuery(sqlQuery);
        }

        public void SuaNhanVien(string manv, string tennv, string gioitinh, string diachi, string dienthoai, string ngaysinh)
        {
            string sqlQuery = string.Format("update nhanvien set tennv = N'{0}',gioitinh='{1}',diachi=N'{2}',dienthoai='{3}',ngaysinh='{4}' where manv='{5}'", tennv, gioitinh, diachi, dienthoai, ngaysinh, manv);
            db.ExecuteNonQuery(sqlQuery);
        }
    }
}
