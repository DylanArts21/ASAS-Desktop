namespace CoffeeCrud
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
            this.TXTjenis = new System.Windows.Forms.TextBox();
            this.TXTnama = new System.Windows.Forms.TextBox();
            this.TXTharga = new System.Windows.Forms.TextBox();
            this.BTNinput = new System.Windows.Forms.Button();
            this.BTNhapus = new System.Windows.Forms.Button();
            this.BTNcari = new System.Windows.Forms.Button();
            this.BTNubah = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Minuman";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama MInuman";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Harga";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTjenis
            // 
            this.TXTjenis.Location = new System.Drawing.Point(229, 51);
            this.TXTjenis.Name = "TXTjenis";
            this.TXTjenis.Size = new System.Drawing.Size(271, 26);
            this.TXTjenis.TabIndex = 2;
            // 
            // TXTnama
            // 
            this.TXTnama.Location = new System.Drawing.Point(229, 95);
            this.TXTnama.Name = "TXTnama";
            this.TXTnama.Size = new System.Drawing.Size(271, 26);
            this.TXTnama.TabIndex = 2;
            // 
            // TXTharga
            // 
            this.TXTharga.Location = new System.Drawing.Point(229, 137);
            this.TXTharga.Name = "TXTharga";
            this.TXTharga.Size = new System.Drawing.Size(189, 26);
            this.TXTharga.TabIndex = 2;
            // 
            // BTNinput
            // 
            this.BTNinput.Location = new System.Drawing.Point(82, 192);
            this.BTNinput.Name = "BTNinput";
            this.BTNinput.Size = new System.Drawing.Size(95, 36);
            this.BTNinput.TabIndex = 3;
            this.BTNinput.Text = "Input";
            this.BTNinput.UseVisualStyleBackColor = true;
            this.BTNinput.Click += new System.EventHandler(this.BTNinput_Click);
            // 
            // BTNhapus
            // 
            this.BTNhapus.Location = new System.Drawing.Point(213, 192);
            this.BTNhapus.Name = "BTNhapus";
            this.BTNhapus.Size = new System.Drawing.Size(95, 36);
            this.BTNhapus.TabIndex = 3;
            this.BTNhapus.Text = "Hapus";
            this.BTNhapus.UseVisualStyleBackColor = true;
            this.BTNhapus.Click += new System.EventHandler(this.BTNhapus_Click);
            // 
            // BTNcari
            // 
            this.BTNcari.Location = new System.Drawing.Point(347, 192);
            this.BTNcari.Name = "BTNcari";
            this.BTNcari.Size = new System.Drawing.Size(95, 36);
            this.BTNcari.TabIndex = 3;
            this.BTNcari.Text = "Cari";
            this.BTNcari.UseVisualStyleBackColor = true;
            this.BTNcari.Click += new System.EventHandler(this.BTNcari_Click);
            // 
            // BTNubah
            // 
            this.BTNubah.Location = new System.Drawing.Point(480, 192);
            this.BTNubah.Name = "BTNubah";
            this.BTNubah.Size = new System.Drawing.Size(95, 36);
            this.BTNubah.TabIndex = 3;
            this.BTNubah.Text = "Ubah";
            this.BTNubah.UseVisualStyleBackColor = true;
            this.BTNubah.Click += new System.EventHandler(this.BTNubah_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(209, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Menu Coffee Shop";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CoffeeCrud.Properties.Resources.BackgroundCoklat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(this.BTNubah);
            this.Controls.Add(this.BTNcari);
            this.Controls.Add(this.BTNhapus);
            this.Controls.Add(this.BTNinput);
            this.Controls.Add(this.TXTharga);
            this.Controls.Add(this.TXTnama);
            this.Controls.Add(this.TXTjenis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox TXTjenis;
        private System.Windows.Forms.TextBox TXTnama;
        private System.Windows.Forms.TextBox TXTharga;
        private System.Windows.Forms.Button BTNinput;
        private System.Windows.Forms.Button BTNhapus;
        private System.Windows.Forms.Button BTNcari;
        private System.Windows.Forms.Button BTNubah;
        private System.Windows.Forms.Label label4;
    }
}

