namespace VücudEndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);

            double boyMetre = boy / 100;
            double vki = kilo / (boyMetre * boyMetre);

            lblSonuc.Text = $"Vki Değeri = {vki:f2}";

            if (vki < 18.5)
                lblDurum.Text = "Durum = Zayıf";
            else if (vki < 25)
                lblDurum.Text = "Durum = Normal";
            else if (vki < 30)
                lblDurum.Text = "Durum = Kilolu";
            else
                lblDurum.Text = "Durum = OBEZ";
        }
    }
}