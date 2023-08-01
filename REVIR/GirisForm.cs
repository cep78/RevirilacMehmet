using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REVIR
{
    public partial class GirisForm : Form
    {

        public void ekranCozunurlugu()
        {
            int ekranGenislik, ekranYukseklik;
            ekranGenislik = Screen.PrimaryScreen.Bounds.Width;
            ekranYukseklik = Screen.PrimaryScreen.Bounds.Height;
            if (ekranGenislik < 1366 || ekranYukseklik < 768)
            {
                MessageBox.Show("Ekran çözünürlüğü 1366x768 altında olması sebebiyle uygulamayı çalıştıramazsınız.", "EKRAN ÇÖZÜNÜRLÜĞÜ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        public void EtkiAlanindaMi()
        {
            string EtkiAlanim = "adalet.gov.tr";
            string EtkiAlani = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            if (EtkiAlani != EtkiAlanim)
            {
                MessageBox.Show("Bilgisayarınız " + EtkiAlanim + " etki alanında olmadığından uygulamayı çalıştıramazsınız.", "ETKİ ALANI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }


        public GirisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void girisFormuGrupKutusu_Enter(object sender, EventArgs e)
        {

        }

        private void girisDugmesi_Click(object sender, EventArgs e)
        {
            bilgisinif.sicil = "ab160526";
            bilgisinif.personelid = 1;
            anasayfa anasayfaform = new anasayfa();
            anasayfaform.Show();
            this.Hide();
        }

        private void kapatDugmesi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            //ekranCozunurlugu();
            //EtkiAlanindaMi();
            kullaniciAdiMetinKutusu.Text = Environment.UserName;
        }

        private void kullaniciAdiMetinKutusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kullanıcı Adı metin kutusunda boşluk yazılmasını engeller.
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void sifreMetinKutusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Şifre metin kutusunda boşluk yazılmasını engeller.
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
