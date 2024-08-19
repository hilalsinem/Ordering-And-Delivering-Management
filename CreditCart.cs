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

namespace OrderAndDeliveryManagement
{
    public partial class CreditCart : Form
    {
        public CreditCart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToTheTable()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

            // ADD TO THE TABLE
            conn.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
            string username = (string)checkCmd.ExecuteScalar();
            conn.Close();

            conn.Open();
            SqlCommand cnn = new SqlCommand("Insert into CreditCardTable values (@username, @Card_Name, @Card_Number, @CVV)", conn);
            cnn.Parameters.AddWithValue("@username", username);
            cnn.Parameters.AddWithValue("@Card_Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Card_Number", textBox2.Text);
            cnn.Parameters.AddWithValue("@CVV", textBox3.Text);
            cnn.ExecuteNonQuery();
            conn.Close();
        }
        private void deleteFromTheTable()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

            conn.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
            string username = (string)checkCmd.ExecuteScalar();

            SqlCommand checkCmd2 = new SqlCommand("DELETE From CreditCardTable WHERE username = @username", conn);
            checkCmd2.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = checkCmd2.ExecuteReader();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addToTheTable();
            this.Close();
        }
    }
}
