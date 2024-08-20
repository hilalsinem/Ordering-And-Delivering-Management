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
    public partial class MenuSellerUserControl : UserControl
    {
        public MenuSellerUserControl()
        {
            InitializeComponent();
        }

        private void MenuSellerUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        public string per
        {
            get => label8.Text;
            set => label8.Text = value;
        }


        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
    }
}
