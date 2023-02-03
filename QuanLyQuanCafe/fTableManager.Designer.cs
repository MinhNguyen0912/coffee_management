namespace QuanLyQuanCafe
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIDTable = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbShowFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalMoney = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinToolStripMenuItem,
            this.btnLogOut});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sửaThôngTinToolStripMenuItem.Text = "Sửa thông tin";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(180, 22);
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(408, 411);
            this.flpTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbIDTable);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.nmFoodCount);
            this.panel1.Controls.Add(this.cbShowFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(426, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 57);
            this.panel1.TabIndex = 2;
            // 
            // lbIDTable
            // 
            this.lbIDTable.AutoSize = true;
            this.lbIDTable.Location = new System.Drawing.Point(299, 11);
            this.lbIDTable.Name = "lbIDTable";
            this.lbIDTable.Size = new System.Drawing.Size(0, 13);
            this.lbIDTable.TabIndex = 4;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(218, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 51);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(299, 34);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(43, 20);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbShowFood
            // 
            this.cbShowFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowFood.FormattingEnabled = true;
            this.cbShowFood.Location = new System.Drawing.Point(3, 30);
            this.cbShowFood.Name = "cbShowFood";
            this.cbShowFood.Size = new System.Drawing.Size(209, 21);
            this.cbShowFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(209, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Location = new System.Drawing.Point(426, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 285);
            this.panel2.TabIndex = 3;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.Size = new System.Drawing.Size(339, 279);
            this.dgvBill.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalMoney);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Location = new System.Drawing.Point(426, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 57);
            this.panel3.TabIndex = 4;
            // 
            // txbTotalMoney
            // 
            this.txbTotalMoney.Location = new System.Drawing.Point(171, 3);
            this.txbTotalMoney.Multiline = true;
            this.txbTotalMoney.Name = "txbTotalMoney";
            this.txbTotalMoney.ReadOnly = true;
            this.txbTotalMoney.Size = new System.Drawing.Size(90, 51);
            this.txbTotalMoney.TabIndex = 6;
            this.txbTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnChangeTable);
            this.panel5.Controls.Add(this.cbChangeTable);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 51);
            this.panel5.TabIndex = 5;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(3, 3);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(3, 27);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(75, 21);
            this.cbChangeTable.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDiscount);
            this.panel4.Controls.Add(this.nmDiscount);
            this.panel4.Location = new System.Drawing.Point(87, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(81, 51);
            this.panel4.TabIndex = 4;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(3, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(3, 28);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(76, 20);
            this.nmDiscount.TabIndex = 1;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(267, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 51);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(669, 11);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(35, 13);
            this.lbDisplayName.TabIndex = 5;
            this.lbDisplayName.Text = "label1";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(513, 11);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "label1";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDisplayName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbShowFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lbIDTable;
        private System.Windows.Forms.TextBox txbTotalMoney;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label lbStatus;
    }
}