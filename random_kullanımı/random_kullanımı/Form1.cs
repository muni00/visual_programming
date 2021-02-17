using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.DodgerBlue, Color.DarkOrange, Color.Chocolate, Color.AliceBlue };
            Random x = new Random();
            int indis_sayi = x.Next(0,7);
            this.BackColor = renkler[indis_sayi];
        }
    }
}
