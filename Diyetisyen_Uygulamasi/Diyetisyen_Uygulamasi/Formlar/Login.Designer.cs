
namespace Diyetisyen_Uygulamasi
{
    partial class Login
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
            this.GirisTc_TB = new System.Windows.Forms.TextBox();
            this.GirisSifre_TB = new System.Windows.Forms.TextBox();
            this.GirisYapBTN = new System.Windows.Forms.Button();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnDiyetisyen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre :";
            // 
            // GirisTc_TB
            // 
            this.GirisTc_TB.Location = new System.Drawing.Point(311, 55);
            this.GirisTc_TB.Margin = new System.Windows.Forms.Padding(4);
            this.GirisTc_TB.Name = "GirisTc_TB";
            this.GirisTc_TB.Size = new System.Drawing.Size(161, 22);
            this.GirisTc_TB.TabIndex = 2;
            // 
            // GirisSifre_TB
            // 
            this.GirisSifre_TB.Location = new System.Drawing.Point(311, 124);
            this.GirisSifre_TB.Margin = new System.Windows.Forms.Padding(4);
            this.GirisSifre_TB.Name = "GirisSifre_TB";
            this.GirisSifre_TB.Size = new System.Drawing.Size(161, 22);
            this.GirisSifre_TB.TabIndex = 3;
            // 
            // GirisYapBTN
            // 
            this.GirisYapBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisYapBTN.Location = new System.Drawing.Point(249, 235);
            this.GirisYapBTN.Margin = new System.Windows.Forms.Padding(4);
            this.GirisYapBTN.Name = "GirisYapBTN";
            this.GirisYapBTN.Size = new System.Drawing.Size(299, 65);
            this.GirisYapBTN.TabIndex = 4;
            this.GirisYapBTN.Text = "Giris Yap";
            this.GirisYapBTN.UseVisualStyleBackColor = true;
            this.GirisYapBTN.Click += new System.EventHandler(this.GirisYapBTN_Click);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdmin.Location = new System.Drawing.Point(539, 55);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(210, 24);
            this.rbtnAdmin.TabIndex = 5;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin Olarak Giris Yap ";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnDiyetisyen
            // 
            this.rbtnDiyetisyen.AutoSize = true;
            this.rbtnDiyetisyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiyetisyen.Location = new System.Drawing.Point(539, 122);
            this.rbtnDiyetisyen.Name = "rbtnDiyetisyen";
            this.rbtnDiyetisyen.Size = new System.Drawing.Size(236, 24);
            this.rbtnDiyetisyen.TabIndex = 6;
            this.rbtnDiyetisyen.TabStop = true;
            this.rbtnDiyetisyen.Text = "Diyetisyen Olarak Giris Yap";
            this.rbtnDiyetisyen.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 396);
            this.Controls.Add(this.rbtnDiyetisyen);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.GirisYapBTN);
            this.Controls.Add(this.GirisSifre_TB);
            this.Controls.Add(this.GirisTc_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GirisTc_TB;
        private System.Windows.Forms.TextBox GirisSifre_TB;
        private System.Windows.Forms.Button GirisYapBTN;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnDiyetisyen;
    }
}