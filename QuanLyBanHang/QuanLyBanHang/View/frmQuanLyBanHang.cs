using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View
{
    public partial class frmQuanLyBanHang : Form
    {
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }
        void HienThiIntro()
        {
            frmIntroduce f = new frmIntroduce();
            f.MdiParent = this;
            f.Show();
        }
        void HienThiQuanLySanPham()
        {
            frmSanPham f = new frmSanPham();
            f.MdiParent = this;
            f.Show();
        }
        void HienThiQuanLyKhachHang()
        {
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }
        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            HienThiIntro();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            HienThiQuanLySanPham();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            HienThiQuanLyKhachHang();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQuanLyBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát không?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
