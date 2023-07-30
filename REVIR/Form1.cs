using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;



namespace REVIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        
        public void ekontrol()
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

        public void yenilem()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From htilac", baglanti);
            System.Data.DataTable tablo = new System.Data.DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }


        public void yenile()
        {
            
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=revir.accdb");


            baglanti.Open();
            da = new OleDbDataAdapter("Select *From ilacenvanter", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglanti.Close();

        }
        public void sil(int numara)
        {

            string sorgu = "Delete From ilacenvanter Where sirano=@sirano";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sirano", dataGridView2.CurrentRow.Cells[0].Value);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("veri kaydınız silindi");
            yenile();

        }
        public void silm(int numaram)
        {
            
            string sorgu = "Delete From htilac Where kno=@no";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[0].Value);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("veri kaydınız silindi");
            yenilem();



        }
        
        public void güncelle(int sayi)
        {

            string sorgu = "Update ilacenvanter Set sirano=@sirano,ilacadi=@ilacadi,ilacdozu=@ilacdozu,gelen=@ilacadeti,tarih=@tarih Where sirano=@sirano";
            komut = new OleDbCommand(sorgu, baglanti);
           // komut.Parameters.AddWithValue("@sirano", dataGridView2.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@sirano", esirano.Text);
            komut.Parameters.AddWithValue("@ilacadi", eilacadı.Text);
            komut.Parameters.AddWithValue("@ilacdozu", edoz.Text);
            komut.Parameters.AddWithValue("@ilacadeti", eadet.Text);
            komut.Parameters.AddWithValue("@tarih", etarih.Text);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("veri tabanı güncelleme yapıldı");
            yenile();
        }
        public void güncellem(int sayim)
        {
            baglanti.Close();
            string sorgu = "Update htilac Set kno=@no,personelsicil=@sicil,httc=@httc,htadsoyad=@htadsoyad,htdosyaid=@htid,htko=@htkogus,tani=@tanı,tarih=@tarih,ilacadi=@ilacadi,ilacdozu=@ilacdozu,ilacadeti=@ilacadeti Where kno=@no";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(Kayitno.Text));
            komut.Parameters.AddWithValue("@sicil", Convert.ToInt32(sicilNo.Text));
            komut.Parameters.AddWithValue("@httc", tcno.Text);
            komut.Parameters.AddWithValue("@htadsoyad", hadisoyadi.Text);
            komut.Parameters.AddWithValue("@htid", dosyaid.Text);
            komut.Parameters.AddWithValue("@htkogus", kous.Text);
            komut.Parameters.AddWithValue("@tanı", tanı.Text);
            komut.Parameters.AddWithValue("@tarih", tarih.Text);
            komut.Parameters.AddWithValue("@ilacadi", ılacadı.Text);
            komut.Parameters.AddWithValue("@ilacdozu", doz.Text);
            komut.Parameters.AddWithValue("@ilacadeti", Convert.ToInt32(ılacadetı.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("veri tabanı güncelleme yapıldı");
            yenilem();

        }
        public void satirsayi()
        {
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ilacenvanter");
            int i = ds.Tables["ilacenvanter"].Rows.Count + 1;
            esirano.Text = i.ToString();
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
            yenilem();
            satirsayi();
            MessageBox.Show("sicil ve tc kimlik numaralarını düzenli yazalım");
            baglanti.Close();
           
        }

        private void dogumTarihiSecici_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sicilNo.Text))
            {
                if (!string.IsNullOrEmpty(tcno.Text))
                {
                    if (!string.IsNullOrEmpty(Kayitno.Text))
                    {
                        baglanti.Close();
                        string sorgu = "Insert into htilac (kno,personelsicil,httc,htadsoyad,htdosyaid,htko,tani,tarih,ilacadi,ilacdozu,ilacadeti) values (@no,@sicil,@httc,@adsoyad,@htid,@htkogus,@tanı,@tarih,@ilacadi,@ilacdozu,@ilacadeti)";
                        komut = new OleDbCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@no", Convert.ToInt32(Kayitno.Text));
                        komut.Parameters.AddWithValue("@sicil", Convert.ToInt32(sicilNo.Text));
                        komut.Parameters.AddWithValue("@httc", tcno.Text);
                        komut.Parameters.AddWithValue("@adsoyad", hadisoyadi.Text);
                        komut.Parameters.AddWithValue("@htid", dosyaid.Text);
                        komut.Parameters.AddWithValue("@htkogus", kous.Text);
                        komut.Parameters.AddWithValue("@tanı", tanı.Text);
                        komut.Parameters.AddWithValue("@tarih", tarih.Text);
                        komut.Parameters.AddWithValue("@ilacadi", ılacadı.Text);
                        komut.Parameters.AddWithValue("@ilacdozu", doz.Text);
                        komut.Parameters.AddWithValue("@ilacadeti", Convert.ToInt32(ılacadetı.Text));
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("veri tabanı kaydı yapıldı");
                        yenilem();

                       
                        
                    }
                }
            }
            else
            {
                MessageBox.Show(" Sicil Kayıt no ve TC no kontrol ediniz");
            }


        }

        private void kous_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ekontrol();
            if (!string.IsNullOrEmpty(sicilNo.Text))
            {
                baglanti.Close();
                string sorgu = "Insert into ilacenvanter (sirano,ilacadi,ilacdozu,gelen,tarih) values (@esirano,@ilacadi,@ilacdozu,@ilacadeti,@tarih)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@esirano", Convert.ToInt32(esirano.Text));
                komut.Parameters.AddWithValue("@ilacadi", eilacadı.Text);
                komut.Parameters.AddWithValue("@ilacdozu", edoz.Text);
                komut.Parameters.AddWithValue("@ilacadeti", Convert.ToInt32(eadet.Text));
                komut.Parameters.AddWithValue("@tarih", etarih.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("veri tabanı kaydı yapıldı");
                yenile();
                satirsayi();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                DialogResult c;
                c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes) { sil(numara); }
                
            }
            satirsayi();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            esirano.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            eilacadı.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            edoz.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            eadet.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            etarih.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları güncelle
            {
                int sayi = Convert.ToInt32(drow.Cells[0].Value);
                güncelle(sayi);
            }
            satirsayi();
        }

        private void esirano_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eilacadı_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eadet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           // baglanti.Close();
            //string sorgu = "SElect *from ilacenvanter where sirano like '" + esirano.Text + "%'";
           // da = new OleDbDataAdapter("Select * from ilacenvanter where sirano like '" + esirano.Text + "%'", baglanti);
            // OleDbDataAdapter data_adapter = new OleDbDataAdapter("SELECT * FROM Tablo1 WHERE Tarih LIKE '%" + dateTimePicker2.Text + "%' " + sorgu + " ", baglanti);
           // ds = new DataSet();
           // baglanti.Open();
           // da.Fill(ds, "ilacenvanter");
          //  dataGridView2.DataSource = ds.Tables["ilacenvanter"];
            //baglanti.Close();


            baglanti.Close();
            //string sorgu = "Select * from ilacenvanter where ilacdozu like '" + dataGridView1.CurrentRow.Cells[9].Value.ToString() + "%'";
            da = new OleDbDataAdapter("Select * from ilacenvanter where ilacadi like '" + eilacadı.Text + "%'", baglanti);
            //OleDbDataAdapter data_adapter = new OleDbDataAdapter("SELECT * FROM Tablo1 WHERE Tarih LIKE '%" + dateTimePicker2.Text + "%' " + sorgu + " ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ilacenvanter");
            dataGridView2.DataSource = ds.Tables["ilacenvanter"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drown in dataGridView1.SelectedRows)  //Seçili Satırları güncelle
            {
                int sayim = Convert.ToInt32(drown.Cells[0].Value);
                güncellem(sayim);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drowm in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numaram = Convert.ToInt32(drowm.Cells[0].Value);
                DialogResult c;
                c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes) { silm(numaram); }
                    
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Kayitno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sicilNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tcno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hadisoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dosyaid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kous.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tanı.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //tarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ılacadı.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            doz.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ılacadetı.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[10].Value.ToString()))
            {
                baglanti.Close();
                //string sorgu = "Select * from ilacenvanter where ilacdozu like '" + dataGridView1.CurrentRow.Cells[9].Value.ToString();
               // da = new OleDbDataAdapter("Select * from ilacenvanter where ilacadi like '" + dataGridView1.CurrentRow.Cells[8].Value.ToString() + "%'", baglanti);
               OleDbDataAdapter data_adapter = new OleDbDataAdapter("Select * from ilacenvanter where ilacdozu like '" + dataGridView1.CurrentRow.Cells[9].Value.ToString() + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
               // da.Fill(ds, "ilacenvanter");
                data_adapter.Fill(ds, "ilacenvanter");
                dataGridView2.DataSource = ds.Tables["ilacenvanter"];
                baglanti.Close();
           
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            //string sorgu = "SElect *from ilacenvanter where sirano like '" + esirano.Text + "%'";
            da = new OleDbDataAdapter("Select * from htilac where httc like '" + tcno.Text + "%'", baglanti);
            // OleDbDataAdapter data_adapter = new OleDbDataAdapter("SELECT * FROM Tablo1 WHERE Tarih LIKE '%" + dateTimePicker2.Text + "%' " + sorgu + " ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "htilac");
            dataGridView1.DataSource = ds.Tables["htilac"];
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          if(dataGridView1.CurrentRow.Cells[8].Value.ToString()== dataGridView2.CurrentRow.Cells[1].Value.ToString())
            {
                if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == dataGridView2.CurrentRow.Cells[2].Value.ToString())
                {
                    baglanti.Close();
                    string sorgum = "Update ilacenvanter Set sirano=@sirano,verilen=@verilen,kalan=@kalan Where sirano=@sirano";
                    komut = new OleDbCommand(sorgum, baglanti);
                    // komut.Parameters.AddWithValue("@sirano", dataGridView2.CurrentRow.Cells[0].Value);
                    komut.Parameters.AddWithValue("@sirano", esirano.Text);
                    komut.Parameters.AddWithValue("@verilen", dataGridView1.CurrentRow.Cells[10].Value);
                    
                    komut.Parameters.AddWithValue("@kalan", Convert.ToInt32((Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value)+ Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value)) - Convert.ToInt32(dataGridView2.CurrentRow.Cells[6].Value)));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("veri tabanı güncelleme yapıldı");
                    yenile();
                }
            }

        }
    }
}
