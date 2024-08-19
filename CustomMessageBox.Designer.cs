namespace OrderAndDeliveryManagement
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            panel1 = new Panel();
            buttonOK = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            title_label = new Label();
            pictureBox1 = new PictureBox();
            message_label = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(215, 231, 222);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(buttonOK);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(message_label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 781);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(15, 48, 87);
            buttonOK.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.ForeColor = SystemColors.Info;
            buttonOK.Location = new Point(716, 633);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(150, 46);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 48, 87);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(title_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 146);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aryom_yazilim_logo;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(436, 117);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.ForeColor = SystemColors.Info;
            title_label.Location = new Point(496, 67);
            title_label.Name = "title_label";
            title_label.Size = new Size(102, 32);
            title_label.TabIndex = 0;
            title_label.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.aryom_logo;
            pictureBox1.Location = new Point(28, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // message_label
            // 
            message_label.Anchor = AnchorStyles.None;
            message_label.BackColor = Color.Transparent;
            message_label.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_label.ForeColor = SystemColors.Info;
            message_label.Location = new Point(483, 224);
            message_label.Name = "message_label";
            message_label.Size = new Size(472, 296);
            message_label.TabIndex = 0;
            message_label.Text = "label1";
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(993, 781);
            Controls.Add(panel1);
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label message_label;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label title_label;
        private Button buttonOK;
        private PictureBox pictureBox2;
    }
}