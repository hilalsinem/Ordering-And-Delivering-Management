namespace OrderAndDeliveryManagement
{
    partial class Seller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            delete_label = new Label();
            delete_button = new Button();
            button2 = new Button();
            refresh_2 = new Button();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 48, 87);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2077, 200);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(21, 56);
            label1.Name = "label1";
            label1.Size = new Size(1576, 85);
            label1.TabIndex = 0;
            label1.Text = "Online Delivering Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 231, 222);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 1114);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(15, 48, 87);
            button4.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(231, 231, 222);
            button4.Location = new Point(36, 843);
            button4.Name = "button4";
            button4.Size = new Size(259, 77);
            button4.TabIndex = 3;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(15, 48, 87);
            button3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(231, 231, 222);
            button3.Location = new Point(36, 477);
            button3.Name = "button3";
            button3.Size = new Size(259, 141);
            button3.TabIndex = 2;
            button3.Text = "ORDERS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 48, 87);
            button1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(231, 231, 222);
            button1.Location = new Point(36, 114);
            button1.Name = "button1";
            button1.Size = new Size(259, 144);
            button1.TabIndex = 0;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 136, 145);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(331, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1746, 1114);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 231, 222);
            panel3.Controls.Add(delete_label);
            panel3.Controls.Add(delete_button);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(refresh_2);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1818, 102);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // delete_label
            // 
            delete_label.AutoSize = true;
            delete_label.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_label.ForeColor = Color.FromArgb(15, 48, 87);
            delete_label.Location = new Point(1570, 35);
            delete_label.Name = "delete_label";
            delete_label.Size = new Size(106, 32);
            delete_label.TabIndex = 6;
            delete_label.Text = "Delete";
            delete_label.Visible = false;
            // 
            // delete_button
            // 
            delete_button.FlatStyle = FlatStyle.Popup;
            delete_button.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.IndianRed;
            delete_button.Image = Properties.Resources.garbage_icon;
            delete_button.Location = new Point(1482, 17);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(82, 71);
            delete_button.TabIndex = 5;
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Visible = false;
            delete_button.Click += delete_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(15, 48, 87);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(231, 231, 222);
            button2.Location = new Point(1204, 30);
            button2.Name = "button2";
            button2.Size = new Size(185, 46);
            button2.TabIndex = 4;
            button2.Text = "Update All";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // refresh_2
            // 
            refresh_2.FlatAppearance.BorderSize = 0;
            refresh_2.FlatStyle = FlatStyle.Flat;
            refresh_2.Image = Properties.Resources.updated;
            refresh_2.Location = new Point(225, 17);
            refresh_2.Name = "refresh_2";
            refresh_2.Size = new Size(72, 68);
            refresh_2.TabIndex = 3;
            refresh_2.UseVisualStyleBackColor = true;
            refresh_2.Visible = false;
            refresh_2.Click += refresh_2_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.updated;
            button6.Location = new Point(220, 17);
            button6.Name = "button6";
            button6.Size = new Size(77, 68);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(15, 48, 87);
            button5.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Info;
            button5.Location = new Point(1204, 27);
            button5.Name = "button5";
            button5.Size = new Size(185, 49);
            button5.TabIndex = 1;
            button5.Text = "Add New";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 48, 87);
            label2.Location = new Point(30, 24);
            label2.Name = "label2";
            label2.Size = new Size(125, 43);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            label2.Visible = false;
            // 
            // Seller
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(2077, 1314);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Seller";
            Text = "Seller";
            Load += Seller_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button3;
        private Button button1;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button button5;
        private Label label2;
        private Button button6;
        private Button refresh_2;
        private Button button2;
        private Button delete_button;
        private Label delete_label;
    }
}