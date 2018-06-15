using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Control;
namespace QuanLyBanHang.View
{
    public partial class frmKhachHang : Form
    {
        QuanLyKhachHangControl kh = new QuanLyKhachHangControl();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void HienThiDSKhachHang()
        {
            DataTable tbKhachHang = kh.LayDSKhachHang();
            for(int i=0;i<tbKhachHang.Rows.Count;i++)
            {
                ListViewItem lvi = lsvKhachHang.Items.Add(tbKhachHang.Rows[i][0].ToString());
                lvi.SubItems.Add(tbKhachHang.Rows[i][1].ToString());
                lvi.SubItems.Add(tbKhachHang.Rows[i][2].ToString());
                lvi.SubItems.Add(tbKhachHang.Rows[i][3].ToString());
                lvi.SubItems.Add(tbKhachHang.Rows[i][4].ToString());
                lvi.SubItems.Add(tbKhachHang.Rows[i][5].ToString());
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }
    }
}
