namespace WinFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Кухня = new LinkLabel();
            Ванная = new LinkLabel();
            Спальня = new LinkLabel();
            Гостиная = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("STXihei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 28);
            label1.Name = "label1";
            label1.Size = new Size(410, 43);
            label1.TabIndex = 0;
            label1.Text = "Выберете комнату";
            label1.Click += label1_Click;
            // 
            // Кухня
            // 
            Кухня.ActiveLinkColor = SystemColors.MenuHighlight;
            Кухня.AutoSize = true;
            Кухня.BackColor = Color.Transparent;
            Кухня.Font = new Font("Century Schoolbook", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            Кухня.ForeColor = Color.Coral;
            Кухня.LinkColor = Color.Purple;
            Кухня.Location = new Point(45, 167);
            Кухня.Name = "Кухня";
            Кухня.Size = new Size(163, 50);
            Кухня.TabIndex = 1;
            Кухня.TabStop = true;
            Кухня.Text = "Кухня";
            Кухня.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Ванная
            // 
            Ванная.ActiveLinkColor = SystemColors.MenuHighlight;
            Ванная.AutoSize = true;
            Ванная.BackColor = Color.Transparent;
            Ванная.Font = new Font("Century Schoolbook", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            Ванная.ForeColor = Color.Coral;
            Ванная.LinkColor = Color.Purple;
            Ванная.Location = new Point(29, 162);
            Ванная.Name = "Ванная";
            Ванная.Size = new Size(191, 50);
            Ванная.TabIndex = 2;
            Ванная.TabStop = true;
            Ванная.Text = "Ванная";
            Ванная.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Спальня
            // 
            Спальня.ActiveLinkColor = SystemColors.MenuHighlight;
            Спальня.AutoSize = true;
            Спальня.BackColor = Color.Transparent;
            Спальня.Font = new Font("Century Schoolbook", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            Спальня.ForeColor = Color.Coral;
            Спальня.LinkColor = Color.Purple;
            Спальня.Location = new Point(15, 169);
            Спальня.Name = "Спальня";
            Спальня.Size = new Size(216, 50);
            Спальня.TabIndex = 3;
            Спальня.TabStop = true;
            Спальня.Text = "Спальня";
            Спальня.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Гостиная
            // 
            Гостиная.ActiveLinkColor = SystemColors.MenuHighlight;
            Гостиная.AutoSize = true;
            Гостиная.BackColor = Color.Transparent;
            Гостиная.Font = new Font("Century Schoolbook", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            Гостиная.ForeColor = Color.Coral;
            Гостиная.LinkColor = Color.Purple;
            Гостиная.Location = new Point(3, 169);
            Гостиная.Name = "Гостиная";
            Гостиная.Size = new Size(233, 50);
            Гостиная.TabIndex = 4;
            Гостиная.TabStop = true;
            Гостиная.Text = "Гостиная";
            Гостиная.TextAlign = ContentAlignment.TopCenter;
            Гостиная.LinkClicked += Гостиная_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Кухня);
            panel1.Location = new Point(83, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 230);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Ванная);
            panel2.Location = new Point(425, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 230);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(Спальня);
            panel3.Location = new Point(83, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 230);
            panel3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(Гостиная);
            panel4.Location = new Point(425, 386);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 230);
            panel4.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(42, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 143);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(753, 681);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Умный дом";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private LinkLabel Кухня;
        private LinkLabel Ванная;
        private LinkLabel Спальня;
        private LinkLabel Гостиная;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}