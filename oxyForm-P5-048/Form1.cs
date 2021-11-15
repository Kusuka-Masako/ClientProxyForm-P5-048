using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oxyForm_P5_048
{
    public partial class Form1 : Form

    {

        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hasilTambah = obj.Tambah(angka1, angka2);
            double hasilKurang = obj.Kurang(angka1, angka2);
            double hasilKali = obj.Kali(angka1, angka2);
            double hasilbagi = obj.Bagi(angka1, angka2);

            labeltambah.Text = hasilTambah.ToString();
            labelkurang.Text = hasilKurang.ToString();
            labelkali.Text = hasilKali.ToString();
            labelbagi.Text = hasilbagi.ToString();
        }

        private void labelPembagian_Click(object sender, EventArgs e)
        {

        }
    }
}
