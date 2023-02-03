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
    public partial class fAdminManager : Form
    {
        public fAdminManager()
        {
            InitializeComponent();
            LoadAllData();

        }
        #region LoadAllData
        void LoadAllData()
        {
            loadAccount();
            loadTable();
            loadCatagory();
            loadFood();
            loadBill();
        }
        void loadAccount()
        {
            dgvUser.DataSource = QuanLyQuanCafeDB.Db.Account.ToList();

        }
        void loadTable()
        {
            dgvTable.DataSource = QuanLyQuanCafeDB.Db.TableFood.ToList();

        }
        void loadCatagory()
        {
            dgvCategory.DataSource =QuanLyQuanCafeDB.Db.FoodCategory.ToList();

        }
        void loadFood()
        {
            dgvFood.DataSource =QuanLyQuanCafeDB.Db.Food.ToList();

        }
        void loadBill()
        {
            if (QuanLyQuanCafeDB.Db.Bill.ToList().Count != 0)
            {
                DateTime dateStart = DateTime.Parse(dtpkStart.Value.ToShortDateString());
                DateTime dateEnd = DateTime.Parse(dtpkEnd.Value.ToShortDateString());
                dgvBill.DataSource = QuanLyQuanCafeDB.Db.Bill.Where(p=>p.DateCheckIn>=dateStart&&(p.DateCheckOut<= dateEnd || p.DateCheckOut==null)).Select(p => new
                {
                    MãHóaĐơn = p.id,
                    NgàyTạo = p.DateCheckIn,
                    NgàyThanhToán = p.DateCheckOut,
                    TênBàn = p.TableFood.name,
                    TrạngThái = p.status == 0 ? "Đã thanh toán" : "Chưa thanh toán",
                    TổngTiền = p.BillInfo.Sum(i => i.Food.price * i.count),
                    GiảmGiá = p.Discount+"%",
                    ThựcThu = p.BillInfo.Sum(i => i.Food.price * i.count)*(100-p.Discount)/100
                }).ToList();
            }
        }
        #endregion
        
        #region Table
        void showInfoTable()
        {
            txbIDTable.DataBindings.Clear();
            txbNameTable.DataBindings.Clear();
            cbStatusTable.DataBindings.Clear();
            txbIDTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "id"));
            txbNameTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "name"));
            cbStatusTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "status"));
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoTable();
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (txbIDTable.Text!="")
            {
                TableFood tf = QuanLyQuanCafeDB.Db.TableFood.Find(int.Parse(txbIDTable.Text));
                tf.name = txbNameTable.Text;
                tf.status = cbStatusTable.Text;
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn tạo thêm 1 bàn mới?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                QuanLyQuanCafeDB.Db.TableFood.Add(new TableFood() { name = $"Bàn {QuanLyQuanCafeDB.Db.TableFood.Count()+1}", status = "Trống" });
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            loadTable();
            showInfoTable();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (txbIDTable.Text!="")
            {
                QuanLyQuanCafeDB.Db.TableFood.Remove(QuanLyQuanCafeDB.Db.TableFood.Find(int.Parse(txbIDTable.Text)));
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }
        #endregion

        #region Bill
        private void btnShowBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.Rows.Count!=0)
            {
                DateTime dateStart = DateTime.Parse(dtpkStart.Value.ToShortDateString());
                DateTime dateEnd = DateTime.Parse(dtpkEnd.Value.ToShortDateString());
                Double TongTienHoaDon = double.Parse(QuanLyQuanCafeDB.Db.Bill.Where(p => p.DateCheckIn >= dateStart && (p.DateCheckOut <= dateEnd || p.DateCheckOut == null)).Sum(p => p.BillInfo.Sum(i => i.Food.price * i.count) * (100 - p.Discount) / 100).ToString());
                Double TongTienChuaThanhToan = double.Parse(QuanLyQuanCafeDB.Db.Bill.Where(p => p.DateCheckIn >= dateStart && (p.DateCheckOut <= dateEnd || p.DateCheckOut == null)&&p.status==1).Sum(p => p.BillInfo.Sum(i => i.Food.price * i.count) * (100 - p.Discount) / 100).ToString());
                MessageBox.Show($"Tổng tiền kiếm được: {TongTienHoaDon}\nTổng tiền chưa thanh toán: { TongTienChuaThanhToan}vnđ\nTổng tiền đã thu về: {TongTienHoaDon - TongTienChuaThanhToan}vnđ");

            }
        }

        private void dtpkStart_ValueChanged(object sender, EventArgs e)
        {
            loadBill();
        }

        private void dtpkEnd_ValueChanged(object sender, EventArgs e)
        {
            loadBill();
        }
        #endregion

        #region Account
        void showInfoAccount()
        {
            txbUserName.DataBindings.Clear();
            txbDisplayName.DataBindings.Clear();
            txbUserName.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "UserName"));
            txbDisplayName.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "DisplayName"));
            cbTypeOfUser.Text = dgvUser.SelectedCells[0].OwningRow.Cells["Type"].Value.ToString()=="0"?"Staff":"Admin";
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoAccount();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != "")
            {
                QuanLyQuanCafeDB.Db.Account.Remove(QuanLyQuanCafeDB.Db.Account.Find(txbUserName.Text));
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            loadAccount();
            showInfoAccount();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text!="")
            {
                QuanLyQuanCafeDB.Db.Account.Where(p => p.UserName == txbUserName.Text).ToList()[0].DisplayName = txbDisplayName.Text;
                QuanLyQuanCafeDB.Db.Account.Where(p => p.UserName == txbUserName.Text).ToList()[0].Type = cbTypeOfUser.Text=="Admin"?1:0;
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text!="")
            {
                QuanLyQuanCafeDB.Db.Account.Where(p => p.UserName == txbUserName.Text).ToList()[0].PassWord = "1";
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fCreateNewAccount f = new fCreateNewAccount();
            f.ShowDialog();
        }






        #endregion

        #region Catagory

        void showInfoCatagory()
        {
            txbIDCategory.DataBindings.Clear();
            txbNameCategory.DataBindings.Clear();
            txbIDCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "id"));
            txbNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "name"));
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoCatagory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            fCreateNewCategory f = new fCreateNewCategory();
            f.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txbIDCategory.Text != "")
            {
                int tmpNameCatagory = int.Parse(txbIDCategory.Text);
                QuanLyQuanCafeDB.Db.FoodCategory.Where(p => p.id == tmpNameCatagory).ToList()[0].name = txbNameCategory.Text;
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            loadCatagory();
            showInfoCatagory();
        }




        #endregion

        #region Food


        void showFood()
        {
            txbIDFood.DataBindings.Clear();
            txbNameFood.DataBindings.Clear();
            txbPriceFood.DataBindings.Clear();
            cbFoodCategory.DataBindings.Clear();
            txbIDFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "id"));
            txbNameFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "name"));
            txbPriceFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "price"));
            cbFoodCategory.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "idCategory"));

            cbFoodCategory.DataSource = QuanLyQuanCafeDB.Db.FoodCategory.Select(p => p.name).ToList();
            cbStatusFood.Text = QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].status == 1 ? "Bán" : "Dừng bán";
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadFood();
            showFood();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (txbIDFood.Text!="")
            {
                QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].status = 0;
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            if (txbIDFood.Text!="")
            {
                try
                {
                    QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].name = txbNameFood.Text;
                    QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].price = double.Parse(txbPriceFood.Text);
                    QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].idCategory = QuanLyQuanCafeDB.Db.FoodCategory.Where(p => p.name == cbFoodCategory.Text).ToList()[0].id;
                    QuanLyQuanCafeDB.Db.Food.Where(p => p.id.ToString() == txbIDFood.Text).ToList()[0].status = cbStatusFood.Text == "Bán" ? 1 : 0;
                    QuanLyQuanCafeDB.Db.SaveChanges();
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập lại thông tin");
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            fCreateNewFood f = new fCreateNewFood();
            f.ShowDialog();
        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showFood();
        }

        #endregion

    }
}
