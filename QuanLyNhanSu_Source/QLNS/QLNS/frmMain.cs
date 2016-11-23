using System;
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
    public partial class frmMain : Form
    {
        public static string UserName = "";
        public static string MaQuyen;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbXinChao.Text += UserName;
            DataTable dt = TaiKhoan_DAO.GetMaQuyen(UserName);
            MaQuyen = dt.Rows[0][0].ToString();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn đăng xuất???","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Application.Restart();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanSu nv = new frmQuanLyNhanSu();
            nv.Show(); 
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan pb = new frmPhongBan();
            pb.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPhongBan pb = new frmPhongBan();
            pb.Show();
        }

        private void toolStripButtonNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanSu nv = new frmQuanLyNhanSu();
            nv.Show();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MaQuyen == "1")
            {
                frmNguoiDung nguoidung = new frmNguoiDung();
                nguoidung.Show();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào đây!!!","Thông Báo",MessageBoxButtons.OK);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmKhenThuong khenthuong = new frmKhenThuong();
            khenthuong.Show();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhenThuong khenthuong = new frmKhenThuong();
            khenthuong.Show();
        }

    }
}
