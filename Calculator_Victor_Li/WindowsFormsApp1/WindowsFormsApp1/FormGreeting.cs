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
    public partial class FormGreeting : Form
    {
        public FormGreeting()
        {
            InitializeComponent();
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart startForm = new FormStart();
            startForm.Show();
            
        }

        private void FormGreeting_Load(object sender, EventArgs e)
        {

        }
    }
}
