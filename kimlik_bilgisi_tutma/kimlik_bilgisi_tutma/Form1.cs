using System;
using System.Windows.Forms;

namespace kimlik_bilgisi_tutma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC NO", 150);
            listView1.Columns.Add("AD SOYAD", 200);
            listView1.Columns.Add("YAŞ", 50);
            listView1.Columns.Add("MEZUNİYET", 150);
            listView1.Columns.Add("CİNSİYET", 125);
            listView1.Columns.Add("DOĞUM YERİ", 125);
            listView1.Columns.Add("TELEFON NO", 130);

            string[] mezuniyet= { "İLKÖĞRETİM","ORTAÖĞRETİM","LİSANS","YUKSEKLİSANS","DOKTORA"};
            comboBox1.Items.AddRange(mezuniyet);
            kayıt_sayısı();
        }
        private void kayıt_sayısı()
        {
            int kayıtsayısı = listView1.Items.Count;
            label8.Text = Convert.ToString(kayıtsayısı);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc = "", adsoyad = "", yaş = "", mezuniyet = "", cinsiyet = "", doğumyeri = "", telno = "";
            tc = textBox1.Text;adsoyad = textBox2.Text;yaş = textBox3.Text;mezuniyet = comboBox1.Text;
            if (radioButton1.Checked == true)
                cinsiyet = radioButton1.Text;
            else if (radioButton2.Checked == true)
                cinsiyet = radioButton2.Text;
            doğumyeri = textBox4.Text;telno = textBox5.Text;
            string[] bilgiler = { tc, adsoyad, yaş, mezuniyet, cinsiyet, doğumyeri, telno };
            bool aranankayitkontrolu = false;
            for(int i=0;i<listView1.Items.Count;i++)
            {
                if(listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    MessageBox.Show("kayıtlarda mevcut kişi vardır");
                }
            }
            if (aranankayitkontrolu == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (tc != "" && adsoyad != "" && yaş != "" && mezuniyet != "" && cinsiyet != "" && telno != "" && doğumyeri != "")
                    listView1.Items.Add(lst);
                else
                    MessageBox.Show("kayıt bilgilerinde eksiklik var");
            }
            kayıt_sayısı();
                         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int seçilensayisi = listView1.CheckedItems.Count;
            foreach(ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(seçilensayisi.ToString() + " adet kayıt silindi");
            kayıt_sayısı();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int seçilensayisi = listView1.SelectedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.SelectedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(seçilensayisi.ToString() + " adet kayıt silindi");
            kayıt_sayısı();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayıt_sayısı();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool aranankayitkontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    textBox5.Text = listView1.Items[i].SubItems[6].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text == "BAY")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text == "BAYAN")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false; groupBox1.Enabled = false; comboBox1.Enabled = false;
                }
                
            }
            if (aranankayitkontrolu== false)
                MessageBox.Show("ARANAN TC NUMARASIYLA KAYITLI KISI BULUMAMAKTA");

        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true; groupBox1.Enabled = true; comboBox1.Enabled = true;
            
        }
    }
}
