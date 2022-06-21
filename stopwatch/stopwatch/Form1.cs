using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        DateTime date1 = new DateTime(0, 0);

        private void Form1_Load(object sender, EventArgs e)
        {
            date1 = date1.AddMilliseconds(100);
            label1.Text = date1.ToString("mm:ss:f");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DateTime date1 = new DateTime(0, 0);
            label1.Text = date1.ToString("mm:ss:f");
            button1.Text = "Пуск";
        }
    }
}
