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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();

        }

        private void depoyaİlaçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilacekle ilacekleform = new ilacekle();
            ilacekleform.Show();
            this.Hide();
        }

        private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void hTİlacTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            htilactakip hukumluilactakip = new htilactakip();
            hukumluilactakip.Show();
            this.Hide();
        }

        private void gunlukilacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gunlukilac gunlukilac = new gunlukilac();
            gunlukilac.Show();
            this.Hide();
        }
    }
}
