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
    public partial class DeliveryUserControl : UserControl
    {
        public DeliveryUserControl()
        {
            InitializeComponent();
        }

        public int Id
        {
            get => int.Parse(id.Text);
            set => id.Text = value.ToString();
        }

        public string OrderDate
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public decimal TotalPrice
        {
            get => decimal.Parse(label3.Text);
            set => label3.Text = value.ToString();
        }

        public string Status
        {
            get => status_label.Text;
            set => status_label.Text = value;
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Id; // Retrieve the selected OrderId based on your application logic

            // Create an instance of SellerDetails form
            SellerDetails detailsForm = new SellerDetails(selectedOrderId);

            // Load the order details for the selected order ID
            detailsForm.LoadOrderDetails();

            // Show the SellerDetails form
            detailsForm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
