namespace _0_dan_başlayıp_sayıları_toplama_100den_fazlaolduğunda_kaç_kez_olduğunu_söyleyen_program
{
    partial class Form1
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
            this.btnkackezcalisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkackezcalisti
            // 
            this.btnkackezcalisti.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkackezcalisti.Location = new System.Drawing.Point(309, 47);
            this.btnkackezcalisti.Name = "btnkackezcalisti";
            this.btnkackezcalisti.Size = new System.Drawing.Size(811, 468);
            this.btnkackezcalisti.TabIndex = 0;
            this.btnkackezcalisti.Text = "Kaç Kez Çalıştı?";
            this.btnkackezcalisti.UseVisualStyleBackColor = true;
            this.btnkackezcalisti.Click += new System.EventHandler(this.btnkackezcalisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 600);
            this.Controls.Add(this.btnkackezcalisti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkackezcalisti;
    }
}

