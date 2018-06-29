namespace QuanLyBanHang.View
{
    partial class frmDanhMucSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvSanPham = new System.Windows.Forms.ListView();
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuongTon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayCapNhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThongTin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.imgHinhSanPham = new System.Windows.Forms.PictureBox();
            this.txtThongTin = new System.Windows.Forms.RichTextBox();
            this.dtpNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.cbbNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnNSX = new System.Windows.Forms.RadioButton();
            this.rbtnLoaiSP = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rbtnTenSP = new System.Windows.Forms.RadioButton();
            this.rbtnMaSP = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenFileAnh = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhSanPham)).BeginInit();
            this.panel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvSanPham
            // 
            this.lsvSanPham.BackColor = System.Drawing.SystemColors.Window;
            this.lsvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoai,
            this.colNSX,
            this.colGiaMua,
            this.colGiaBan,
            this.colSoLuongTon,
            this.colNgayCapNhat,
            this.colHinh,
            this.colThongTin});
            this.lsvSanPham.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsvSanPham.FullRowSelect = true;
            this.lsvSanPham.GridLines = true;
            this.lsvSanPham.Location = new System.Drawing.Point(6, 19);
            this.lsvSanPham.Name = "lsvSanPham";
            this.lsvSanPham.RightToLeftLayout = true;
            this.lsvSanPham.Size = new System.Drawing.Size(861, 167);
            this.lsvSanPham.TabIndex = 0;
            this.lsvSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvSanPham.View = System.Windows.Forms.View.Details;
            this.lsvSanPham.SelectedIndexChanged += new System.EventHandler(this.lsvSanPham_SelectedIndexChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã";
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên Sản Phẩm";
            this.colTenSP.Width = 150;
            // 
            // colLoai
            // 
            this.colLoai.Text = "Loại";
            // 
            // colNSX
            // 
            this.colNSX.Text = "NSX";
            // 
            // colGiaMua
            // 
            this.colGiaMua.Text = "Giá mua";
            // 
            // colGiaBan
            // 
            this.colGiaBan.Text = "Giá Bán";
            this.colGiaBan.Width = 80;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.Text = "SL tồn";
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Text = "Ngày Cập Nhật";
            this.colNgayCapNhat.Width = 100;
            // 
            // colHinh
            // 
            this.colHinh.Text = "Hình Sản Phẩm";
            this.colHinh.Width = 100;
            // 
            // colThongTin
            // 
            this.colThongTin.Text = "Thông Tin Sản Phẩm";
            this.colThongTin.Width = 300;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoaAnh);
            this.panel4.Controls.Add(this.btnUpload);
            this.panel4.Controls.Add(this.imgHinhSanPham);
            this.panel4.Location = new System.Drawing.Point(6, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 210);
            this.panel4.TabIndex = 15;
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.ForeColor = System.Drawing.Color.Blue;
            this.btnXoaAnh.Image = global::QuanLyBanHang.Properties.Resources.RemoveItem_16x16;
            this.btnXoaAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaAnh.Location = new System.Drawing.Point(140, 177);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(61, 30);
            this.btnXoaAnh.TabIndex = 6;
            this.btnXoaAnh.Text = "Xóa";
            this.btnXoaAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpload.ForeColor = System.Drawing.Color.Blue;
            this.btnUpload.Image = global::QuanLyBanHang.Properties.Resources.Up2_16x16;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(3, 177);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(131, 30);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Tải ảnh";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // imgHinhSanPham
            // 
            this.imgHinhSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgHinhSanPham.Location = new System.Drawing.Point(3, 3);
            this.imgHinhSanPham.Name = "imgHinhSanPham";
            this.imgHinhSanPham.Size = new System.Drawing.Size(198, 168);
            this.imgHinhSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHinhSanPham.TabIndex = 14;
            this.imgHinhSanPham.TabStop = false;
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(59, 126);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(349, 81);
            this.txtThongTin.TabIndex = 5;
            this.txtThongTin.Text = "";
            // 
            // dtpNgayCapNhat
            // 
            this.dtpNgayCapNhat.Location = new System.Drawing.Point(88, 71);
            this.dtpNgayCapNhat.Name = "dtpNgayCapNhat";
            this.dtpNgayCapNhat.Size = new System.Drawing.Size(223, 20);
            this.dtpNgayCapNhat.TabIndex = 12;
            // 
            // cbbNhaSanXuat
            // 
            this.cbbNhaSanXuat.FormattingEnabled = true;
            this.cbbNhaSanXuat.Location = new System.Drawing.Point(335, 27);
            this.cbbNhaSanXuat.Name = "cbbNhaSanXuat";
            this.cbbNhaSanXuat.Size = new System.Drawing.Size(79, 21);
            this.cbbNhaSanXuat.TabIndex = 10;
            // 
            // cbbLoaiSanPham
            // 
            this.cbbLoaiSanPham.FormattingEnabled = true;
            this.cbbLoaiSanPham.Location = new System.Drawing.Point(335, 51);
            this.cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            this.cbbLoaiSanPham.Size = new System.Drawing.Size(80, 21);
            this.cbbLoaiSanPham.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(4, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thông tin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày cập nhật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(144, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(256, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(256, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(88, 26);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(162, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Controls.Add(this.grbChucNang);
            this.panel9.Controls.Add(this.groupBox2);
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(886, 484);
            this.panel9.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnNSX);
            this.groupBox3.Controls.Add(this.rbtnLoaiSP);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.rbtnTenSP);
            this.groupBox3.Controls.Add(this.rbtnMaSP);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(651, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // rbtnNSX
            // 
            this.rbtnNSX.AutoSize = true;
            this.rbtnNSX.ForeColor = System.Drawing.Color.Blue;
            this.rbtnNSX.Location = new System.Drawing.Point(127, 71);
            this.rbtnNSX.Name = "rbtnNSX";
            this.rbtnNSX.Size = new System.Drawing.Size(88, 17);
            this.rbtnNSX.TabIndex = 8;
            this.rbtnNSX.TabStop = true;
            this.rbtnNSX.Text = "Nhà sản xuất";
            this.rbtnNSX.UseVisualStyleBackColor = true;
            // 
            // rbtnLoaiSP
            // 
            this.rbtnLoaiSP.AutoSize = true;
            this.rbtnLoaiSP.ForeColor = System.Drawing.Color.Blue;
            this.rbtnLoaiSP.Location = new System.Drawing.Point(6, 71);
            this.rbtnLoaiSP.Name = "rbtnLoaiSP";
            this.rbtnLoaiSP.Size = new System.Drawing.Size(94, 17);
            this.rbtnLoaiSP.TabIndex = 7;
            this.rbtnLoaiSP.TabStop = true;
            this.rbtnLoaiSP.Text = "Loại sản phẩm";
            this.rbtnLoaiSP.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = global::QuanLyBanHang.Properties.Resources.Find_16x16;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(75, 94);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(63, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm ";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rbtnTenSP
            // 
            this.rbtnTenSP.AutoSize = true;
            this.rbtnTenSP.ForeColor = System.Drawing.Color.Blue;
            this.rbtnTenSP.Location = new System.Drawing.Point(127, 48);
            this.rbtnTenSP.Name = "rbtnTenSP";
            this.rbtnTenSP.Size = new System.Drawing.Size(93, 17);
            this.rbtnTenSP.TabIndex = 2;
            this.rbtnTenSP.TabStop = true;
            this.rbtnTenSP.Text = "Tên sản phẩm";
            this.rbtnTenSP.UseVisualStyleBackColor = true;
            // 
            // rbtnMaSP
            // 
            this.rbtnMaSP.AutoSize = true;
            this.rbtnMaSP.ForeColor = System.Drawing.Color.Blue;
            this.rbtnMaSP.Location = new System.Drawing.Point(6, 48);
            this.rbtnMaSP.Name = "rbtnMaSP";
            this.rbtnMaSP.Size = new System.Drawing.Size(89, 17);
            this.rbtnMaSP.TabIndex = 1;
            this.rbtnMaSP.TabStop = true;
            this.rbtnMaSP.Text = "Mã sản phẩm";
            this.rbtnMaSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(651, 189);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(226, 91);
            this.grbChucNang.TabIndex = 5;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = global::QuanLyBanHang.Properties.Resources.Remove_16x16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(75, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.Close_16x16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(144, 55);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Image = global::QuanLyBanHang.Properties.Resources.Reset_16x16;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(75, 55);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(63, 30);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::QuanLyBanHang.Properties.Resources.EditName_16x16;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(144, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::QuanLyBanHang.Properties.Resources.Apply_16x16;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(6, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 30);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = global::QuanLyBanHang.Properties.Resources.Add_16x16;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(6, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(4, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(4, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtGiaBan);
            this.panel10.Controls.Add(this.txtGiaMua);
            this.panel10.Controls.Add(this.nudSoLuong);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.txtTenFileAnh);
            this.panel10.Controls.Add(this.txtMaSanPham);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.txtThongTin);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.cbbLoaiSanPham);
            this.panel10.Controls.Add(this.txtTenSanPham);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.cbbNhaSanXuat);
            this.panel10.Controls.Add(this.dtpNgayCapNhat);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(217, 19);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(418, 210);
            this.panel10.TabIndex = 16;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(197, 100);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(79, 20);
            this.txtGiaBan.TabIndex = 3;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaMua_TextChanged);
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(59, 100);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(79, 20);
            this.txtGiaMua.TabIndex = 2;
            this.txtGiaMua.TextChanged += new System.EventHandler(this.txtGiaMua_TextChanged);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(357, 100);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(57, 20);
            this.nudSoLuong.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(4, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Hình sản phẩm:";
            // 
            // txtTenFileAnh
            // 
            this.txtTenFileAnh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTenFileAnh.Location = new System.Drawing.Point(88, 48);
            this.txtTenFileAnh.Name = "txtTenFileAnh";
            this.txtTenFileAnh.ReadOnly = true;
            this.txtTenFileAnh.Size = new System.Drawing.Size(162, 20);
            this.txtTenFileAnh.TabIndex = 21;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMaSanPham.Location = new System.Drawing.Point(88, 3);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(66, 20);
            this.txtMaSanPham.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(4, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(282, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số lượng tồn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(4, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giá mua:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(880, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Danh Mục Sản Phẩm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(911, 502);
            this.Controls.Add(this.panel9);
            this.KeyPreview = true;
            this.Name = "frmDanhMucSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhMucSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhSanPham)).EndInit();
            this.panel9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvSanPham;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colLoai;
        private System.Windows.Forms.ColumnHeader colNSX;
        private System.Windows.Forms.ColumnHeader colGiaBan;
        private System.Windows.Forms.ColumnHeader colNgayCapNhat;
        private System.Windows.Forms.ColumnHeader colHinh;
        private System.Windows.Forms.ColumnHeader colThongTin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox imgHinhSanPham;
        private System.Windows.Forms.RichTextBox txtThongTin;
        private System.Windows.Forms.DateTimePicker dtpNgayCapNhat;
        private System.Windows.Forms.ComboBox cbbNhaSanXuat;
        private System.Windows.Forms.ComboBox cbbLoaiSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rbtnTenSP;
        private System.Windows.Forms.RadioButton rbtnMaSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rbtnNSX;
        private System.Windows.Forms.RadioButton rbtnLoaiSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader colGiaMua;
        private System.Windows.Forms.ColumnHeader colSoLuongTon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenFileAnh;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaMua;
    }
}