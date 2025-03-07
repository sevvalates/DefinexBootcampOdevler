using Microsoft.VisualBasic.Logging;

namespace OdemeFormu
{
    public partial class Form1 : Form
    {

        public string odemeTipi = "";
        public string mesaj = "";
        public IOdemeIslemi iOdemeIslemi;
        public OdemeIslemi odemeIslemi;

        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            if (odemeTipi == "KrediKarti")
            {
                KrediKarti krediKarti = new KrediKarti();
                mesaj = krediKarti.OdemeYap(Convert.ToInt32(textBox1.Text));
                MessageBox.Show(mesaj);
            }*/

            OdemeIslemiFactory factory = new OdemeIslemiFactory();
            iOdemeIslemi = factory.GetInstance(odemeTipi);
            odemeIslemi = new OdemeIslemi(iOdemeIslemi);
            mesaj = iOdemeIslemi.OdemeYap(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(mesaj);

            /*
            LogFactory logFactory = new LogFactory();
            iLogger = logFactory.GetInstance(logTipi);
            logger = new Logger(iLogger);
            lblSonuc.Text = iLogger.logYaz(textBox1.Text);
            */
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            odemeTipi = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
