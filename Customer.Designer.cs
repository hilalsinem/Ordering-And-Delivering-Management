namespace OrderAndDeliveryManagement
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            logout_button = new Button();
            cart_button = new Button();
            orders_button = new Button();
            menu_button = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            refresh_order_button = new Button();
            refresh_button = new Button();
            order_label = new Label();
            order_button = new Button();
            button7 = new Button();
            delete_label = new Label();
            delete_button = new Button();
            button6 = new Button();
            title_label = new Label();
            payment_panel = new Panel();
            confirm_button = new Button();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            payment_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.ForeColor = Color.FromArgb(231, 231, 222);
            label1.Location = new Point(32, 56);
            label1.Name = "label1";
            label1.Size = new Size(1519, 85);
            label1.TabIndex = 0;
            label1.Text = "Online Ordering Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 231, 222);
            panel2.Controls.Add(logout_button);
            panel2.Controls.Add(cart_button);
            panel2.Controls.Add(orders_button);
            panel2.Controls.Add(menu_button);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 1114);
            panel2.TabIndex = 1;
            // 
            // logout_button
            // 
            logout_button.BackColor = Color.FromArgb(15, 48, 87);
            logout_button.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_button.ForeColor = Color.FromArgb(231, 231, 222);
            logout_button.Location = new Point(32, 911);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(259, 84);
            logout_button.TabIndex = 3;
            logout_button.Text = "LOG OUT";
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += button4_Click;
            // 
            // cart_button
            // 
            cart_button.BackColor = Color.FromArgb(15, 48, 87);
            cart_button.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cart_button.ForeColor = Color.FromArgb(231, 231, 222);
            cart_button.Location = new Point(32, 649);
            cart_button.Name = "cart_button";
            cart_button.Size = new Size(259, 134);
            cart_button.TabIndex = 2;
            cart_button.Text = "MY CART";
            cart_button.UseVisualStyleBackColor = false;
            cart_button.Click += button3_Click;
            // 
            // orders_button
            // 
            orders_button.BackColor = Color.FromArgb(15, 48, 87);
            orders_button.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orders_button.ForeColor = Color.FromArgb(231, 231, 222);
            orders_button.Location = new Point(32, 371);
            orders_button.Name = "orders_button";
            orders_button.Size = new Size(259, 134);
            orders_button.TabIndex = 1;
            orders_button.Text = "MY ORDERS";
            orders_button.UseVisualStyleBackColor = false;
            orders_button.Click += button2_Click;
            // 
            // menu_button
            // 
            menu_button.BackColor = Color.FromArgb(15, 48, 87);
            menu_button.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_button.ForeColor = Color.FromArgb(231, 231, 222);
            menu_button.Location = new Point(32, 104);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(259, 134);
            menu_button.TabIndex = 0;
            menu_button.Text = "MENU";
            menu_button.UseVisualStyleBackColor = false;
            menu_button.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 136, 145);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(payment_panel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(325, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1752, 1114);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 231, 222);
            panel3.Controls.Add(refresh_order_button);
            panel3.Controls.Add(refresh_button);
            panel3.Controls.Add(order_label);
            panel3.Controls.Add(order_button);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(delete_label);
            panel3.Controls.Add(delete_button);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(title_label);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(2130, 105);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // refresh_order_button
            // 
            refresh_order_button.FlatAppearance.BorderSize = 0;
            refresh_order_button.FlatStyle = FlatStyle.Popup;
            refresh_order_button.Image = Properties.Resources.updated;
            refresh_order_button.Location = new Point(263, 13);
            refresh_order_button.Name = "refresh_order_button";
            refresh_order_button.Size = new Size(99, 89);
            refresh_order_button.TabIndex = 10;
            refresh_order_button.UseVisualStyleBackColor = true;
            refresh_order_button.Visible = false;
            refresh_order_button.Click += refresh_order_button_Click;
            // 
            // refresh_button
            // 
            refresh_button.FlatAppearance.BorderSize = 0;
            refresh_button.FlatStyle = FlatStyle.Popup;
            refresh_button.Image = Properties.Resources.updated;
            refresh_button.Location = new Point(263, 16);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(92, 86);
            refresh_button.TabIndex = 9;
            refresh_button.UseVisualStyleBackColor = true;
            refresh_button.Visible = false;
            // 
            // order_label
            // 
            order_label.AutoSize = true;
            order_label.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_label.ForeColor = Color.FromArgb(15, 48, 87);
            order_label.Location = new Point(1558, 40);
            order_label.Name = "order_label";
            order_label.Size = new Size(98, 32);
            order_label.TabIndex = 8;
            order_label.Text = "Order";
            order_label.Visible = false;
            // 
            // order_button
            // 
            order_button.FlatStyle = FlatStyle.Popup;
            order_button.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_button.ForeColor = Color.IndianRed;
            order_button.Image = (Image)resources.GetObject("order_button.Image");
            order_button.Location = new Point(1470, 21);
            order_button.Name = "order_button";
            order_button.Size = new Size(82, 71);
            order_button.TabIndex = 7;
            order_button.UseVisualStyleBackColor = true;
            order_button.Visible = false;
            order_button.Click += order_button_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Image = Properties.Resources.updated;
            button7.Location = new Point(263, 16);
            button7.Name = "button7";
            button7.Size = new Size(99, 82);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // delete_label
            // 
            delete_label.AutoSize = true;
            delete_label.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_label.ForeColor = Color.FromArgb(15, 48, 87);
            delete_label.Location = new Point(1312, 42);
            delete_label.Name = "delete_label";
            delete_label.Size = new Size(106, 32);
            delete_label.TabIndex = 5;
            delete_label.Text = "Delete";
            delete_label.Visible = false;
            // 
            // delete_button
            // 
            delete_button.FlatStyle = FlatStyle.Popup;
            delete_button.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.IndianRed;
            delete_button.Image = Properties.Resources.garbage_icon;
            delete_button.Location = new Point(1224, 19);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(82, 71);
            delete_button.TabIndex = 4;
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Visible = false;
            delete_button.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(263, 16);
            button6.Name = "button6";
            button6.Size = new Size(89, 74);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.BackColor = Color.FromArgb(215, 231, 222);
            title_label.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.ForeColor = Color.FromArgb(15, 48, 87);
            title_label.Location = new Point(24, 31);
            title_label.Name = "title_label";
            title_label.Size = new Size(125, 43);
            title_label.TabIndex = 0;
            title_label.Text = "Menu";
            title_label.Visible = false;
            // 
            // payment_panel
            // 
            payment_panel.Controls.Add(pictureBox1);
            payment_panel.Controls.Add(confirm_button);
            payment_panel.Controls.Add(label3);
            payment_panel.Controls.Add(radioButton2);
            payment_panel.Controls.Add(radioButton1);
            payment_panel.Location = new Point(3, 114);
            payment_panel.Name = "payment_panel";
            payment_panel.Size = new Size(1718, 184);
            payment_panel.TabIndex = 1;
            payment_panel.Visible = false;
            // 
            // confirm_button
            // 
            confirm_button.FlatStyle = FlatStyle.Popup;
            confirm_button.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_button.ForeColor = Color.FromArgb(231, 231, 222);
            confirm_button.Location = new Point(1318, 78);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(150, 46);
            confirm_button.TabIndex = 4;
            confirm_button.Text = "Confirm";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Visible = false;
            confirm_button.Click += confirm_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(231, 231, 222);
            label3.Location = new Point(378, 78);
            label3.Name = "label3";
            label3.Size = new Size(119, 38);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(231, 231, 222);
            radioButton2.Location = new Point(830, 127);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cash";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            radioButton2.Click += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(231, 231, 222);
            radioButton1.Location = new Point(830, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(212, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Credit Card";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            radioButton1.Click += radioButton1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cashless_payment;
            pictureBox1.Location = new Point(140, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 75);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(2077, 1314);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            payment_panel.ResumeLayout(false);
            payment_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button menu_button;
        private Button cart_button;
        private Button orders_button;
        private Label label1;
        private Button logout_button;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label title_label;
        private Button button6;
        private Button delete_button;
        private Label delete_label;
        private Button button7;
        private Button order_button;
        private Label order_label;
        private Button refresh_button;
        private Panel payment_panel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button confirm_button;
        private Label label3;
        private Button refresh_order_button;
        private PictureBox pictureBox1;
    }
}