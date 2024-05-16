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
    public partial class Спальня : Form
    {
        private const string ConnectionString = "Data Source=KATYA\\SQLEXPRESS;Initial Catalog=Devices;Integrated Security=True";
        public Спальня()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
            button3.BackColor = Color.LightSkyBlue;
            label1.Text = "Кондиционер";
            button2.BackColor = Color.White;
            panel3.Visible = false;
            panel4.Visible = false;
            button7.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            label4.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Освещение";
            button1.BackColor = Color.White;
            button3.BackColor = Color.LightSkyBlue;
            button2.BackColor = Color.LightSkyBlue;
            panel3.Visible = true;
            panel4.Visible = true;
            button7.Visible = false;
            panel5.Visible = false;
            label4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSkyBlue;
            button1.BackColor = Color.LightSkyBlue;
            label1.Text = "Электроприборы";
            button3.BackColor = Color.White;
            panel3.Visible = false;
            panel4.Visible = false;
            button7.Visible = false;
            panel5.Visible = false;
            label4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 oldForm = new Form1();

            this.Close();
            oldForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 13;
            if (button6.Text == "Включить")
            {
                button6.Text = "Выключить";
                Bitmap disable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lantern_on.png");
                button6.Image = disable;
                UpdateDeviceStateInDatabase(id, "Вкл");

            }
            else
            {
                button6.Text = "Включить";
                Bitmap enable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\lantern_off.png");
                button6.Image = enable;
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = 14;
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

        private void button7_Click(object sender, EventArgs e)
        {
            int id = 16;
            if (button7.Text == "Включить")
            {
                button7.Text = "Выключить";
                button7.BackColor = Color.LightCoral;
                UpdateDeviceStateInDatabase(id, "Вкл");
            }
            else
            {
                button7.Text = "Включить";
                button7.BackColor = Color.LightGreen;
                UpdateDeviceStateInDatabase(id, "Выкл");
            }

        }

        private void button_shtor_Click(object sender, EventArgs e)
        {
            int id = 11;
            if (button_shtor.Text == "Открыть")
            {
                button_shtor.Text = "Закрыть";
                Bitmap disable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\sun.png");
                button_shtor.Image = disable;
                UpdateDeviceStateInDatabase(id, "Открыты");

            }
            else
            {
                button_shtor.Text = "Открыть";
                Bitmap enable = new Bitmap("C:\\Users\\golub\\source\\repos\\WinFormsApp2\\Properties\\Resources\\shtor.png");
                button_shtor.Image = enable;
                UpdateDeviceStateInDatabase(id, "Закрыты");
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
        
        private void button8_Click(object sender, EventArgs e)
        {
            int id = 12;
            if (button8.Text == "Включить")
            {
                button8.Text = "Выключить";
                UpdateDeviceStateInDatabase(id, "Вкл");
            }
            else
            {
                button8.Text = "Включить";
                UpdateDeviceStateInDatabase(id, "Выкл");
            }
        }
    }
}
