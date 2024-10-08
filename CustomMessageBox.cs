﻿using System;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void message_label_Click(object sender, EventArgs e)
        {

        }
    }
}
