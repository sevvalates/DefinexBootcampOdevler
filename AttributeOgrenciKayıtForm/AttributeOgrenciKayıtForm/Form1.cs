using AttributeClassLibrary;

namespace AttributeOgrenciKayıtForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Bolum = txtBolumu.Text
            };

            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
