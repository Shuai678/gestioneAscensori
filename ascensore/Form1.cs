using System.Runtime.CompilerServices;

namespace sistema_idraulico
{
    public partial class Form1 : Form
    {
        private Ascensore ascensore1;
        private Ascensore ascensore2;
        private Ascensore ascensore3;

        private StazioneDiControllo stazioneDiControllo1;

        public Form1()
        {
            InitializeComponent();
            ascensore1 = new Ascensore("001", "huawei", 10, 1, 0);
            ascensore2 = new Ascensore("002", "huawei", 10, 1, 0);
            ascensore3 = new Ascensore("003", "huawei", 10, 1, 0);
            stazioneDiControllo1 = new StazioneDiControllo("0001");
            label1.Text = Convert.ToString(ascensore1.posizioneAttuale);
            label2.Text = Convert.ToString(ascensore2.posizioneAttuale);
            label3.Text = Convert.ToString(ascensore3.posizioneAttuale);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ascensore1.salire(Convert.ToInt32(numericUpDown1.Value));
            label1.Text = Convert.ToString(ascensore1.posizioneAttuale);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ascensore1.reset();
            label1.Text = Convert.ToString(ascensore1.posizioneAttuale);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ascensore2.salire(Convert.ToInt32(numericUpDown2.Value));
            label2.Text = Convert.ToString(ascensore2.posizioneAttuale);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ascensore3.salire(Convert.ToInt32(numericUpDown3.Value));
            label3.Text = Convert.ToString(ascensore3.posizioneAttuale);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ascensore2.reset();
            label2.Text = Convert.ToString(ascensore2.posizioneAttuale);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ascensore3.reset();
            label3.Text = Convert.ToString(ascensore3.posizioneAttuale);
        }
    }
}
