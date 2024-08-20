namespace OrderAndDeliveryManagement
{
    partial class SellerDetails
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
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listView1 = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 48, 87);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1453, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(63, 25);
            label1.Name = "label1";
            label1.Size = new Size(275, 78);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(231, 231, 222);
            label2.Location = new Point(146, 284);
            label2.Name = "label2";
            label2.Size = new Size(192, 43);
            label2.TabIndex = 1;
            label2.Text = "Products";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(205, 239, 255);
            label6.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 48, 66);
            label6.Location = new Point(641, 525);
            label6.Name = "label6";
            label6.Size = new Size(572, 245);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(231, 231, 222);
            label3.Location = new Point(146, 626);
            label3.Name = "label3";
            label3.Size = new Size(280, 43);
            label3.TabIndex = 7;
            label3.Text = "User Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(231, 231, 222);
            label4.Location = new Point(146, 873);
            label4.Name = "label4";
            label4.Size = new Size(345, 43);
            label4.TabIndex = 8;
            label4.Text = "Payment Method";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(205, 239, 255);
            label5.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(15, 48, 66);
            label5.Location = new Point(851, 873);
            label5.Name = "label5";
            label5.Size = new Size(116, 37);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(205, 239, 255);
            listView1.Font = new Font("Lucida Fax", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.FromArgb(15, 48, 66);
            listView1.Location = new Point(541, 182);
            listView1.Name = "listView1";
            listView1.Size = new Size(789, 284);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // SellerDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 136, 145);
            ClientSize = new Size(1453, 1030);
            Controls.Add(listView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SellerDetails";
            Text = "SellerDetails";
            Load += SellerDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listView1;
    }
}