﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QLNS
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_DAO.DoiMatKhau(txtuser.Text) == false)
            {
                lbNote.Text = "Tên Đăng Nhập Không Khớp!!!";
                return;
            }
            if(txtnewpass.Text!=txtnhaplaipass.Text)
            {
                lbNote.Text = "Mật Khẩu nhập lại không trùng !!!";
                return;
            }
            else
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.UserName = txtuser.Text;
                tk.Password = txtnewpass.Text;
                TaiKhoan_DAO.Sua(tk);
                MessageBox.Show("Thay đổi thành công!!!");
                this.Hide();
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát","QUESTION",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi==DialogResult.OK)
            {
                Application.Restart();
            }

        }
    }
}