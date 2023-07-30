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
    public partial class htilactakip : Form
    {
        public htilactakip()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hukumlutctext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hukumlutctext.TextLength == 11)
            {


                try
                {
                    hukumlubilgipanel.Enabled = false;
                    DataTable tablo = new DataTable();
                    ds = new DataSet();
                    da = new OleDbDataAdapter("Select * from hukumlu where tcno like '" + hukumlutctext.Text + "%'", baglanti);
                    // OleDbDataAdapter data_adapter = new OleDbDataAdapter("SELECT * FROM Tablo1 WHERE Tarih LIKE '%" + dateTimePicker2.Text + "%' " + sorgu + " ", baglanti);
                    baglanti.Open();
                    da.Fill(ds, "htilac");
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        hukumlubilgipanel.Enabled = true;
                        MessageBox.Show("Yeni Kayıt Giriniz TC No dan emin olunuz");
                        tcno.Text = hukumlutctext.Text;
                    }
                    else if (ds.Tables[0].Rows.Count == 1)
                    {
                        DataRow satir = ds.Tables[0].Rows[0];
                        tcno.Text = satir["tcno"].ToString();
                        hadisoyadi.Text = satir["adisoyadi"].ToString();
                        dosyaid.Text = satir["cikno"].ToString();
                        hukumlutabloid = Convert.ToInt32(satir["id"].ToString());
                    }


                    else if (ds.Tables[0].Rows.Count > 1)
                    {
                        MessageBox.Show("Arama sonucunda bulunan kişi Sayısı: " + ds.Tables[0].Rows.Count);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    int a;
                }
                finally
                {
                    baglanti.Close();
                }

            }
            else
            {
                MessageBox.Show("Tc No Doğru Giriniz");
            }
            
        }

        private void htilactakip_Load(object sender, EventArgs e)
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

        private void htilactakip_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verilenadettextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilenilacid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
     
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sorgu;
            if (tcno.TextLength == 11 && hadisoyadi.Text != "" && dosyaid.Text != "" && secilenilacid > 0 && Convert.ToInt32(verilenadettextbox.Text) > 0)
            {
                if (hukumlutabloid > 0) // eski kayıt içerde hükümlü var 
                {
                    sorgu = "Insert into depogiris (ilacid,personelid,hukumluid,ilacadet,odaid,kayittarihi) values (@ilacid,@personelid,@hukumluid,@ilacadet,@odaid,@kayittarihi)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ilacid", secilenilacid.ToString());
                    komut.Parameters.AddWithValue("@personelid", bilgisinif.personelid);
                    komut.Parameters.AddWithValue("@ilacadet", Convert.ToInt32(verilenadettextbox.Text));
                    komut.Parameters.AddWithValue("@kayittarihi", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@hukumluid", hukumlutabloid.ToString());
                    komut.Parameters.AddWithValue("@odaid", odacombobox.SelectedValue.ToString());
                    baglanti.Open();
                    if (komut.ExecuteNonQuery() == 1)//the insert succeded
                    {
                        MessageBox.Show("Kayıt Başarı Bir Şekilde Güncellendi");
                        baglanti.Close();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncelleme yapılmadı");
                    }
                }
                else if (hukumlutabloid == 0) // kayıt yok
                {

                }
                else
                {
                    MessageBox.Show("Hukumlu id kısmında hata var. Yönetici Başvur");
                }



            }
            else
            {
                MessageBox.Show("verileri kontrol edin");
            }
        }
        public void temizle()
        {
            dataGridView1.DataSource = null;
            da = new OleDbDataAdapter("Select * From ilac", baglanti);
            System.Data.DataTable tablo2 = new System.Data.DataTable();
            da.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
        
    }
}
