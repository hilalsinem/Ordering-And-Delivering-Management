
using System.Data;

using Microsoft.Data.SqlClient;


namespace OrderAndDeliveryManagement
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

        private void btnExit_Click(object sender, EventArgs e)
        {
            BindData();
            this.Close();
        }
        private void Products_Load(object sender, EventArgs e)
        {

            BindData();

        }

        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty; // Return an empty string if input is null or empty
            }

            // Convert the first letter to uppercase and concatenate it with the rest of the string
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }



        private decimal price
        {
            get => decimal.Parse(textBox2.Text);
            set => textBox2.Text = value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image errorIcon = Properties.Resources.error;

            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    CustomMessageBox.Show("ERROR", "Please fill in all fields.", errorIcon);
                    return;
                }
                else if (price == 0)
                {
                    CustomMessageBox.Show("ERROR", "Please set a price value different than 0 (zero)", errorIcon);
                    return;
                }

                // Validate description length
                if (richTextBox1.Text.Length > 300)
                {
                    CustomMessageBox.Show("ERROR", "The description can only be up to 300 characters long.", errorIcon);
                    return;
                }

                // Get the product name from the textbox
                string productName = textBox1.Text;

                // Check if the product already exists in the database
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM ProductTable WHERE Name = @Name", con);
                checkCmd.Parameters.AddWithValue("@Name", productName);
                int productExists = (int)checkCmd.ExecuteScalar();
                con.Close();

                string inputPer = textBox3.Text;
                string formattedPer = CapitalizeFirstLetter(inputPer);

                if (productExists > 0)
                {
                    // Warn the user that the product already exists
                    MessageBox.Show("This product already exists in the database. Please enter a different product.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Validate and parse the price
                    if (!decimal.TryParse(textBox2.Text, out decimal price))
                    {
                        CustomMessageBox.Show("ERROR", "Invalid price format. Please enter a valid decimal value for the price.", errorIcon);
                        return;
                    }

                    // Insert the new product into the database
                    con.Open();
                    SqlCommand cnn = new SqlCommand("Insert into ProductTable values (@Product_Name, @Price, @Per, @Description)", con);
                    cnn.Parameters.AddWithValue("@Product_Name", productName);
                    cnn.Parameters.AddWithValue("@Price", price);
                    cnn.Parameters.AddWithValue("@Description", richTextBox1.Text);
                    cnn.Parameters.AddWithValue("@Per", formattedPer);

                    cnn.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    richTextBox1.Clear();
                    textBox3.Clear();
                    con.Close();

                    // Refresh the DataGridView
                    BindData();
                }
            }
            catch (FormatException ex)
            {
                CustomMessageBox.Show("ERROR", "Invalid input format. Please check your input values.", errorIcon);
            }
            catch (SqlException ex)
            {
                CustomMessageBox.Show("ERROR", "A database error occurred: " + ex.Message, errorIcon);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("ERROR", "An unexpected error occurred: " + ex.Message, errorIcon);
            }

        }

        void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");
            SqlCommand cnn = new SqlCommand("Select * from ProductTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Get the value of the primary key (Name in this case) of the selected row
                    string productName = row.Cells["Name"].Value.ToString();

                    // Delete the row from the database
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ProductTable WHERE Name = @Name", con);
                        cmd.Parameters.AddWithValue("@Name", productName);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    // Remove the row from the DataGridView
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
