namespace Algoritma_ornek_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTekSayi = new System.Windows.Forms.Label();
            this.lblCiftSayi = new System.Windows.Forms.Label();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(149, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Tek Sayılar\r\n---------------------\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(492, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "   Çift Sayılar\r\n---------------------\r\n\r\n";
            // 
            // lblTekSayi
            // 
            this.lblTekSayi.AutoSize = true;
            this.lblTekSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTekSayi.Location = new System.Drawing.Point(207, 251);
            this.lblTekSayi.Name = "lblTekSayi";
            this.lblTekSayi.Size = new System.Drawing.Size(24, 26);
            this.lblTekSayi.TabIndex = 1;
            this.lblTekSayi.Text = "0";
            // 
            // lblCiftSayi
            // 
            this.lblCiftSayi.AutoSize = true;
            this.lblCiftSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiftSayi.Location = new System.Drawing.Point(564, 251);
            this.lblCiftSayi.Name = "lblCiftSayi";
            this.lblCiftSayi.Size = new System.Drawing.Size(24, 26);
            this.lblCiftSayi.TabIndex = 1;
            this.lblCiftSayi.Text = "0";
            // 
            // tbSayi
            // 
            this.tbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSayi.Location = new System.Drawing.Point(361, 50);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(155, 30);
            this.tbSayi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(259, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sayı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 573);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCiftSayi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTekSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTekSayi;
        private System.Windows.Forms.Label lblCiftSayi;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Label label5;
    }
}

