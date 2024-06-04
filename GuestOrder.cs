using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafe_management
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemCat = '" + categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int num = 0;
        int price, qty, total;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0;

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "INSERT INTO OrdersTbl VALUES (" + OrderNumTb.Text + ",'" + Datelbl.Text + "','" + SellerNameTb.Text + "',"+OrderAmt.Text+")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created");
            Con.Close();
        }

        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the Quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product to be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            OrderAmt.Text = "" + sum;
        }

        private void categorycb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
