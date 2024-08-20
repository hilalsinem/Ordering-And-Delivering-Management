using Microsoft.Data.SqlClient;
using OrderAndDeliveryManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OrderAndDeliveryManagement
{
    public partial class Customer : Form
    {

        public Customer()
        {
            InitializeComponent();
            this.FormClosing += Customer_FormClosing;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");


        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
            {
                con.Open();

                // Delete from CartTable where the name matches ToBeDeletedTable
                SqlCommand deleteCartCmd = new SqlCommand("DELETE FROM CartTable WHERE Name IN (SELECT * FROM ToBeDeletedTable)", con);
                deleteCartCmd.ExecuteNonQuery();

                // Optionally clear the ToBeDeletedTable after deletion
                SqlCommand clearToDeleteCmd = new SqlCommand("DELETE FROM ToBeDeletedTable", con);
                clearToDeleteCmd.ExecuteNonQuery();
                con.Close();
            }

            // Refresh the cart display
            LoadCartItems();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            title_label.Visible = true;
            button7.Visible = false;
            delete_label.Visible = false;
            delete_button.Visible = false;
            title_label.Text = "Menu";
            order_label.Visible = false;
            order_button.Visible = false;
            button7.Visible = true;
            refresh_button.Visible = false;
            refresh_order_button.Visible = false;

            panel3.Controls.Add(title_label);
            panel3.Controls.Add(button7);

            flowLayoutPanel1.Controls.Add(panel3);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MenuUserControl menuTable = new MenuUserControl()
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


        private void button3_Click(object sender, EventArgs e)
        {
            LoadCartItems();
        }
        private void LoadCartItems()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            title_label.Visible = true;
            title_label.Text = "My Cart";
            button7.Visible = false;
            delete_button.Visible = true;
            delete_label.Visible = true;
            order_label.Visible = true;
            order_button.Visible = true;
            refresh_order_button.Visible = false;
            refresh_button.Visible = true;

            panel3.Controls.Add(title_label);
            panel3.Controls.Add(refresh_button);
            panel3.Controls.Add(delete_button);
            panel3.Controls.Add(delete_label);

            flowLayoutPanel1.Controls.Add(panel3);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            {

                conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
                string username = (string)checkCmd.ExecuteScalar();
                conn.Close();

                conn.Open();

                SqlCommand query = new SqlCommand("SELECT * FROM CartTable WHERE username = @username", conn);
                query.Parameters.AddWithValue("@username", username);
                SqlDataReader reader2 = query.ExecuteReader();

                while (reader2.Read())
                {
                    CartUserControl cartTable = new CartUserControl
                    {
                        username = reader2["username"].ToString(),
                        ProductName = reader2["Name"].ToString(),
                        Quantity = Convert.ToInt32(reader2["Quantity"]),
                        ProductPrice = Convert.ToDecimal(reader2["Price"])

                    };


                    flowLayoutPanel1.Controls.Add(cartTable);
                }

                conn.Close();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM LoginTable", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        public void LoadOrderItems()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            title_label.Visible = true;
            title_label.Text = "My Orders";
            button7.Visible = false;
            delete_button.Visible = false;
            refresh_button.Visible = true;
            order_button.Visible = false;
            delete_label.Visible = false;
            order_label.Visible = false;
            refresh_order_button.Visible = true;
            label3.Visible = true;
            payment_panel.Visible = true;
            confirm_button.Visible = true;
            payment_panel.Visible = true;
            radioButton2.Visible = true;
            radioButton1.Visible = true;

            payment_panel.Controls.Add(confirm_button);
            payment_panel.Controls.Add(label3);
            payment_panel.Controls.Add(radioButton1);
            payment_panel.Controls.Add(radioButton2);
            panel3.Controls.Add(title_label);
            panel3.Controls.Add(refresh_order_button);

            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(payment_panel);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

            conn.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
            string username = (string)checkCmd.ExecuteScalar();
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CartTable WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();

            decimal totalPrice = 0m;

            while (reader.Read())
            {

                OrderUserControl orderTable = new OrderUserControl
                {
                    username = reader["username"].ToString(),
                    ProductName = reader["Name"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    ProductPrice = Convert.ToDecimal(reader["Price"])

                };

                totalPrice += orderTable.ProductPrice * orderTable.Quantity;

                flowLayoutPanel1.Controls.Add(orderTable);
                label3.Text = $"Total Amount: {totalPrice:C}";
            }
            conn.Close();


        }

        public void LoadOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            panel3.Visible = true;
            title_label.Visible = true;
            title_label.Text = "My Orders";
            button7.Visible = false;
            delete_button.Visible = false;
            delete_label.Visible = false;
            order_label.Visible = false;
            order_button.Visible = false;
            refresh_order_button.Visible = true;
            refresh_button.Visible = false;

            panel3.Controls.Add(title_label);
            panel3.Controls.Add(refresh_order_button);

            flowLayoutPanel1.Controls.Add(panel3);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

            conn.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
            string username = (string)checkCmd.ExecuteScalar();
            conn.Close();

            conn.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM OrderTable WHERE username = @username ORDER BY OrderDate DESC", conn);
            query.Parameters.AddWithValue("@username", username);
            SqlDataReader reader2 = query.ExecuteReader();

            while (reader2.Read())
            {
                DeliveryUserControl orderTable = new DeliveryUserControl
                {
                    Id = Convert.ToInt32(reader2["Id"]),
                    TotalPrice = Convert.ToDecimal(reader2["TotalPrice"]),
                    OrderDate = reader2["OrderDate"].ToString(),
                    Status = reader2["Status"].ToString(),

                };

                flowLayoutPanel1.Controls.Add(orderTable);
            }

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void order_button_Click(object sender, EventArgs e)
        {
            LoadOrderItems();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CreditCart creditcard = new CreditCart();
            creditcard.Show();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Image InfoIcon = Properties.Resources.informative;
            CustomMessageBox.Show("Information", "Your payment will process when your order is delivered", InfoIcon);
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        public int GenerateUniqueOrderId()
        {
            int randomNumber;
            bool isUnique = false;

            // Establish the connection string (replace with your actual connection string)
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

            Random random = new Random();

            do
            {
                // Generate a random number between 1 and 10001
                randomNumber = random.Next(1, 10001);

                // Check if the generated random number already exists in the OrderTable
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM OrderTable WHERE Id = @Id", con);
                checkCmd.Parameters.AddWithValue("@Id", randomNumber);

                int count = (int)checkCmd.ExecuteScalar();
                con.Close();

                // If count is 0, it means the ID is unique
                if (count == 0)
                {
                    isUnique = true;
                }

            } while (!isUnique); // Repeat until a unique ID is found

            return randomNumber;
        }

        private string radioButton_Selection()
        {
            string selectedOption = "";

            if (radioButton1.Checked)
            {
                return "Credit Card";
            }
            else if (radioButton2.Checked)
            {
                return "Cash"; // You can set this to whatever the radio button represents.
            }
            else
            {
                Image helpIcon = Properties.Resources.help;
                CustomMessageBox.Show("Alert", "Please select a payment method before confirming.", helpIcon);
                return null; // Exit the method if no option is selected.
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {

            string paymentMethod = radioButton_Selection();
            // Check if paymentMethod is null (indicating that no option was selected)
            if (paymentMethod == null)
            {
                // Exit the method to prevent further processing
                return;
            }


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            int Id = GenerateUniqueOrderId();

            conn.Open();
            SqlCommand checkCmd2 = new SqlCommand("SELECT username FROM LoginTable", conn);
            string username = (string)checkCmd2.ExecuteScalar();
            conn.Close();


            conn.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Address FROM Login_Guest WHERE username = @username", conn);
            cmd3.Parameters.AddWithValue("@username", username);
            string address = (string)cmd3.ExecuteScalar();
            conn.Close();

          

            decimal totalPrice = 0m;

            DateTime orderTime = DateTime.Now;
            string formattedOrderTime = orderTime.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            string status = "Placed";

            conn.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM CartTable WHERE username = @username", conn);
            query.Parameters.AddWithValue("@username", username);
            SqlDataReader reader2 = query.ExecuteReader();


            List<Tuple<string, int, decimal>> products = new List<Tuple<string, int, decimal>>();


            while (reader2.Read())
            {

                OrderUserControl orderTable = new OrderUserControl
                {
                    username = reader2["username"].ToString(),
                    ProductName = reader2["Name"].ToString(),
                    Quantity = Convert.ToInt32(reader2["Quantity"]),
                    ProductPrice = Convert.ToDecimal(reader2["Price"])

                };

                string productName = reader2["Name"].ToString();
                int quantity = Convert.ToInt32(reader2["Quantity"]);
                decimal price = Convert.ToDecimal(reader2["Price"]);

                products.Add(new Tuple<string, int, decimal>(productName, quantity, price));

                totalPrice += orderTable.ProductPrice * orderTable.Quantity;

                label3.Text = $"Total Amount: {totalPrice:C}";
            }

            conn.Close();


            foreach (var product in products)
            {
                string insertQuery = "INSERT INTO OrderDetailsTable (Id, Name, Quantity, Price, Address, PaymentMethod) VALUES (@Id, @Name, @Quantity, @Price, @Address, @PaymentMethod)";
                using (SqlCommand cmd11 = new SqlCommand(insertQuery, conn))
                {
                    conn.Open();
                    cmd11.Parameters.AddWithValue("@Id", Id);
                    cmd11.Parameters.AddWithValue("@Name", product.Item1);       // Product Name
                    cmd11.Parameters.AddWithValue("@Quantity", product.Item2);   // Quantity
                    cmd11.Parameters.AddWithValue("@Price", product.Item3);      // Price
                    cmd11.Parameters.AddWithValue("@Address", address);
                    cmd11.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd11.ExecuteNonQuery();

                }
                conn.Close();
            }


            conn.Open();
            SqlCommand insertCmd = new SqlCommand("INSERT INTO OrderTable (Id, username, TotalPrice, OrderDate, Status) VALUES (@Id, @username, @TotalPrice, @OrderDate, @Status)", conn);
            insertCmd.Parameters.AddWithValue("@Id", Id);
            insertCmd.Parameters.AddWithValue("@username", username);
            insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
            insertCmd.Parameters.AddWithValue("@OrderDate", formattedOrderTime);
            insertCmd.Parameters.AddWithValue("@Status", status);
            insertCmd.ExecuteNonQuery();
            conn.Close();


            conn.Open();
            SqlCommand cmd4 = new SqlCommand("DELETE FROM CartTable WHERE username = @username", conn);
            cmd4.Parameters.AddWithValue("@username", username);
            cmd4.ExecuteNonQuery();
            conn.Close();
            LoadOrders();

            conn.Open();
            SqlCommand cmd5 = new SqlCommand("DELETE FROM CreditCardTable WHERE username = @username", conn);
            cmd5.Parameters.AddWithValue("@username", username);
            cmd5.ExecuteNonQuery();
            conn.Close();

            string message = "Thank you. We have received your order. You can track your order from 'MY ORDERS' page";
            string title = "SUCCESSFUL ORDER";

            Image partyIcon = Properties.Resources.party_popper;
            CustomMessageBox.Show(title, message, partyIcon);

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void refresh_order_button_Click(object sender, EventArgs e)
        {
            LoadOrders();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadCartItems();
        }
    }
}
