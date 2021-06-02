
namespace Diyetisyen_Uygulamasi
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.GirisYapBTN = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("X-Files", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("X-Files", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre :";
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(311, 55);
            this.KullaniciAdiTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(161, 22);
            this.KullaniciAdiTB.TabIndex = 2;
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(311, 124);
            this.SifreTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(161, 22);
            this.SifreTB.TabIndex = 3;
            // 
            // GirisYapBTN
            // 
            this.GirisYapBTN.Font = new System.Drawing.Font("X-Files", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisYapBTN.Location = new System.Drawing.Point(249, 235);
            this.GirisYapBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GirisYapBTN.Name = "GirisYapBTN";
            this.GirisYapBTN.Size = new System.Drawing.Size(299, 65);
            this.GirisYapBTN.TabIndex = 4;
            this.GirisYapBTN.Text = "Giris Yap";
            this.GirisYapBTN.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("X-Files", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(539, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(199, 18);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Admin Olarak Giris Yap ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("X-Files", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(539, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(228, 18);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Diyetisyen Olarak Giris Yap";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 396);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.GirisYapBTN);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Button GirisYapBTN;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}