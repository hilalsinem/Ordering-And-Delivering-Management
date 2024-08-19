using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.Metadata.Ecma335;


namespace OrderAndDeliveryManagement
{
    public partial class MenuUserControl : UserControl
    {

        public MenuUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");


        // ADD TO CART
        private void AddToCart()
        {
            // Get the product name from the label
            string productName = label1.Text.Trim().Replace("\n", "");



            if (string.IsNullOrWhiteSpace(comboBox1.Text) || !int.TryParse(comboBox1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("You should select a valid quantity to add to your cart", "No quantity selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no valid quantity is selected
            }


            // Check if the product already exists in the database
            con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM ProductTable WHERE Name = @Name", con);
            checkCmd.Parameters.AddWithValue("@Name", productName);
            int productExists = (int)checkCmd.ExecuteScalar();
            con.Close();

            if (productExists > 0)
            {
                con.Open();

                SqlCommand checkCmd2 = new SqlCommand("SELECT username FROM LoginTable", con);
                string username = (string)checkCmd2.ExecuteScalar();
                con.Close();


                con.Open();
                SqlCommand checkCmd3 = new SqlCommand("SELECT COUNT(*) FROM CartTable WHERE Name = @Name AND username = @username", con);
                checkCmd3.Parameters.AddWithValue("@Name", productName);
                checkCmd3.Parameters.AddWithValue("@username", username);
                int productDoubles = (int)checkCmd3.ExecuteScalar();
                con.Close();


                if (productDoubles > 0)
                {
                    MessageBox.Show("You have already added this item to your cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

                else
                {
                    Image partyIcon = Properties.Resources.party_popper;

                    CustomMessageBox.Show("Successful", "Item is added to yor cart. You can view items and complete your order from your cart menu", partyIcon);

                    // Insert the new product into the database
                    con.Open();
                    SqlCommand cnn = new SqlCommand("Insert into CartTable values (@username, @Name, @Price, @Quantity)", con);
                    cnn.Parameters.AddWithValue("@username", username);
                    cnn.Parameters.AddWithValue("@Name", productName);
                    cnn.Parameters.AddWithValue("@Price", decimal.Parse(label3.Text));
                    cnn.Parameters.AddWithValue("@Quantity", comboBox1.Text);
                    cnn.ExecuteNonQuery();

                }
            }


            else
            {
                Image errorIcon = Properties.Resources.error1;
                // Notify the user that the product does not exist
                CustomMessageBox.Show("Error", "This product does not exist in the menu.", errorIcon);
                MessageBox.Show("The product does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
            comboBox1.SelectedIndex = -1;

            // Refresh the DataGridView
            BindData();
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            SqlCommand cnn = new SqlCommand("Select * from CartTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
        }

        //ELEMENTS
        public int Quantity
        {
            get
            {
                if (comboBox1.SelectedItem != null && decimal.TryParse(comboBox1.SelectedItem.ToString(), out decimal result))
                {
                    return Quantity;
                }
                else
                {
                    // Handle the case where no valid selection is made
                    return 0; // Default value
                }
            }
            set
            {
                comboBox1.SelectedItem = value.ToString();
            }
        }
        public string ProductName
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public string ProductDescription
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public decimal ProductPrice
        {
            get => decimal.Parse(label3.Text);
            set => label3.Text = value.ToString();
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void MenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
