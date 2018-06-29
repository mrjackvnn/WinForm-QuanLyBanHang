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
    public partial class frmDanhMucLoaiSanPham : Form
    {
        bool themmoi;
        ControlDanhMucNSXvsLSP dm = new ControlDanhMucNSXvsLSP();
        public frmDanhMucLoaiSanPham()
        {
            InitializeComponent();
        }

        void HienThiLSP()
        {
            DataTable lsp = dm.LayDanhSachLSP();
            for (int i = 0; i < lsp.Rows.Count; i++)
            {
                ListViewItem lvi = lsvLoaiSanPham.Items.Add(lsp.Rows[i][0].ToString());
                lvi.SubItems.Add(lsp.Rows[i][1].ToString());
            }
        }
        private void lsvLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLoaiSanPham.SelectedIndices.Count > 0)
            {
                txtMaLoai.Text = lsvLoaiSanPham.SelectedItems[0].SubItems[0].Text;
                txtTenLoai.Text = lsvLoaiSanPham.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void frmDanhMucLoaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiLSP();
            setButton(true);
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            txtTenLoai.Enabled = !val;
        }

        void setNull()
        {
            txtMaLoai.Text = null;
            txtTenLoai.Text = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setNull();
            txtTenLoai.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvLoaiSanPham.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa " + txtTenLoai.Text + " khỏi danh mục loại sản phẩm không?", "Thông Báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lsvLoaiSanPham.Items.Clear();
                    dm.XoaLSP(txtMaLoai.Text);
                    HienThiLSP();
                    setNull();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn loại sản phẩm cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvLoaiSanPham.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Chọn loại sản phẩm cần sửa!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                dm.ThemLSP(txtTenLoai.Text);
                MessageBox.Show("Đã thêm thành công!!!");

            }
            else
            {
                dm.SuaLSP(txtMaLoai.Text, txtTenLoai.Text);
                MessageBox.Show("Sửa thành công!!!");
            }
            lsvLoaiSanPham.Items.Clear();
            setNull();
            HienThiLSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhMucLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không???", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
