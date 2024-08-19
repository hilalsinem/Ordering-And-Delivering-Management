namespace OrderAndDeliveryManagement
{
    partial class CreditCart
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(215, 231, 222);
            label1.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 48, 87);
            label1.Location = new Point(163, 244);
            label1.Name = "label1";
            label1.Size = new Size(287, 33);
            label1.TabIndex = 0;
            label1.Text = "Name on the card";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(215, 231, 222);
            label2.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 48, 87);
            label2.Location = new Point(176, 371);
            label2.Name = "label2";
            label2.Size = new Size(216, 33);
            label2.TabIndex = 1;
            label2.Text = "Card number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(215, 231, 222);
            label3.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 48, 87);
            label3.Location = new Point(213, 515);
            label3.Name = "label3";
            label3.Size = new Size(78, 33);
            label3.TabIndex = 2;
            label3.Text = "CVV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(502, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(502, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(506, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(502, 509);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 39);
            textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 48, 87);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 160);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(46, 37);
            label4.Name = "label4";
            label4.Size = new Size(995, 85);
            label4.TabIndex = 0;
            label4.Text = "Credit Card Information";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 48, 87);
            button1.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(286, 767);
            button1.Name = "button1";
            button1.Size = new Size(205, 52);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(15, 48, 87);
            button2.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Info;
            button2.Location = new Point(734, 767);
            button2.Name = "button2";
            button2.Size = new Size(210, 52);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CreditCart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 231, 222);
            ClientSize = new Size(1424, 989);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreditCart";
            Text = "CreditCart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}