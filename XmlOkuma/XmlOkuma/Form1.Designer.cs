namespace XmlOkuma
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
            this.listBasliklar = new System.Windows.Forms.ListBox();
            this.listAciklamalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBasliklar
            // 
            this.listBasliklar.FormattingEnabled = true;
            this.listBasliklar.Location = new System.Drawing.Point(12, 71);
            this.listBasliklar.Name = "listBasliklar";
            this.listBasliklar.Size = new System.Drawing.Size(209, 316);
            this.listBasliklar.TabIndex = 0;
            this.listBasliklar.SelectedIndexChanged += new System.EventHandler(this.listBasliklar_SelectedIndexChanged);
            // 
            // listAciklamalar
            // 
            this.listAciklamalar.FormattingEnabled = true;
            this.listAciklamalar.Location = new System.Drawing.Point(268, 71);
            this.listAciklamalar.Name = "listAciklamalar";
            this.listAciklamalar.Size = new System.Drawing.Size(364, 316);
            this.listAciklamalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haber Başlıkları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Haber Detayı";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(217, 9);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(35, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 404);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAciklamalar);
            this.Controls.Add(this.listBasliklar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBasliklar;
        private System.Windows.Forms.ListBox listAciklamalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAciklama;
    }
}

