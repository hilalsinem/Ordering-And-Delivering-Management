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
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
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


        private void OrderUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
