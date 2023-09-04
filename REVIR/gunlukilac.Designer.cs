namespace REVIR
{
    partial class gunlukilac
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Eklebuton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Kaydetbuton = new System.Windows.Forms.Button();
            this.odacombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(494, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(447, 313);
            this.dataGridView2.TabIndex = 1;
            // 
            // Eklebuton
            // 
            this.Eklebuton.Location = new System.Drawing.Point(413, 54);
            this.Eklebuton.Name = "Eklebuton";
            this.Eklebuton.Size = new System.Drawing.Size(75, 53);
            this.Eklebuton.TabIndex = 2;
            this.Eklebuton.Text = "Ekle";
            this.Eklebuton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Kaydetbuton
            // 
            this.Kaydetbuton.Location = new System.Drawing.Point(816, 354);
            this.Kaydetbuton.Name = "Kaydetbuton";
            this.Kaydetbuton.Size = new System.Drawing.Size(101, 54);
            this.Kaydetbuton.TabIndex = 4;
            this.Kaydetbuton.Text = "KAYDET";
            this.Kaydetbuton.UseVisualStyleBackColor = true;
            this.Kaydetbuton.Click += new System.EventHandler(this.Kaydetbuton_Click);
            // 
            // odacombobox
            // 
            this.odacombobox.FormattingEnabled = true;
            this.odacombobox.Location = new System.Drawing.Point(574, 8);
            this.odacombobox.Name = "odacombobox";
            this.odacombobox.Size = new System.Drawing.Size(121, 21);
            this.odacombobox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // gunlukilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odacombobox);
            this.Controls.Add(this.Kaydetbuton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Eklebuton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gunlukilac";
            this.Text = "gunlukilac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gunlukilac_FormClosed);
            this.Load += new System.EventHandler(this.gunlukilac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Eklebuton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Kaydetbuton;
        private System.Windows.Forms.ComboBox odacombobox;
        private System.Windows.Forms.Label label1;
    }
}