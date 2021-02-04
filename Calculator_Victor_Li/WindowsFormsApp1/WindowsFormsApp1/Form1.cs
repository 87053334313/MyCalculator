using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle =System.Windows.Forms.ComboBoxStyle.DropDownList;

            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));
        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                double c;

                switch (comboBox1.Text)
                {
                    case "+":
                        c = a + b;

                        textBox3.Text = Convert.ToString(c);

                        break;
                    case "-":
                        c = a - b;

                        textBox3.Text = Convert.ToString(c);

                        break;
                    case "*":
                        c = a * b;

                        textBox3.Text = Convert.ToString(c);

                        break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("На ноль делить нельзя!");
                        }
                        else
                        {
                            c = a / b;
                            textBox3.Text = Convert.ToString(c);
                        }




                        break;
                }
            }
            catch(System.FormatException a)
            {
                MessageBox.Show("Ты не ввел в какое то поле данные!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoToIngenerCalc_Click(object sender, EventArgs e)
        {
            FormIng IngenerCalc = new FormIng();
           
            IngenerCalc.Show();

        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3KV form3kv = new Form3KV();
            form3kv.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void goToWindowOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3KV newform3 = new Form3KV();
            newform3.Show();
        }

        private void goToIngenerCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIng newForm2 = new FormIng();
            newForm2.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void перейтиКИнженерномуКалькуляторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIng newForm2 = new FormIng();
            newForm2.Show();
        }

        private void перейтиККвадратномуУравнениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3KV newform3 = new Form3KV();
            newform3.Show();
        }
    }
}
