﻿
namespace oxyForm_P5_048
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labeltambah = new System.Windows.Forms.Label();
            this.labelkurang = new System.Windows.Forms.Label();
            this.labelkali = new System.Windows.Forms.Label();
            this.labelbagi = new System.Windows.Forms.Label();
            this.btnHasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angka 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasil Penjumlahan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasil Pengurangan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hasil Perkalian :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hasil Pembagian :";
            this.label6.Click += new System.EventHandler(this.labelPembagian_Click);
            // 
            // labeltambah
            // 
            this.labeltambah.AutoSize = true;
            this.labeltambah.Location = new System.Drawing.Point(591, 121);
            this.labeltambah.Name = "labeltambah";
            this.labeltambah.Size = new System.Drawing.Size(0, 17);
            this.labeltambah.TabIndex = 0;
            // 
            // labelkurang
            // 
            this.labelkurang.AutoSize = true;
            this.labelkurang.Location = new System.Drawing.Point(591, 165);
            this.labelkurang.Name = "labelkurang";
            this.labelkurang.Size = new System.Drawing.Size(0, 17);
            this.labelkurang.TabIndex = 0;
            // 
            // labelkali
            // 
            this.labelkali.AutoSize = true;
            this.labelkali.Location = new System.Drawing.Point(591, 210);
            this.labelkali.Name = "labelkali";
            this.labelkali.Size = new System.Drawing.Size(0, 17);
            this.labelkali.TabIndex = 0;
            // 
            // labelbagi
            // 
            this.labelbagi.AutoSize = true;
            this.labelbagi.Location = new System.Drawing.Point(591, 255);
            this.labelbagi.Name = "labelbagi";
            this.labelbagi.Size = new System.Drawing.Size(0, 17);
            this.labelbagi.TabIndex = 0;
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(300, 335);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(157, 42);
            this.btnHasil.TabIndex = 2;
            this.btnHasil.Text = "Hasil";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbagi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelkali);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelkurang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeltambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeltambah;
        private System.Windows.Forms.Label labelkurang;
        private System.Windows.Forms.Label labelkali;
        private System.Windows.Forms.Label labelbagi;
        private System.Windows.Forms.Button btnHasil;
    }
}

