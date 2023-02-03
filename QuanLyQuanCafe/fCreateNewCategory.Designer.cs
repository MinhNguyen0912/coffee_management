namespace QuanLyQuanCafe
{
    partial class fCreateNewCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNameCatagory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateCatagory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbNameCatagory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 40);
            this.panel1.TabIndex = 1;
            // 
            // txbNameCatagory
            // 
            this.txbNameCatagory.Location = new System.Drawing.Point(110, 10);
            this.txbNameCatagory.Name = "txbNameCatagory";
            this.txbNameCatagory.Size = new System.Drawing.Size(130, 20);
            this.txbNameCatagory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm: ";
            // 
            // btnCreateCatagory
            // 
            this.btnCreateCatagory.Location = new System.Drawing.Point(177, 58);
            this.btnCreateCatagory.Name = "btnCreateCatagory";
            this.btnCreateCatagory.Size = new System.Drawing.Size(75, 33);
            this.btnCreateCatagory.TabIndex = 2;
            this.btnCreateCatagory.Text = "Tạo";
            this.btnCreateCatagory.UseVisualStyleBackColor = true;
            this.btnCreateCatagory.Click += new System.EventHandler(this.btnCreateCatagory_Click);
            // 
            // fCreateNewCategory
            // 
            this.AcceptButton = this.btnCreateCatagory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 98);
            this.Controls.Add(this.btnCreateCatagory);
            this.Controls.Add(this.panel1);
            this.Name = "fCreateNewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCreateNewCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNameCatagory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateCatagory;
    }
}