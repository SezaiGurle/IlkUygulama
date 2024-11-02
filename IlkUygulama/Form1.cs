namespace IlkUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, MouseEventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;

            MessageBox.Show($"Merhaba, {adSoyad}");
        }
    }
}