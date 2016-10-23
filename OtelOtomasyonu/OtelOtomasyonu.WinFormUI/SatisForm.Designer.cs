namespace OtelOtomasyonu.WinFormUI
{
    partial class SatisForm
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
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.nudOdaFiyati = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSatisaEkle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUrunMiktari = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 50);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda";
            // 
            // cmbOda
            // 
            this.cmbOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(139, 50);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(121, 21);
            this.cmbOda.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 334);
            this.dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Fiyatı";
            // 
            // nudOdaFiyati
            // 
            this.nudOdaFiyati.Location = new System.Drawing.Point(266, 51);
            this.nudOdaFiyati.Name = "nudOdaFiyati";
            this.nudOdaFiyati.Size = new System.Drawing.Size(120, 20);
            this.nudOdaFiyati.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Fiyati";
            // 
            // nudUrunFiyati
            // 
            this.nudUrunFiyati.Location = new System.Drawing.Point(346, 239);
            this.nudUrunFiyati.Name = "nudUrunFiyati";
            this.nudUrunFiyati.Size = new System.Drawing.Size(120, 20);
            this.nudUrunFiyati.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "İndirim";
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(348, 309);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(120, 20);
            this.nudIndirim.TabIndex = 8;
            // 
            // btnSatisaEkle
            // 
            this.btnSatisaEkle.Location = new System.Drawing.Point(348, 348);
            this.btnSatisaEkle.Name = "btnSatisaEkle";
            this.btnSatisaEkle.Size = new System.Drawing.Size(100, 23);
            this.btnSatisaEkle.TabIndex = 9;
            this.btnSatisaEkle.Text = "Satışa Ekle";
            this.btnSatisaEkle.UseVisualStyleBackColor = true;
            this.btnSatisaEkle.Click += new System.EventHandler(this.btnSatisaEkle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(471, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 302);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra No:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Indirim:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(620, 412);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 43);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Miktari";
            // 
            // nudUrunMiktari
            // 
            this.nudUrunMiktari.Location = new System.Drawing.Point(345, 176);
            this.nudUrunMiktari.Name = "nudUrunMiktari";
            this.nudUrunMiktari.Size = new System.Drawing.Size(120, 20);
            this.nudUrunMiktari.TabIndex = 6;
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 477);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSatisaEkle);
            this.Controls.Add(this.nudIndirim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudUrunFiyati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudUrunMiktari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudOdaFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudOdaFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudUrunFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudIndirim;
        private System.Windows.Forms.Button btnSatisaEkle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudUrunMiktari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}