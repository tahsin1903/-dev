using System;
using System.Windows.Forms;


namespace Arabalar
{
    public partial class Form1 : Form
    {
        Arabalar arabalar;
        public Form1()
        {
            InitializeComponent();
        }



        private void bTkaydet_Click(object sender, EventArgs e)
        {
            arabalar = new Arabalar()
            {
                Id = tbId.Text,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                Kapısayısı = tbKsayı.Text,
                Beygirgücü = tbBeygir.Text,
                Tür = tbTür.Text,
                Maxhız = tbMaxhız.Text,
                Cekis = tbCekis.Text,
                hızlanma = tbYuzHız.Text,
                Agırlık = tbAgırlık.Text,
                Motorgücü = tbMotorHacmi.Text,

            };
        }


        private void btGöster_Click(object sender, EventArgs e)
        {
            rtbGöster.Text += "Id" + arabalar.Id + "\n";
            rtbGöster.Text += "Marka" + arabalar.Marka + "\n";
            rtbGöster.Text += "Model" + arabalar.Model + "\n";
            rtbGöster.Text += "Kapısayısı" + arabalar.Kapısayısı + "\n";
            rtbGöster.Text += "Beygirgücü" + arabalar.Beygirgücü + "\n";
            rtbGöster.Text += "Tür" + arabalar.Beygirgücü + "\n";
            rtbGöster.Text += "Maxhız" + arabalar.Maxhız + "\n";
            rtbGöster.Text += "Çekiş" + arabalar.Cekis + "\n";
            rtbGöster.Text += "Hızlanma" + arabalar.hızlanma + "\n";
            rtbGöster.Text += "Ağırlık" + arabalar.Agırlık + "\n";
            rtbGöster.Text += "Motorgücü" + arabalar.Motorgücü + "\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
