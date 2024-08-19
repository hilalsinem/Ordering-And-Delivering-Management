using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OrderAndDeliveryManagement
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            textBox1.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textBox2.KeyDown += new KeyEventHandler(textBox_KeyDown);
            this.FormClosing += Login_FormClosing;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            try
            {
                String admin_query = "SELECT * FROM Login_Admin WHERE username = @username AND password = @password";
                SqlDataAdapter sda1 = new SqlDataAdapter(admin_query, con);
                sda1.SelectCommand.Parameters.AddWithValue("@username", username);
                sda1.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dataTable1 = new DataTable();
                sda1.Fill(dataTable1);

                if (dataTable1.Rows.Count > 0)
                {

                    // Navigate to Seller form
                    Seller seller = new Seller();
                    seller.Show();
                    this.Hide();
                }
                else
                {
                    String guest_query = "SELECT * FROM Login_Guest WHERE username = @username AND password = @password";
                    SqlDataAdapter sda2 = new SqlDataAdapter(guest_query, con);
                    sda2.SelectCommand.Parameters.AddWithValue("@username", username);
                    sda2.SelectCommand.Parameters.AddWithValue("@password", password);

                    DataTable dataTable2 = new DataTable();
                    sda2.Fill(dataTable2);

                    if (dataTable2.Rows.Count > 0)
                    {
                        con.Open();
                        SqlCommand cnn = new SqlCommand("Insert into LoginTable values (@username)", con);
                        cnn.Parameters.AddWithValue("@username", username);

                        cnn.ExecuteNonQuery();
                        con.Close();
                        // Pass the username to the Customer form
                        Customer customer = new Customer();
                        customer.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the ding sound on Enter key press
                button1_Click(sender, e); // Trigger the sign-in process
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
