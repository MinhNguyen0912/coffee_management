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
    public partial class fLogin : Form
    {
        

        public fLogin()
        {
            InitializeComponent();
            Application.ApplicationExit += Application_ApplicationExit;

        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            foreach (var item in QuanLyQuanCafeDB.Db.Account.ToList())
            {
                item.status = 0;
            }
            QuanLyQuanCafeDB.Db.SaveChanges();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txbUserName.Text;
            string PassWord = txbPassWord.Text;
            if (UserName == "" || PassWord == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản", "Thông báo", MessageBoxButtons.OK);
            }
            else if (LogIn(UserName, PassWord))
            {
                this.Hide();
                QuanLyQuanCafeDB.Db.Account.Find(UserName).status = 1;
                QuanLyQuanCafeDB.Db.SaveChanges();
                fTableManager f = new fTableManager();
                f.ShowDialog();
                QuanLyQuanCafeDB.Db.Account.Find(UserName).status = 0;
                QuanLyQuanCafeDB.Db.SaveChanges();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khảu không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool LogIn(string UserName, string PassWord)
        {
            if ((from c in QuanLyQuanCafeDB.Db.Account
                 where (c.UserName.ToLower() == (UserName).ToLower() && c.PassWord == PassWord)
                 select c).ToList().Count() != 0)
            {
                return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel=true;
            }
        }
    }
}
