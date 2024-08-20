using Microsoft.Data.SqlClient;
using OrderAndDeliveryManagement.Properties;



namespace OrderAndDeliveryManagement
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            this.FormClosing += Seller_FormClosing;
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
        public void button2_Click(object sender, EventArgs e)
        {
        }

        private void Seller_Load(object sender, EventArgs e)
        {

        }
        private void Seller_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void LoadMenuItems()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            button5.Visible = true;
            label2.Visible = true;
            button6.Visible = true;
            button2.Visible = false;
            delete_button.Visible = false;
            delete_label.Visible = false;
            refresh_2.Visible = false;

            panel3.Controls.Add(button5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button6);

            flowLayoutPanel1.Controls.Add(panel3);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MenuSellerUserControl menuTable = new MenuSellerUserControl
                    {
                        ProductName = reader["Name"].ToString(),
                        ProductDescription = reader["Description"].ToString(),
                        ProductPrice = Convert.ToDecimal(reader["Price"]),
                        ProductImage = Resources.small_icon1 // Assuming you have a default icon for products
                    };


                    flowLayoutPanel1.Controls.Add(menuTable);
                }
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Products product = new Products())
            {
                product.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void Seller_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LoginTable", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Application.Exit(); // Terminate the application

        }

        public void LoadOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            button5.Visible = false;
            label2.Visible = true;
            button6.Visible = false;
            refresh_2.Visible = true;
            label2.Text = "Orders";
            button2.Visible = true;
            delete_button.Visible = true;
            delete_label.Visible = true;

            panel3.Controls.Add(label2);
            panel3.Controls.Add(refresh_2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(delete_label);
            panel3.Controls.Add(delete_button);

            flowLayoutPanel1.Controls.Add(panel3);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderTable ORDER BY OrderDate DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var orderControl = new DeliverySellerUserControl
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        Username = reader["username"].ToString(),
                        TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                        Status = reader["Status"].ToString(),
                        OrderDate = reader["OrderDate"].ToString(),
                    };

                    flowLayoutPanel1.Controls.Add(orderControl);
                }
                conn.Close();
            }
        }

        // Method to update all orders when button2 (Update All) is clicked
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
            {
                conn.Open();

                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is DeliverySellerUserControl orderControl)
                    {
                        string updateQuery = "UPDATE OrderTable SET Status = @Status WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Status", orderControl.Status);
                            cmd.Parameters.AddWithValue("@Id", orderControl.ID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                conn.Close();
            }

            // Optionally, reload the orders to reflect the changes
            LoadOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
            {
                con.Open();

                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is DeliverySellerUserControl orderControl)
                    {
                        if (orderControl.IsRadioButtonChecked) // Use the new public property
                        {
                            string deleteQuery = "DELETE FROM OrderTable WHERE Id = @Id";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@Id", orderControl.ID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                con.Close();
            }

            // Refresh the orders display
            LoadOrders();
        }

        private void refresh_2_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
