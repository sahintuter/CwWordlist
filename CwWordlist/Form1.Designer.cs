
namespace CwWordlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parolalar = new System.Windows.Forms.RichTextBox();
            this.karakterSayisi = new System.Windows.Forms.NumericUpDown();
            this.parolaSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.karakterSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parola Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parolalar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Karakter Sayısı:";
            // 
            // parolalar
            // 
            this.parolalar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolalar.Location = new System.Drawing.Point(28, 269);
            this.parolalar.Name = "parolalar";
            this.parolalar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.parolalar.Size = new System.Drawing.Size(740, 149);
            this.parolalar.TabIndex = 1;
            this.parolalar.Text = "";
            // 
            // karakterSayisi
            // 
            this.karakterSayisi.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karakterSayisi.Location = new System.Drawing.Point(220, 123);
            this.karakterSayisi.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.karakterSayisi.Name = "karakterSayisi";
            this.karakterSayisi.Size = new System.Drawing.Size(167, 34);
            this.karakterSayisi.TabIndex = 3;
            this.karakterSayisi.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // parolaSayisi
            // 
            this.parolaSayisi.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaSayisi.Location = new System.Drawing.Point(220, 54);
            this.parolaSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.parolaSayisi.Name = "parolaSayisi";
            this.parolaSayisi.Size = new System.Drawing.Size(167, 34);
            this.parolaSayisi.TabIndex = 4;
            this.parolaSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(608, 18);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(160, 47);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnTXT
            // 
            this.btnTXT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTXT.Location = new System.Drawing.Point(608, 78);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(160, 47);
            this.btnTXT.TabIndex = 5;
            this.btnTXT.Text = "TXT\'ye aktar";
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Location = new System.Drawing.Point(608, 184);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(160, 47);
            this.temizle.TabIndex = 5;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.parolaSayisi);
            this.Controls.Add(this.karakterSayisi);
            this.Controls.Add(this.parolalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CwWordlist";
            ((System.ComponentModel.ISupportInitialize)(this.karakterSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox parolalar;
        private System.Windows.Forms.NumericUpDown karakterSayisi;
        private System.Windows.Forms.NumericUpDown parolaSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button temizle;
    }
}

