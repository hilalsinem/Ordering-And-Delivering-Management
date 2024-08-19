using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderAndDeliveryManagement
{
    public partial class CartUserControl : UserControl
    {
        public CartUserControl()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True");


        public string username
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public string ProductName
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

        public int Quantity
        {
            get => int.Parse(label4.Text);
            set => label4.Text = value.ToString();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string productName = label2.Text;

            if (radioButton1.Checked)
            {

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ToBeDeletedTable (Name) VALUES (@Name)", con);
                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BKKQ3CK\SQLSERVER;Initial Catalog=dbonline;User ID=sa;Password=Sinem*2002;Trust Server Certificate=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ToBeDeletedTable WHERE Name = @Name", con);
                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        private void CartUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
