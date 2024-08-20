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
            panel1 = new Panel();
            title_label = new Label();
            pictureBox2 = new PictureBox();
            message_label = new Label();
            buttonOK = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 136, 145);
            panel1.Controls.Add(title_label);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 115);
            panel1.TabIndex = 0;
            // 
            // title_label
            // 
            title_label.BackColor = Color.FromArgb(0, 136, 145);
            title_label.Font = new Font("Lucida Fax", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_label.ForeColor = SystemColors.Info;
            title_label.Location = new Point(130, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(875, 100);
            title_label.TabIndex = 0;
            title_label.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aryom_logo;
            pictureBox2.Location = new Point(21, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // message_label
            // 
            message_label.BackColor = Color.Transparent;
            message_label.Font = new Font("Lucida Fax", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_label.ForeColor = Color.FromArgb(15, 48, 87);
            message_label.Location = new Point(488, 368);
            message_label.Name = "message_label";
            message_label.Size = new Size(454, 191);
            message_label.TabIndex = 1;
            message_label.Text = "label1";
            message_label.Click += message_label_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(0, 136, 145);
            buttonOK.Font = new Font("Lucida Fax", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.ForeColor = SystemColors.Info;
            buttonOK.Location = new Point(756, 653);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(160, 52);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.help_icon;
            pictureBox1.Location = new Point(58, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 231, 222);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 773);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK);
            Controls.Add(message_label);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title_label;
        private Label message_label;
        private PictureBox pictureBox2;
        private Button buttonOK;
        private PictureBox pictureBox1;
    }
}