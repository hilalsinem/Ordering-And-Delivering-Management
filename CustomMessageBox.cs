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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Show(string title, string message, Image icon)
        {
            using (CustomMessageBox messageBox = new CustomMessageBox())
            {
                messageBox.title_label.Text = title;
                messageBox.message_label.Text = message;
                messageBox.SetIcon(icon);
                messageBox.ShowDialog();
            }
        }
        private void SetIcon(Image icon)
        {
            pictureBox1.Image = icon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
