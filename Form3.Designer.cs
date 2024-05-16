namespace WinFormsApp2
{
    partial class Гостиная
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Гостиная));
            panel1 = new Panel();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            button_telev = new Button();
            label5 = new Label();
            panel5 = new Panel();
            button_robot = new Button();
            label4 = new Label();
            button6_temp = new Button();
            label5_temp = new Label();
            label4_temp = new Label();
            textBox_temp = new TextBox();
            panel4 = new Panel();
            button5 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 510);
            panel1.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(3, 458);
            button6.Name = "button6";
            button6.Size = new Size(119, 49);
            button6.TabIndex = 4;
            button6.Text = "Назад";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(17, 321);
            button3.Name = "button3";
            button3.Size = new Size(93, 85);
            button3.TabIndex = 2;
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(17, 184);
            button2.Name = "button2";
            button2.Size = new Size(93, 85);
            button2.TabIndex = 1;
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(17, 47);
            button1.Name = "button1";
            button1.Size = new Size(93, 85);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(button6_temp);
            panel2.Controls.Add(label5_temp);
            panel2.Controls.Add(label4_temp);
            panel2.Controls.Add(textBox_temp);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Location = new Point(147, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 511);
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSkyBlue;
            panel6.Controls.Add(button_telev);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(584, 280);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 172);
            panel6.TabIndex = 12;
            panel6.Visible = false;
            // 
            // button_telev
            // 
            button_telev.BackColor = Color.White;
            button_telev.BackgroundImageLayout = ImageLayout.Zoom;
            button_telev.ForeColor = SystemColors.ActiveCaptionText;
            button_telev.Image = (Image)resources.GetObject("button_telev.Image");
            button_telev.Location = new Point(45, 51);
            button_telev.Name = "button_telev";
            button_telev.Size = new Size(142, 96);
            button_telev.TabIndex = 1;
            button_telev.Text = "Включить";
            button_telev.TextAlign = ContentAlignment.BottomCenter;
            button_telev.UseVisualStyleBackColor = false;
            button_telev.Click += button_telev_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 15);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 0;
            label5.Text = "Телевизор";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSkyBlue;
            panel5.Controls.Add(button_robot);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(584, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 172);
            panel5.TabIndex = 11;
            panel5.Visible = false;
            panel5.Paint += panel5_Paint;
            // 
            // button_robot
            // 
            button_robot.BackColor = Color.White;
            button_robot.BackgroundImageLayout = ImageLayout.Zoom;
            button_robot.ForeColor = SystemColors.ActiveCaptionText;
            button_robot.Image = (Image)resources.GetObject("button_robot.Image");
            button_robot.Location = new Point(45, 51);
            button_robot.Name = "button_robot";
            button_robot.Size = new Size(142, 96);
            button_robot.TabIndex = 1;
            button_robot.Text = "Включить";
            button_robot.TextAlign = ContentAlignment.BottomCenter;
            button_robot.UseVisualStyleBackColor = false;
            button_robot.Click += button_robot_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 18);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 0;
            label4.Text = "Робот-пылесос";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6_temp
            // 
            button6_temp.ImeMode = ImeMode.NoControl;
            button6_temp.Location = new Point(634, 295);
            button6_temp.Name = "button6_temp";
            button6_temp.Size = new Size(142, 38);
            button6_temp.TabIndex = 10;
            button6_temp.Text = "Применить";
            button6_temp.UseVisualStyleBackColor = true;
            button6_temp.Visible = false;
            button6_temp.Click += button6_temp_Click;
            // 
            // label5_temp
            // 
            label5_temp.AutoSize = true;
            label5_temp.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5_temp.ImeMode = ImeMode.NoControl;
            label5_temp.Location = new Point(586, 136);
            label5_temp.Name = "label5_temp";
            label5_temp.Size = new Size(235, 21);
            label5_temp.TabIndex = 8;
            label5_temp.Text = "Изменение температуры";
            label5_temp.Visible = false;
            // 
            // label4_temp
            // 
            label4_temp.AutoSize = true;
            label4_temp.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4_temp.Location = new Point(568, 23);
            label4_temp.Name = "label4_temp";
            label4_temp.Size = new Size(47, 40);
            label4_temp.TabIndex = 7;
            label4_temp.Text = "℃";
            label4_temp.Visible = false;
            // 
            // textBox_temp
            // 
            textBox_temp.BackColor = Color.AliceBlue;
            textBox_temp.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_temp.Location = new Point(477, 20);
            textBox_temp.Name = "textBox_temp";
            textBox_temp.ReadOnly = true;
            textBox_temp.Size = new Size(85, 48);
            textBox_temp.TabIndex = 6;
            textBox_temp.Text = "20";
            textBox_temp.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(578, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 172);
            panel4.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(41, 59);
            button5.Name = "button5";
            button5.Size = new Size(142, 96);
            button5.TabIndex = 2;
            button5.Text = "Включить";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 15);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 0;
            label3.Text = "Подсветка";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(578, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 172);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(41, 61);
            button4.Name = "button4";
            button4.Size = new Size(142, 96);
            button4.TabIndex = 1;
            button4.Text = "Включить";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 21);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 0;
            label2.Text = "Основной свет";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(241, 43);
            label1.TabIndex = 1;
            label1.Text = "Освещение";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(638, 227);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(113, 27);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.Visible = false;
            // 
            // Гостиная
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 535);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Гостиная";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гостиная";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel6;
        private Button button_telev;
        private Label label5;
        private Panel panel5;
        private Button button_robot;
        private Label label4;
        private Button button6_temp;
        private Label label5_temp;
        private Label label4_temp;
        private TextBox textBox_temp;
        private Panel panel4;
        private Button button5;
        private Label label3;
        private Panel panel3;
        private Button button4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private Button button6;
    }
}