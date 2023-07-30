using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace REVIR
{
    public partial class ilacekle : Form
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        int secilenilacid;
        public ilacekle()
        {
            InitializeComponent();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");
        }

        private void ilacekle_Load(object sender, EventArgs e)
        {
            sicilNo.Text = bilgisinif.sicil;
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From ilac", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();



            //////////////////
            //yenile();
            //yenilem();
            //satirsayi();

            //baglanti.Close();
        }

        private void ilacekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.OpenForms[1].Show();
        }

        private void ilacekle_buton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sorgu;

                if (checkBox1.Checked == true)// daha önce yok listede yeni kayıt 
                {
                    if (ilacadi.Text != "" && doz.Text != "") //ilac adını yazdı mı 
                    {                        
                        sorgu = "Insert into ilac (ad,doz,adet) values (@ad,@doz,@adet)";
                        komut = new OleDbCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@ad", ilacadi.Text);
                        komut.Parameters.AddWithValue("@doz", doz.Text);
                        komut.Parameters.AddWithValue("@adet", Convert.ToInt32(ilacadet.Text));
                    }

                }
                else if(ilacadi.Text!="" && doz.Text!="" && secilenilacid>0)// listede var update yapılacak  - ilaç daha önce listede var o yüzden güncelleme işlemi yapılıyor
                {
                    sorgu = "Update ilac SET adet=adet+"+ ilacadet.Text +"  where id="+secilenilacid;
                    komut = new OleDbCommand(sorgu, baglanti);
                   

                }
                else
                {
                    MessageBox.Show("ilac seçimini doğru şekilde yapınız");
                }
                baglanti.Open();
               
                int id=0;
                if (komut.ExecuteNonQuery() == 1)//the insert succeded
                {
                    komut.CommandText = "Select @@Identity";
                    id = Convert.ToInt32(komut.ExecuteScalar());
                }
                sorgu = "Insert into depogiris (ilacid,personelid,ilacadet,kayittarihi) values (@ilacid,@personelid,@ilacadet,@kayittarihi)";
                komut = new OleDbCommand(sorgu, baglanti);
                //komut.Parameters.AddWithValue("@esirano", Convert.ToInt32(esirano.Text));
                komut.Parameters.AddWithValue("@ilacid", id);//ilac id gelecek 
                komut.Parameters.AddWithValue("@personelid", bilgisinif.personelid);
                komut.Parameters.AddWithValue("@ilacadet", Convert.ToInt32(ilacadet.Text));
                komut.Parameters.AddWithValue("@kayittarihi", kayittarihi.Text);
                komut.ExecuteNonQuery();

                
                MessageBox.Show("veri tabanı kaydı yapıldı");
            }
            catch (Exception ex)
            {

                int a;
            }
            finally {

                baglanti.Close();
                temizle();
                }

            
          
        }

    /*    public void ekontrol()
        {
            if (string.IsNullOrEmpty(esirano.Text))
            {
                MessageBox.Show(" Sıra no kontrol ediniz");
            }
            if (string.IsNullOrEmpty(sicilNo.Text))
            {
                MessageBox.Show("Sicil ve Sıra no kontrol ediniz");
            }
            if (string.IsNullOrEmpty(eilacadı.Text))
            {
                MessageBox.Show("ilac adını kontrol ediniz");
            }
            if (string.IsNullOrEmpty(edoz.Text))
            {
                MessageBox.Show("Doz miktarın kontrol ediniz");

            }
            if (string.IsNullOrEmpty(eadet.Text))
            {
                MessageBox.Show("İlac adetini  kontrol ediniz");
            }

            if (string.IsNullOrEmpty(esirano.Text) && string.IsNullOrEmpty(sicilNo.Text) && string.IsNullOrEmpty(eilacadı.Text) && string.IsNullOrEmpty(edoz.Text) && string.IsNullOrEmpty(eadet.Text))
            {
                MessageBox.Show("Veri Girişlerinizi Kontrol ediniz");
            }

        }
        */
        public void temizle()
        {

            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From ilac", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();
            ilacadi.Text = "";
            doz.Text = "";
            secilenilacid = 0;
        }

        public void satirsayi()
        {
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ilacenvanter");
            int i = ds.Tables["ilacenvanter"].Rows.Count + 1;
            //esirano.Text = i.ToString();
            baglanti.Close();
        }

        public void yenilem()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From htilac", baglanti);
            System.Data.DataTable tablo = new System.Data.DataTable();
            da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if (checkBox1.Checked==true)
            {
                groupBox2.Enabled = true;
            }
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilenilacid = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value);
            ilacadi.Text = (dataGridView2.SelectedRows[0].Cells["ad"].Value).ToString();
            doz.Text = (dataGridView2.SelectedRows[0].Cells["doz"].Value).ToString();
            //MessageBox.Show(secilenilacid.ToString());
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

        private void ilacguncelle_buton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlac Adını ve Dozunu Güncelleme yapabilirsiniz");
            string sorgu = "Update ilac SET ad=+'" + ilacadi.Text + "',doz=" + doz.Text + "  where id=" + secilenilacid;
            komut = new OleDbCommand(sorgu, baglanti);
            baglanti.Open();

            if (komut.ExecuteNonQuery() == 1)//the insert succeded
            {
                MessageBox.Show("Kayıt Başarı Bir Şekilde Güncellendi");
                temizle();
            }
            else
            {
                MessageBox.Show("Kayıt güncelleme yapılmadı");
            }
        }

        private void ilacsil_buton_Click(object sender, EventArgs e)
        {

        }
    }
}
