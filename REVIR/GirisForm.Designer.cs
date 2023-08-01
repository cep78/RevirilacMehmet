namespace REVIR
{
    partial class GirisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.girisFormuGrupKutusu = new System.Windows.Forms.GroupBox();
            this.kapatDugmesi = new System.Windows.Forms.Button();
            this.girisDugmesi = new System.Windows.Forms.Button();
            this.sifreMetinKutusu = new System.Windows.Forms.TextBox();
            this.kullaniciAdiMetinKutusu = new System.Windows.Forms.TextBox();
            this.sifreEtiketi = new System.Windows.Forms.Label();
            this.kullaniciAdiEtiketi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisFormuGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisFormuGrupKutusu
            // 
            this.girisFormuGrupKutusu.BackColor = System.Drawing.Color.Transparent;
            this.girisFormuGrupKutusu.Controls.Add(this.kapatDugmesi);
            this.girisFormuGrupKutusu.Controls.Add(this.girisDugmesi);
            this.girisFormuGrupKutusu.Controls.Add(this.sifreMetinKutusu);
            this.girisFormuGrupKutusu.Controls.Add(this.kullaniciAdiMetinKutusu);
            this.girisFormuGrupKutusu.Controls.Add(this.sifreEtiketi);
            this.girisFormuGrupKutusu.Controls.Add(this.kullaniciAdiEtiketi);
            this.girisFormuGrupKutusu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.girisFormuGrupKutusu.Location = new System.Drawing.Point(273, 36);
            this.girisFormuGrupKutusu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.girisFormuGrupKutusu.Name = "girisFormuGrupKutusu";
            this.girisFormuGrupKutusu.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.girisFormuGrupKutusu.Size = new System.Drawing.Size(553, 228);
            this.girisFormuGrupKutusu.TabIndex = 7;
            this.girisFormuGrupKutusu.TabStop = false;
            this.girisFormuGrupKutusu.Text = "Revir İlaç Takip: Giriş";
            this.girisFormuGrupKutusu.Enter += new System.EventHandler(this.girisFormuGrupKutusu_Enter);
            // 
            // kapatDugmesi
            // 
            this.kapatDugmesi.BackColor = System.Drawing.Color.DarkRed;
            this.kapatDugmesi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kapatDugmesi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kapatDugmesi.FlatAppearance.BorderSize = 0;
            this.kapatDugmesi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.kapatDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatDugmesi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapatDugmesi.Location = new System.Drawing.Point(123, 136);
            this.kapatDugmesi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kapatDugmesi.Name = "kapatDugmesi";
            this.kapatDugmesi.Size = new System.Drawing.Size(170, 80);
            this.kapatDugmesi.TabIndex = 3;
            this.kapatDugmesi.Text = "KAPAT";
            this.kapatDugmesi.UseVisualStyleBackColor = false;
            this.kapatDugmesi.Click += new System.EventHandler(this.kapatDugmesi_Click);
            // 
            // girisDugmesi
            // 
            this.girisDugmesi.BackColor = System.Drawing.Color.SteelBlue;
            this.girisDugmesi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.girisDugmesi.FlatAppearance.BorderSize = 0;
            this.girisDugmesi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.girisDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisDugmesi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisDugmesi.Location = new System.Drawing.Point(371, 136);
            this.girisDugmesi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.girisDugmesi.Name = "girisDugmesi";
            this.girisDugmesi.Size = new System.Drawing.Size(170, 80);
            this.girisDugmesi.TabIndex = 2;
            this.girisDugmesi.Text = "GİRİŞ";
            this.girisDugmesi.UseVisualStyleBackColor = false;
            this.girisDugmesi.Click += new System.EventHandler(this.girisDugmesi_Click);
            // 
            // sifreMetinKutusu
            // 
            this.sifreMetinKutusu.Location = new System.Drawing.Point(123, 98);
            this.sifreMetinKutusu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sifreMetinKutusu.Name = "sifreMetinKutusu";
            this.sifreMetinKutusu.PasswordChar = '*';
            this.sifreMetinKutusu.Size = new System.Drawing.Size(418, 26);
            this.sifreMetinKutusu.TabIndex = 1;
            // 
            // kullaniciAdiMetinKutusu
            // 
            this.kullaniciAdiMetinKutusu.Location = new System.Drawing.Point(123, 60);
            this.kullaniciAdiMetinKutusu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kullaniciAdiMetinKutusu.Name = "kullaniciAdiMetinKutusu";
            this.kullaniciAdiMetinKutusu.Size = new System.Drawing.Size(418, 26);
            this.kullaniciAdiMetinKutusu.TabIndex = 0;
            // 
            // sifreEtiketi
            // 
            this.sifreEtiketi.AutoSize = true;
            this.sifreEtiketi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifreEtiketi.Location = new System.Drawing.Point(14, 101);
            this.sifreEtiketi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sifreEtiketi.Name = "sifreEtiketi";
            this.sifreEtiketi.Size = new System.Drawing.Size(46, 20);
            this.sifreEtiketi.TabIndex = 0;
            this.sifreEtiketi.Text = "Şifre:";
            // 
            // kullaniciAdiEtiketi
            // 
            this.kullaniciAdiEtiketi.AutoSize = true;
            this.kullaniciAdiEtiketi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciAdiEtiketi.Location = new System.Drawing.Point(14, 63);
            this.kullaniciAdiEtiketi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kullaniciAdiEtiketi.Name = "kullaniciAdiEtiketi";
            this.kullaniciAdiEtiketi.Size = new System.Drawing.Size(97, 20);
            this.kullaniciAdiEtiketi.TabIndex = 0;
            this.kullaniciAdiEtiketi.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REVIR.Properties.Resources.drug;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GirisForm
            // 
            this.AcceptButton = this.girisDugmesi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kapatDugmesi;
            this.ClientSize = new System.Drawing.Size(841, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisFormuGrupKutusu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revir İlaç Takip: Giriş";
            this.girisFormuGrupKutusu.ResumeLayout(false);
            this.girisFormuGrupKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox girisFormuGrupKutusu;
        private System.Windows.Forms.Button kapatDugmesi;
        private System.Windows.Forms.Button girisDugmesi;
        private System.Windows.Forms.TextBox sifreMetinKutusu;
        private System.Windows.Forms.TextBox kullaniciAdiMetinKutusu;
        private System.Windows.Forms.Label sifreEtiketi;
        private System.Windows.Forms.Label kullaniciAdiEtiketi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}