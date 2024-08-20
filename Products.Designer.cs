namespace OrderAndDeliveryManagement
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 48, 87);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(0, 88, 122);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1758, 200);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(82, 49);
            label4.Name = "label4";
            label4.Size = new Size(500, 109);
            label4.TabIndex = 0;
            label4.Text = "Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 136, 145);
            label1.Font = new Font("Lucida Console", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(344, 264);
            label1.Name = "label1";
            label1.Size = new Size(293, 37);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 136, 145);
            label2.Font = new Font("Lucida Console", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(420, 374);
            label2.Name = "label2";
            label2.Size = new Size(132, 37);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 136, 145);
            label3.Font = new Font("Lucida Console", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(353, 653);
            label3.Name = "label3";
            label3.Size = new Size(270, 37);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(215, 231, 222);
            textBox1.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(15, 48, 66);
            textBox1.Location = new Point(798, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 42);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(215, 231, 222);
            textBox2.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(15, 48, 66);
            textBox2.Location = new Point(873, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 42);
            textBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(215, 231, 222);
            richTextBox1.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(15, 48, 66);
            richTextBox1.Location = new Point(770, 591);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(514, 174);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 48, 87);
            button1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(798, 847);
            button1.Name = "button1";
            button1.Size = new Size(174, 56);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(15, 48, 87);
            button3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Info;
            button3.Location = new Point(1085, 847);
            button3.Name = "button3";
            button3.Size = new Size(170, 56);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(215, 231, 222);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(215, 231, 222);
            dataGridViewCellStyle3.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 48, 87);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(215, 231, 222);
            dataGridViewCellStyle4.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(15, 48, 87);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 925);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1758, 300);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 136, 145);
            label5.Font = new Font("Lucida Console", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(440, 478);
            label5.Name = "label5";
            label5.Size = new Size(86, 37);
            label5.TabIndex = 13;
            label5.Text = "Per";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(215, 231, 222);
            textBox3.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(15, 48, 66);
            textBox3.Location = new Point(873, 477);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 42);
            textBox3.TabIndex = 14;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 136, 145);
            ClientSize = new Size(1758, 1225);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox3;
    }
}