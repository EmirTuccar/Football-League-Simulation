namespace Lig_siste4mi
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
            this.giris_btn = new System.Windows.Forms.Button();
            this.ayar_btn = new System.Windows.Forms.Button();
            this.hak_btn = new System.Windows.Forms.Button();
            this.cks_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.giris_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.giris_btn.Location = new System.Drawing.Point(528, 300);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(141, 52);
            this.giris_btn.TabIndex = 0;
            this.giris_btn.Text = "Lige Giriş";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // ayar_btn
            // 
            this.ayar_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ayar_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayar_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ayar_btn.Location = new System.Drawing.Point(528, 358);
            this.ayar_btn.Name = "ayar_btn";
            this.ayar_btn.Size = new System.Drawing.Size(141, 52);
            this.ayar_btn.TabIndex = 4;
            this.ayar_btn.Text = "Ayarlar";
            this.ayar_btn.UseVisualStyleBackColor = false;
            this.ayar_btn.Click += new System.EventHandler(this.ayar_btn_Click);
            // 
            // hak_btn
            // 
            this.hak_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.hak_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hak_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hak_btn.Location = new System.Drawing.Point(528, 416);
            this.hak_btn.Name = "hak_btn";
            this.hak_btn.Size = new System.Drawing.Size(141, 52);
            this.hak_btn.TabIndex = 5;
            this.hak_btn.Text = "Hakkında";
            this.hak_btn.UseVisualStyleBackColor = false;
            this.hak_btn.Click += new System.EventHandler(this.hak_btn_Click);
            // 
            // cks_btn
            // 
            this.cks_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cks_btn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cks_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cks_btn.Location = new System.Drawing.Point(528, 474);
            this.cks_btn.Name = "cks_btn";
            this.cks_btn.Size = new System.Drawing.Size(141, 52);
            this.cks_btn.TabIndex = 6;
            this.cks_btn.Text = "Çıkış";
            this.cks_btn.UseVisualStyleBackColor = false;
            this.cks_btn.Click += new System.EventHandler(this.cks_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lig_siste4mi.Properties.Resources.uefa_champions_league2;
            this.ClientSize = new System.Drawing.Size(1199, 629);
            this.Controls.Add(this.cks_btn);
            this.Controls.Add(this.hak_btn);
            this.Controls.Add(this.ayar_btn);
            this.Controls.Add(this.giris_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Button ayar_btn;
        private System.Windows.Forms.Button hak_btn;
        private System.Windows.Forms.Button cks_btn;
    }
}

