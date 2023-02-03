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
    public partial class fCreateNewCategory : Form
    {
        public fCreateNewCategory()
        {
            InitializeComponent();
        }

        private void btnCreateCatagory_Click(object sender, EventArgs e)
        {
            if (txbNameCatagory.Text!="")
            {
                QuanLyQuanCafeDB.Db.FoodCategory.Add(new FoodCategory() { name = txbNameCatagory.Text });
                QuanLyQuanCafeDB.Db.SaveChanges();
                MessageBox.Show("Tạo nhóm đồ ăn thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }
        
    }
}
