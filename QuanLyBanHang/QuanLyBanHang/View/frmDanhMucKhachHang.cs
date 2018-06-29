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
    public partial class frmDanhMucKhachHang : Form
    {
        bool themmoi;
        ControlDanhMucKhachHang kh = new ControlDanhMucKhachHang();
        public frmDanhMucKhachHang()
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
            setButton(true);
        }

        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                txtMaKH.Text = lsvKhachHang.SelectedItems[0].SubItems[0].Text;
                txtTenKH.Text = lsvKhachHang.SelectedItems[0].SubItems[1].Text;
                txtTaiKhoan.Text = lsvKhachHang.SelectedItems[0].SubItems[2].Text;
                txtMatKhau.Text = lsvKhachHang.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text= lsvKhachHang.SelectedItems[0].SubItems[4].Text;
                txtDiaChi.Text= lsvKhachHang.SelectedItems[0].SubItems[5].Text; ;
            }
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            txtDiaChi.Enabled = !val;
            txtMatKhau.Enabled = !val;
            txtSDT.Enabled = !val;
            txtTaiKhoan.Enabled = !val;
            txtTenKH.Enabled = !val;
        }

        void setNull()
        {
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setNull();
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa " + txtTenKH.Text + " khỏi danh mục khách hàng không?", "Thông Báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lsvKhachHang.Items.Clear();
                    kh.XoaKhachHang(txtMaKH.Text);
                    HienThiDSKhachHang();
                    setNull();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần sửa!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                kh.ThemKhachHang(txtTenKH.Text,txtTaiKhoan.Text,txtMatKhau.Text,txtSDT.Text,txtDiaChi.Text);
                MessageBox.Show("Đã thêm thành công!!!");

            }
            else
            {
                kh.SuaKhachHang(txtMaKH.Text, txtTenKH.Text,txtTaiKhoan.Text,txtMatKhau.Text,txtSDT.Text,txtDiaChi.Text);
                MessageBox.Show("Sửa thành công!!!");
            }
            lsvKhachHang.Items.Clear();
            setNull();
            HienThiDSKhachHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhMucKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không???", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
