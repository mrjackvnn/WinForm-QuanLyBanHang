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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void HienThiIntro()
        {
            frmIntroduce f = new frmIntroduce();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiIntro();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void loạiSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucLoaiSanPham f = new frmDanhMucLoaiSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucNhaSanXuat f = new frmDanhMucNhaSanXuat();
            f.MdiParent = this;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucSanPham f = new frmDanhMucSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucKhachHang f = new frmDanhMucKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucNhanVien f = new frmDanhMucNhanVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
