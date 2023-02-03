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
    public partial class fCreateNewFood : Form
    {
        public fCreateNewFood()
        {
            InitializeComponent();
            cbFoodCategory.DataSource=QuanLyQuanCafeDB.Db.FoodCategory.Select(p=>p.name).ToList();
        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {
            if (txbNameFood.Text!=""&&nmFoodPrice.Value.ToString()!=""&&cbFoodCategory.Text!="")
            {
                QuanLyQuanCafeDB.Db.Food.Add(new Food()
                {
                    name = txbNameFood.Text,
                    idCategory = QuanLyQuanCafeDB.Db.FoodCategory.Where(p => p.name == cbFoodCategory.Text).ToList()[0].id,
                    price = double.Parse(Math.Round(nmFoodPrice.Value, 0).ToString()),
                    status = 1
                }) ;
                QuanLyQuanCafeDB.Db.SaveChanges();
                MessageBox.Show("Tạo món mới thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
    }
}
