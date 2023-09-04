namespace REVIR
{
    partial class htilactakip
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hukumlutctext = new System.Windows.Forms.TextBox();
            this.tcarabuton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hukumlubilgipanel = new System.Windows.Forms.Panel();
            this.dosyaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcno = new System.Windows.Forms.TextBox();
            this.hadisoyadi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.odacombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.secContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ogundekullanimadettext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ogunsayisicombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ilacbaslangictarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.yazilanadettextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Secilenilacdozu = new System.Windows.Forms.TextBox();
            this.Secilanilacadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ilacbitistarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.hukumlubilgipanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.secContextMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "H/T Tc";
            // 
            // hukumlutctext
            // 
            this.hukumlutctext.Location = new System.Drawing.Point(52, 12);
            this.hukumlutctext.MaxLength = 11;
            this.hukumlutctext.Name = "hukumlutctext";
            this.hukumlutctext.Size = new System.Drawing.Size(139, 20);
            this.hukumlutctext.TabIndex = 1;
            this.hukumlutctext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.hukumlutctext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hukumlutctext_KeyPress);
            // 
            // tcarabuton
            // 
            this.tcarabuton.Location = new System.Drawing.Point(197, 12);
            this.tcarabuton.Name = "tcarabuton";
            this.tcarabuton.Size = new System.Drawing.Size(75, 23);
            this.tcarabuton.TabIndex = 2;
            this.tcarabuton.Text = "Tc No Ara";
            this.tcarabuton.UseVisualStyleBackColor = true;
            this.tcarabuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tcarabuton);
            this.panel1.Controls.Add(this.hukumlutctext);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 49);
            this.panel1.TabIndex = 3;
            // 
            // hukumlubilgipanel
            // 
            this.hukumlubilgipanel.Controls.Add(this.dosyaid);
            this.hukumlubilgipanel.Controls.Add(this.label3);
            this.hukumlubilgipanel.Controls.Add(this.label8);
            this.hukumlubilgipanel.Controls.Add(this.label5);
            this.hukumlubilgipanel.Controls.Add(this.label4);
            this.hukumlubilgipanel.Controls.Add(this.tcno);
            this.hukumlubilgipanel.Controls.Add(this.hadisoyadi);
            this.hukumlubilgipanel.Enabled = false;
            this.hukumlubilgipanel.Location = new System.Drawing.Point(12, 68);
            this.hukumlubilgipanel.Name = "hukumlubilgipanel";
            this.hukumlubilgipanel.Size = new System.Drawing.Size(291, 90);
            this.hukumlubilgipanel.TabIndex = 4;
            // 
            // dosyaid
            // 
            this.dosyaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosyaid.Location = new System.Drawing.Point(72, 53);
            this.dosyaid.MaxLength = 30;
            this.dosyaid.Name = "dosyaid";
            this.dosyaid.Size = new System.Drawing.Size(184, 20);
            this.dosyaid.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "TC No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dosya id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adı";
            // 
            // tcno
            // 
            this.tcno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tcno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcno.Enabled = false;
            this.tcno.Location = new System.Drawing.Point(72, 6);
            this.tcno.MaxLength = 11;
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(184, 20);
            this.tcno.TabIndex = 21;
            // 
            // hadisoyadi
            // 
            this.hadisoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hadisoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hadisoyadi.Location = new System.Drawing.Point(72, 29);
            this.hadisoyadi.MaxLength = 30;
            this.hadisoyadi.Name = "hadisoyadi";
            this.hadisoyadi.Size = new System.Drawing.Size(184, 20);
            this.hadisoyadi.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.odacombobox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 55);
            this.panel3.TabIndex = 5;
            // 
            // odacombobox
            // 
            this.odacombobox.FormattingEnabled = true;
            this.odacombobox.Location = new System.Drawing.Point(72, 11);
            this.odacombobox.Name = "odacombobox";
            this.odacombobox.Size = new System.Drawing.Size(184, 21);
            this.odacombobox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda/Koğuş";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.secContextMenuStrip;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 438);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // secContextMenuStrip
            // 
            this.secContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem});
            this.secContextMenuStrip.Name = "secContextMenuStrip";
            this.secContextMenuStrip.Size = new System.Drawing.Size(93, 26);
            this.secContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.secToolStripMenuItem.Text = "Sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(309, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 444);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ilacbitistarihi);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.ogundekullanimadettext);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.ogunsayisicombo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.ilacbaslangictarihi);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.yazilanadettextbox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(759, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 441);
            this.panel4.TabIndex = 9;
            // 
            // ogundekullanimadettext
            // 
            this.ogundekullanimadettext.Location = new System.Drawing.Point(152, 40);
            this.ogundekullanimadettext.MaxLength = 1;
            this.ogundekullanimadettext.Name = "ogundekullanimadettext";
            this.ogundekullanimadettext.Size = new System.Drawing.Size(100, 20);
            this.ogundekullanimadettext.TabIndex = 25;
            this.ogundekullanimadettext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Öğündeki Kullanım Adedi";
            // 
            // ogunsayisicombo
            // 
            this.ogunsayisicombo.FormattingEnabled = true;
            this.ogunsayisicombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ogunsayisicombo.Location = new System.Drawing.Point(152, 8);
            this.ogunsayisicombo.Name = "ogunsayisicombo";
            this.ogunsayisicombo.Size = new System.Drawing.Size(100, 21);
            this.ogunsayisicombo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Öğün Sayısı";
            // 
            // ilacbaslangictarihi
            // 
            this.ilacbaslangictarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ilacbaslangictarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ilacbaslangictarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ilacbaslangictarihi.Location = new System.Drawing.Point(152, 111);
            this.ilacbaslangictarihi.Name = "ilacbaslangictarihi";
            this.ilacbaslangictarihi.Size = new System.Drawing.Size(100, 20);
            this.ilacbaslangictarihi.TabIndex = 21;
            this.ilacbaslangictarihi.Value = new System.DateTime(2023, 5, 28, 14, 35, 30, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "İlacın basladığı Tarih";
            // 
            // yazilanadettextbox
            // 
            this.yazilanadettextbox.Location = new System.Drawing.Point(152, 77);
            this.yazilanadettextbox.MaxLength = 2;
            this.yazilanadettextbox.Name = "yazilanadettextbox";
            this.yazilanadettextbox.Size = new System.Drawing.Size(100, 20);
            this.yazilanadettextbox.TabIndex = 7;
            this.yazilanadettextbox.TextChanged += new System.EventHandler(this.verilenadettextbox_TextChanged);
            this.yazilanadettextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verilenadettextbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "H-T Yazılan İlac Adedi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Secilenilacdozu);
            this.groupBox1.Controls.Add(this.Secilanilacadi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secilen İlac Bilgi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "İlac Dozu";
            // 
            // Secilenilacdozu
            // 
            this.Secilenilacdozu.Enabled = false;
            this.Secilenilacdozu.Location = new System.Drawing.Point(72, 59);
            this.Secilenilacdozu.Name = "Secilenilacdozu";
            this.Secilenilacdozu.Size = new System.Drawing.Size(184, 20);
            this.Secilenilacdozu.TabIndex = 2;
            // 
            // Secilanilacadi
            // 
            this.Secilanilacadi.Enabled = false;
            this.Secilanilacadi.Location = new System.Drawing.Point(72, 20);
            this.Secilanilacadi.Name = "Secilanilacadi";
            this.Secilanilacadi.Size = new System.Drawing.Size(184, 20);
            this.Secilanilacadi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "İlac Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "İlacın bitiş Tarih";
            // 
            // ilacbitistarihi
            // 
            this.ilacbitistarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ilacbitistarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ilacbitistarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ilacbitistarihi.Location = new System.Drawing.Point(152, 146);
            this.ilacbitistarihi.Name = "ilacbitistarihi";
            this.ilacbitistarihi.Size = new System.Drawing.Size(100, 20);
            this.ilacbitistarihi.TabIndex = 27;
            this.ilacbitistarihi.Value = new System.DateTime(2023, 5, 28, 14, 35, 30, 0);
            // 
            // htilactakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hukumlubilgipanel);
            this.Controls.Add(this.panel1);
            this.Name = "htilactakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "htilactakip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.htilactakip_FormClosed);
            this.Load += new System.EventHandler(this.htilactakip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hukumlubilgipanel.ResumeLayout(false);
            this.hukumlubilgipanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.secContextMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hukumlutctext;
        private System.Windows.Forms.Button tcarabuton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hukumlubilgipanel;
        private System.Windows.Forms.TextBox dosyaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.TextBox hadisoyadi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox odacombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox yazilanadettextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip secContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Secilenilacdozu;
        private System.Windows.Forms.TextBox Secilanilacadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ilacbaslangictarihi;
        private System.Windows.Forms.TextBox ogundekullanimadettext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ogunsayisicombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ilacbitistarihi;
        private System.Windows.Forms.Label label13;
    }
}