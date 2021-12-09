using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Thong tin ca nhan
MSSV: 2059054 
Ho Ten: Tram Thi Tuyet Thanh 
Dia chi mail: 2059054@itec.hcmus.edu.vn
Github: 
 */

namespace src
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Chưa Điền Thông Tin Đăng Nhập", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Chưa Điền Tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Chưa Điền Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (cbxField.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa Chọn Vị Trí", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (txtUserName.Text != "Minh" && cbxField.SelectedIndex == 1)
            {
                MessageBox.Show("Không Thể Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbxField.SelectedIndex == 0)
                {
                    frmThi frm = new frmThi();
                    frm.Show();
                    this.Visible = false;
                }
                else if (txtUserName.Text == "Minh" && cbxField.SelectedIndex == 1)
                {
                    frmChamDiem frm = new frmChamDiem();
                    frm.Show();
                    this.Visible = false;
                }
            }

            /*
            frmThi frm = new frmThi();
            frm.Show();
            this.Visible = false;
            */
        }
    }
}
