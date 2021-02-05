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
    public partial class FormIng : Form
    {
        public FormIng()
        {
            InitializeComponent();
            this.switchOp.DropDownStyle =
    System.Windows.Forms.ComboBoxStyle.DropDownList;
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(myVal.Text);
                double n = Convert.ToDouble(TBstepen.Text);
                double c = Math.Pow(a, n);
                MyResult.Text = Convert.ToString(c);
            }
            catch(System.FormatException a)
            {
                MessageBox.Show("Ты не ввел нормальные данные \n в какое то поле или не \n выбрал из выпадающего списка оператор! \n выбери или приложение не будет рабоать");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(myVal.Text);



                switch (switchOp.Text)
                {



                    case "Извлечение квадратного корня":
                        double c = Math.Sqrt(a);
                        MyResult.Text = Convert.ToString(c);
                        break;

                    case "Расчет обратного значения(1/x)":
                        double m = 1 / a;
                        MyResult.Text = Convert.ToString(m);
                        break;

                    case "Определение квадрата числа":
                        double k = a * a;
                        MyResult.Text = Convert.ToString(k);
                        break;

                    case "Извлечение кубического корня":
                        double kubkor = Math.Pow(a, 1.0 / 3.0);
                        MyResult.Text = Convert.ToString(kubkor);
                        break;

                    case "Расчет факториала":
                        int myI;
                        int answer;
                        string s = myVal.Text;
                        bool CheckInt = Int32.TryParse(s,out myI);
                        if (CheckInt == true)
                        {
                            bool ok = Program.Factorial(myI, out answer);
                            MyResult.Text = Convert.ToString(answer);
                        }
                        else
                        {
                            MessageBox.Show("Вы вели не инт для расчета фактороиала!");
                        }
                        break;
                }
            }
            catch (System.FormatException a)
            {
                MessageBox.Show("Ты ничего нормального не ввел ");
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.myVal.Text = "";
            switchOp.Text = "";
            TBstepen.Text = "";
            MyResult.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormIng_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
