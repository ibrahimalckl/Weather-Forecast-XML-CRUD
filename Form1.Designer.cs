
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
            this.bYaz = new System.Windows.Forms.Button();
            this.lVeri = new System.Windows.Forms.ListBox();
            this.bDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bYaz
            // 
            this.bYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYaz.Location = new System.Drawing.Point(77, 48);
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
            this.lVeri.Location = new System.Drawing.Point(289, 48);
            this.lVeri.Name = "lVeri";
            this.lVeri.Size = new System.Drawing.Size(499, 388);
            this.lVeri.TabIndex = 1;
            // 
            // bDownload
            // 
            this.bDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDownload.Location = new System.Drawing.Point(77, 140);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(154, 51);
            this.bDownload.TabIndex = 2;
            this.bDownload.Text = "Veri İndir";
            this.bDownload.UseVisualStyleBackColor = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // fHavaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

