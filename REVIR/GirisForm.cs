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
    }
}
