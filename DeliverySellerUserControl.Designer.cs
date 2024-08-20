namespace OrderAndDeliveryManagement
{
    partial class DeliverySellerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            User_label = new Label();
            id_label = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 279F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 239F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 6, 0);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 3, 0);
            tableLayoutPanel1.Controls.Add(User_label, 2, 0);
            tableLayoutPanel1.Controls.Add(id_label, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 5, 0);
            tableLayoutPanel1.Controls.Add(radioButton1, 7, 0);
            tableLayoutPanel1.Location = new Point(16, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1653, 126);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tracking_icon;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 120);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(15, 48, 87);
            button1.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(231, 231, 222);
            button1.Location = new Point(1443, 40);
            button1.Name = "button1";
            button1.Size = new Size(132, 46);
            button1.TabIndex = 8;
            button1.Text = "Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(231, 231, 222);
            label3.Location = new Point(977, 44);
            label3.Name = "label3";
            label3.Size = new Size(101, 38);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(231, 231, 222);
            label1.Location = new Point(663, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 38);
            label1.TabIndex = 7;
            label1.Text = "Date";
            // 
            // User_label
            // 
            User_label.Anchor = AnchorStyles.None;
            User_label.AutoSize = true;
            User_label.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_label.ForeColor = Color.FromArgb(231, 231, 222);
            User_label.Location = new Point(372, 44);
            User_label.Name = "User_label";
            User_label.Size = new Size(94, 38);
            User_label.TabIndex = 9;
            User_label.Text = "User";
            // 
            // id_label
            // 
            id_label.Anchor = AnchorStyles.None;
            id_label.AutoSize = true;
            id_label.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id_label.ForeColor = Color.FromArgb(231, 231, 222);
            id_label.Location = new Point(148, 44);
            id_label.Name = "id_label";
            id_label.Size = new Size(119, 38);
            id_label.TabIndex = 1;
            id_label.Text = "label1";
            id_label.Click += id_label_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.FromArgb(15, 48, 87);
            comboBox1.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(231, 231, 222);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Placed", "Processing", "Shipped", "Delivered" });
            comboBox1.Location = new Point(1206, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 40);
            comboBox1.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1606, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(27, 26);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 48, 87);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(19, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1647, 37);
            panel1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(369, 5);
            label7.Name = "label7";
            label7.Size = new Size(75, 32);
            label7.TabIndex = 4;
            label7.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(1252, 5);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 3;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(974, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 32);
            label5.TabIndex = 2;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(679, 5);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 1;
            label4.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(194, 5);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // DeliverySellerUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "DeliverySellerUserControl";
            Size = new Size(1669, 187);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Label id_label;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label User_label;
        private Label label7;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
    }
}
