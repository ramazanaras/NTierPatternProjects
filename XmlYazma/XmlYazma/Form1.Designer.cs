namespace XmlYazma
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilmTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpYapimYili = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImdbPuani = new System.Windows.Forms.TextBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.listOyuncular = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDbToXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(30, 44);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(100, 20);
            this.txtFilmAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Turu";
            // 
            // cmbFilmTuru
            // 
            this.cmbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmTuru.FormattingEnabled = true;
            this.cmbFilmTuru.Items.AddRange(new object[] {
            "Aksiyon",
            "Gerilim",
            "Macera",
            "Komedi",
            "Bilim Kurgu",
            "Romantik",
            "Romantik Komedi",
            "Korku",
            "Dram"});
            this.cmbFilmTuru.Location = new System.Drawing.Point(152, 43);
            this.cmbFilmTuru.Name = "cmbFilmTuru";
            this.cmbFilmTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbFilmTuru.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yapım Yılı";
            // 
            // dtpYapimYili
            // 
            this.dtpYapimYili.CustomFormat = "yyyy";
            this.dtpYapimYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYapimYili.Location = new System.Drawing.Point(315, 44);
            this.dtpYapimYili.Name = "dtpYapimYili";
            this.dtpYapimYili.Size = new System.Drawing.Size(138, 20);
            this.dtpYapimYili.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yönetmen";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(475, 44);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(100, 20);
            this.txtYonetmen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IMDB Puanı";
            // 
            // txtImdbPuani
            // 
            this.txtImdbPuani.Location = new System.Drawing.Point(591, 43);
            this.txtImdbPuani.Name = "txtImdbPuani";
            this.txtImdbPuani.Size = new System.Drawing.Size(100, 20);
            this.txtImdbPuani.TabIndex = 4;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(709, 41);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(75, 23);
            this.btnFilmEkle.TabIndex = 5;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oyuncu Adı";
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(30, 120);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(147, 20);
            this.txtOyuncuAdi.TabIndex = 6;
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(30, 146);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(147, 23);
            this.btnOyuncuEkle.TabIndex = 7;
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // listOyuncular
            // 
            this.listOyuncular.FormattingEnabled = true;
            this.listOyuncular.Location = new System.Drawing.Point(30, 186);
            this.listOyuncular.Name = "listOyuncular";
            this.listOyuncular.Size = new System.Drawing.Size(147, 238);
            this.listOyuncular.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(202, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 304);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Türü";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapım Yılı";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IMDB Puanı";
            this.columnHeader5.Width = 218;
            // 
            // btnDbToXml
            // 
            this.btnDbToXml.Location = new System.Drawing.Point(709, 85);
            this.btnDbToXml.Name = "btnDbToXml";
            this.btnDbToXml.Size = new System.Drawing.Size(75, 23);
            this.btnDbToXml.TabIndex = 10;
            this.btnDbToXml.Text = "Db To Xml";
            this.btnDbToXml.UseVisualStyleBackColor = true;
            this.btnDbToXml.Click += new System.EventHandler(this.btnDbToXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 446);
            this.Controls.Add(this.btnDbToXml);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listOyuncular);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.txtImdbPuani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpYapimYili);
            this.Controls.Add(this.cmbFilmTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtOyuncuAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilmTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpYapimYili;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImdbPuani;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.ListBox listOyuncular;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDbToXml;
    }
}

