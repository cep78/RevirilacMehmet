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
        DataTable gridtablo = new DataTable();
        private void Kaydetbuton_Click(object sender, EventArgs e)
        {
            string sorgu;
            if (true)
            {

            }
            baglanti.Open();
            int adimsay = dataGridView3.Rows.Count - 1;
            for (int i = 0; i < dataGridView3.Rows.Count-1; i++)
            {

                string ilacid = dataGridView3.Rows[i].Cells["ilac_id"].Value.ToString();
                string hukumluid = dataGridView3.Rows[i].Cells["Hukumlu_id"].Value.ToString();
                string ilacadet = dataGridView3.Rows[i].Cells["Kullanim_Adeti"].Value.ToString();
                string odaid = dataGridView3.Rows[i].Cells["Oda_id"].Value.ToString();
               

                sorgu = "Insert into depocikis (personelid,ilacid,hukumluid,ilacadet,odaid) values (" + bilgisinif.personelid + "," + ilacid + "," + hukumluid + "," + ilacadet + "," + odaid + ")";
                komut = new OleDbCommand(sorgu, baglanti);
                if (komut.ExecuteNonQuery() != 1)//the insert succeded
                {
                    adimsay--;
                    MessageBox.Show("Kayıtta Hata Var");
                    break;
                }
            }
            if (dataGridView3.Rows.Count - 1==adimsay)
            {
                MessageBox.Show("Kayıtlar Başarılı bir şekilde Kaydedildi");
            }
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
            da = new OleDbDataAdapter("Select id,cikno,tcno,adisoyadi From hukumlu", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView1.DataSource = tablo2;

            da = new OleDbDataAdapter("Select id,ad,doz From ilac ", baglanti);
            System.Data.DataTable tablo3 = new System.Data.DataTable();
            da.Fill(tablo3);
            dataGridView2.DataSource = tablo3;




            baglanti.Close();

           
            gridtablo.Columns.Add("Hukumlu_id", typeof(int));
            gridtablo.Columns.Add("Hukumlu_TC", typeof(string));
            gridtablo.Columns.Add("Hukumlu_Adi_Soyadi", typeof(string));

            gridtablo.Columns.Add("ilac_id", typeof(int));
            gridtablo.Columns.Add("İlac_Adi", typeof(string));
            gridtablo.Columns.Add("İlac_Doz", typeof(int));

            gridtablo.Columns.Add("Oda_id", typeof(int));
            gridtablo.Columns.Add("Oda_Adi", typeof(string));

            gridtablo.Columns.Add("Kullanim_Adeti", typeof(int));



        }

        private void Eklebuton_Click(object sender, EventArgs e)
        {

            DataRow satir = gridtablo.NewRow();
            satir[0]    = secilenhukumluidtextbox.Text;
            satir[1]    = dataGridView1.SelectedRows[0].Cells["tcno"].Value.ToString();
            satir[2]    = secilenhukumluaditextbox.Text;

            satir[3]    = dataGridView2.SelectedRows[0].Cells["id"].Value.ToString();
            satir[4]    = dataGridView2.SelectedRows[0].Cells["ad"].Value.ToString();
            satir[5]    = dataGridView2.SelectedRows[0].Cells["doz"].Value.ToString();

            satir[6]    = odacombobox.SelectedValue.ToString();
            satir[7]    = odacombobox.Text.ToString();
            gridtablo.Rows.Add(satir);
            dataGridView3.DataSource = gridtablo.DefaultView;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            /// mause ile sağ tıklanınca satır seçme kodu
            if (e.Button == MouseButtons.Right)
            {
                int satir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dataGridView1.Rows[satir].Selected = true;
                }
            }
            /// mause ile sağ tıklanınca satır seçme kodu
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilenhukumluidtextbox.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            secilenhukumluaditextbox.Text = dataGridView1.SelectedRows[0].Cells["adisoyadi"].Value.ToString();
        }

        private void secToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            secilenilacidtextbox.Text = dataGridView2.SelectedRows[0].Cells["id"].Value.ToString();
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            /// mause ile sağ tıklanınca satır seçme kodu
            if (e.Button == MouseButtons.Right)
            {
                int satir = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dataGridView2.Rows[satir].Selected = true;
                }
            }
            /// mause ile sağ tıklanınca satır seçme kodu
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            { //seçili satırı siliyoruz.
                dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Satırı Seçin!");

            }
        }


    }
}
