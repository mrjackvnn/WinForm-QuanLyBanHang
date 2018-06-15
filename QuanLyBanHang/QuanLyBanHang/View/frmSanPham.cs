using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.Control;
namespace QuanLyBanHang.View
{
    public partial class frmSanPham : Form
    {
        public bool themmoi = false;
        QuanLySanPhamControl sp = new QuanLySanPhamControl();
        public frmSanPham()
        {
            InitializeComponent();
        }
        void LayDsSanPham()
        {
            DataTable tbSanPham = sp.LayDanhSachSanPham();
            for(int i=0;i<tbSanPham.Rows.Count;i++)
            {
                ListViewItem lvi = lsvSanPham.Items.Add(tbSanPham.Rows[i][0].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][1].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][2].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][3].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][4].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][5].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][6].ToString());
            }
        }

        void LayDsNhaSanXuat()
        {
            DataTable tbNSX = sp.LayNhaSanXuat();
            cbbNhaSanXuat.DataSource = tbNSX;
            cbbNhaSanXuat.DisplayMember = "tennsx";
            cbbNhaSanXuat.ValueMember = "mansx";
        }

        void LayDsLoaiSanPham()
        {
            DataTable tbLSP = sp.LayLoaiSanPham();
            cbbLoaiSanPham.DataSource = tbLSP;
            cbbLoaiSanPham.DisplayMember = "tenloai";
            cbbLoaiSanPham.ValueMember = "maloai";
        }

        void setNull()
        {
            txtTenSanPham.Text = "";
            txtGiaBan.Text = "";
            txtThongTin.Text = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnThoat.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled=!val;
            btnHuy.Enabled = !val;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            LayDsSanPham();
            LayDsLoaiSanPham();
            LayDsNhaSanXuat();
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedIndices.Count > 0)
            {
                txtTenSanPham.Text = lsvSanPham.SelectedItems[0].SubItems[1].Text;
                dtpNgayCapNhat.Value = DateTime.Parse(lsvSanPham.SelectedItems[0].SubItems[5].Text);
                txtGiaBan.Text = lsvSanPham.SelectedItems[0].SubItems[4].Text;
                txtThongTin.Text = lsvSanPham.SelectedItems[0].SubItems[6].Text;
                cbbLoaiSanPham.SelectedIndex = cbbLoaiSanPham.FindString(lsvSanPham.SelectedItems[0].SubItems[2].Text);
                cbbNhaSanXuat.SelectedIndex = cbbNhaSanXuat.FindString(lsvSanPham.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvSanPham.SelectedItems.Count>0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    sp.XoaSanPham(lsvSanPham.SelectedItems[0].SubItems[0].Text);
                    lsvSanPham.Items.RemoveAt(lsvSanPham.SelectedIndices[0]);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txtTenSanPham.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lsvSanPham.SelectedIndices.Count>0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Mời chọn sản phẩm cần sửa!!!");
            }
        }
    }
}
