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
    public partial class Form3KV : Form
    {
        public Form3KV()
        {
            InitializeComponent();
            ImageCalc.Image = Properties.Resources.VictorCalc;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(A_textBox.Text);
                double b = Convert.ToDouble(B_TextBox.Text);
                double c = Convert.ToDouble(C_TB.Text);
                string otvet = KvadratnoeUravnenie.KvUravnenie(a, b, c);
                RichTextBox.Text = otvet;
            }
            catch(System.FormatException a)
            {
                MessageBox.Show("произошла ошибка связананя с некоректным водом данных \n проверь вводимые поля");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A_textBox.Text = "";
            B_TextBox.Text = "";
            C_TB.Text = "";
            RichTextBox.Text = "";

        }

        private void Form3KV_Load(object sender, EventArgs e)
        {

        }

        
    }
}
