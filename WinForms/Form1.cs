using ProyectodeConsola;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            dataGridView1.Hide();
            button5.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRUD.Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            CRUD.Create(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, (int)Convert.ChangeType(textBox5.Text, typeof(int)));
            button5.Hide();
        }
    }
}
