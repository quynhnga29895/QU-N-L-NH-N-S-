namespace QLNS
{
    partial class frmQuanLyNhanSu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboMaChuyenMon = new System.Windows.Forms.ComboBox();
            this.cboMaChucVu = new System.Windows.Forms.ComboBox();
            this.cboMaPB = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblMaChuyenMon = new System.Windows.Forms.Label();
            this.lblMaChucVu = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbThongTinNV.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbChucNang);
            this.panel1.Controls.Add(this.grbThongTinNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 180);
            this.panel1.TabIndex = 0;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLamMoi);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChucNang.Location = new System.Drawing.Point(620, 0);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(182, 180);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            this.grbChucNang.Enter += new System.EventHandler(this.grbChucNang_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(15, 90);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 72);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(96, 90);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 72);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(96, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 72);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(15, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 72);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.Controls.Add(this.txtGT);
            this.grbThongTinNV.Controls.Add(this.txtGhiChu);
            this.grbThongTinNV.Controls.Add(this.cboMaChuyenMon);
            this.grbThongTinNV.Controls.Add(this.cboMaChucVu);
            this.grbThongTinNV.Controls.Add(this.cboMaPB);
            this.grbThongTinNV.Controls.Add(this.dtpNgaySinh);
            this.grbThongTinNV.Controls.Add(this.txtDiaChi);
            this.grbThongTinNV.Controls.Add(this.txtHoTen);
            this.grbThongTinNV.Controls.Add(this.txtMaNV);
            this.grbThongTinNV.Controls.Add(this.lblGhiChu);
            this.grbThongTinNV.Controls.Add(this.lblMaChuyenMon);
            this.grbThongTinNV.Controls.Add(this.lblMaChucVu);
            this.grbThongTinNV.Controls.Add(this.lblMaPB);
            this.grbThongTinNV.Controls.Add(this.lblDiaChi);
            this.grbThongTinNV.Controls.Add(this.lblNgaySinh);
            this.grbThongTinNV.Controls.Add(this.lblGioiTinh);
            this.grbThongTinNV.Controls.Add(this.lblHoTen);
            this.grbThongTinNV.Controls.Add(this.lblMaNV);
            this.grbThongTinNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbThongTinNV.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(620, 180);
            this.grbThongTinNV.TabIndex = 0;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông tin nhân viên";
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(107, 74);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(200, 20);
            this.txtGT.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(478, 101);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(121, 43);
            this.txtGhiChu.TabIndex = 18;
            // 
            // cboMaChuyenMon
            // 
            this.cboMaChuyenMon.FormattingEnabled = true;
            this.cboMaChuyenMon.Items.AddRange(new object[] {
            "CD",
            "DH",
            "PTCS",
            "PTTH",
            "TC"});
            this.cboMaChuyenMon.Location = new System.Drawing.Point(478, 74);
            this.cboMaChuyenMon.Name = "cboMaChuyenMon";
            this.cboMaChuyenMon.Size = new System.Drawing.Size(121, 21);
            this.cboMaChuyenMon.TabIndex = 17;
            // 
            // cboMaChucVu
            // 
            this.cboMaChucVu.FormattingEnabled = true;
            this.cboMaChucVu.Items.AddRange(new object[] {
            "BV   \t",
            "GD",
            "GS",
            "LT",
            "NV",
            "PGD",
            "PTP",
            "TK",
            "TP",
            "TT"});
            this.cboMaChucVu.Location = new System.Drawing.Point(478, 49);
            this.cboMaChucVu.Name = "cboMaChucVu";
            this.cboMaChucVu.Size = new System.Drawing.Size(121, 21);
            this.cboMaChucVu.TabIndex = 16;
            // 
            // cboMaPB
            // 
            this.cboMaPB.FormattingEnabled = true;
            this.cboMaPB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cboMaPB.Location = new System.Drawing.Point(478, 23);
            this.cboMaPB.Name = "cboMaPB";
            this.cboMaPB.Size = new System.Drawing.Size(121, 21);
            this.cboMaPB.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(107, 98);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(107, 124);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(107, 23);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 20);
            this.txtMaNV.TabIndex = 9;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(375, 104);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblMaChuyenMon
            // 
            this.lblMaChuyenMon.AutoSize = true;
            this.lblMaChuyenMon.Location = new System.Drawing.Point(375, 77);
            this.lblMaChuyenMon.Name = "lblMaChuyenMon";
            this.lblMaChuyenMon.Size = new System.Drawing.Size(83, 13);
            this.lblMaChuyenMon.TabIndex = 7;
            this.lblMaChuyenMon.Text = "Mã chuyên môn";
            // 
            // lblMaChucVu
            // 
            this.lblMaChucVu.AutoSize = true;
            this.lblMaChucVu.Location = new System.Drawing.Point(375, 49);
            this.lblMaChucVu.Name = "lblMaChucVu";
            this.lblMaChucVu.Size = new System.Drawing.Size(64, 13);
            this.lblMaChucVu.TabIndex = 6;
            this.lblMaChucVu.Text = "Mã chức vụ";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(375, 26);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(39, 13);
            this.lblMaPB.TabIndex = 5;
            this.lblMaPB.Text = "Mã PB";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(33, 126);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(33, 104);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(33, 77);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(33, 49);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(33, 26);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(40, 13);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThongTinNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 330);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvThongTinNhanVien
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colMaPB,
            this.colMaChucVu,
            this.colMaChuyenMon,
            this.colGhiChu});
            this.dgvThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(802, 330);
            this.dgvThongTinNhanVien.TabIndex = 0;
            this.dgvThongTinNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNhanVien_CellClick);
            // 
            // colMaNV
            // 
            this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colMaPB
            // 
            this.colMaPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPB.DataPropertyName = "MaPB";
            this.colMaPB.HeaderText = "Mã PB";
            this.colMaPB.Name = "colMaPB";
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChucVu.DataPropertyName = "MaChucVu";
            this.colMaChucVu.HeaderText = "Mã chức vụ";
            this.colMaChucVu.Name = "colMaChucVu";
            // 
            // colMaChuyenMon
            // 
            this.colMaChuyenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChuyenMon.DataPropertyName = "MaChuyenMon";
            this.colMaChuyenMon.HeaderText = "Mã chuyên môn";
            this.colMaChuyenMon.Name = "colMaChuyenMon";
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            // 
            // frmQuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyNhanSu";
            this.Text = "frmQuanLyNhanSu";
            this.Load += new System.EventHandler(this.frmQuanLyNhanSu_Load);
            this.panel1.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblMaChuyenMon;
        private System.Windows.Forms.Label lblMaChucVu;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ComboBox cboMaChuyenMon;
        private System.Windows.Forms.ComboBox cboMaChucVu;
        private System.Windows.Forms.ComboBox cboMaPB;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.TextBox txtGT;
    }
}