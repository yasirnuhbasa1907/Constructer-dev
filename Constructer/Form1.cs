using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Constructer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxStatu.Items.Add("i��i");
            comboBoxStatu.Items.Add("m�hendis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(textBoxAd.Text, textBoxAdres.Text, Convert.ToInt32(textBoxYas.Text), Convert.ToInt32(textBoxMesai.Text), comboBoxStatu.Text);


            if (comboBoxStatu.Text == "i��i")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }
    }
}