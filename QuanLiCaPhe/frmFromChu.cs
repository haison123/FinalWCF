using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QLCP;
using QuanLiCaPhe.UserService;
namespace QuanLiCaPhe
{
    public partial class frmFromChu : Form
    {
        UserServiceClient usr = new UserServiceClient();
        public frmFromChu()
        {
            InitializeComponent();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmFormMenu frmMenu;
            frmMenu = new frmFormMenu();
            if (txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Bạn chưa nhập User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (usr.kiemTraLogin(txtUser.Text, txtPass.Text))
                {
                    frmMenu.Show();
                    txtPass.Text = "";
                    txtUser.Text = "";
                }
                else
                    MessageBox.Show("Sai User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFromChu_Load(object sender, EventArgs e)
        {

        }
    }
}
