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
            this.girisFormuGrupKutusu = new System.Windows.Forms.GroupBox();
            this.kapatDugmesi = new System.Windows.Forms.Button();
            this.girisDugmesi = new System.Windows.Forms.Button();
            this.sifreMetinKutusu = new System.Windows.Forms.TextBox();
            this.kullaniciAdiMetinKutusu = new System.Windows.Forms.TextBox();
            this.sifreEtiketi = new System.Windows.Forms.Label();
            this.kullaniciAdiEtiketi = new System.Windows.Forms.Label();
            this.girisFormuGrupKutusu.SuspendLayout();
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
            this.girisFormuGrupKutusu.Location = new System.Drawing.Point(13, 13);
            this.girisFormuGrupKutusu.Margin = new System.Windows.Forms.Padding(4);
            this.girisFormuGrupKutusu.Name = "girisFormuGrupKutusu";
            this.girisFormuGrupKutusu.Padding = new System.Windows.Forms.Padding(4);
            this.girisFormuGrupKutusu.Size = new System.Drawing.Size(444, 182);
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
            this.kapatDugmesi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapatDugmesi.Location = new System.Drawing.Point(141, 119);
            this.kapatDugmesi.Margin = new System.Windows.Forms.Padding(4);
            this.kapatDugmesi.Name = "kapatDugmesi";
            this.kapatDugmesi.Size = new System.Drawing.Size(113, 52);
            this.kapatDugmesi.TabIndex = 3;
            this.kapatDugmesi.Text = "KAPAT";
            this.kapatDugmesi.UseVisualStyleBackColor = false;
            // 
            // girisDugmesi
            // 
            this.girisDugmesi.BackColor = System.Drawing.Color.SteelBlue;
            this.girisDugmesi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.girisDugmesi.FlatAppearance.BorderSize = 0;
            this.girisDugmesi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.girisDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisDugmesi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.girisDugmesi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisDugmesi.Location = new System.Drawing.Point(309, 119);
            this.girisDugmesi.Margin = new System.Windows.Forms.Padding(4);
            this.girisDugmesi.Name = "girisDugmesi";
            this.girisDugmesi.Size = new System.Drawing.Size(113, 52);
            this.girisDugmesi.TabIndex = 2;
            this.girisDugmesi.Text = "GİRİŞ";
            this.girisDugmesi.UseVisualStyleBackColor = false;
            this.girisDugmesi.Click += new System.EventHandler(this.girisDugmesi_Click);
            // 
            // sifreMetinKutusu
            // 
            this.sifreMetinKutusu.Location = new System.Drawing.Point(141, 73);
            this.sifreMetinKutusu.Margin = new System.Windows.Forms.Padding(4);
            this.sifreMetinKutusu.Name = "sifreMetinKutusu";
            this.sifreMetinKutusu.PasswordChar = '*';
            this.sifreMetinKutusu.Size = new System.Drawing.Size(280, 20);
            this.sifreMetinKutusu.TabIndex = 1;
            // 
            // kullaniciAdiMetinKutusu
            // 
            this.kullaniciAdiMetinKutusu.Location = new System.Drawing.Point(141, 37);
            this.kullaniciAdiMetinKutusu.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiMetinKutusu.Name = "kullaniciAdiMetinKutusu";
            this.kullaniciAdiMetinKutusu.Size = new System.Drawing.Size(280, 20);
            this.kullaniciAdiMetinKutusu.TabIndex = 0;
            // 
            // sifreEtiketi
            // 
            this.sifreEtiketi.AutoSize = true;
            this.sifreEtiketi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sifreEtiketi.Location = new System.Drawing.Point(9, 77);
            this.sifreEtiketi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifreEtiketi.Name = "sifreEtiketi";
            this.sifreEtiketi.Size = new System.Drawing.Size(31, 13);
            this.sifreEtiketi.TabIndex = 0;
            this.sifreEtiketi.Text = "Şifre:";
            // 
            // kullaniciAdiEtiketi
            // 
            this.kullaniciAdiEtiketi.AutoSize = true;
            this.kullaniciAdiEtiketi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciAdiEtiketi.Location = new System.Drawing.Point(9, 41);
            this.kullaniciAdiEtiketi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullaniciAdiEtiketi.Name = "kullaniciAdiEtiketi";
            this.kullaniciAdiEtiketi.Size = new System.Drawing.Size(67, 13);
            this.kullaniciAdiEtiketi.TabIndex = 0;
            this.kullaniciAdiEtiketi.Text = "Kullanıcı Adı:";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 199);
            this.Controls.Add(this.girisFormuGrupKutusu);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.girisFormuGrupKutusu.ResumeLayout(false);
            this.girisFormuGrupKutusu.PerformLayout();
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
    }
}