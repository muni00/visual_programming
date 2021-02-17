using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araç_fiyat_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV_ORAN = 0.18, OTV_ORAN = 0.23;
            double fiyat = 0, kdv_tutar = 0, otv_tutar = 0, toplam = 0;

            fiyat = Convert.ToDouble(textBox1.Text);

            kdv_tutar = fiyat * KDV_ORAN;
            otv_tutar = fiyat * OTV_ORAN;
            toplam = kdv_tutar + otv_tutar + fiyat;

            textBox2.Text = Convert.ToString(kdv_tutar);
            textBox3.Text = Convert.ToString(otv_tutar);
            textBox4.Text = Convert.ToString(toplam);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
