using ProyectodeConsola;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public float state { get; set; }
        List<string[]> list = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
        }

        private void hideAll()
        
        {
            foreach (var control in Controls.OfType<Control>()) {control.Hide();}
        }
        private void showMenu()
        {
            dataGridView1.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            state = 0;
            hideAll();
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
            state = 1;
            dataGridView1.Rows.Clear();
            hideAll();
            dataGridView1.Show();
            button5.Show();
            list = CRUD.Read();
            foreach (var carData in list) 
            {
                dataGridView1.Rows.Add(carData);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideAll();
            label6.Show();
            textBox6.Show();
            button5.Show();
            state = 2.1F;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAll();
            label6.Show();
            textBox6.Show();
            button5.Show();
            state = 3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch (state) {
                case 0: 
                    CRUD.Create(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
                    foreach (var txtbox in Controls.OfType<System.Windows.Forms.TextBox>()) 
                    {
                        txtbox.Text = "";
                    }
                    hideAll();
                    showMenu();
                    break;

                case 1:
                    hideAll();
                    showMenu();
                    break;

                case 2.1F:
                    hideAll();
                    button5.Show();
                    label1.Text = "Company";
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
                    state = 2.2F;
                    break;

                case 2.2F:
                    CRUD.Update(Convert.ToInt32(textBox6.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
                    foreach (var txtbox in Controls.OfType<System.Windows.Forms.TextBox>())
                    {
                        txtbox.Text = "";
                    }
                    hideAll();
                    showMenu();
                    break;

                case 3:
                    CRUD.Delete(Convert.ToInt32(textBox6.Text));
                    hideAll();
                    showMenu();
                    break;
                    }
        }
    }
}
