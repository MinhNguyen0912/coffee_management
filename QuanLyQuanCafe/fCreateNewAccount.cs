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
    public partial class fCreateNewAccount : Form
    {
        public fCreateNewAccount()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txbDisplayName.Text==""|| txbPassWord.Text == "" || txbUserName.Text == "" || cbTypeOfUser.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }else if (QuanLyQuanCafeDB.Db.Account.Where(p=>p.UserName.ToLower()==txbUserName.Text.ToLower()).ToList().Count!=0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }
            else
            {
                QuanLyQuanCafeDB.Db.Account.Add(new Account() { DisplayName=txbDisplayName.Text,UserName=txbUserName.Text,PassWord=txbPassWord.Text,Type=cbTypeOfUser.Text=="Admin"?1:0,status=0});
                QuanLyQuanCafeDB.Db.SaveChanges();
                MessageBox.Show("Tạo tài khoản thành công!");
            }
        }
    }
}
