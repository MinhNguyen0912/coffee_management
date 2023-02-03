using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccountInfo : Form
    {
        public fAccountInfo()
        {
            InitializeComponent();
            showInfo();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text!="" && txbNewPassword.Text != "" && txbOldPassword.Text != "" )
            {
                if (txbOldPassword.Text== QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).ToList()[0].PassWord)
                {
                    if (txbNewPassword.Text==txbConfirmPassword.Text)
                    {
                        QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).ToList()[0].PassWord=txbNewPassword.Text;
                        QuanLyQuanCafeDB.Db.SaveChanges();
                        MessageBox.Show("Thay đổi thông tin tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Hai mật khẩu mới không trùng khớp!");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu cũ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
        void showInfo()
        {
            txbUserName.Text = QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).ToList()[0].UserName;
            txbDisplayName.Text = QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).ToList()[0].DisplayName;

        }
    }
}
