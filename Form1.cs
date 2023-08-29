namespace NotHesapla
{
    public partial class NotHesapla : Form
    {
        public NotHesapla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, ortalama;
            AdBilgisi.Items.Add(textBox1.Text);
            SoyadBilgisi.Items.Add(textBox2.Text);
            vize = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox4.Text);
            ortalama = Convert.ToInt32((vize * 40 / 100) + (final * 60 / 100));
            OrtalamaBilgisi.Items.Add(ortalama);
            if (ortalama >= 60)
            {

                GectiKaldiDurumu.Items.Add("Geçti");
            }
            else
            {
                GectiKaldiDurumu.Items.Add("Kaldý");
            }




        }
    }
}