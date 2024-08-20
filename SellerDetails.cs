using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderAndDeliveryManagement
{
    public partial class SellerDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

        int id;

        public SellerDetails(int orderId)
        {
            InitializeComponent();
            InitializeListView();
            id = orderId;

        }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public List<Tuple<string, int, decimal>> Products { get; set; }


        private void SellerDetails_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void InitializeListView()
        {
            listView1.View = View.Details; // Set the view to Details
            listView1.Columns.Add("Product Name", 250); // Width in pixels
            listView1.Columns.Add("Quantity", 200);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Per", 100);
        }

        public void LoadOrderDetails()
        {
            string query = "SELECT Name, Quantity, Price, Address, PaymentMethod FROM OrderDetailsTable WHERE Id = @Id";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //listView1.Items.Clear();


                        // Move back to the first row to load product details


                        while (reader.Read())
                        {
                            string productName = reader["Name"].ToString();
                            string quantity = reader["Quantity"].ToString();
                            string price = reader["Price"].ToString();
                            string per = reader["Per"].ToString();

                            Address = reader["Address"].ToString();
                            PaymentMethod = reader["PaymentMethod"].ToString();
                            label5.Text = PaymentMethod;
                            label6.Text = Address;

                            // Create a new ListViewItem with product details
                            ListViewItem item = new ListViewItem(productName);
                            item.SubItems.Add(quantity);
                            item.SubItems.Add(price);
                            item.SubItems.Add(per);


                            listView1.Items.Add(item);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
