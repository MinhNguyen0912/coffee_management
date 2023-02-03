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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadBillWhenClickBtnTable();
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            for (int i = 0; i < QuanLyQuanCafeDB.Db.TableFood.Count(); i++)
            {
                if (QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status == "Tạm đóng")
                {
                    QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status = "Tạm đóng";
                }
                else if (QuanLyQuanCafeDB.Db.TableFood.ToList()[i].Bill.Count!=0)
                {
                    QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status = "Trống";
                    foreach (var item in QuanLyQuanCafeDB.Db.TableFood.ToList()[i].Bill)
                    {
                        if (item.status==1)
                        {
                            QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status = "Có người";
                            break;
                        }
                    }
                }
                else
                {
                    QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status = "Trống";
                }
                Button btn = new Button() { Width = 90, Height = 90, Text = $"{QuanLyQuanCafeDB.Db.TableFood.ToList()[i].name}\n{QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status}",BackColor= QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status=="Trống"?Color.GreenYellow:QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status == "Có người"?Color.DarkSalmon:Color.Gray,Enabled= QuanLyQuanCafeDB.Db.TableFood.ToList()[i].status == "Tạm đóng"?false:true };
                flpTable.Controls.Add(btn);
            }
            lbStatus.Text = QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).Select(p => p.Type).ToList()[0] == 1 ? "Chức vụ: Admin" : "Chức vụ: Staff";
            lbDisplayName.Text = QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).Select(p => p.DisplayName).ToList()[0];
            LoadCategory();
            ShowChangeTable();
        }
        void LoadBillWhenClickBtnTable()
        {
            foreach (Button btn in flpTable.Controls)
            {
                btn.Click += Btn_Click;
            }
        }

        void LoadCategory()
        {
            cbCategory.Items.Clear();
            foreach (var item in QuanLyQuanCafeDB.Db.FoodCategory.ToList())
            {
                cbCategory.Items.Add(item.name);
            }
        }

        void LoadFood()
        {
            cbShowFood.Text = "";
            cbShowFood.Items.Clear();
            foreach (var item in (QuanLyQuanCafeDB.Db.Food.Where(p => p.FoodCategory.name == cbCategory.Text && p.status==1)).ToList())
            {
                cbShowFood.Items.Add(item.name);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var tmp = btn.Text.Split('\n')[0];
            lbIDTable.Text = QuanLyQuanCafeDB.Db.TableFood.Where(p => p.name.Equals(tmp)).ToList()[0].id.ToString();
            LoadBill();

        }
        int tmpIDTable;
        void LoadBill()
        {
            tmpIDTable = int.Parse(lbIDTable.Text);

            dgvBill.DataSource = QuanLyQuanCafeDB.Db.BillInfo.Where(p => p.Bill.TableFood.id.Equals(tmpIDTable) && p.Bill.status==1).Select(p => new { TênMón = p.Food.name, SốLượng = p.count, ĐơnGiá = p.Food.price, ThànhTiền = p.count * p.Food.price, MãHóaĐơn = p.Bill.id, MãMón = p.idFood ,TrạngThái=p.Bill.status}).ToList();
            LoadTotalMoney();
        }
        void LoadTotalMoney()
        {
            double TotalMoney=0;
            for (int i = 0; i < dgvBill.Rows.Count; i++)
            {
                TotalMoney += double.Parse(dgvBill.Rows[i].Cells["ThànhTiền"].Value.ToString()) * ((100 - double.Parse(Math.Round(nmDiscount.Value, 0).ToString())) / 100) * int.Parse(dgvBill.Rows[i].Cells["TrạngThái"].Value.ToString());
            }
            txbTotalMoney.Text = TotalMoney.ToString()+$" VNĐ";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountInfo f = new fAccountInfo();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuanLyQuanCafeDB.Db.Account.Where(p => p.status == 1).Select(p => p.Type).ToList()[0]==1)
            {
                fAdminManager f = new fAdminManager();
                f.ShowDialog();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(Math.Round(nmFoodCount.Value, 0));
            if (dgvBill.DataSource == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (cbShowFood.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lại món!");
            } 
            else if (dgvBill.Rows.Count == 0)
            {
                Bill b = new Bill() { DateCheckIn = DateTime.Today, idTable = int.Parse(lbIDTable.Text), status = 1 ,Discount=0};
                QuanLyQuanCafeDB.Db.Bill.Add(b);
                QuanLyQuanCafeDB.Db.BillInfo.Add(new BillInfo() { idBill = b.id, idFood = QuanLyQuanCafeDB.Db.Food.Where(p => p.name == cbShowFood.Text).ToList()[0].id, count = tmp });
                QuanLyQuanCafeDB.Db.SaveChanges();

            }
            else
            {
                for (int i = 0; i < dgvBill.Rows.Count; i++)
                {
                    if (dgvBill.Rows[i].Cells["TênMón"].Value.ToString() == cbShowFood.Text)
                    {
                        //QuanLyQuanCafeDB.Db.BillInfo.Find(int.Parse(dgvBill.Rows[i].Cells["MãMón"].Value.ToString())).count += tmp;
                        int MaMon = int.Parse(dgvBill.Rows[i].Cells["MãMón"].Value.ToString());
                        QuanLyQuanCafeDB.Db.BillInfo.Where(p => p.idFood == MaMon).ToList()[0].count += tmp;
                        QuanLyQuanCafeDB.Db.SaveChanges();
                        break;
                    }
                }

                QuanLyQuanCafeDB.Db.BillInfo.Add(new BillInfo() { idBill = int.Parse(dgvBill.Rows[0].Cells["MãHóaĐơn"].Value.ToString()), idFood = QuanLyQuanCafeDB.Db.Food.Where(p => p.name == cbShowFood.Text).ToList()[0].id, count = tmp });
                QuanLyQuanCafeDB.Db.SaveChanges();
            }
            LoadCategory();
            LoadFood();
            LoadTable();
            LoadBill();
            LoadBillWhenClickBtnTable();
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            LoadTotalMoney();

        }
        void ShowChangeTable()
        {
            cbChangeTable.Items.Clear();
            foreach (var item in QuanLyQuanCafeDB.Db.TableFood.ToList())
            {
                if(item.status!="Tạm đóng")
                {
                    var DisplayName = item.name +"-"+ item.id;
                    cbChangeTable.Items.Add(DisplayName);
                }
            }
            LoadBillWhenClickBtnTable();
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if (cbChangeTable.Text=="")
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển tới");
            }else if (dgvBill.Rows.Count == 0)
            {
                MessageBox.Show("Bàn này chưa có khách");
            }
            else
            {
                var tmpBillID = int.Parse(dgvBill.Rows[0].Cells["MãHóaĐơn"].Value.ToString());
                QuanLyQuanCafeDB.Db.Bill.Where(p => p.id == tmpBillID).ToList()[0].idTable = int.Parse(cbChangeTable.Text.Split('-')[cbChangeTable.Text.Split(' ').Length-1]);
                QuanLyQuanCafeDB.Db.SaveChanges();
                lbIDTable.Text = cbChangeTable.Text.Split('-')[cbChangeTable.Text.Split(' ').Length - 1];
            }
            cbChangeTable.Text = "";
            LoadTable();
            LoadBill();
            LoadBillWhenClickBtnTable();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var tmpIDTablePay = int.Parse(lbIDTable.Text);
            foreach (var item in QuanLyQuanCafeDB.Db.Bill.Where(p => p.TableFood.id == tmpIDTable).ToList())
            {
                item.status = 0;
                item.DateCheckOut = DateTime.Today;
                item.Discount = double.Parse(Math.Round(nmDiscount.Value,0).ToString());
            }
            QuanLyQuanCafeDB.Db.SaveChanges();
            nmDiscount.Text = "0";
            LoadBill();
            LoadTable();
            LoadBillWhenClickBtnTable();
        }
    }
}
