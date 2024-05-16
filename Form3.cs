using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Гостиная : Form
    {
        private const string ConnectionString = "Data Source=KATYA\\SQLEXPRESS;Initial Catalog=Devices;Integrated Security=True";
        public Гостиная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Освещение";
            button1.BackColor = Color.White;
            button3.BackColor = Color.LightSkyBlue;
            button2.BackColor = Color.LightSkyBlue;
            panel3.Visible = true;
            panel4.Visible = true;
            textBox_temp.Visible = false;
            maskedTextBox1.Visible = false;
            label4_temp.Visible = false;
            label5_temp.Visible = false;
            button6_temp.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
            button3.BackColor = Color.LightSkyBlue;
            label1.Text = "Температура";
            button2.BackColor = Color.White;
            panel3.Visible = false;
            panel4.Visible = false;
            textBox_temp.Visible = true;
            maskedTextBox1.Visible = true;
            label4_temp.Visible = true;
            label5_temp.Visible = true;
            button6_temp.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSkyBlue;
            button1.BackColor = Color.LightSkyBlue;
            label1.Text = "Электроприборы";
            button3.BackColor = Color.White;
            panel3.Visible = false;
            panel4.Visible = false;
            textBox_temp.Visible = false;
            maskedTextBox1.Visible = false;
            label4_temp.Visible = false;
            label5_temp.Visible = false;
            button6_temp.Visible = false;
            panel5.Visible = true;
            panel6.Visible = true;
        }

        private void button_robot_Click(object sender, EventArgs e)
        {
            int id = 6;
            if (button_robot.Text == "Включить")
            {
                button_robot.Text = "Выключить";
                UpdateDeviceStateInDatabase(id, "Вкл");
            }
            else
            {
                button_robot.Text = "Включить";
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }

        private void button_telev_Click(object sender, EventArgs e)
        {
            int id = 7;
            if (button_telev.Text == "Включить")
            {
                button_telev.Text = "Выключить";
                UpdateDeviceStateInDatabase(id, "Вкл");
            }
            else
            {
                button_telev.Text = "Включить";
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int id = 8;
            if (button5.Text == "Включить")
            {
                button5.Text = "Выключить";
                Bitmap disable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lamp_on.png");
                button5.Image = disable;
                UpdateDeviceStateInDatabase(id, "Вкл");

            }
            else
            {
                button5.Text = "Включить";
                Bitmap enable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lamp_off.png");
                button5.Image = enable;
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int id = 9;
            if (button4.Text == "Включить")
            {
                button4.Text = "Выключить";
                Bitmap disable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lantern_on.png");
                button4.Image = disable;
                UpdateDeviceStateInDatabase(id, "Вкл");

            }
            else
            {
                button4.Text = "Включить";
                Bitmap enable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lantern_off.png");
                button4.Image = enable;
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }

        private void button6_temp_Click(object sender, EventArgs e)
        {
            int id = 10;
            int num1;
            if (int.TryParse(maskedTextBox1.Text, out num1))
            {
                if (num1 >= 12 && num1 <= 30)
                {
                    textBox_temp.Text = num1.ToString();
                    UpdateDeviceTemp(id, num1);
                }
                else
                {
                    MessageBox.Show("Введите корректное число, в диапозоне от 12 до 30");
                }

            }
            else
            {
                MessageBox.Show("Введите корректное число, в диапозоне от 12 до 30");
            }


        }
        private void UpdateDeviceStateInDatabase(int id, string state_device)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Изменяем колонку state_device в таблице Devices
                string updateQuery = "UPDATE Devices SET state_device = @state WHERE id = @deviceId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@state", state_device);
                    command.Parameters.AddWithValue("@deviceId", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void UpdateDeviceTemp(int id, int temperature)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Devices SET temperature = @temp WHERE id = @deviceId";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@temp", temperature);
                    command.Parameters.AddWithValue("@deviceId", id);
                    command.ExecuteNonQuery();

                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 oldForm = new Form1();

            this.Close();
            oldForm.Show();
        }
    }
}
