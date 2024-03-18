namespace _23MY03001_ODEV_NO_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.turkce_dogru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.turkce_yanlis = new System.Windows.Forms.TextBox();
            this.matematik_dogru = new System.Windows.Forms.TextBox();
            this.sosyal_dogru = new System.Windows.Forms.TextBox();
            this.matematik_yanlis = new System.Windows.Forms.TextBox();
            this.sosyal_yanlis = new System.Windows.Forms.TextBox();
            this.fen_dogru = new System.Windows.Forms.TextBox();
            this.fen_yanlis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.turkce_net_lbl = new System.Windows.Forms.Label();
            this.sosyal_net_lbl = new System.Windows.Forms.Label();
            this.matematik_net_lbl = new System.Windows.Forms.Label();
            this.fen_net_lbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matematik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(415, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sosyal Bilimleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(436, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fen Bilimleri";
            // 
            // turkce_dogru
            // 
            this.turkce_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkce_dogru.Location = new System.Drawing.Point(17, 74);
            this.turkce_dogru.Name = "turkce_dogru";
            this.turkce_dogru.Size = new System.Drawing.Size(121, 29);
            this.turkce_dogru.TabIndex = 4;
            this.turkce_dogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(199, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toplam net :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(271, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turkce_yanlis
            // 
            this.turkce_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkce_yanlis.Location = new System.Drawing.Point(160, 74);
            this.turkce_yanlis.Name = "turkce_yanlis";
            this.turkce_yanlis.Size = new System.Drawing.Size(121, 29);
            this.turkce_yanlis.TabIndex = 14;
            this.turkce_yanlis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matematik_dogru
            // 
            this.matematik_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematik_dogru.Location = new System.Drawing.Point(17, 228);
            this.matematik_dogru.Name = "matematik_dogru";
            this.matematik_dogru.Size = new System.Drawing.Size(121, 29);
            this.matematik_dogru.TabIndex = 15;
            this.matematik_dogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sosyal_dogru
            // 
            this.sosyal_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sosyal_dogru.Location = new System.Drawing.Point(358, 74);
            this.sosyal_dogru.Name = "sosyal_dogru";
            this.sosyal_dogru.Size = new System.Drawing.Size(121, 29);
            this.sosyal_dogru.TabIndex = 16;
            this.sosyal_dogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matematik_yanlis
            // 
            this.matematik_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematik_yanlis.Location = new System.Drawing.Point(159, 228);
            this.matematik_yanlis.Name = "matematik_yanlis";
            this.matematik_yanlis.Size = new System.Drawing.Size(121, 29);
            this.matematik_yanlis.TabIndex = 17;
            this.matematik_yanlis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sosyal_yanlis
            // 
            this.sosyal_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sosyal_yanlis.Location = new System.Drawing.Point(494, 74);
            this.sosyal_yanlis.Name = "sosyal_yanlis";
            this.sosyal_yanlis.Size = new System.Drawing.Size(121, 29);
            this.sosyal_yanlis.TabIndex = 18;
            // 
            // fen_dogru
            // 
            this.fen_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fen_dogru.Location = new System.Drawing.Point(358, 228);
            this.fen_dogru.Name = "fen_dogru";
            this.fen_dogru.Size = new System.Drawing.Size(121, 29);
            this.fen_dogru.TabIndex = 19;
            this.fen_dogru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fen_yanlis
            // 
            this.fen_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fen_yanlis.Location = new System.Drawing.Point(494, 228);
            this.fen_yanlis.Name = "fen_yanlis";
            this.fen_yanlis.Size = new System.Drawing.Size(121, 29);
            this.fen_yanlis.TabIndex = 20;
            this.fen_yanlis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Doğru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Doğru";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Doğru";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Doğru";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Yanlış";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Yanlış";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Yanlış";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(534, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Yanlış";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(320, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "___________";
            // 
            // turkce_net_lbl
            // 
            this.turkce_net_lbl.AutoSize = true;
            this.turkce_net_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkce_net_lbl.Location = new System.Drawing.Point(156, 120);
            this.turkce_net_lbl.Name = "turkce_net_lbl";
            this.turkce_net_lbl.Size = new System.Drawing.Size(95, 16);
            this.turkce_net_lbl.TabIndex = 30;
            this.turkce_net_lbl.Text = "___________";
            // 
            // sosyal_net_lbl
            // 
            this.sosyal_net_lbl.AutoSize = true;
            this.sosyal_net_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sosyal_net_lbl.Location = new System.Drawing.Point(492, 120);
            this.sosyal_net_lbl.Name = "sosyal_net_lbl";
            this.sosyal_net_lbl.Size = new System.Drawing.Size(95, 16);
            this.sosyal_net_lbl.TabIndex = 31;
            this.sosyal_net_lbl.Text = "___________";
            // 
            // matematik_net_lbl
            // 
            this.matematik_net_lbl.AutoSize = true;
            this.matematik_net_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matematik_net_lbl.Location = new System.Drawing.Point(157, 281);
            this.matematik_net_lbl.Name = "matematik_net_lbl";
            this.matematik_net_lbl.Size = new System.Drawing.Size(95, 16);
            this.matematik_net_lbl.TabIndex = 32;
            this.matematik_net_lbl.Text = "___________";
            // 
            // fen_net_lbl
            // 
            this.fen_net_lbl.AutoSize = true;
            this.fen_net_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fen_net_lbl.Location = new System.Drawing.Point(492, 281);
            this.fen_net_lbl.Name = "fen_net_lbl";
            this.fen_net_lbl.Size = new System.Drawing.Size(95, 16);
            this.fen_net_lbl.TabIndex = 33;
            this.fen_net_lbl.Text = "___________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(369, 279);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 18);
            this.label19.TabIndex = 34;
            this.label19.Text = "Fen Bilimleri Neti :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(36, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 18);
            this.label20.TabIndex = 35;
            this.label20.Text = "Matematik Neti :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(54, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 18);
            this.label21.TabIndex = 36;
            this.label21.Text = " Türkçe Neti :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(346, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 18);
            this.label22.TabIndex = 37;
            this.label22.Text = "Sosyal Bilimleri Neti :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.fen_net_lbl);
            this.Controls.Add(this.matematik_net_lbl);
            this.Controls.Add(this.sosyal_net_lbl);
            this.Controls.Add(this.turkce_net_lbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fen_yanlis);
            this.Controls.Add(this.fen_dogru);
            this.Controls.Add(this.sosyal_yanlis);
            this.Controls.Add(this.matematik_yanlis);
            this.Controls.Add(this.sosyal_dogru);
            this.Controls.Add(this.matematik_dogru);
            this.Controls.Add(this.turkce_yanlis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.turkce_dogru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Net Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox turkce_dogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox turkce_yanlis;
        private System.Windows.Forms.TextBox matematik_dogru;
        private System.Windows.Forms.TextBox sosyal_dogru;
        private System.Windows.Forms.TextBox matematik_yanlis;
        private System.Windows.Forms.TextBox sosyal_yanlis;
        private System.Windows.Forms.TextBox fen_dogru;
        private System.Windows.Forms.TextBox fen_yanlis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label turkce_net_lbl;
        private System.Windows.Forms.Label sosyal_net_lbl;
        private System.Windows.Forms.Label matematik_net_lbl;
        private System.Windows.Forms.Label fen_net_lbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

