using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar_örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label2.Text = "0";label4.Text = "0";
            progressBar1.Maximum = 59;progressBar2.Maximum = 59;
            button2.Enabled = false;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if(saniye==60)
            {
                saniye = 0;
                dakika++;
            }
            label2.Text = dakika.ToString();
            label4.Text = saniye.ToString();
            progressBar1.Value = dakika;
            progressBar2.Value = saniye;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dakika = 0;
            saniye = 0;
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
    }
}
