namespace Bilgi_Yarışması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogruSayisi = 0, yanlisSayisi = 0;



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            soruno++;
            soruNo.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Dünyanın Yüzölçümü bakımından en büyük ülkesi hangisidir?";
                btnA.Text = "Rusya";
                btnB.Text = "Çin";
                btnC.Text = "ABD";
                btnD.Text = "Kanada";
                label4.Text = "Rusya";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Suç ve Ceza romanının yazarı kimdir?";
                btnA.Text = "Mark Twain";
                btnB.Text = "Leo Tolstoy";
                btnC.Text = "Anton Chekhov";
                btnD.Text = "Fyodor Dostoyevski";
                label4.Text = "Fyodor Dostoyevski";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "İnsan Vücudundaki En Büyük Organ Hangisidir?";
                btnA.Text = "Karaciğer";
                btnB.Text = "Beyin";
                btnC.Text = "Deri";
                btnD.Text = "Kalp";
                label4.Text = "Deri";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Berlin Duvarı Kaç Yılında Yıkılmıştır?";
                btnA.Text = "1991";
                btnB.Text = "1989";
                btnC.Text = "1990";
                btnD.Text = "1988";
                label4.Text = "1989";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Birleşmiş Milletlerin Merkez Ofisi Nerede Bulunur?";
                btnA.Text = "New York";
                btnB.Text = "Gine";
                btnC.Text = "Gürcistan";
                btnD.Text = "Birleşik Krallık";
                label4.Text = "New York";
            }
            if (soruno == 6)
            {
                btnSonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Oyun Bitti. Doğru Sayınız: " +"\n" + dogruSayisi + "\n" + " Yanlış Sayınız: " + yanlisSayisi);
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnA.Text;
            if (label5.Text == label4.Text)
            {
                dogruSayisi++;
                dogru.Text = dogruSayisi.ToString();
            }
            else
            {
                yanlisSayisi++;
                yanlis.Text = yanlisSayisi.ToString();

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnB.Text;
            if (label5.Text == label4.Text)
            {
                dogruSayisi++;
                dogru.Text = dogruSayisi.ToString();
            }
            else
            {
                yanlisSayisi++;
                yanlis.Text = yanlisSayisi.ToString();

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnC.Text;
            if (label5.Text == label4.Text)
            {
                dogruSayisi++;
                dogru.Text = dogruSayisi.ToString();
            }
            else
            {
                yanlisSayisi++;
                yanlis.Text = yanlisSayisi.ToString();

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnD.Text;
            if (label5.Text == label4.Text)
            {
                dogruSayisi++;
                dogru.Text = dogruSayisi.ToString();
            }
            else
            {
                yanlisSayisi++;
                yanlis.Text = yanlisSayisi.ToString();

            }
        }
    }
} 



