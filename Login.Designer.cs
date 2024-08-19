namespace OrderAndDeliveryManagement
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BackgroundImage = Properties.Resources.aryom_yazilim_logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1549, 333);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 583);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 101);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(231, 231, 222);
            label2.Location = new Point(498, 543);
            label2.Name = "label2";
            label2.Size = new Size(230, 43);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(231, 231, 222);
            label3.Location = new Point(498, 671);
            label3.Name = "label3";
            label3.Size = new Size(204, 43);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 136, 145);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(231, 231, 222);
            textBox1.Location = new Point(775, 553);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 38);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 136, 145);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(231, 231, 222);
            textBox2.Location = new Point(775, 680);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(423, 38);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 48, 87);
            button1.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(231, 231, 222);
            button1.Location = new Point(536, 885);
            button1.Name = "button1";
            button1.Size = new Size(623, 51);
            button1.TabIndex = 5;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 231, 222);
            panel2.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(498, 589);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 3);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(231, 231, 222);
            panel3.Location = new Point(498, 720);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 3);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(15, 48, 87);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(-9, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(1558, 56);
            panel4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(231, 231, 222);
            label1.Location = new Point(35, 16);
            label1.Name = "label1";
            label1.Size = new Size(653, 33);
            label1.TabIndex = 0;
            label1.Text = "Online Ordering and Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 136, 145);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1549, 1122);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login Page";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
    }
}
