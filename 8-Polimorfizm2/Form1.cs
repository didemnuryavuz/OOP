using _8_Polimorfizm2.CepTelefonlari;
using System.Media;

namespace _8_Polimorfizm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.CallSound();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iphone phone = new Iphone();
            phone.CallSound();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.CallSound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Huawei huawei = new Huawei();
            huawei.CallSound();
        }
    }
}
