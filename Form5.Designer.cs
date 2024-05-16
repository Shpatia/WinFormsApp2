namespace WinFormsApp2
{
    partial class Ванна
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ванна));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            button_voda = new Button();
            label5 = new Label();
            panel5 = new Panel();
            button_roz = new Button();
            label4 = new Label();
            button6_temp = new Button();
            label5_temp = new Label();
            label4_temp = new Label();
            textBox_temp = new TextBox();
            panel4 = new Panel();
            button5 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            button6 = new Button();
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
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 510);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(5, 457);
            button4.Name = "button4";
            button4.Size = new Size(119, 49);
            button4.TabIndex = 3;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(20, 323);
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
            button2.Location = new Point(20, 179);
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
            button1.Location = new Point(20, 35);
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
            panel2.Location = new Point(137, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 511);
            panel2.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSkyBlue;
            panel6.Controls.Add(button_voda);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(611, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 172);
            panel6.TabIndex = 12;
            panel6.Visible = false;
            // 
            // button_voda
            // 
            button_voda.BackColor = Color.White;
            button_voda.BackgroundImageLayout = ImageLayout.Zoom;
            button_voda.ForeColor = SystemColors.ActiveCaptionText;
            button_voda.Image = (Image)resources.GetObject("button_voda.Image");
            button_voda.Location = new Point(45, 51);
            button_voda.Name = "button_voda";
            button_voda.Size = new Size(142, 96);
            button_voda.TabIndex = 1;
            button_voda.Text = "Включить";
            button_voda.TextAlign = ContentAlignment.BottomCenter;
            button_voda.UseVisualStyleBackColor = false;
            button_voda.Click += button_voda_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(84, 18);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 0;
            label5.Text = "Вода";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSkyBlue;
            panel5.Controls.Add(button_roz);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(611, 288);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 172);
            panel5.TabIndex = 11;
            panel5.Visible = false;
            // 
            // button_roz
            // 
            button_roz.BackColor = Color.White;
            button_roz.BackgroundImageLayout = ImageLayout.Zoom;
            button_roz.ForeColor = SystemColors.ActiveCaptionText;
            button_roz.Image = (Image)resources.GetObject("button_roz.Image");
            button_roz.Location = new Point(45, 44);
            button_roz.Name = "button_roz";
            button_roz.Size = new Size(142, 109);
            button_roz.TabIndex = 1;
            button_roz.Text = "Включить";
            button_roz.TextAlign = ContentAlignment.BottomCenter;
            button_roz.UseVisualStyleBackColor = false;
            button_roz.Click += button_roz_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 18);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 0;
            label4.Text = "Розетки";
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
            panel4.Location = new Point(601, 320);
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
            button5.Click += button5_Click;
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
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(601, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 172);
            panel3.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(41, 61);
            button6.Name = "button6";
            button6.Size = new Size(142, 96);
            button6.TabIndex = 1;
            button6.Text = "Включить";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
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
            pictureBox1.Location = new Point(0, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 425);
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
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Ванна
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ванна";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ванная";
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel6;
        private Button button_voda;
        private Label label5;
        private Panel panel5;
        private Button button_roz;
        private Label label4;
        private Button button6_temp;
        private Label label5_temp;
        private Label label4_temp;
        private TextBox textBox_temp;
        private Panel panel4;
        private Button button5;
        private Label label3;
        private Panel panel3;
        private Button button6;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
    }
}