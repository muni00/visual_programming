using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mezuniyet_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = "İLKOGRETİM";
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "ORTAOGRETİM";
            }
            else if (radioButton3.Checked == true)
            {
                label2.Text = "LİSANS";
            }
            else if (radioButton4.Checked == true)
            {
                label2.Text = "YUKSEKLİSANS";
            }
           
            
        }
    }
}
