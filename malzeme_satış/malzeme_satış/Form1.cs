using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malzeme_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";textBox3.Text = "1";radioButton1.Checked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                double birim_fiyat = Convert.ToDouble(textBox2.Text);
                double adet = Convert.ToDouble(textBox3.Text);
                double kdv = 0;
                double tutar = birim_fiyat * adet;
                if (radioButton1.Checked == true)
                    kdv = tutar * 0.25;
                else if (radioButton2.Checked == true)
                    kdv = tutar * 0.18;
                else if (radioButton3.Checked == true)
                    kdv = tutar * 0.08;
                tutar = tutar + kdv;
                if (checkBox1.Checked == true)
                    tutar = tutar - tutar * 0.1;
                textBox4.Text = kdv.ToString();
                textBox5.Text = tutar.ToString();
            }
            catch(Exception)
            { }
        }
    }
}
