namespace OtelOtomasyonu.WinFormUI
{
    partial class OzelliklerForm
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.Açıklama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(140, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(140, 44);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(162, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(140, 71);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(162, 20);
            this.txtAciklama.TabIndex = 2;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(79, 44);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(22, 13);
            this.ad.TabIndex = 3;
            this.ad.Text = "Adı";
            // 
            // Açıklama
            // 
            this.Açıklama.AutoSize = true;
            this.Açıklama.Location = new System.Drawing.Point(82, 77);
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.Size = new System.Drawing.Size(50, 13);
            this.Açıklama.TabIndex = 4;
            this.Açıklama.Text = "Açıklama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 165);
            this.dataGridView1.TabIndex = 5;
            // 
            // OzelliklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Açıklama);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnEkle);
            this.Name = "OzelliklerForm";
            this.Text = "OzelliklerForm";
            this.Load += new System.EventHandler(this.OzelliklerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label Açıklama;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}