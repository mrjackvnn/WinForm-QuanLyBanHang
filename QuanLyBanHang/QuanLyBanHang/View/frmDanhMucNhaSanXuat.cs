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
    public partial class frmDanhMucNhaSanXuat : Form
    {
        bool themmoi;
        ControlDanhMucNSXvsLSP dm = new ControlDanhMucNSXvsLSP();
        public frmDanhMucNhaSanXuat()
        {
            InitializeComponent();
        }

        void HienThiNSX()
        {
            DataTable nsx = dm.LayDanhSachNSX();
            for(int i=0;i<nsx.Rows.Count;i++)
            {
                ListViewItem lvi = lsvNhaSanXuat.Items.Add(nsx.Rows[i][0].ToString());
                lvi.SubItems.Add(nsx.Rows[i][1].ToString());
            }
        }

        private void frmDanhMucNhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiNSX();
            setButton(true);
        }

        private void lsvNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhaSanXuat.SelectedIndices.Count > 0)
            {
                txtMaNSX.Text = lsvNhaSanXuat.SelectedItems[0].SubItems[0].Text;
                txtTenNSX.Text = lsvNhaSanXuat.SelectedItems[0].SubItems[1].Text;
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
            txtTenNSX.Enabled = !val;

        }

        void setNull()
        {
            txtTenNSX.Text = null;
            txtMaNSX.Text = null;
        }  

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setNull();
            txtTenNSX.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvNhaSanXuat.SelectedItems.Count>0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa "+ txtTenNSX.Text + " khỏi danh mục nhà sản xuất không?", "Thông Báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lsvNhaSanXuat.Items.Clear();
                    dm.XoaNSX(txtMaNSX.Text);
                    HienThiNSX();
                    setNull();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn nhà sản xuất cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lsvNhaSanXuat.SelectedItems.Count>0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Chọn nhà sản xuất cần sửa!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(themmoi==true)
            {
                dm.ThemNSX(txtTenNSX.Text);
                MessageBox.Show("Đã thêm thành công!!!");

            }
            else
            {
                dm.SuaNSX(txtMaNSX.Text, txtTenNSX.Text);
                MessageBox.Show("Sửa thành công!!!");
            }
            lsvNhaSanXuat.Items.Clear();
            setNull();
            HienThiNSX();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhMucNhaSanXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không???", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
