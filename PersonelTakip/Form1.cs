namespace PersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriYukle();

            //Datasource liste kutusunda veri baðlamak için kullanýlýr
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";
            lboxPersoneller.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel yeni = lboxPersoneller.SelectedItem as Personel;
            if (yeni == null)
                yeni = new Personel();

            yeni.Id = 0;
            yeni.AdSoyad = txtAdSoyad.Text;
            yeni.CalistigiBirim = txtCalistigiBirim.Text;
            yeni.Cinsiyet = cboxCinsiyet.SelectedIndex;
            yeni.Turu = cboxPersonelTürü.SelectedIndex;

            CheckBox[] chk = { null, chkPzt, chkSal, chkCar, chkPer, chkCum, chkCmt, chkPaz };
            int gunler = 0;
            Array degerler = Enum.GetValues(typeof(Gunler));
            for (int i = 1; i < chk.Length; i++)
            {
                CheckBox c = chk[i];
                if (c.Checked) gunler |= (int)degerler.GetValue(i);
            }
            yeni.CalismaGunleri = gunler;
            if (rdSgk.Checked)
                yeni.SaglikSigortasi = (int)SigortaTuru.Sgk;
            else
                yeni.SaglikSigortasi = (int)SigortaTuru.Ozel;

            if (lboxPersoneller.SelectedItem == null)
                DosyaYardimcisi.PersonelEkle(yeni);

            lboxPersoneller.DataSource = null;
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";
            lboxPersoneller.ValueMember = "Id";
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriKaydet();
            MessageBox.Show("Veriler Kaydedildi");
        }

        private void lboxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel pers  = lboxPersoneller.SelectedItem as Personel;
            


            if (pers != null)
            {
                txtAdSoyad.Text = pers.AdSoyad;
                txtCalistigiBirim.Text = pers.CalistigiBirim;
                cboxCinsiyet.SelectedIndex = pers.Cinsiyet;
                cboxPersonelTürü.SelectedIndex = pers.Turu;

                if (pers.SaglikSigortasi == (int)SigortaTuru.Sgk)
                    rdSgk.Checked = true;
                else if (pers.SaglikSigortasi == (int)SigortaTuru.Ozel)
                    rdÖzel.Checked = true;
            }
            else
            {
                txtAdSoyad.Text = "";
                txtCalistigiBirim.Text = "";
                cboxCinsiyet.SelectedIndex = -1;
                cboxPersonelTürü.SelectedIndex = -1;
                rdSgk.Checked = rdÖzel.Checked = false;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lboxPersoneller.SelectedIndex = -1;
        }
    }
}