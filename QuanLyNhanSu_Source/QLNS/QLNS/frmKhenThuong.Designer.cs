namespace QLNS
{
    partial class frmKhenThuong
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbNhanvien = new System.Windows.Forms.GroupBox();
            this.dtpNgaythuong = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.dgvKhenthuong = new System.Windows.Forms.DataGridView();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenthuong)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbNhanvien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKhenthuong);
            this.splitContainer1.Size = new System.Drawing.Size(793, 368);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbNhanvien
            // 
            this.grbNhanvien.Controls.Add(this.dtpNgaythuong);
            this.grbNhanvien.Controls.Add(this.label3);
            this.grbNhanvien.Controls.Add(this.label2);
            this.grbNhanvien.Controls.Add(this.label1);
            this.grbNhanvien.Controls.Add(this.txtMoney);
            this.grbNhanvien.Controls.Add(this.txtNote);
            this.grbNhanvien.Controls.Add(this.btnEdit);
            this.grbNhanvien.Controls.Add(this.btnCancel);
            this.grbNhanvien.Controls.Add(this.btnDel);
            this.grbNhanvien.Controls.Add(this.btnSave);
            this.grbNhanvien.Controls.Add(this.btnAdd);
            this.grbNhanvien.Controls.Add(this.cmbName);
            this.grbNhanvien.Controls.Add(this.lblNhanvien);
            this.grbNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNhanvien.Location = new System.Drawing.Point(0, 0);
            this.grbNhanvien.Name = "grbNhanvien";
            this.grbNhanvien.Size = new System.Drawing.Size(793, 113);
            this.grbNhanvien.TabIndex = 0;
            this.grbNhanvien.TabStop = false;
            this.grbNhanvien.Text = "Thông tin nhân viên";
            // 
            // dtpNgaythuong
            // 
            this.dtpNgaythuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaythuong.Location = new System.Drawing.Point(338, 23);
            this.dtpNgaythuong.Name = "dtpNgaythuong";
            this.dtpNgaythuong.Size = new System.Drawing.Size(171, 20);
            this.dtpNgaythuong.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tiền thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày khen";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(111, 66);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(121, 20);
            this.txtMoney.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(338, 51);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(171, 51);
            this.txtNote.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(617, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(706, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(706, 23);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(532, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(532, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(111, 23);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 1;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Location = new System.Drawing.Point(11, 28);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(76, 13);
            this.lblNhanvien.TabIndex = 0;
            this.lblNhanvien.Text = "Tên nhân viên";
            // 
            // dgvKhenthuong
            // 
            this.dgvKhenthuong.AllowUserToAddRows = false;
            this.dgvKhenthuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenthuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKT,
            this.MaNV,
            this.HoTen,
            this.NgayKhenThuong,
            this.TienKhenThuong,
            this.Ghichu});
            this.dgvKhenthuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhenthuong.Location = new System.Drawing.Point(0, 0);
            this.dgvKhenthuong.Name = "dgvKhenthuong";
            this.dgvKhenthuong.ReadOnly = true;
            this.dgvKhenthuong.Size = new System.Drawing.Size(793, 251);
            this.dgvKhenthuong.TabIndex = 0;
            this.dgvKhenthuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhenthuong_CellContentClick);
            // 
            // MaKT
            // 
            this.MaKT.DataPropertyName = "MaKT";
            this.MaKT.HeaderText = "MaKT";
            this.MaKT.Name = "MaKT";
            this.MaKT.ReadOnly = true;
            this.MaKT.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Visible = false;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên nhân viên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // NgayKhenThuong
            // 
            this.NgayKhenThuong.DataPropertyName = "NgayKhenThuong";
            this.NgayKhenThuong.HeaderText = "Ngày khen thưởng";
            this.NgayKhenThuong.Name = "NgayKhenThuong";
            this.NgayKhenThuong.ReadOnly = true;
            this.NgayKhenThuong.Width = 200;
            // 
            // TienKhenThuong
            // 
            this.TienKhenThuong.DataPropertyName = "TienKhenThuong";
            this.TienKhenThuong.HeaderText = "Tiền thưởng";
            this.TienKhenThuong.Name = "TienKhenThuong";
            this.TienKhenThuong.ReadOnly = true;
            this.TienKhenThuong.Width = 150;
            // 
            // Ghichu
            // 
            this.Ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ghichu.DataPropertyName = "GhiChu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.ReadOnly = true;
            // 
            // frmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 368);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKhenThuong";
            this.Text = "frmKhenThuong";
            this.Load += new System.EventHandler(this.frmKhenThuong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbNhanvien.ResumeLayout(false);
            this.grbNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenthuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbNhanvien;
        private System.Windows.Forms.DataGridView dgvKhenthuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.DateTimePicker dtpNgaythuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}