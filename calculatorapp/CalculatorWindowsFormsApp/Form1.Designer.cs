namespace CalculatorWindowsFormsApp
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
            this.label4 = new System.Windows.Forms.Label();
            this.pilihoperasi = new System.Windows.Forms.ComboBox();
            this.nilaiA = new System.Windows.Forms.TextBox();
            this.nilaiB = new System.Windows.Forms.TextBox();
            this.hasilperhitungan = new System.Windows.Forms.TextBox();
            this.btnhasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pilihoperasi
            // 
            this.pilihoperasi.FormattingEnabled = true;
            this.pilihoperasi.Location = new System.Drawing.Point(118, 31);
            this.pilihoperasi.Name = "pilihoperasi";
            this.pilihoperasi.Size = new System.Drawing.Size(121, 28);
            this.pilihoperasi.TabIndex = 4;
            // 
            // nilaiA
            // 
            this.nilaiA.Location = new System.Drawing.Point(118, 91);
            this.nilaiA.Name = "nilaiA";
            this.nilaiA.Size = new System.Drawing.Size(100, 26);
            this.nilaiA.TabIndex = 5;
            // 
            // nilaiB
            // 
            this.nilaiB.Location = new System.Drawing.Point(118, 134);
            this.nilaiB.Name = "nilaiB";
            this.nilaiB.Size = new System.Drawing.Size(100, 26);
            this.nilaiB.TabIndex = 6;
            // 
            // hasilperhitungan
            // 
            this.hasilperhitungan.Location = new System.Drawing.Point(118, 194);
            this.hasilperhitungan.Name = "hasilperhitungan";
            this.hasilperhitungan.Size = new System.Drawing.Size(100, 26);
            this.hasilperhitungan.TabIndex = 7;
            // 
            // btnhasil
            // 
            this.btnhasil.Location = new System.Drawing.Point(229, 230);
            this.btnhasil.Name = "btnhasil";
            this.btnhasil.Size = new System.Drawing.Size(96, 33);
            this.btnhasil.TabIndex = 8;
            this.btnhasil.Text = "Hitung";
            this.btnhasil.UseVisualStyleBackColor = true;
            this.btnhasil.Click += new System.EventHandler(this.btnhasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.btnhasil);
            this.Controls.Add(this.hasilperhitungan);
            this.Controls.Add(this.nilaiB);
            this.Controls.Add(this.nilaiA);
            this.Controls.Add(this.pilihoperasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pilihoperasi;
        private System.Windows.Forms.TextBox nilaiA;
        private System.Windows.Forms.TextBox nilaiB;
        private System.Windows.Forms.TextBox hasilperhitungan;
        private System.Windows.Forms.Button btnhasil;
    }
}

