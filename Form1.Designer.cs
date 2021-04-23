
namespace havadurumu_ia
{
    partial class fHavaDurumu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bYaz = new System.Windows.Forms.Button();
            this.lVeri = new System.Windows.Forms.ListBox();
            this.bDownload = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lTarih = new System.Windows.Forms.Label();
            this.lSaat = new System.Windows.Forms.Label();
            this.lSayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bYaz
            // 
            this.bYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYaz.Location = new System.Drawing.Point(77, 80);
            this.bYaz.Name = "bYaz";
            this.bYaz.Size = new System.Drawing.Size(154, 50);
            this.bYaz.TabIndex = 0;
            this.bYaz.Text = "Veri Yaz";
            this.bYaz.UseVisualStyleBackColor = true;
            this.bYaz.Click += new System.EventHandler(this.bYaz_Click);
            // 
            // lVeri
            // 
            this.lVeri.FormattingEnabled = true;
            this.lVeri.ItemHeight = 16;
            this.lVeri.Location = new System.Drawing.Point(289, 80);
            this.lVeri.Name = "lVeri";
            this.lVeri.Size = new System.Drawing.Size(499, 356);
            this.lVeri.TabIndex = 1;
            // 
            // bDownload
            // 
            this.bDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDownload.Location = new System.Drawing.Point(77, 171);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(154, 51);
            this.bDownload.TabIndex = 2;
            this.bDownload.Text = "Veri İndir";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lTarih
            // 
            this.lTarih.AutoSize = true;
            this.lTarih.Location = new System.Drawing.Point(633, 9);
            this.lTarih.Name = "lTarih";
            this.lTarih.Size = new System.Drawing.Size(0, 17);
            this.lTarih.TabIndex = 3;
            this.lTarih.Click += new System.EventHandler(this.lTarih_Click);
            // 
            // lSaat
            // 
            this.lSaat.AutoSize = true;
            this.lSaat.Location = new System.Drawing.Point(633, 41);
            this.lSaat.Name = "lSaat";
            this.lSaat.Size = new System.Drawing.Size(0, 17);
            this.lSaat.TabIndex = 4;
            this.lSaat.Click += new System.EventHandler(this.lSaat_Click);
            // 
            // lSayac
            // 
            this.lSayac.AutoSize = true;
            this.lSayac.Location = new System.Drawing.Point(500, 9);
            this.lSayac.Name = "lSayac";
            this.lSayac.Size = new System.Drawing.Size(0, 17);
            this.lSayac.TabIndex = 6;
            this.lSayac.Visible = false;
            this.lSayac.Click += new System.EventHandler(this.lSayac_Click);
            // 
            // fHavaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSayac);
            this.Controls.Add(this.lSaat);
            this.Controls.Add(this.lTarih);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.lVeri);
            this.Controls.Add(this.bYaz);
            this.Name = "fHavaDurumu";
            this.Text = "Hava Durumu";
            this.Load += new System.EventHandler(this.fHavaDurumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bYaz;
        private System.Windows.Forms.ListBox lVeri;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lTarih;
        private System.Windows.Forms.Label lSaat;
        private System.Windows.Forms.Label lSayac;
    }
}

