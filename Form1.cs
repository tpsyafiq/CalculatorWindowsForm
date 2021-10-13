using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            var cal = new Calculator();

            lstHasil.Items.Clear();

            lstHasil.Items.Add(String.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            lstHasil.Items.Add(String.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            lstHasil.Items.Add(String.Format("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b)));
            lstHasil.Items.Add(String.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            lstHasil.Items.Add(String.Format("Hasil Pangkat: {0} / {1} = {2}", a, b, cal.Pangkat(a, b)));
            lstHasil.Items.Add(String.Format("Hasil Modulo: {0} / {1} = {2}", a, b, Calculator.Modulo(a, b)));
        }
    }
}
