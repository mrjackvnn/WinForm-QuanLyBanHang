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
using QuanLyBanHang.Model;
using QuanLyBanHang.Report;
namespace QuanLyBanHang.View
{
    public partial class frmChiTietHoaDon : Form
    {
        bool themmoi;
        DatabaseSonGaming db = new DatabaseSonGaming();
        ControlChiTietHoaDon cthd = new ControlChiTietHoaDon();
        public frmChiTietHoaDon(string mahd)
        {
            InitializeComponent();
            txtMaHoaDon.Text = mahd;
        }

        void ComboBoxTenSanPham()
        {
            DataTable tbSanPham = cthd.LayDsSanPham();
            cbbTenSanPham.DataSource = tbSanPham;
            cbbTenSanPham.DisplayMember = "tensanpham";
            cbbTenSanPham.ValueMember = "masanpham";
            cbbTenSanPham.SelectedValue = -1;
        }

        void HienThiChiTietHoaDon()
        {
            DataTable tbChiTiet = cthd.LayDsChiTietHoaDon(txtMaHoaDon.Text);
            for(int i=0;i<tbChiTiet.Rows.Count;i++)
            {
                ListViewItem lvi = lsvChiTietHoaDon.Items.Add(tbChiTiet.Rows[i][0].ToString());
                lvi.SubItems.Add(tbChiTiet.Rows[i][1].ToString());
                lvi.SubItems.Add(tbChiTiet.Rows[i][2].ToString());
                lvi.SubItems.Add(tbChiTiet.Rows[i][3].ToString());
                lvi.SubItems.Add(tbChiTiet.Rows[i][4].ToString());
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
            ComboBoxTenSanPham();
        }

        private void lsvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvChiTietHoaDon.SelectedIndices.Count>0)
            {
                txtMaSanPham.Text = lsvChiTietHoaDon.SelectedItems[0].SubItems[0].Text;
                cbbTenSanPham.SelectedIndex = cbbTenSanPham.FindString(lsvChiTietHoaDon.SelectedItems[0].SubItems[1].Text);
                nudSoLuong.Value = int.Parse(lsvChiTietHoaDon.SelectedItems[0].SubItems[2].Text);
                txtDonGia.Text = lsvChiTietHoaDon.SelectedItems[0].SubItems[3].Text;
                decimal thanhtien = decimal.Parse(txtDonGia.Text) * (nudSoLuong.Value);
                txtThanhTien.Text = thanhtien.ToString();
            }
        }

        private void cbbTenSanPham_TextChanged(object sender, EventArgs e)
        {
            txtMaSanPham.Text = db.LayGiaTriCuaBang("select masanpham from sanpham where masanpham = '"+cbbTenSanPham.SelectedValue+"'");
            txtDonGia.Text = db.LayGiaTriCuaBang("select giaban from sanpham where masanpham = '" + cbbTenSanPham.SelectedValue + "'");
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnThoat.Enabled = val;
            cbbTenSanPham.Enabled = !val;
            txtDonGia.Enabled = !val;
            nudSoLuong.Enabled = !val;
            grbTimKiem.Enabled = !val;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            nudSoLuong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cthd.XoaSanPham_HoaDon(lsvChiTietHoaDon.SelectedItems[0].SubItems[0].Text);
                    lsvChiTietHoaDon.Items.Clear();
                    HienThiChiTietHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            setButton(false);
            cbbTenSanPham.Enabled = false;
            txtDonGia.Enabled = false;
            nudSoLuong.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                cthd.ThemSanPham_HoaDon(txtMaHoaDon.Text,txtMaSanPham.Text,nudSoLuong.Value.ToString(),txtDonGia.Text,int.Parse(txtThanhTien.Text));
                cthd.CapNhatLaiHoaDon();
                MessageBox.Show("Thêm Thành Công!!!", "Thông Báo");
            }
            else
            {
                cthd.SuaSanPham_HoaDon(txtMaHoaDon.Text,txtMaSanPham.Text, nudSoLuong.Value.ToString());
                cthd.CapNhatLaiHoaDon();
                MessageBox.Show("Cập nhật thành công!!!", "Thông Báo");
            }
            lsvChiTietHoaDon.Items.Clear();
            HienThiChiTietHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            lsvChiTietHoaDon.Items.Clear();
            HienThiChiTietHoaDon();
            ComboBoxTenSanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon f = new frmInHoaDon();
            f.ShowDialog();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (decimal.Parse(txtDonGia.Text) * nudSoLuong.Value).ToString();
        }

        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không???", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
