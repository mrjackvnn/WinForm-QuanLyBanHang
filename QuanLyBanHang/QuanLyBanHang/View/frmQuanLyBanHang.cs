﻿using System;
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
        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            HienThiIntro();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            HienThiQuanLySanPham();
        }
    }
}