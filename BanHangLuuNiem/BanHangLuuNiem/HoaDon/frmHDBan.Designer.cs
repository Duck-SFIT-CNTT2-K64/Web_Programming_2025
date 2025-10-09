namespace BanHangLuuNiem.HoaDon
{
    partial class frmHDBan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxThongTinChung = new System.Windows.Forms.GroupBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.labelDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.labelTenKhach = new System.Windows.Forms.Label();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.labelMaKhach = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.labelNgayBan = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.labelMaHDBan = new System.Windows.Forms.Label();

            this.groupBoxThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelThanhTien = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.labelGiamGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.labelTenHang = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.labelMaHang = new System.Windows.Forms.Label();

            this.dgvHDBan = new System.Windows.Forms.DataGridView();

            this.labelTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelBangChu = new System.Windows.Forms.Label();
            this.txtBangChu = new System.Windows.Forms.TextBox();

            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.txtMaHDBanSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();

            this.groupBoxThongTinChung.SuspendLayout();
            this.groupBoxThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).BeginInit();
            this.SuspendLayout();

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTitle.Location = new System.Drawing.Point(340, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(320, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HÓA ĐƠN BÁN HÀNG";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // groupBoxThongTinChung
            // 
            this.groupBoxThongTinChung.Controls.Add(this.txtDienThoai);
            this.groupBoxThongTinChung.Controls.Add(this.labelDienThoai);
            this.groupBoxThongTinChung.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTinChung.Controls.Add(this.labelDiaChi);
            this.groupBoxThongTinChung.Controls.Add(this.txtTenKhach);
            this.groupBoxThongTinChung.Controls.Add(this.labelTenKhach);
            this.groupBoxThongTinChung.Controls.Add(this.cboMaKhach);
            this.groupBoxThongTinChung.Controls.Add(this.labelMaKhach);
            this.groupBoxThongTinChung.Controls.Add(this.txtTenNhanVien);
            this.groupBoxThongTinChung.Controls.Add(this.labelTenNhanVien);
            this.groupBoxThongTinChung.Controls.Add(this.cboMaNhanVien);
            this.groupBoxThongTinChung.Controls.Add(this.labelMaNhanVien);
            this.groupBoxThongTinChung.Controls.Add(this.txtNgayBan);
            this.groupBoxThongTinChung.Controls.Add(this.labelNgayBan);
            this.groupBoxThongTinChung.Controls.Add(this.txtMaHDBan);
            this.groupBoxThongTinChung.Controls.Add(this.labelMaHDBan);
            this.groupBoxThongTinChung.Location = new System.Drawing.Point(12, 50);
            this.groupBoxThongTinChung.Name = "groupBoxThongTinChung";
            this.groupBoxThongTinChung.Size = new System.Drawing.Size(980, 110);
            this.groupBoxThongTinChung.TabIndex = 1;
            this.groupBoxThongTinChung.TabStop = false;
            this.groupBoxThongTinChung.Text = "Thông tin chung";

            // 
            // labelMaHDBan
            // 
            this.labelMaHDBan.AutoSize = true;
            this.labelMaHDBan.Location = new System.Drawing.Point(10, 25);
            this.labelMaHDBan.Name = "labelMaHDBan";
            this.labelMaHDBan.Size = new System.Drawing.Size(62, 13);
            this.labelMaHDBan.TabIndex = 0;
            this.labelMaHDBan.Text = "Mã hóa đơn:";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(80, 22);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(180, 20);
            this.txtMaHDBan.TabIndex = 1;
            // 
            // labelNgayBan
            // 
            this.labelNgayBan.AutoSize = true;
            this.labelNgayBan.Location = new System.Drawing.Point(10, 55);
            this.labelNgayBan.Name = "labelNgayBan";
            this.labelNgayBan.Size = new System.Drawing.Size(56, 13);
            this.labelNgayBan.TabIndex = 2;
            this.labelNgayBan.Text = "Ngày bán:";
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(80, 52);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(180, 20);
            this.txtNgayBan.TabIndex = 3;
            // 
            // labelMaNhanVien
            // 
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Location = new System.Drawing.Point(10, 85);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(74, 13);
            this.labelMaNhanVien.TabIndex = 4;
            this.labelMaNhanVien.Text = "Mã nhân viên:";
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(80, 82);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(180, 21);
            this.cboMaNhanVien.TabIndex = 5;
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Location = new System.Drawing.Point(280, 85);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(78, 13);
            this.labelTenNhanVien.TabIndex = 6;
            this.labelTenNhanVien.Text = "Tên nhân viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(370, 82);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(180, 20);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // labelMaKhach
            // 
            this.labelMaKhach.AutoSize = true;
            this.labelMaKhach.Location = new System.Drawing.Point(280, 25);
            this.labelMaKhach.Name = "labelMaKhach";
            this.labelMaKhach.Size = new System.Drawing.Size(67, 13);
            this.labelMaKhach.TabIndex = 8;
            this.labelMaKhach.Text = "Mã khách hàng:";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(370, 22);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(180, 21);
            this.cboMaKhach.TabIndex = 9;
            // 
            // labelTenKhach
            // 
            this.labelTenKhach.AutoSize = true;
            this.labelTenKhach.Location = new System.Drawing.Point(280, 55);
            this.labelTenKhach.Name = "labelTenKhach";
            this.labelTenKhach.Size = new System.Drawing.Size(74, 13);
            this.labelTenKhach.TabIndex = 10;
            this.labelTenKhach.Text = "Tên khách hàng:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(370, 52);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(180, 20);
            this.txtTenKhach.TabIndex = 11;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(570, 25);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labelDiaChi.TabIndex = 12;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(620, 22);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(340, 20);
            this.txtDiaChi.TabIndex = 13;
            // 
            // labelDienThoai
            // 
            this.labelDienThoai.AutoSize = true;
            this.labelDienThoai.Location = new System.Drawing.Point(570, 55);
            this.labelDienThoai.Name = "labelDienThoai";
            this.labelDienThoai.Size = new System.Drawing.Size(58, 13);
            this.labelDienThoai.TabIndex = 14;
            this.labelDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(620, 52);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(340, 20);
            this.txtDienThoai.TabIndex = 15;
            // 
            // groupBoxThongTinMatHang
            // 
            this.groupBoxThongTinMatHang.Controls.Add(this.txtThanhTien);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelThanhTien);
            this.groupBoxThongTinMatHang.Controls.Add(this.txtGiamGia);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelGiamGia);
            this.groupBoxThongTinMatHang.Controls.Add(this.txtDonGia);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelDonGia);
            this.groupBoxThongTinMatHang.Controls.Add(this.txtSoLuong);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelSoLuong);
            this.groupBoxThongTinMatHang.Controls.Add(this.txtTenHang);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelTenHang);
            this.groupBoxThongTinMatHang.Controls.Add(this.cboMaHang);
            this.groupBoxThongTinMatHang.Controls.Add(this.labelMaHang);
            this.groupBoxThongTinMatHang.Location = new System.Drawing.Point(12, 165);
            this.groupBoxThongTinMatHang.Name = "groupBoxThongTinMatHang";
            this.groupBoxThongTinMatHang.Size = new System.Drawing.Size(980, 60);
            this.groupBoxThongTinMatHang.TabIndex = 2;
            this.groupBoxThongTinMatHang.TabStop = false;
            this.groupBoxThongTinMatHang.Text = "Thông tin các mặt hàng";

            // 
            // labelMaHang
            // 
            this.labelMaHang.AutoSize = true;
            this.labelMaHang.Location = new System.Drawing.Point(10, 28);
            this.labelMaHang.Name = "labelMaHang";
            this.labelMaHang.Size = new System.Drawing.Size(50, 13);
            this.labelMaHang.TabIndex = 0;
            this.labelMaHang.Text = "Mã hàng:";
            // 
            // cboMaHang
            // 
            this.cboMaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(65, 25);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(80, 21);
            this.cboMaHang.TabIndex = 1;
            // 
            // labelTenHang
            // 
            this.labelTenHang.AutoSize = true;
            this.labelTenHang.Location = new System.Drawing.Point(155, 28);
            this.labelTenHang.Name = "labelTenHang";
            this.labelTenHang.Size = new System.Drawing.Size(56, 13);
            this.labelTenHang.TabIndex = 2;
            this.labelTenHang.Text = "Tên hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(215, 25);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(120, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(345, 28);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(52, 13);
            this.labelSoLuong.TabIndex = 4;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(400, 25);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(470, 28);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(47, 13);
            this.labelDonGia.TabIndex = 6;
            this.labelDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(520, 25);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(80, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // labelGiamGia
            // 
            this.labelGiamGia.AutoSize = true;
            this.labelGiamGia.Location = new System.Drawing.Point(610, 28);
            this.labelGiamGia.Name = "labelGiamGia";
            this.labelGiamGia.Size = new System.Drawing.Size(51, 13);
            this.labelGiamGia.TabIndex = 8;
            this.labelGiamGia.Text = "Giảm giá:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(665, 25);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(60, 20);
            this.txtGiamGia.TabIndex = 9;
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.AutoSize = true;
            this.labelThanhTien.Location = new System.Drawing.Point(735, 28);
            this.labelThanhTien.Name = "labelThanhTien";
            this.labelThanhTien.Size = new System.Drawing.Size(62, 13);
            this.labelThanhTien.TabIndex = 10;
            this.labelThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(800, 25);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(120, 20);
            this.txtThanhTien.TabIndex = 11;
            // 
            // dgvHDBan
            // 
            this.dgvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBan.Location = new System.Drawing.Point(12, 235);
            this.dgvHDBan.Name = "dgvHDBan";
            this.dgvHDBan.Size = new System.Drawing.Size(980, 150);
            this.dgvHDBan.TabIndex = 3;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(800, 395);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(56, 13);
            this.labelTongTien.TabIndex = 4;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(860, 392);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(130, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // labelBangChu
            // 
            this.labelBangChu.AutoSize = true;
            this.labelBangChu.Location = new System.Drawing.Point(12, 420);
            this.labelBangChu.Name = "labelBangChu";
            this.labelBangChu.Size = new System.Drawing.Size(110, 13);
            this.labelBangChu.TabIndex = 6;
            this.labelBangChu.Text = "Bằng chữ:";
            // 
            // txtBangChu
            // 
            this.txtBangChu.Location = new System.Drawing.Point(70, 417);
            this.txtBangChu.Name = "txtBangChu";
            this.txtBangChu.Size = new System.Drawing.Size(920, 20);
            this.txtBangChu.TabIndex = 7;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(12, 460);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(110, 30);
            this.btnThemHD.TabIndex = 8;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(132, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 30);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(252, 460);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(110, 30);
            this.btnHuyHD.TabIndex = 10;
            this.btnHuyHD.Text = "Hủy hóa đơn";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(372, 460);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(110, 30);
            this.btnInHD.TabIndex = 11;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(492, 460);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 30);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtMaHDBanSearch
            // 
            this.txtMaHDBanSearch.Location = new System.Drawing.Point(12, 510);
            this.txtMaHDBanSearch.Name = "txtMaHDBanSearch";
            this.txtMaHDBanSearch.Size = new System.Drawing.Size(180, 20);
            this.txtMaHDBanSearch.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(202, 508);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 24);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1006, 589);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaHDBanSearch);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.txtBangChu);
            this.Controls.Add(this.labelBangChu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.dgvHDBan);
            this.Controls.Add(this.groupBoxThongTinMatHang);
            this.Controls.Add(this.groupBoxThongTinChung);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmHDBan";
            this.Text = "HÓA ĐƠN BÁN HÀNG";
            this.groupBoxThongTinChung.ResumeLayout(false);
            this.groupBoxThongTinChung.PerformLayout();
            this.groupBoxThongTinMatHang.ResumeLayout(false);
            this.groupBoxThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxThongTinChung;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label labelTenKhach;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.Label labelMaKhach;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.Label labelNgayBan;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label labelMaHDBan;

        private System.Windows.Forms.GroupBox groupBoxThongTinMatHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label labelThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label labelGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label labelTenHang;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label labelMaHang;

        private System.Windows.Forms.DataGridView dgvHDBan;

        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label labelBangChu;
        private System.Windows.Forms.TextBox txtBangChu;

        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.TextBox txtMaHDBanSearch;
        private System.Windows.Forms.Button btnTimKiem;
    }
}