namespace cafe_management
{
    partial class GuestOrder
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
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderAmt = new System.Windows.Forms.Label();
            this.SellerNameTb = new System.Windows.Forms.TextBox();
            this.OrderNumTb = new System.Windows.Forms.TextBox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGv);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OrderAmt);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.OrderNumTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(216, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 639);
            this.panel1.TabIndex = 0;
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(338, 256);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QtyTb.Size = new System.Drawing.Size(157, 22);
            this.QtyTb.TabIndex = 13;
            this.QtyTb.Text = "Quantity";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(455, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Place the Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Your Order";
            // 
            // OrdersGv
            // 
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGv.Location = new System.Drawing.Point(257, 329);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.RowHeadersVisible = false;
            this.OrdersGv.RowHeadersWidth = 51;
            this.OrdersGv.RowTemplate.Height = 24;
            this.OrdersGv.Size = new System.Drawing.Size(507, 253);
            this.OrdersGv.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(527, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderAmt
            // 
            this.OrderAmt.AutoSize = true;
            this.OrderAmt.Location = new System.Drawing.Point(685, 606);
            this.OrderAmt.Name = "OrderAmt";
            this.OrderAmt.Size = new System.Drawing.Size(89, 16);
            this.OrderAmt.TabIndex = 8;
            this.OrderAmt.Text = "Order Amount";
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.Enabled = false;
            this.SellerNameTb.Location = new System.Drawing.Point(74, 139);
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(157, 22);
            this.SellerNameTb.TabIndex = 7;
            this.SellerNameTb.Text = "Guest";
            // 
            // OrderNumTb
            // 
            this.OrderNumTb.Location = new System.Drawing.Point(74, 97);
            this.OrderNumTb.Name = "OrderNumTb";
            this.OrderNumTb.Size = new System.Drawing.Size(157, 22);
            this.OrderNumTb.TabIndex = 6;
            this.OrderNumTb.Text = "Order Number";
            // 
            // ItemsGV
            // 
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(257, 44);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersVisible = false;
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(507, 204);
            this.ItemsGV.TabIndex = 4;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // categorycb
            // 
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.categorycb.Location = new System.Drawing.Point(74, 44);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(157, 24);
            this.categorycb.TabIndex = 3;
            this.categorycb.Text = "Category";
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.categorycb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(983, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(699, 9);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(36, 16);
            this.Datelbl.TabIndex = 14;
            this.Datelbl.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rs";
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1017, 688);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.TextBox OrderNumTb;
        private System.Windows.Forms.TextBox SellerNameTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OrderAmt;
        private System.Windows.Forms.DataGridView OrdersGv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label2;
    }
}