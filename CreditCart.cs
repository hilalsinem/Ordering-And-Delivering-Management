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
            Image errorIcon = Properties.Resources.error_icon;
            try
            {
                long cardNumber;
                int CVV;

                // Validate if the card number is numeric and 16 digits
                if (!long.TryParse(textBox2.Text, out cardNumber))
                {
                    CustomMessageBox.Show("ERROR", "Card Number must consist of numbers.", errorIcon);
                    return;
                }
                if(textBox2.Text.Length != 16)
                {
                    CustomMessageBox.Show("ERROR", "Card Number must be exactly 16 digits.", errorIcon);
                    return;
                }

                if (!int.TryParse(textBox3.Text, out CVV) || textBox3.Text.Length != 3)
                {
                    MessageBox.Show("CVV must be exactly 3 digits.", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");

                // ADD TO THE TABLE
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT username FROM LoginTable", conn);
                string username = (string)checkCmd.ExecuteScalar();
                conn.Close();

                conn.Open();
                SqlCommand cnn = new SqlCommand("Insert into CreditCardTable values (@username, @CardName, @CardNumber, @CVV)", conn);
                cnn.Parameters.AddWithValue("@username", username);
                cnn.Parameters.AddWithValue("@CardName", textBox1.Text);
                cnn.Parameters.AddWithValue("@CardNumber", cardNumber);
                cnn.Parameters.AddWithValue("@CVV", CVV);
                cnn.ExecuteNonQuery();
                conn.Close();
            }
            catch (FormatException ex)
            {
                
                CustomMessageBox.Show("ERROR", "Invalid input format.\nPlease make sure you entered the correct data types.",errorIcon);
            }
            catch (SqlException ex)
            {
                
                CustomMessageBox.Show(" SQL ERROR", "A database error occurred", errorIcon);
                
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("ERROR: ", ex.Message, errorIcon);
            }
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
