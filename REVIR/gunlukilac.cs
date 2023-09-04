using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REVIR
{
    public partial class gunlukilac : Form
    {
        public gunlukilac()
        {
            InitializeComponent();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        int secilenilacid;
        int hukumlutabloid;
        private void Kaydetbuton_Click(object sender, EventArgs e)
        {

        }

        private void gunlukilac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }

        private void gunlukilac_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Odakogus order by OdaAdi asc ", baglanti);
            baglanti.Open();
            da.Fill(dt);
            odacombobox.ValueMember = "Odaid";
            odacombobox.DisplayMember = "OdaAdi";
            odacombobox.DataSource = dt;
            da = new OleDbDataAdapter("Select * From ilac", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();




        }
    }
}
