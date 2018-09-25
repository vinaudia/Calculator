using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pilihoperasi.Items.Add("Penambahan");
            pilihoperasi.Items.Add("Pengurangan");
            pilihoperasi.Items.Add("Perkalian");
            pilihoperasi.Items.Add("Pembagian");

        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnhasil_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(nilaiA.Text);
            var b = Convert.ToInt32(nilaiB.Text);
            string operasi = pilihoperasi.Text;

            if (operasi == "Penambahan")
            {
                hasilperhitungan.Text = Convert.ToString(Penambahan(a, b));
            }
            else if (operasi == "Pengurangan")
            {
                hasilperhitungan.Text = Convert.ToString(Pengurangan(a, b));
            }
            else if (operasi == "Perkalian")
            {
                hasilperhitungan.Text = Convert.ToString(Perkalian(a, b));
            }
            else
            {
                hasilperhitungan.Text = Convert.ToString(Pembagian(a, b));
            }
        }
    }
}
