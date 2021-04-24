
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
            this.bDownload = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lTarih = new System.Windows.Forms.Label();
            this.lSaat = new System.Windows.Forms.Label();
            this.lSayac = new System.Windows.Forms.Label();
            this.dVeri = new System.Windows.Forms.DataGridView();
            this.bGuncelleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // bYaz
            // 
            this.bYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYaz.Location = new System.Drawing.Point(25, 116);
            this.bYaz.Name = "bYaz";
            this.bYaz.Size = new System.Drawing.Size(154, 50);
            this.bYaz.TabIndex = 0;
            this.bYaz.Text = "Veri Yaz";
            this.bYaz.UseVisualStyleBackColor = true;
            this.bYaz.Click += new System.EventHandler(this.bYaz_Click);
            // 
            // bDownload
            // 
            this.bDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDownload.Location = new System.Drawing.Point(25, 200);
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
            this.lTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lTarih.Location = new System.Drawing.Point(21, 9);
            this.lTarih.Name = "lTarih";
            this.lTarih.Size = new System.Drawing.Size(0, 24);
            this.lTarih.TabIndex = 3;
            this.lTarih.Click += new System.EventHandler(this.lTarih_Click);
            // 
            // lSaat
            // 
            this.lSaat.AutoSize = true;
            this.lSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSaat.Location = new System.Drawing.Point(20, 44);
            this.lSaat.Name = "lSaat";
            this.lSaat.Size = new System.Drawing.Size(0, 25);
            this.lSaat.TabIndex = 4;
            this.lSaat.Click += new System.EventHandler(this.lSaat_Click);
            // 
            // lSayac
            // 
            this.lSayac.AutoSize = true;
            this.lSayac.Location = new System.Drawing.Point(12, 470);
            this.lSayac.Name = "lSayac";
            this.lSayac.Size = new System.Drawing.Size(45, 17);
            this.lSayac.TabIndex = 6;
            this.lSayac.Text = "sayac";
            this.lSayac.Visible = false;
            this.lSayac.Click += new System.EventHandler(this.lSayac_Click);
            // 
            // dVeri
            // 
            this.dVeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dVeri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dVeri.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dVeri.Location = new System.Drawing.Point(252, 9);
            this.dVeri.Name = "dVeri";
            this.dVeri.RowHeadersVisible = false;
            this.dVeri.RowHeadersWidth = 51;
            this.dVeri.RowTemplate.Height = 24;
            this.dVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dVeri.Size = new System.Drawing.Size(849, 529);
            this.dVeri.TabIndex = 7;
            // 
            // bGuncelleme
            // 
            this.bGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGuncelleme.Location = new System.Drawing.Point(25, 283);
            this.bGuncelleme.Name = "bGuncelleme";
            this.bGuncelleme.Size = new System.Drawing.Size(154, 51);
            this.bGuncelleme.TabIndex = 8;
            this.bGuncelleme.Text = "Veri Kontrol";
            this.bGuncelleme.UseVisualStyleBackColor = true;
            this.bGuncelleme.Click += new System.EventHandler(this.bGuncelleme_Click);
            // 
            // fHavaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.bGuncelleme);
            this.Controls.Add(this.dVeri);
            this.Controls.Add(this.lSayac);
            this.Controls.Add(this.lSaat);
            this.Controls.Add(this.lTarih);
            this.Controls.Add(this.bDownload);
            this.Controls.Add(this.bYaz);
            this.Name = "fHavaDurumu";
            this.Text = "Hava Durumu";
            this.Load += new System.EventHandler(this.fHavaDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bYaz;
        private System.Windows.Forms.Button bDownload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lTarih;
        private System.Windows.Forms.Label lSaat;
        private System.Windows.Forms.Label lSayac;
        private System.Windows.Forms.DataGridView dVeri;
        private System.Windows.Forms.Button bGuncelleme;
    }
}

