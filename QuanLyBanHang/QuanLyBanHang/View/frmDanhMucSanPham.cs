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
using System.IO;
namespace QuanLyBanHang.View
{
    public partial class frmDanhMucSanPham : Form
    {
        public bool themmoi = false;
        ControlDanhMucSanPham sp = new ControlDanhMucSanPham();

        public frmDanhMucSanPham()
        {
            InitializeComponent();
        }

        void HienThiDsSanPham()
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
                lvi.SubItems.Add(tbSanPham.Rows[i][7].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][8].ToString());
                lvi.SubItems.Add(tbSanPham.Rows[i][9].ToString());
            }
        }

        void ComboBoxLoaiSP()
        {
            DataTable tbLoaiSP = sp.LayLoaiSanPham();
            cbbLoaiSanPham.DataSource = tbLoaiSP;
            cbbLoaiSanPham.DisplayMember = "tenloai";
            cbbLoaiSanPham.ValueMember = "maloai";
        }

        void ComboBoxNSX()
        {
            DataTable tbNSX = sp.LayNhaSanXuat();
            cbbNhaSanXuat.DataSource = tbNSX;
            cbbNhaSanXuat.DisplayMember = "tennsx";
            cbbNhaSanXuat.ValueMember = "mansx";
        }

        void setNull()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtTenFileAnh.Text = "";
            txtGiaMua.Text = "";
            txtGiaBan.Text = "";
            nudSoLuong.Text = "0";
            txtThongTin.Text = "";
            imgHinhSanPham.ImageLocation = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnThoat.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled=!val;
            btnHuy.Enabled = !val;
            btnUpload.Enabled = !val;
            btnXoaAnh.Enabled = !val;
            txtTenSanPham.Enabled = !val;
            dtpNgayCapNhat.Enabled = !val;
            cbbLoaiSanPham.Enabled = !val;
            cbbNhaSanXuat.Enabled = !val;
            txtGiaBan.Enabled = !val;
            txtGiaMua.Enabled = !val;
            nudSoLuong.Enabled = !val;
            txtThongTin.Enabled = !val;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienThiDsSanPham();
            ComboBoxLoaiSP();
            ComboBoxNSX();
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedIndices.Count > 0)
            {
                txtMaSanPham.Text = lsvSanPham.SelectedItems[0].SubItems[0].Text;
                txtTenSanPham.Text = lsvSanPham.SelectedItems[0].SubItems[1].Text;
                cbbLoaiSanPham.SelectedIndex = cbbLoaiSanPham.FindString(lsvSanPham.SelectedItems[0].SubItems[2].Text);
                cbbNhaSanXuat.SelectedIndex = cbbNhaSanXuat.FindString(lsvSanPham.SelectedItems[0].SubItems[3].Text);
                txtGiaMua.Text = lsvSanPham.SelectedItems[0].SubItems[4].Text;
                txtGiaBan.Text = lsvSanPham.SelectedItems[0].SubItems[5].Text;
                nudSoLuong.Text = lsvSanPham.SelectedItems[0].SubItems[6].Text;
                dtpNgayCapNhat.Value = DateTime.Parse(lsvSanPham.SelectedItems[0].SubItems[7].Text);
                txtTenFileAnh.Text = lsvSanPham.SelectedItems[0].SubItems[8].Text;
                txtThongTin.Text = lsvSanPham.SelectedItems[0].SubItems[9].Text;
                imgHinhSanPham.ImageLocation = Application.StartupPath + @"\Assets\Images\HinhSanPham\"+lsvSanPham.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            setNull();
            txtTenSanPham.Focus();
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
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
                txtTenSanPham.Focus();
            }
            else
            {
                MessageBox.Show("Mời chọn sản phẩm cần sửa!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", dtpNgayCapNhat.Value);
            if (themmoi == true)
            {
                sp.ThemSanPham(cbbNhaSanXuat.SelectedValue.ToString(), cbbLoaiSanPham.SelectedValue.ToString(), txtTenSanPham.Text,txtGiaMua.Text ,txtGiaBan.Text,nudSoLuong.Value.ToString(), ngay, txtTenFileAnh.Text, txtThongTin.Text);
                MessageBox.Show("Thêm Thành Công!!!", "Thông Báo");
            }
            else
            {
                sp.CapNhatSanPham(txtTenSanPham.Text, cbbNhaSanXuat.SelectedValue.ToString(), cbbLoaiSanPham.SelectedValue.ToString(),txtGiaMua.Text, txtGiaBan.Text,nudSoLuong.Value.ToString(), ngay, txtTenFileAnh.Text, txtThongTin.Text, txtMaSanPham.Text);
                MessageBox.Show("Cập nhật thành công!!!", "Thông Báo");
            }
            lsvSanPham.Items.Clear();
            HienThiDsSanPham();
            setNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG FILE|*.jpg|PNG FILE|*.png";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                txtTenFileAnh.Text = ofd.SafeFileName;
                imgHinhSanPham.ImageLocation = @ofd.FileName;
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            imgHinhSanPham.ImageLocation = "";
            txtTenFileAnh.Text = "";
        }

        private void txtGiaMua_TextChanged(object sender, EventArgs e)
        {
            TextBox txtSoNguyen = (TextBox)sender;
            if(txtSoNguyen.Text.Length>0)
            {
                if(!char.IsDigit(txtSoNguyen.Text[txtSoNguyen.Text.Length - 1]))
                {
                    if(MessageBox.Show("Mời nhập số nguyên!!!", "Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Error)==DialogResult.OK)
                    {
                        txtSoNguyen.Clear();
                        txtSoNguyen.Focus();
                    }
                }
            }
        }

        private void frmDanhMucSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát không???","Thông Báo!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(rbtnMaSP.Checked==true || rbtnLoaiSP.Checked ==true || rbtnNSX.Checked==true ||rbtnTenSP.Checked==true)
            {
                sp.TimKiem(txtTimKiem.Text);
                lsvSanPham.Items.Clear();
                DataTable tbTimKiem = sp.TimKiem(txtTimKiem.Text);
                for(int i=0;i<tbTimKiem.Rows.Count;i++)
                {
                    ListViewItem lvi = lsvSanPham.Items.Add(tbTimKiem.Rows[0][0].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][1].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][2].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][3].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][4].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][5].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][6].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][7].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][8].ToString());
                    lvi.SubItems.Add(tbTimKiem.Rows[i][9].ToString());
                }
                if(lsvSanPham.Items.Count==0)
                {
                    MessageBox.Show("Không tim thấy!", "Thông Báo!");
                    txtTimKiem.Focus();
                }
            }
        }
    }
}
