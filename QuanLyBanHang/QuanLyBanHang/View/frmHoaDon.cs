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
namespace QuanLyBanHang.View
{
    public partial class frmHoaDon : Form
    {
        bool themmoi;
        DatabaseSonGaming db = new DatabaseSonGaming();
        ControlHoaDon hd = new ControlHoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        void HienThiHoaDon()
        {
            DataTable tbHoaDon = hd.LayDsHoaDon();
            for(int i=0;i<tbHoaDon.Rows.Count;i++)
            {
                ListViewItem lvi = lsvHoaDon.Items.Add(tbHoaDon.Rows[i][0].ToString());
                lvi.SubItems.Add(tbHoaDon.Rows[i][1].ToString());
                lvi.SubItems.Add(tbHoaDon.Rows[i][2].ToString());
                lvi.SubItems.Add( tbHoaDon.Rows[i][3].ToString());
                lvi.SubItems.Add(tbHoaDon.Rows[i][4].ToString());
            }
        }

        void ComboBoxNhanVien()
        {
            DataTable tbNhanVien = hd.LayDsNhanVien();
            cbbTenNhanVien.DataSource = tbNhanVien;
            cbbTenNhanVien.DisplayMember = "tennv";
            cbbTenNhanVien.ValueMember = "manv";
            cbbTenNhanVien.SelectedIndex = -1;
        }

        void ComboBoxKhachHang()
        {
            DataTable tbKhachHang = hd.LayDsKhachHang();
            cbbTenKhachHang.DataSource = tbKhachHang;
            cbbTenKhachHang.ValueMember = "makh";
            cbbTenKhachHang.DisplayMember = "tenkhachhang";
            cbbTenKhachHang.SelectedIndex = -1;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            ComboBoxNhanVien();
            ComboBoxKhachHang();
            setButton(true);
        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvHoaDon.SelectedItems.Count>0)
            {
                txtMaHoaDon.Text = lsvHoaDon.SelectedItems[0].SubItems[0].Text;
                cbbTenNhanVien.SelectedIndex = cbbTenNhanVien.FindString(lsvHoaDon.SelectedItems[0].SubItems[1].Text);
                txtMaNV.Text = cbbTenNhanVien.SelectedValue.ToString();
                cbbTenKhachHang.SelectedIndex = cbbTenKhachHang.FindString(lsvHoaDon.SelectedItems[0].SubItems[2].Text);
                txtMaKH.Text = cbbTenKhachHang.SelectedValue.ToString();
                txtDiaChi.Text = db.LayGiaTriCuaBang("select diachi from KHACHHANG where makh = '" + txtMaKH.Text + "'");
                txtDienThoai.Text = db.LayGiaTriCuaBang("select sodienthoai from KHACHHANG where makh = '" + txtMaKH.Text + "'");
                dtpNgayBan.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void cbbTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if(cbbTenKhachHang.Text == "")
            {
                txtMaKH.Text = "";
                txtDienThoai.Text = "";
                txtDiaChi.Text = "";
            }
            str = "select makh from khachhang where makh = N'" + cbbTenKhachHang.SelectedValue + "'";
            txtMaKH.Text = db.LayGiaTriCuaBang(str);
            txtDiaChi.Text = db.LayGiaTriCuaBang("select diachi from KHACHHANG where makh = N'"+cbbTenKhachHang.SelectedValue+"'"  );
            txtDienThoai.Text = db.LayGiaTriCuaBang("select sodienthoai from khachhang where makh = N'" + cbbTenKhachHang.SelectedValue + "'");
        }

        private void cbbTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = db.LayGiaTriCuaBang("select manv from NHANVIEN where manv = '" + cbbTenNhanVien.SelectedValue + "'");
            
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnThoat.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            cbbTenNhanVien.Enabled = !val;
            cbbTenKhachHang.Enabled = !val;
            dtpNgayBan.Enabled = !val;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            cbbTenKhachHang.SelectedValue = -1;
            cbbTenNhanVien.SelectedValue = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    hd.XoaHoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
                    lsvHoaDon.Items.Clear();
                    HienThiHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Mời chọn hóa đơn cần xóa!!!","Thông Báo!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Mời chọn hóa đơn cần sửa!!!","Thông Báo!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dtpNgayBan.Value);
            if (themmoi == true)
            {
                hd.ThemHoaDon(txtMaNV.Text,txtMaKH.Text,ngay);
                MessageBox.Show("Thêm Thành Công!!!", "Thông Báo");
            }
            else
            {
                hd.SuaHoaDon(txtMaHoaDon.Text,txtMaNV.Text,txtMaKH.Text,ngay);
                MessageBox.Show("Cập nhật thành công!!!", "Thông Báo");
            }
            lsvHoaDon.Items.Clear();
            HienThiHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            lsvHoaDon.Items.Clear();
            HienThiHoaDon();
            ComboBoxKhachHang();
            ComboBoxNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if(lsvHoaDon.SelectedIndices.Count == 1)
            {
                frmChiTietHoaDon f = new frmChiTietHoaDon(txtMaHoaDon.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời chọn hóa đơn cần xem!!!", "Thông báo!!!");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Items.Clear();
            HienThiHoaDon();
            ComboBoxKhachHang();
            ComboBoxNhanVien();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không???", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbtnMaHD.Checked == true || rbtnNgayBan.Checked == true || rbtnTenKH.Checked == true || rbtnTenNV.Checked == true)
            {
                hd.TimKiem(txtTimKiem.Text);
                lsvHoaDon.Items.Clear();
                DataTable tbTimKiem = hd.TimKiem(txtTimKiem.Text);
                for (int i = 0; i < tbTimKiem.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvHoaDon.Items.Add(tbTimKiem.Rows[0][0].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][1].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][2].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][3].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][4].ToString());
                }
                if (lsvHoaDon.Items.Count == 0)
                {
                    MessageBox.Show("Không tim thấy!", "Thông Báo!");
                    txtTimKiem.Focus();
                }
            }
        }
    }
}
