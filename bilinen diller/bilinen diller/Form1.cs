using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilinen_diller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bil_dil = "";
            if (checkBox1.Checked==true)
            {
                bil_dil = bil_dil + " " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                bil_dil = bil_dil + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                bil_dil = bil_dil + "," + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                bil_dil = bil_dil + "," + checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                bil_dil = bil_dil + "," + checkBox5.Text;
            }
            label2.Text = bil_dil;
        }
    }
}
