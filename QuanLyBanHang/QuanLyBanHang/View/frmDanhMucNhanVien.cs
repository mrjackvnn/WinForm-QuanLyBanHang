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
    public partial class frmDanhMucNhanVien : Form
    {
        bool themmoi;
        ControlDanhMucNhanVien nv = new ControlDanhMucNhanVien();
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        void HienThiDsNhanVien()
        {
            DataTable tbNhanVien = nv.LayDSNhanVien();
            for (int i = 0; i < tbNhanVien.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(tbNhanVien.Rows[i][0].ToString());
                lvi.SubItems.Add(tbNhanVien.Rows[i][1].ToString());
                lvi.SubItems.Add(tbNhanVien.Rows[i][2].ToString());
                lvi.SubItems.Add(tbNhanVien.Rows[i][3].ToString());
                lvi.SubItems.Add(tbNhanVien.Rows[i][4].ToString());
                lvi.SubItems.Add(tbNhanVien.Rows[i][5].ToString());
            }
        }

        private void frmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDsNhanVien();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtMaNV.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                if(lsvNhanVien.SelectedItems[0].SubItems[2].Text == "Nam")
                {
                    rdbNam.Checked=true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                dtpNgaySinh.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
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
        }

        void setNull()
        {
            txtMaNV.Text = null;
            txtTenNV.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setNull();
            txtTenNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa " + txtTenNV.Text + " khỏi danh mục nhân viên không?", "Thông Báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lsvNhanVien.Items.Clear();
                    nv.XoaNhanVien(txtMaNV.Text);
                    HienThiDsNhanVien();
                    setNull();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần sửa!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:yyyy.MM.dd}", dtpNgaySinh.Value);
            if (themmoi == true)
            {
                string gioitinh="";
                if(rdbNam.Checked==true)
                {
                    gioitinh = "1";
                }
                if(rdbNu.Checked==true)
                {
                    gioitinh = "0";
                }
                nv.ThemNhanVien(txtTenNV.Text, gioitinh, txtDiaChi.Text, txtSDT.Text, ngay);
                MessageBox.Show("Đã thêm thành công!!!");

            }
            else
            {
                string gioitinh = "";
                if (rdbNam.Checked == true)
                {
                    gioitinh = "1";
                }
                if (rdbNu.Checked == true)
                {
                    gioitinh = "0";
                }
                nv.SuaNhanVien(txtMaNV.Text, txtTenNV.Text, gioitinh,txtDiaChi.Text, txtSDT.Text,ngay);
                MessageBox.Show("Sửa thành công!!!");
            }
            lsvNhanVien.Items.Clear();
            setNull();
            HienThiDsNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
