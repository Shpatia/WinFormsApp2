namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        DataBase dataBase= new DataBase();
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ����� newForm = new �����();
            newForm.Show();
            this.Hide();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ����� newForm = new �����();
            newForm.Show();
            this.Hide();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ������� newForm = new �������();
            newForm.Show();
            this.Hide();
        }

        private void ��������_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            �������� newForm = new ��������();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ����� newForm = new �����();
            newForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            �������� newForm = new ��������();
            newForm.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ������� newForm = new �������();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ����� newForm = new �����();
            newForm.Show();
            this.Hide();

        }
    }
}